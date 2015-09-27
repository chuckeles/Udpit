namespace Udpit {

  /// <summary>
  ///   The UDP messaging system.
  /// </summary>
  internal class Udper {

    public Udper() {
      // set up default options
      SetupOptions();
    }

    /// <summary>
    ///   Creates new singleton.
    /// </summary>
    public static Udper Create() {
      // check singleton
      if (Singleton != null)
        return Singleton;

      // create singleton
      Singleton = new Udper();

      // return
      return Singleton;
    }

    /// <summary>
    ///   Sets up default first-time options.
    /// </summary>
    private void SetupOptions() {
      Name = "excited user";
      Destination = "localhost";
      MaxFragment = 128;
      SendError = false;
    }

    /// <summary>
    ///   The udper singleton.
    /// </summary>
    public static Udper Singleton { get; private set; }

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
