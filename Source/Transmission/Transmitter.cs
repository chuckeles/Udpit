using System;

namespace Udpit {

  /// <summary>
  ///   Handles UDP communication and transmits the fragments.
  /// </summary>
  internal class Transmitter {

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
    ///   Open the socket for listening.
    /// </summary>
    public void Listen() {
      if (_listening)
        return;

      // set the flag
      _listening = true;

      // log
      Log.Singleton.LogMessage("Listening for incoming fragments");
    }

    /// <summary>
    /// Whether the socket is currently listening.
    /// </summary>
    private bool _listening = false;

    /// <summary>
    ///   Send a message.
    /// </summary>
    public void SendMessage(Message message) {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   Close the socket for listening.
    /// </summary>
    public void StopListening() {
      if (!_listening)
        return;

      // set the flag
      _listening = false;

      // log
      Log.Singleton.LogMessage("Stopping listening");
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Transmitter Singleton { get; private set; }

  }

}
