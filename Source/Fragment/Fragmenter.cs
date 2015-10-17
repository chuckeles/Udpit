﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Udpit {

  /// <summary>
  ///   Contains static methods to work with fragments.
  /// </summary>
  internal static class Fragmenter {

    /// <summary>
    ///   Creates a message and all it's fragments.
    /// </summary>
    /// <param name="remoteEndPoint">Where to send the message</param>
    /// <param name="messageString">String to send</param>
    /// <param name="maxFragmentSize">Maximum size of one fragment in bytes</param>
    public static Message CreateMessage(IPEndPoint remoteEndPoint, string messageString, ushort maxFragmentSize) {
      // convert message string to bytes
      var messageStringBytes = Encoding.ASCII.GetBytes(messageString);

      // create a sorted list of fragments
      var fragmentList = new SortedList<ushort, byte[]>();

      // add all fragments
      while (messageStringBytes.Length > 0) {
        // get the fragment bytes
        byte[] bytes;

        // check the remaining size
        if (messageStringBytes.Length > maxFragmentSize) {
          // take maximum allowed bytes and make a fragment
          bytes = messageStringBytes.Take(maxFragmentSize).ToArray();

          // shift
          messageStringBytes = messageStringBytes.Skip(maxFragmentSize).ToArray();
        }
        else {
          // take whole fragment
          bytes = messageStringBytes;
          messageStringBytes = new byte[0];
        }

        // add the fragment to the list
        fragmentList.Add((ushort) fragmentList.Count, bytes);
      }

      // create a message
      var message = new Message((ushort) fragmentList.Count) {
        RemoteEndPoint = remoteEndPoint,
        FragmentList = fragmentList
      };

      // return the message
      return message;
    }

    /// <summary>
    ///   Gets the number of data fragments from a prepare fragment.
    /// </summary>
    public static ushort GetFragmentCount(byte[] fragment) {
      // the count is the fourth and fifth byte
      return BitConverter.ToUInt16(fragment, 3);
    }

    /// <summary>
    ///   Gets the type of a fragment.
    /// </summary>
    public static FragmentType GetFragmentType(byte[] fragment) {
      // the very first byte is always the type
      return (FragmentType) fragment[0];
    }

    /// <summary>
    ///   Gets the id of a message from fragment.
    /// </summary>
    public static byte[] GetID(byte[] fragment) {
      // id is the second and third byte
      return fragment.Skip(1).Take(2).ToArray();
    }

    /// <summary>
    ///   Makes a prepared fragment.
    /// </summary>
    public static byte[] GetPreparedFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Prepared);

      // add the id
      data.AddRange(message.Id);

      // add name
      data.AddRange(Encoding.ASCII.GetBytes(Options.Name));

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes a prepare fragment.
    /// </summary>
    public static byte[] GetPrepareFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Prepare);

      // add the id
      data.AddRange(message.Id);

      // add fragment count
      data.AddRange(BitConverter.GetBytes(message.FragmentCount));

      // add name
      data.AddRange(Encoding.ASCII.GetBytes(Options.Name));

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Get the remote name from a prepare fragment.
    /// </summary>
    public static string GetPrepareName(byte[] fragment) {
      // the name starts at the sixth byte
      var bytes = fragment.Skip(5).ToArray();

      // convert and return
      return Encoding.ASCII.GetString(bytes);
    }

  }

}
