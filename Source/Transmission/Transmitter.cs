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
    ///   Fired when the socket is listening and a fragment is received.
    /// </summary>
    public event EventHandler<byte[]> FragmentReceived;

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
    ///   Send a message.
    /// </summary>
    public void SendMessage(Message message) {
      // create a task
      Task.Run(() => {
        // check the listening state
        if (_listening) {
          // error
          Log.Singleton.LogError("Can't send a message while listening");

          // cancel
          return;

          // TODO: Delete message
        }

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
          Log.Singleton.LogMessage($"Message <{message.ID[0]}{message.ID[1]}> is in state <{message.Status}>");
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
            $"Sending a <{FragmentType.Prepare}> fragment for message <{message.ID[0]}{message.ID[1]}> to <{message.RemoteEndPoint}>");
        }

        // send the fragment
        lock (message) {
          _client.Send(prepareFragment, prepareFragment.Length, message.RemoteEndPoint);
        }

        // close and remove client
        _client.Close();
        _client = null;
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
          FragmentReceived?.Invoke(this, bytes);

          // done, close please and goodbye
          _client.Close();
          _client = null;

          // set the flag
          _listening = false;
        }
        catch (ObjectDisposedException) {
          // fine, the socket has been closed
        }
        catch (SocketException) {
          // same deal
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
    ///   Whether the socket is currently listening.
    /// </summary>
    private bool _listening;

  }

}
