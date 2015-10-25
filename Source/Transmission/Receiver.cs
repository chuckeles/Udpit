using System;
using System.Net;
using System.Net.Sockets;

namespace Udpit {

  /// <summary>
  ///   Receives fragments. Lets others know via events.
  /// </summary>
  internal class Receiver {

    /// <summary>
    ///   Delegate for the fragment event.
    /// </summary>
    public delegate void FragmentDelegate(byte[] fragment, IPEndPoint remoteEndPoint);

    /// <summary>
    ///   Fired when a fragment is received.
    /// </summary>
    public event FragmentDelegate FragmentReceived;

    private Receiver() {
      lock (_udpClient) {
        // set up the UDP client
        _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));
      }

      // start listening
      Listen();
    }

    /// <summary>
    ///   Creates the singleton instance.
    /// </summary>
    public static Receiver Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Receiver();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Updates the client port that is used.
    /// </summary>
    public void UpdatePort() {
      // lock first
      lock (_udpClient) {
        // close current client
        _udpClient.Close();

        // create new client with a different port
        _udpClient = new UdpClient();
        _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));
      }

      // listen
      Listen();
    }

    /// <summary>
    ///   Starts listening.
    /// </summary>
    private void Listen() {
      lock (_udpClient) {
        _udpClient.BeginReceive(OnReceive, null);
      }
    }

    /// <summary>
    ///   Called on incoming fragment.
    /// </summary>
    private void OnReceive(IAsyncResult ar) {
      try {
        // receive fragment
        var remoteEndPoint = new IPEndPoint(IPAddress.Any, Options.Port);
        byte[] fragment;
        lock (_udpClient) {
          fragment = _udpClient.EndReceive(ar, ref remoteEndPoint);
        }

        // listen again
        Listen();

        // fire an event
        FragmentReceived?.Invoke(fragment, remoteEndPoint);
      }
      catch (ObjectDisposedException) {
        // this is in case the socket has been closed, i. e. when changing a port
        // https://stackoverflow.com/questions/18309974/how-do-you-cancel-a-udpclientbeginreceive
      }
      catch (ArgumentException) {
        // ignore as well
      }
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Receiver Singleton { get; private set; }

    /// <summary>
    ///   The UDP client.
    /// </summary>
    private UdpClient _udpClient = new UdpClient();

  }

}
