using System;
using System.Collections.Generic;
using System.Net;

namespace Udpit {

  /// <summary>
  ///   Message hub. Contains all messages in progress.
  /// </summary>
  internal class MessageCenter {

    private MessageCenter() {}

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
    ///   Create a new message that needs to be send. Called by the UI.
    /// </summary>
    /// <param name="remoteEndPoint">Where to send the message</param>
    /// <param name="messageString">String to send</param>
    /// <param name="maxFragmentSize">Maximum size of one fragment in bytes</param>
    public void CreateMessage(IPEndPoint remoteEndPoint, string messageString, ushort maxFragmentSize) {
      // ask for a fragmented message
      var message = Fragmenter.CreateMessage(remoteEndPoint, messageString, maxFragmentSize);

      // add it to the dictionary
      lock (Messages) {
        Messages.Add(BitConverter.ToUInt16(message.Id, 0), message);
      }

      // begin transmission
      //Sender.Singleton.SendPrepareFragment(message);
    }

    /// <summary>
    ///   Add an incoming data fragment.
    /// </summary>
    private void AddFragment(byte[] fragment) {
      // get message id
      var id = Fragmenter.GetID(fragment);

      // convert id
      var idKey = BitConverter.ToUInt16(id, 0);

      // find it in the dictionary
      if (!Messages.ContainsKey(idKey))
        return;

      // get the message
      var message = Messages[idKey];

      // get fragment number
      var number = Fragmenter.GetFragmentNumber(fragment);

      // check if the fragment exists
      if (message.PartList.ContainsKey(number))
        return;

      // TODO: Check the fragment for errors

      // get data
      var data = Fragmenter.GetData(fragment);

      // add the fragment
      lock (message) {
        message.PartList.Add(number, data);
      }
    }

    /// <summary>
    ///   Delegate for the receiver's fragment received event.
    /// </summary>
    private void FragmentReceived(byte[] fragment, IPEndPoint remoteEndPoint) {
      // check the type
      var type = Fragmenter.GetFragmentType(fragment);

      // decision time
      switch (type) {
        case FragmentType.Prepare:
          // make a local copy
          var prepareMessage = PrepareMessage(fragment, remoteEndPoint);

          // respond
          if (prepareMessage != null) {
            //Sender.Singleton.SendPreparedFragment(prepareMessage);
          }

          break;

        case FragmentType.Prepared:
          // set remote name
          var preparedMessage = SetRemoteName(fragment);

          // start sending data fragments
          if (preparedMessage != null) {
            //Sender.Singleton.SendDataFragments(preparedMessage);
          }

          break;

        case FragmentType.Data:
          // add fragment
          AddFragment(fragment);

          break;

        case FragmentType.End:
          // get message
          var endMessage = GetMessage(fragment);
          if (endMessage == null)
            break;

          // TODO: Check missing fragments

          // send okay fragment
          //Sender.Singleton.SendOkayFragment(endMessage);

          break;

        case FragmentType.Okay:
          // get message
          var okayMessage = GetMessage(fragment);
          if (okayMessage == null)
            break;

          // update status
          lock (okayMessage) {
            okayMessage.Status = MessageStatus.Finished;
          }

          break;
      }
    }

    /// <summary>
    ///   Finds a message from a fragment.
    /// </summary>
    private Message GetMessage(byte[] fragment) {
      // get id
      var id = Fragmenter.GetID(fragment);
      var idKey = BitConverter.ToUInt16(id, 0);

      // find and return message
      return Messages.ContainsKey(idKey) ? Messages[idKey] : null;
    }

    /// <summary>
    ///   Creates a message based on prepare fragment.
    /// </summary>
    private Message PrepareMessage(byte[] fragment, IPEndPoint remoteEndPoint) {
      // get message id
      var id = Fragmenter.GetID(fragment);

      // convert id
      var idKey = BitConverter.ToUInt16(id, 0);

      // check if we already have one like that
      lock (Messages) {
        if (Messages.ContainsKey(idKey))
          return Messages[idKey];
      }

      // get fragment count
      var count = Fragmenter.GetFragmentCount(fragment);

      // get remote name
      var name = Fragmenter.GetPrepareName(fragment);

      // create a message
      var message = new Message(count, id) {
        RemoteName = name,
        RemoteEndPoint = remoteEndPoint,
        Status = MessageStatus.Handshaking
      };

      // add it to the dictionary
      lock (Messages) {
        Messages.Add(idKey, message);
      }

      // return the message
      return message;
    }

    /// <summary>
    ///   Update the message remote name from a prepared fragment.
    /// </summary>
    private Message SetRemoteName(byte[] fragment) {
      // get ID
      var id = Fragmenter.GetID(fragment);

      // convert id
      var idKey = BitConverter.ToUInt16(id, 0);

      // get remote name
      var name = Fragmenter.GetPreparedName(fragment);

      // set the name
      lock (Messages) {
        if (Messages.ContainsKey(idKey)) {
          Messages[idKey].RemoteName = name;

          // return the message
          return Messages[idKey];
        }
      }

      // there's no message
      return null;
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
