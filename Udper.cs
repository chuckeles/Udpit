namespace Udpit {

  /// <summary>
  ///   The UDP messaging system.
  /// </summary>
  internal class Udper {

    public Udper() {
      // check singleton
      if (Singleton != null)
        return;

      // set singleton
      Singleton = this;
    }

    /// <summary>
    ///   The udper singleton.
    /// </summary>
    public Udper Singleton { get; }

    /// <summary>
    ///   The destination url.
    /// </summary>
    public string Destination;

    /// <summary>
    ///   Maximum fragment size.
    /// </summary>
    public int MaxFragment;

    /// <summary>
    ///   The user's name.
    /// </summary>
    public string Name;

    /// <summary>
    ///   Whether to send error fragments for testing purposes.
    /// </summary>
    public bool SendError;

  }

}
