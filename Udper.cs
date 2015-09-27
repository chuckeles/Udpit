using System.Net;

namespace Udpit {

  /// <summary>
  ///   The UDP messaging system.
  /// </summary>
  internal class Udper {

    private Udper() {
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
    ///   Returns whether we are correctly configured and can send a message.
    /// </summary>
    public bool CanSend() {
      // check name
      if (Name == "")
        return false;

      // all set up
      return true;
    }

    /// <summary>
    /// </summary>
    public bool SetDestination(string destinationString) {
      // try to parse ip address
      return IPAddress.TryParse(destinationString, out Destination);
    }

    /// <summary>
    ///   Sets up default first-time options.
    /// </summary>
    private void SetupOptions() {
      Name = "excited user";
      Destination = new IPAddress(new byte[] {127, 0, 0, 1});
      MaxFragment = 128;
      SendError = false;
    }

    /// <summary>
    ///   The udper singleton.
    /// </summary>
    public static Udper Singleton { get; private set; }

    /// <summary>
    ///   The destination ip.
    /// </summary>
    public IPAddress Destination;

    /// <summary>
    ///   Maximum fragment size.
    /// </summary>
    public decimal MaxFragment;

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
