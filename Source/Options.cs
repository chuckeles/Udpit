using System.Net;

namespace Udpit {

  /// <summary>
  ///   Application options.
  /// </summary>
  internal static class Options {

    /// <summary>
    ///   Maximum size of one message part when sending.
    /// </summary>
    public static ushort MaxPartSize = 1000;

    /// <summary>
    ///   User's name.
    /// </summary>
    public static string Name = "Newbie";

    /// <summary>
    ///   Port on which to communicate.
    /// </summary>
    public static int Port = 6994;

    /// <summary>
    ///   Remote endpoint. Where to send messages.
    /// </summary>
    public static IPEndPoint Remote = new IPEndPoint(new IPAddress(new byte[] {127, 0, 0, 1}), 6994);

    /// <summary>
    ///   Number of retries when fails occur.
    /// </summary>
    public const int Retries = 5;

    /// <summary>
    ///   Whether to send corrupt fragments.
    /// </summary>
    public static bool SendCorrupt = false;

    /// <summary>
    ///   Time in ms after which to time out operations.
    /// </summary>
    public const int TimeoutTime = 1000;

  }

}
