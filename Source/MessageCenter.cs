using System.Collections.Generic;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {}

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
    ///   The list of messages in progress.
    /// </summary>
    private List<Message> _messages = new List<Message>();

  }

}
