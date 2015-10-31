namespace Udpit {

  /// <summary>
  ///   Type of fragment.
  /// </summary>
  internal enum FragmentType {

    /// <summary>
    ///   Initialize handshake.
    /// </summary>
    Prepare = 0,

    /// <summary>
    ///   Confirm handshake.
    /// </summary>
    Prepared = 1,

    /// <summary>
    ///   Keep sending data.
    /// </summary>
    KeepAlive = 2,

    /// <summary>
    ///   Sending data.
    /// </summary>
    Data = 3,

    /// <summary>
    ///   Finish sending data.
    /// </summary>
    End = 4,

    /// <summary>
    ///   Data is fine.
    /// </summary>
    Okay = 5,

    /// <summary>
    ///   Request missing fragments.
    /// </summary>
    Missing = 6,

    /// <summary>
    ///   Initialize handshake with a file.
    /// </summary>
    PrepareFile = 7

  }

}
