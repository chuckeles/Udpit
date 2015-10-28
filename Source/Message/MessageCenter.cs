using System;
using System.Collections.Generic;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {
      // hook the transmitter's fragment received
      Transmitter.Singleton.FragmentReceived += FragmentCame;
    }

    /// <summary>
    ///   Creates a singleton instance.
    /// </summary>
    public static MessageCenter Create() {
      // check existing instance
      if (Singleton != null)
        return Singleton;

      // create an instance
      Singleton = new MessageCenter();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Sends a message.
    /// </summary>
    public void SendMessage(string messageText) {
      // ask for a message
      var message = Fragmenter.CreateMessage(Options.Remote, messageText, Options.MaxPartSize);

      // add to the dictionary
      lock (Messages) {
        Messages.Add(BitConverter.ToUInt16(message.ID, 0), message);
      }

      // log the start
      Log.Singleton.LogMessage(
        $"Sending message to <{Options.Remote}> with maximum part size of <{Options.MaxPartSize}B>");

      // delegate to the transmitter
      Transmitter.Singleton.SendMessage(message);
    }

    /// <summary>
    ///   Handles an incoming fragment.
    /// </summary>
    private void FragmentCame(object sender, byte[] fragment) {
      // get type
      var type = Fragmenter.GetFragmentType(fragment);

      // log
      Log.Singleton.LogMessage($"Received a fragment of type <{type}> and size <{fragment.Length}B>");
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static MessageCenter Singleton { get; private set; }

    /// <summary>
    ///   The dictionary of messages in progress keyed by the id.
    /// </summary>
    public Dictionary<ushort, Message> Messages { get; } = new Dictionary<ushort, Message>();

  }

}
