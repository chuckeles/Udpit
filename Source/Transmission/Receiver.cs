using System;
using System.Net;
using System.Net.Sockets;

namespace Udpit {

  /// <summary>
  ///   Receives fragments. Lets others know via events.
  /// </summary>
  internal class Receiver {

    private Receiver() {
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
    ///   Starts listening.
    /// </summary>
    private void Listen() {
      _udpClient.BeginReceive(OnReceive, null);
    }

    /// <summary>
    ///   Called on incoming fragment.
    /// </summary>
    private void OnReceive(IAsyncResult ar) {
      // receive fragment
      var remoteEndPoint = new IPEndPoint(IPAddress.Any, Options.ReceivePort);
      var fragment = _udpClient.EndReceive(ar, ref remoteEndPoint);

      // listen again
      Listen();
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Receiver Singleton { get; private set; }

    /// <summary>
    ///   The UDP client.
    /// </summary>
    private readonly UdpClient _udpClient = new UdpClient(Options.ReceivePort);

  }

}
