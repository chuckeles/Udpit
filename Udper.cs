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
    /// Returns whether we are correctly configured and can send a message.
    /// </summary>
    public bool CanSend() {
      // check name
      if (Name == "")
        return false;

      // check destination
      if (Destination == "")
        return false;

      // check if destination is a valid ip address
      IPAddress ip;
      if (!IPAddress.TryParse(Destination, out ip))
        return false;

      // all set up
      return true;
    }

    /// <summary>
    ///   Sets up default first-time options.
    /// </summary>
    private void SetupOptions() {
      Name = "excited user";
      Destination = "";
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
