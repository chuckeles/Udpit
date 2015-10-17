using System.Net.Sockets;
using System.Threading.Tasks;

namespace Udpit {

  /// <summary>
  ///   Sends messages. Lets others know via events.
  /// </summary>
  internal class Sender {

    /// <summary>
    ///   Delegate for the fragment sent event.
    /// </summary>
    /// <param name="message">Message the fragment is part of</param>
    /// <param name="number">Fragment number</param>
    public delegate void FragmentSentDelegate(Message message, ushort number);

    /// <summary>
    ///   Delegate for the message events.
    /// </summary>
    public delegate void MessageDelegate(Message message);

    /// <summary>
    ///   Fired when a fragment has been sent.
    /// </summary>
    public event FragmentSentDelegate OnFragmentSent;

    /// <summary>
    ///   Fired when a message transmission is complete.
    /// </summary>
    public event MessageDelegate OnMessageSendingFinish;

    /// <summary>
    ///   Fired when a new message is beginning to be transmitted.
    /// </summary>
    public event MessageDelegate OnMessageSendingStart;

    private Sender() {}

    /// <summary>
    ///   Creates the singleton instance.
    /// </summary>
    public static Sender Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Sender();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Begin the transmission procedure.
    /// </summary>
    public void TransmitMessage(Message message) {
      // create a task
      Task.Run(() => {
        // initialize handshake
        SendPrepareFragment(message);
      });
    }

    /// <summary>
    ///   Sends a prepare fragment for a message.
    /// </summary>
    private void SendPrepareFragment(Message message) {
      // ask for a prepare fragment
      var fragment = Fragmenter.GetPrepareFragment(message);

      // fire the event
      OnMessageSendingStart?.Invoke(message);

      // update message status
      lock (message) {
        message.Status = MessageStatus.Handshaking;
      }

      // send the fragment
      lock (_udpClient) {
        _udpClient.Send(fragment, fragment.Length, message.RemoteEndPoint);
      }

      // TODO: Retry
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Sender Singleton { get; private set; }

    /// <summary>
    ///   The UDP client that is used to send data.
    /// </summary>
    private readonly UdpClient _udpClient = new UdpClient(Options.SendPort);

  }

}
