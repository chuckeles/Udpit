namespace Udpit {

  /// <summary>
  ///   Handles UDP communication and transmits the fragments.
  /// </summary>
  public class Transmitter {

    private Transmitter() {}

    /// <summary>
    ///   Creates a singleton instance.
    /// </summary>
    public static Transmitter Create() {
      // check existing instance
      if (Singleton != null)
        return Singleton;

      // create an instance
      Singleton = new Transmitter();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Transmitter Singleton { get; private set; }

  }

}
