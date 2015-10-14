namespace Udpit {

  /// <summary>
  ///   Enumeration of possible statuses of a message during transmission.
  /// </summary>
  internal enum MessageStatus {

    /// <summary>
    ///   The message was created locally and is awaiting transmission.
    /// </summary>
    Created,

    /// <summary>
    ///   A handshake is in progress.
    /// </summary>
    Handshaking,

    /// <summary>
    ///   Message fragments are begin sent / received.
    /// </summary>
    Transmitting,

    /// <summary>
    ///   Ending procedure is in progress.
    /// </summary>
    Ending,

    /// <summary>
    ///   The message was successfully sent / received.
    /// </summary>
    Finished,

    /// <summary>
    ///   Transmission of the message timed out.
    /// </summary>
    TimedOut

  }

}
