using System;

namespace Udpit {

  /// <summary>
  ///   Provides central point to log and listen to text messages.
  /// </summary>
  public class Log {

    /// <summary>
    ///   Fired when an error is logged.
    /// </summary>
    public event EventHandler<string> ErrorLogged;

    /// <summary>
    ///   Fired when a message is logged.
    /// </summary>
    public event EventHandler<string> MessageLogged;

    private Log() {}

    /// <summary>
    ///   Creates a singleton instance.
    /// </summary>
    public static Log Create() {
      // check existing instance
      if (Singleton != null)
        return Singleton;

      // create an instance
      Singleton = new Log();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Logs an error.
    /// </summary>
    public void LogError(string errorMessage) {
      // fire the event
      ErrorLogged?.Invoke(this, errorMessage);
    }

    /// <summary>
    ///   Logs a new message.
    /// </summary>
    public void LogMessage(string message) {
      // fire the event
      MessageLogged?.Invoke(this, message);
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Log Singleton { get; private set; }

  }

}
