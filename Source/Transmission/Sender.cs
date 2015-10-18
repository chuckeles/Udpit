﻿using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Udpit {

  /// <summary>
  ///   Sends messages. Lets others know via events.
  /// </summary>
  internal class Sender {

    /// <summary>
    ///   Delegate for fragment events.
    /// </summary>
    /// <param name="message">Message the fragment is part of</param>
    /// <param name="number">Fragment number</param>
    public delegate void FragmentDelegate(Message message, ushort number);

    /// <summary>
    ///   Delegate for the message events.
    /// </summary>
    public delegate void MessageDelegate(Message message);

    /// <summary>
    ///   Fired when a fragment has been sent.
    /// </summary>
    public event FragmentDelegate FragmentSent;

    /// <summary>
    ///   Fired when a message transmission is complete.
    /// </summary>
    public event MessageDelegate MessageSendingFinish;

    /// <summary>
    ///   Fired when a new message is beginning to be transmitted.
    /// </summary>
    public event MessageDelegate MessageSendingStart;

    private Sender() {
      // set up the UDP client
      _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
      _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));
    }

    /// <summary>
    ///   Creates the singleton instance.
    /// </summary>
    public static Sender Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Sender();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Send all data fragments of a message.
    /// </summary>
    public void SendDataFragments(Message message) {
      // create a task
      Task.Run(() => {
        // send all data fragments
        foreach (var pair in message.FragmentList) {
          // request a data fragment
          var fragment = Fragmenter.GetDataFragment(message, pair.Key);

          // send it
          lock (_udpClient) {
            _udpClient.Send(fragment, fragment.Length, message.RemoteEndPoint);
          }
        }
      });
    }

    /// <summary>
    ///   Sends a prepared fragment for a message.
    /// </summary>
    public void SendPreparedFragment(Message message) {
      // create a task
      Task.Run(() => {
        // ask for a prepared fragment
        var fragment = Fragmenter.GetPreparedFragment(message);

        // send the fragment
        lock (_udpClient) {
          _udpClient.Send(fragment, fragment.Length, message.RemoteEndPoint);
        }
      });
    }

    /// <summary>
    ///   Sends a prepare fragment for a message.
    /// </summary>
    public void SendPrepareFragment(Message message) {
      // create a task
      Task.Run(() => {
        // ask for a prepare fragment
        var fragment = Fragmenter.GetPrepareFragment(message);

        // fire the event
        MessageSendingStart?.Invoke(message);

        // update message status
        lock (message) {
          message.Status = MessageStatus.Handshaking;
        }

        // send the fragment
        lock (_udpClient) {
          _udpClient.Send(fragment, fragment.Length, message.RemoteEndPoint);
        }

        // TODO: Retry
      });
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Sender Singleton { get; private set; }

    /// <summary>
    ///   The UDP client that is used to send data.
    /// </summary>
    private readonly UdpClient _udpClient = new UdpClient();

  }

}