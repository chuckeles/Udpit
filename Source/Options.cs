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
    ///   Port on which to listen for data.
    /// </summary>
    public static int ReceivePort { get; set; } = 10695;

    /// <summary>
    ///   Port on which to send data.
    /// </summary>
    public static int SendPort { get; set; } = 10694;

  }

}
