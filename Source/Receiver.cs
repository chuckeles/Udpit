namespace Udpit {

  /// <summary>
  ///   Receives fragments. Lets others know via events.
  /// </summary>
  internal class Receiver {

    private Receiver() {}

    /// <summary>
    ///   Creates the singleton instance.
    /// </summary>
    public static Receiver Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Receiver();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Receiver Singleton { get; private set; }

  }

}
