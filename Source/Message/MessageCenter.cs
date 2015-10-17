using System.Collections.Generic;
using System.Net;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {
      // hook the receiver's fragment event
      Receiver.Singleton.FragmentReceived += FragmentReceived;
    }

    /// <summary>
    ///   Create a singleton instance.
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
    ///   Add an incoming fragment.
    /// </summary>
    /// <param name="id">Id of the message</param>
    /// <param name="number">Fragment number</param>
    /// <param name="data">Fragment data</param>
    public void AddFragment(byte[] id, ushort number, byte[] data) {
      // find it in the dictionary
      if (!_messages.ContainsKey(id))
        return;

      // get the message
      var message = _messages[id];

      // check if the fragment exists
      if (message.FragmentList.ContainsKey(number))
        return;

      // TODO: Check the fragment

      // add the fragment
      message.FragmentList.Add(number, data);
    }

    /// <summary>
    ///   Add a new message to the list.
    /// </summary>
    public void AddMessage(Message message) {
      _messages.Add(message.Id, message);
    }

    /// <summary>
    ///   Create a new message that needs to be send. Called by the UI.
    /// </summary>
    /// <param name="remoteEndPoint">Where to send the message</param>
    /// <param name="messageString">String to send</param>
    /// <param name="maxFragmentSize">Maximum size of one fragment in bytes</param>
    public void CreateMessage(IPEndPoint remoteEndPoint, string messageString, ushort maxFragmentSize) {
      // ask for a fragmented message
      var message = Fragmenter.CreateMessage(remoteEndPoint, messageString, maxFragmentSize);

      // add it to the dictionary
      lock (_messages) {
        _messages.Add(message.Id, message);
      }

      // begin transmission
      Sender.Singleton.SendPrepareFragment(message);
    }

    /// <summary>
    ///   Delegate for the receiver's fragment received event.
    /// </summary>
    private void FragmentReceived(byte[] fragment) {
      // check the type
      var type = Fragmenter.GetFragmentType(fragment);

      switch (type) {
        case FragmentType.Prepare:
          var id = PrepareMessage(fragment);
          break;
      }
    }

    /// <summary>
    /// Creates a message based on prepare fragment.
    /// </summary>
    private byte[] PrepareMessage(byte[] fragment) {
      // get message id
      var id = Fragmenter.GetID(fragment);

      // return id
      return id;
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static MessageCenter Singleton { get; private set; }

    /// <summary>
    ///   The dictionary of messages in progress keyed by the id.
    /// </summary>
    private readonly Dictionary<byte[], Message> _messages = new Dictionary<byte[], Message>();

  }

}
