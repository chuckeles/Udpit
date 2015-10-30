using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Udpit {

  /// <summary>
  ///   Handles UDP communication and transmits the fragments.
  /// </summary>
  internal class Transmitter {

    /// <summary>
    ///   Delegate for the fragment received event.
    /// </summary>
    public delegate void FragmentReceivedDelegate(byte[] fragment, IPEndPoint remoteEndPoint);

    /// <summary>
    ///   Fired when the socket is listening and a fragment is received.
    /// </summary>
    public event FragmentReceivedDelegate FragmentReceived;

    /// <summary>
    ///   Fired when stopping listening and not from a user input.
    /// </summary>
    public event EventHandler StoppedListening;

    private Transmitter() {}

    /// <summary>
    ///   Creates a singleton instance.
    /// </summary>
    public static Transmitter Create() {
      // check existing instance
      if (Singleton != null)
        return Singleton;

      // create an instance
      Singleton = new Transmitter();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Open a socket for listening.
    /// </summary>
    public Task<bool> Listen(bool timeout = true) {
      if (_listening)
        return null;

      // set the flag
      _listening = true;

      // create a socket
      return CreateListenSocket(timeout);
    }

    /// <summary>
    ///   Sends all data fragments of a message.
    /// </summary>
    public void SendDataFragments(Message message) {
      // create a task
      Task.Run(() => {
        // set state
        lock (message) {
          message.Status = MessageStatus.Transmitting;
        }

        // log that
        lock (message) {
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

          MessageCenter.Singleton.FireChange(message.Status);
        }

        // send all data fragments
        var sendTasks = new List<Task>();
        lock (message) {
          foreach (var pair in message.PartList) {
            // request a data fragment
            var fragment = Fragmenter.MakeDataFragment(message, pair.Key);

            // send it
            sendTasks.Add(SendFragment(message, fragment, FragmentType.Data));
          }
        }

        // TODO: Handle keep-alive fragments

        Task.WhenAll(sendTasks).ContinueWith(task => {
          // set state
          lock (message) {
            message.Status = MessageStatus.Ending;
          }

          // log that
          lock (message) {
            Log.Singleton.LogMessage(
              $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

            MessageCenter.Singleton.FireChange(message.Status);
          }

          // send end fragment
          SendEndFragment(message);
        });
      });
    }

    /// <summary>
    ///   Sends only missing parts of a message.
    /// </summary>
    public void SendDataFragments(Message message, List<ushort> missingList) {
      // create a task
      Task.Run(() => {
        // set state
        lock (message) {
          message.Status = MessageStatus.Transmitting;
        }

        // log that
        lock (message) {
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

          MessageCenter.Singleton.FireChange(message.Status);
        }

        // send missing data fragments
        var sendTasks = new List<Task>();
        lock (message) {
          foreach (var missingNumber in missingList) {
            // request a data fragment
            var fragment = Fragmenter.MakeDataFragment(message, missingNumber);

            // send it
            sendTasks.Add(SendFragment(message, fragment, FragmentType.Data));
          }
        }

        // TODO: Handle keep-alive fragments

        Task.WhenAll(sendTasks).ContinueWith(task => {
          // set state
          lock (message) {
            message.Status = MessageStatus.Ending;
          }

          // log that
          lock (message) {
            Log.Singleton.LogMessage(
              $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

            MessageCenter.Singleton.FireChange(message.Status);
          }

          // send end fragment
          SendEndFragment(message);
        });
      });
    }

    /// <summary>
    ///   Sends a missing fragment for a message.
    /// </summary>
    public void SendMissingFragment(Message message, List<ushort> missingList) {
      // create a task
      Task.Run(() => {
        // ask for a missing fragment
        byte[] fragment;
        lock (message) {
          fragment = Fragmenter.MakeMissingFragment(message, missingList);
        }

        // send the fragment
        SendFragment(message, fragment, FragmentType.Missing)

          // listen
          .ContinueWith(task => Listen(false));
      });
    }

    /// <summary>
    ///   Sends ending okay fragment.
    /// </summary>
    public void SendOkayFragment(Message message) {
      // create a task
      Task.Run(() => {
        // ask for an end fragment
        byte[] fragment;
        lock (message) {
          fragment = Fragmenter.MakeOkayFragment(message);
        }

        // send the fragment
        SendFragment(message, fragment, FragmentType.Okay)

          // set status
          .ContinueWith(task => {
            lock (message) {
              message.Status = MessageStatus.Finished;
              Log.Singleton.LogMessage(
                $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

              MessageCenter.Singleton.FireChange(message.Status);
            }
          });
      });
    }

    /// <summary>
    ///   Sends a prepared fragment for a message.
    /// </summary>
    public void SendPreparedFragment(Message message) {
      // create a task
      Task.Run(() => {
        // ask for a prepared fragment
        byte[] fragment;
        lock (message) {
          fragment = Fragmenter.MakePreparedFragment(message);
        }

        // send the fragment
        SendFragment(message, fragment, FragmentType.Prepared)

          // listen
          .ContinueWith(task => Listen(false));
      });
    }

    /// <summary>
    ///   Sends a prepare file fragment for a message.
    /// </summary>
    public void SendPrepareFileFragment(Message message, int retries = 0) {
      // create a task
      Task.Run(() => {
        // create a prepare file fragment
        byte[] prepareFragment;
        lock (message) {
          prepareFragment = Fragmenter.MakePrepareFileFragment(message);
        }

        // update status
        lock (message) {
          message.Status = MessageStatus.Handshaking;
        }

        // log that
        lock (message) {
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

          MessageCenter.Singleton.FireChange(message.Status);
        }

        // go ahead, send it
        SendFragment(message, prepareFragment, FragmentType.PrepareFile)

          // listen
          .ContinueWith(task => Listen())

          // handle timeout
          .ContinueWith(task => {
            // check the result
            if (!task.Result.Result) {
              // timeout, check retries
              if (retries < Options.Retries)
                SendPrepareFileFragment(message, retries + 1);

              else {
                // message timed out
                lock (message) {
                  MessageCenter.Singleton.Messages.Remove(BitConverter.ToUInt16(message.ID, 0));

                  // log
                  Log.Singleton.LogError(
                    $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> timed out");
                }
              }
            }
          });
      });
    }

    /// <summary>
    ///   Send a prepare fragment for a message.
    /// </summary>
    public void SendPrepareFragment(Message message, int retries = 0) {
      // create a task
      Task.Run(() => {
        // create a prepare fragment
        byte[] prepareFragment;
        lock (message) {
          prepareFragment = Fragmenter.MakePrepareFragment(message);
        }

        // update status
        lock (message) {
          message.Status = MessageStatus.Handshaking;
        }

        // log that
        lock (message) {
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");

          MessageCenter.Singleton.FireChange(message.Status);
        }

        // go ahead, send it
        SendFragment(message, prepareFragment, FragmentType.Prepare)

          // listen
          .ContinueWith(task => Listen())

          // handle timeout
          .ContinueWith(task => {
            // check the result
            if (!task.Result.Result) {
              // timeout, check retries
              if (retries < Options.Retries)
                SendPrepareFragment(message, retries + 1);

              else {
                // message timed out
                lock (message) {
                  MessageCenter.Singleton.Messages.Remove(BitConverter.ToUInt16(message.ID, 0));

                  // log
                  Log.Singleton.LogError(
                    $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> timed out");
                }
              }
            }
          });
      });
    }

    /// <summary>
    ///   Close the socket for listening.
    /// </summary>
    public void StopListening() {
      if (!_listening)
        return;

      // set the flag
      _listening = false;

      // close and destroy the client
      _client.Close();
      lock (_clientMutex) {
        _client = null;
      }

      // log
      Log.Singleton.LogMessage("Stopped listening");
    }

    /// <summary>
    ///   Create an UPD client and set it up to receive fragments.
    /// </summary>
    private Task<bool> CreateListenSocket(bool timeout) {
      // create a task
      return Task.Run(() => {
        try {
          lock (_clientMutex) {
            // create UDP client
            _client = new UdpClient();

            // bind it
            _client.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));

            // set the timeout flag
            if (timeout)
              _client.Client.ReceiveTimeout = Options.TimeoutTime;
          }
        }
        catch (SocketException) {
          // the port is probably already bound to
          Log.Singleton.LogError($"Failed to bind the listening socket to the port <{Options.Port}>");

          // remove client
          lock (_clientMutex) {
            _client = null;
          }

          // set the flag
          _listening = false;

          // fire the event
          StoppedListening?.Invoke(this, EventArgs.Empty);

          // stop
          return false;
        }

        // log
        Log.Singleton.LogMessage($"Listening on port <{Options.Port}>");


        // receive
        var received = false;
        try {
          lock (_clientMutex) {
            var remoteEndPoint = new IPEndPoint(IPAddress.Any, Options.Port);
            var bytes = _client.Receive(ref remoteEndPoint);

            // done, close please and goodbye
            _client.Close();

            // need to do this to allow listening immediately after this
            _listening = false;

            // got some fragment, oh my god!
            received = true;
            FragmentReceived?.Invoke(bytes, remoteEndPoint);
          }
        }
        catch (ObjectDisposedException) {
          // fine, the socket has been closed

          // set the flag
          _listening = false;
        }
        catch (SocketException) {
          // same deal

          // set the flag
          _listening = false;

          // done, close please and goodbye
          lock (_clientMutex) {
            if (_client != null && _client.Client.IsBound)
              _client.Close();
          }
        }
        finally {
          // remote the client
          lock (_clientMutex) {
            _client = null;
          }

          // fire the event
          StoppedListening?.Invoke(this, EventArgs.Empty);
        }

        return received;
      });
    }

    /// <summary>
    ///   Sends end fragment for a message.
    /// </summary>
    private void SendEndFragment(Message message, int retries = 0) {
      // create a task
      Task.Run(() => {
        // ask for an end fragment
        byte[] fragment;
        lock (message) {
          fragment = Fragmenter.MakeEndFragment(message);
        }

        // send the fragment
        SendFragment(message, fragment, FragmentType.End)

          // listen
          .ContinueWith(task => Listen())

          // handle timeout
          .ContinueWith(task => {
            // check the result
            if (!task.Result.Result) {
              // timeout, check retries
              if (retries < Options.Retries)
                SendEndFragment(message, retries + 1);

              else {
                // message timed out
                lock (message) {
                  MessageCenter.Singleton.Messages.Remove(BitConverter.ToUInt16(message.ID, 0));

                  // log
                  Log.Singleton.LogError(
                    $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> timed out");
                }
              }
            }
          });
      });
    }

    /// <summary>
    ///   Sends a fragment.
    /// </summary>
    private Task SendFragment(Message message, byte[] fragment, FragmentType type) {
      // create a task
      return Task.Run(() => {
        // check the listening state
        if (_listening) {
          // error
          Log.Singleton.LogError("Can't send a fragment while listening");

          // delete message
          lock (message) {
            MessageCenter.Singleton.Messages.Remove(BitConverter.ToUInt16(message.ID, 0));
          }

          // cancel
          return;
        }

        // append CRC checksum
        CRC.GenerateChecksum(ref fragment);

        // need to lock to prevent multiple tasks trying to send simultaneously
        lock (_clientMutex) {
          // check if we want to lose some fragments
          if (Options.LoseFragments) {
            // get a random value
            var random = new Random();
            if ((ushort) random.Next() % 100 < 30) {
              // 30% of fragments will be lost

              // log that
              Log.Singleton.LogMessage($"Purposefully losing a fragment of type <{type}>");

              // exit
              return;
            }
          }

          // check if we want to corrupt some fragments
          if (Options.SendCorrupt) {
            // get a random value
            var random = new Random();
            if ((ushort) random.Next() % 100 < 40) {
              // 40% of fragments will be corrupted

              // log that
              Log.Singleton.LogMessage($"Purposefully corrupting a fragment of type <{type}>");

              // change random bytes
              for (int i = 0, imax = Math.Abs(random.Next() + 2) % 16; i < imax; ++i) {
                fragment[random.Next() % fragment.Length] = (byte) random.Next();
              }
            }
          }

          // create a client
          _client = new UdpClient();

          // bind it
          try {
            _client.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));
          }
          catch (SocketException) {
            // nope, can't bind to that port
            Log.Singleton.LogError($"Failed to bind the sending socket to the port <{Options.Port}>");

            // remove client
            _client = null;

            // remove message
            lock (message) {
              MessageCenter.Singleton.Messages.Remove(BitConverter.ToUInt16(message.ID, 0));
            }


            // stop
            return;
          }

          // log
          lock (message) {
            Log.Singleton.LogMessage(
              $"Sending a <{type}> fragment for message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> to <{message.RemoteEndPoint}>");
          }

          // send the fragment
          lock (message) {
            _client.Send(fragment, fragment.Length, message.RemoteEndPoint);
          }

          // close and remove client
          _client.Close();
          _client = null;
        }
      });
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Transmitter Singleton { get; private set; }

    /// <summary>
    ///   The UDP client used for transmission.
    /// </summary>
    private UdpClient _client;

    /// <summary>
    ///   Mutex for the client.
    /// </summary>
    private readonly object _clientMutex = new object();

    /// <summary>
    ///   Whether the socket is currently listening.
    /// </summary>
    private bool _listening;

  }

}
