using System;
using System.Collections.Generic;
using System.Net;

namespace Udpit {

  /// <summary>
  ///   Message information and fragments.
  /// </summary>
  internal class Message {

    public Message(ushort partCount, MessageOrigin origin = MessageOrigin.Local)
      : this(partCount, new[] {(byte) DateTime.Now.Minute, (byte) DateTime.Now.Second}) {}

    public Message(ushort partCount, SortedList<ushort, byte[]> parts, MessageOrigin origin = MessageOrigin.Local)
      : this(partCount, origin) {
      // set the part list
      PartList = parts;
    }

    public Message(ushort partCount, byte[] id, MessageOrigin origin = MessageOrigin.Remote) {
      // set part count
      PartCount = partCount;

      // set origin
      Origin = origin;

      // set the id
      Id[0] = id[0];
      Id[1] = id[1];
    }

    /// <summary>
    ///   Message ID.
    /// </summary>
    public byte[] Id { get; } = new byte[2];

    /// <summary>
    ///   The origin of the message.
    /// </summary>
    public MessageOrigin Origin { get; }

    /// <summary>
    ///   Number of parts.
    /// </summary>
    public ushort PartCount { get; }

    /// <summary>
    ///   The sorted list of parts.
    /// </summary>
    /// <remarks>
    ///   In the source this is a list of all parts.
    ///   In the destination this is a list of received and checked parts.
    /// </remarks>
    public SortedList<ushort, byte[]> PartList { get; } = new SortedList<ushort, byte[]>();

    /// <summary>
    ///   Remote's IP and port.
    /// </summary>
    public IPEndPoint RemoteEndPoint { get; set; }

    /// <summary>
    ///   Remote's name.
    /// </summary>
    public string RemoteName { get; set; }

    /// <summary>
    ///   The current status of the message.
    /// </summary>
    public MessageStatus Status = MessageStatus.Created;

  }

}
