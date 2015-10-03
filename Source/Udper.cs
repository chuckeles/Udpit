using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Udpit {

  /// <summary>
  ///   The UDP messaging system.
  /// </summary>
  internal class Udper {

    private Udper() {
      // set up default options
      SetupOptions();

      // start listening
      Listen();
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

      // check ip
      // if (Destination.ToString() == "127.0.0.1")
      //   return false;

      // all set up
      return true;
    }

    /// <summary>
    ///   Send a message.
    /// </summary>
    public void SendMessage(string message) {
      // check
      if (!CanSend())
        return;

      // create end point
      var endPoint = new IPEndPoint(Destination, Port);

      // create client
      var client = new UdpClient();

      // bytes to send
      var bytes = new List<byte>();

      // add name
      bytes.AddRange(ByteUtility.GetBytes(Name));

      // make sure it's 32 bytes for the name
      while (bytes.Count > 32)
        bytes.Remove(bytes.Last());
      while (bytes.Count < 32)
        bytes.Add(0);

      // add message text
      bytes.AddRange(ByteUtility.GetBytes(message));

      // get array
      var data = bytes.ToArray();

      // send the message
      client.Send(data, data.Length, endPoint);

      // fire an event
      OnMessageSend?.Invoke(message, Name, endPoint.Address.ToString());
    }

    /// <summary>
    ///   Set a destination IP.
    /// </summary>
    public bool SetDestination(string destinationString) {
      // try to parse ip address
      IPAddress ipAddress;
      if (IPAddress.TryParse(destinationString, out ipAddress)) {
        Destination = ipAddress;
        return true;
      }
      return false;
    }

    /// <summary>
    ///   Listens for incoming messages.
    /// </summary>
    private void Listen() {
      // create listener
      var listener = new UdpClient(Port);

      // listen
      listener.BeginReceive(Receive, listener);
    }

    /// <summary>
    ///   Receive a message.
    /// </summary>
    private void Receive(IAsyncResult ar) {
      // end point
      var remotePoint = new IPEndPoint(IPAddress.Any, Port);

      // get listener
      var listener = ar.AsyncState as UdpClient;

      // get data
      var data = listener.EndReceive(ar, ref remotePoint);

      // listen again
      listener.BeginReceive(Receive, listener);

      // get name
      var name = ByteUtility.GetString(data.Take(32).ToArray());

      // get message
      var message = ByteUtility.GetString(data.Skip(32).ToArray());

      // fire an event
      OnMessageReceive?.Invoke(message, name, remotePoint.Address.ToString());
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

    /// <summary>
    ///   Fired when a message is received.
    /// </summary>
    public event MessageReceiveData OnMessageReceive;

    /// <summary>
    ///   Fired when a message is sent.
    /// </summary>
    public event MessageSendData OnMessageSend;

    /// <summary>
    ///   Communication port.
    /// </summary>
    private const int Port = 11002;

  }

  /// <summary>
  ///   Delegate for incoming message.
  /// </summary>
  public delegate void MessageReceiveData(string message, string name, string source);

  /// <summary>
  ///   Delegate for outgoing message.
  /// </summary>
  public delegate void MessageSendData(string message, string name, string source);

}
