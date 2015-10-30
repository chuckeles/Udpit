using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

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
    ///   Sends a file.
    /// </summary>
    public void SendFileMessage(string file) {
      // ask for a message
      var message = Fragmenter.CreateFileMessage(Options.Remote, file, Options.MaxPartSize);

      // add to the dictionary
      lock (Messages) {
        Messages.Add(BitConverter.ToUInt16(message.ID, 0), message);
      }

      // log the start
      lock (message) {
        Log.Singleton.LogMessage(
          $"Sending message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> to <{Options.Remote}> with maximum part size of <{Options.MaxPartSize}B> from the file <{message.FileName}>");
      }

      // delegate to the transmitter
      Transmitter.Singleton.SendPrepareFileFragment(message);
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
    ///   Add an incoming part.
    /// </summary>
    private void AddPart(byte[] fragment) {
      // get message id
      var id = Fragmenter.GetID(fragment);

      // convert id
      var idKey = BitConverter.ToUInt16(id, 0);

      // find it in the dictionary
      lock (Messages) {
        if (!Messages.ContainsKey(idKey))
          return;
      }

      // get the message
      Message message;
      lock (Messages) {
        message = Messages[idKey];
      }

      // update status
      lock (message) {
        if (message.Status != MessageStatus.Transmitting) {
          message.Status = MessageStatus.Transmitting;

          // log
          Log.Singleton.LogMessage(
            $"Message <{message.ID[0].ToString("00")}{message.ID[1].ToString("00")}> is in state <{message.Status}>");
        }
      }

      // get part number
      var number = Fragmenter.GetPartNumber(fragment);

      // check if the fragment exists
      lock (message) {
        if (message.PartList.ContainsKey(number))
          return;
      }

      // get data
      var data = Fragmenter.GetData(fragment);

      // add the fragment
      lock (message) {
        message.PartList.Add(number, data);
      }
    }

    /// <summary>
    ///   Handles an incoming fragment.
    /// </summary>
    private void FragmentCame(byte[] fragment, IPEndPoint remoteEndPoint) {
      // TODO: CRC, check for errors

      // get type
      var type = Fragmenter.GetFragmentType(fragment);

      // log
      Log.Singleton.LogMessage($"Received a fragment of type <{type}> and size <{fragment.Length}B>");

      // decision time
      switch (type) {
        case FragmentType.Prepare:
          // make a local copy
          var prepareMessage = PrepareMessage(fragment, remoteEndPoint);

          // log the fact
          lock (prepareMessage) {
            Log.Singleton.LogMessage(
              $"Created a message <{prepareMessage.ID[0].ToString("00")}{prepareMessage.ID[1].ToString("00")}>");
          }

          // respond
          Transmitter.Singleton.SendPreparedFragment(prepareMessage);

          break;

        case FragmentType.PrepareFile:
          // make a local copy
          var prepareFileMessage = PrepareFileMessage(fragment, remoteEndPoint);

          // log the fact
          lock (prepareFileMessage) {
            Log.Singleton.LogMessage(
              $"Created a message <{prepareFileMessage.ID[0].ToString("00")}{prepareFileMessage.ID[1].ToString("00")}> from a file <{prepareFileMessage.FileName}>");
          }

          // respond
          Transmitter.Singleton.SendPreparedFragment(prepareFileMessage);

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
          AddPart(fragment);

          // listen again
          Transmitter.Singleton.Listen(false);

          break;

        case FragmentType.End:
          // get message
          var endMessage = GetMessage(fragment);
          if (endMessage == null)
            break;

          // check missing fragments
          var missing = new List<ushort>();
          lock (endMessage) {
            if (endMessage.PartList.Count < endMessage.PartCount) {
              // missing fragments, oh god!
              for (ushort i = 0; i < endMessage.PartCount; ++i) {
                if (!endMessage.PartList.ContainsKey(i))
                  missing.Add(i);
              }
            }
          }

          // if missing, request them
          if (missing.Count > 0) {
            // log
            Log.Singleton.LogMessage(
              $"Message <{endMessage.ID[0].ToString("00")}{endMessage.ID[1].ToString("00")}> is <missing> some parts");

            // send missing fragment
            Transmitter.Singleton.SendMissingFragment(endMessage, missing);

            // done
            break;
          }

          // send okay fragment
          Transmitter.Singleton.SendOkayFragment(endMessage);

          // print the message
          lock (endMessage) {
            if (!endMessage.FileName.Equals("")) {
              // received a file
              Log.Singleton.LogMessage(
                $"Successfully received a full message <{endMessage.ID[0].ToString("00")}{endMessage.ID[1].ToString("00")}> from <{endMessage.RemoteName}> to a file <'{endMessage.FileName}'>");

              // save to the file
              File.WriteAllBytes(Path.Combine(Directory.GetCurrentDirectory(), endMessage.FileName), endMessage.ReconstructFile());
            }
            else {
              if (endMessage.Text.Equals(""))
                endMessage.ReconstructText();

              Log.Singleton.LogMessage(
                $"Successfully received a full message <{endMessage.ID[0].ToString("00")}{endMessage.ID[1].ToString("00")}> from <{endMessage.RemoteName}> with a text <'{endMessage.Text}'>");
            }
          }

          // remove message
          lock (endMessage) {
            Messages.Remove(BitConverter.ToUInt16(endMessage.ID, 0));
          }

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

          // print the message
          lock (okayMessage) {
            if (!okayMessage.FileName.Equals("")) {
              // sent a file
              Log.Singleton.LogMessage(
                $"Successfully sent a full message <{okayMessage.ID[0].ToString("00")}{okayMessage.ID[1].ToString("00")}> to <{okayMessage.RemoteName}> from a file <'{okayMessage.FileName}'>");
            }
            else {
              if (okayMessage.Text.Equals(""))
                okayMessage.ReconstructText();

              Log.Singleton.LogMessage(
                $"Successfully sent a full message <{okayMessage.ID[0].ToString("00")}{okayMessage.ID[1].ToString("00")}> to <{okayMessage.RemoteName}> with a text <'{okayMessage.Text}'>");
            }
          }

          // remove message
          lock (okayMessage) {
            Messages.Remove(BitConverter.ToUInt16(okayMessage.ID, 0));
          }

          break;

        case FragmentType.Missing:
          // get message
          var missingMessage = GetMessage(fragment);
          if (missingMessage == null)
            break;

          // get missing list
          var missingList = Fragmenter.GetMissingFragments(fragment);

          // resend data
          Transmitter.Singleton.SendDataFragments(missingMessage, missingList);

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

      // find message
      lock (Messages) {
        if (!Messages.ContainsKey(idKey))
          return null;
      }

      // get message
      lock (Messages) {
        return Messages[idKey];
      }
    }

    /// <summary>
    ///   Creates a message based on prepare file fragment.
    /// </summary>
    private Message PrepareFileMessage(byte[] fragment, IPEndPoint remoteEndPoint) {
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

      // get file name
      var fileName = Fragmenter.GetFileName(fragment);

      // get remote name
      var name = Fragmenter.GetPrepareFileName(fragment);

      // create a message
      var message = new Message(count, id) {
        RemoteName = name,
        RemoteEndPoint = remoteEndPoint,
        Status = MessageStatus.Handshaking,
        FileName = fileName
      };

      // add it to the dictionary
      lock (Messages) {
        Messages.Add(idKey, message);
      }

      // return the message
      return message;
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
          lock (Messages[idKey]) {
            Messages[idKey].RemoteName = name;
          }

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
