using System;
using System.Collections.Generic;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {}

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
    ///   The singleton instance.
    /// </summary>
    public static MessageCenter Singleton { get; private set; }

    /// <summary>
    ///   The dictionary of messages in progress keyed by the id.
    /// </summary>
    public Dictionary<ushort, Message> Messages { get; } = new Dictionary<ushort, Message>();

  }

}
