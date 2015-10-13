using System;

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
    public Sender Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Sender();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Transmit a message to its destination.
    /// </summary>
    public void SendMessage(Message message) {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Sender Singleton { get; private set; }

  }

}
