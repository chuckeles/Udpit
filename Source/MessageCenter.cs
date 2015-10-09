using System.Collections.Generic;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {}

    /// <summary>
    ///   Add a new message which is in progress.
    /// </summary>
    public void AddMessage(Message message) {
      _messages.Add(message.Id, message);
    }

    public MessageCenter Create() {
      // check existing instance
      if (Singleton != null)
        return Singleton;

      // create an instance
      Singleton = new MessageCenter();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public MessageCenter Singleton { get; private set; }

    /// <summary>
    ///   The dictionary of messages in progress keyed by the id.
    /// </summary>
    private readonly Dictionary<byte[], Message> _messages = new Dictionary<byte[], Message>();

  }

}
