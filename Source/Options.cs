namespace Udpit {

  /// <summary>
  ///   Application options.
  /// </summary>
  internal static class Options {

    /// <summary>
    ///   User's name.
    /// </summary>
    public static string Name { get; set; } = "Newbie";

    /// <summary>
    ///   Port on which to communicate.
    /// </summary>
    /// <remarks>
    ///   https://stackoverflow.com/questions/9120050/connecting-two-udp-clients-to-one-port-send-and-receive
    /// </remarks>
    public static int Port { get; set; } = 6994;

  }

}
