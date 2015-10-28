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

      // log
      Log.Singleton.LogMessage("Listening for incoming fragments");
    }

    /// <summary>
    ///   Send a message.
    /// </summary>
    public void SendMessage(Message message) {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   Close the socket for listening.
    /// </summary>
    public void StopListening() {
      if (!_listening)
        return;

      // set the flag
      _listening = false;

      // log
      Log.Singleton.LogMessage("Stopping listening");
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

          // remote client
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

          // done, close please
          _client.Close();

          // set the flag
          _listening = false;
        }
        catch (ObjectDisposedException) {
          // fine, the socket has been closed
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
