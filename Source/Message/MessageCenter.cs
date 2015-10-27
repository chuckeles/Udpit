using System.Collections.Generic;
using System.Net;

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
    /// Sends a message.
    /// </summary>
    /// <param name="endPoint">Where to send the message</param>
    /// <param name="maxPartSize">Maximum size of one part, in bytes</param>
    /// <param name="message">Message body</param>
    public void SendMessage(IPEndPoint endPoint, ushort maxPartSize, string message) {}

    /// <summary>
    /// Sends a file.
    /// </summary>
    /// <param name="endPoint">Where to send the file</param>
    /// <param name="maxPartSize">Maximum size of one part, in bytes</param>
    /// <param name="file">Path to the file</param>
    public void SendFile(IPEndPoint endPoint, ushort maxPartSize, string file) {}

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
