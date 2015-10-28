using System;
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
    public void Listen() {
      if (_listening)
        return;

      // set the flag
      _listening = true;

      // create a socket
      CreateListenSocket();
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
        }

        // send all data fragments
        lock (message) {
          foreach (var pair in message.PartList) {
            // request a data fragment
            var fragment = Fragmenter.MakeDataFragment(message, pair.Key);

            // send it
            SendFragment(message, fragment, FragmentType.Data);
          }
        }

        // TODO: Handle keep-alive fragments

        // set state
        lock (message) {
          message.Status = MessageStatus.Ending;
        }

        // log that
        lock (message) {
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");
        }

        // send end fragment
        SendEndFragment(message);
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
        SendFragment(message, fragment, FragmentType.Okay);
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
        SendFragment(message, fragment, FragmentType.Prepared);
      });
    }

    /// <summary>
    ///   Send a prepare fragment for a message.
    /// </summary>
    public void SendPrepareFragment(Message message) {
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
        }

        // go ahead, send it
        SendFragment(message, prepareFragment, FragmentType.Prepare);
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
      _client = null;

      // log
      Log.Singleton.LogMessage("Stopped listening");
    }

    /// <summary>
    ///   Create an UPD client and set it up to receive fragments.
    /// </summary>
    private void CreateListenSocket() {
      // create a task
      Task.Run(() => {
        // create UDP client
        _client = new UdpClient();

        // bind it
        try {
          _client.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));
        }
        catch (SocketException) {
          // the port is probably already bound to
          Log.Singleton.LogError($"Failed to bind the listening socket to the port <{Options.Port}>");

          // remove client
          _client = null;

          // set the flag
          _listening = false;

          // fire the event
          StoppedListening?.Invoke(this, EventArgs.Empty);

          // stop
          return;
        }

        // log
        Log.Singleton.LogMessage($"Listening on port <{Options.Port}>");


        // receive
        try {
          var remoteEndPoint = new IPEndPoint(IPAddress.Any, Options.Port);
          var bytes = _client.Receive(ref remoteEndPoint);

          // got some fragment, oh my god!
          FragmentReceived?.Invoke(bytes, remoteEndPoint);

          // done, close please and goodbye
          _client.Close();
        }
        catch (ObjectDisposedException) {
          // fine, the socket has been closed
        }
        catch (SocketException) {
          // same deal
        }
        finally {
          // remote the client
          _client = null;

          // set the flag
          _listening = false;

          // fire the event
          StoppedListening?.Invoke(this, EventArgs.Empty);
        }
      });
    }

    /// <summary>
    ///   Sends end fragment for a message.
    /// </summary>
    private void SendEndFragment(Message message) {
      // create a task
      Task.Run(() => {
        // ask for an end fragment
        byte[] fragment;
        lock (message) {
          fragment = Fragmenter.MakeEndFragment(message);
        }

        // send the fragment
        SendFragment(message, fragment, FragmentType.End);
      });
    }

    /// <summary>
    ///   Sends a fragment.
    /// </summary>
    private void SendFragment(Message message, byte[] fragment, FragmentType type) {
      // create a task
      Task.Run(() => {
        // check the listening state
        if (_listening) {
          // error
          Log.Singleton.LogError("Can't send a fragment while listening");

          // cancel
          return;

          // TODO: Delete message
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

          // stop
          return;

          // TODO: Remove message
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
    ///   Whether the socket is currently listening.
    /// </summary>
    private bool _listening;

  }

}
