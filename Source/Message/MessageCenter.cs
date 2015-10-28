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
      lock (message) {
        Log.Singleton.LogMessage(
          $"Sending message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> to <{Options.Remote}> with maximum part size of <{Options.MaxPartSize}B>");
      }

      // delegate to the transmitter
      Transmitter.Singleton.SendPrepareFragment(message);
    }

    /// <summary>
    ///   Handles an incoming fragment.
    /// </summary>
    private void FragmentCame(object sender, byte[] fragment) {
      // get type
      var type = Fragmenter.GetFragmentType(fragment);

      // log
      Log.Singleton.LogMessage($"Received a fragment of type <{type}> and size <{fragment.Length}B>");

      // decision time
      switch (type) {
        case FragmentType.Prepare:
          // make a local copy
          var prepareMessage = PrepareMessage(fragment, remoteEndPoint);

          // respond
          if (prepareMessage != null)
            Transmitter.Singleton.SendPreparedFragment(prepareMessage);

          break;

        case FragmentType.Prepared:
          // set remote name
          var preparedMessage = SetRemoteName(fragment);

          // start sending data fragments
          if (preparedMessage != null)
            Transmitter.Singleton.SendDataFragments(preparedMessage);

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
          Transmitter.Singleton.SendOkayFragment(endMessage);

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

          // log that
          lock (okayMessage) {
            Log.Singleton.LogMessage(
              $"Message <{okayMessage.ID[0].ToString("00")}{okayMessage.ID[1].ToString("00")}> is in state <{okayMessage.Status}>");
          }

          break;
      }
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
