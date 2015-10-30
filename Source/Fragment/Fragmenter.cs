using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Udpit {

  /// <summary>
  ///   Contains static methods to work with fragments.
  /// </summary>
  internal static class Fragmenter {

    /// <summary>
    ///   Creates a message and all it's fragments. From a file.
    /// </summary>
    /// <param name="remoteEndPoint">Where to send the message</param>
    /// <param name="file">File to send</param>
    /// <param name="maxFragmentSize">Maximum size of one fragment in bytes</param>
    public static Message CreateFileMessage(IPEndPoint remoteEndPoint, string file, ushort maxFragmentSize) {
      // read file bytes
      var fileBytes = File.ReadAllBytes(file);

      // create a sorted list of fragments
      var fragmentList = new SortedList<ushort, byte[]>();

      // add all fragments
      while (fileBytes.Length > 0) {
        // get the fragment bytes
        byte[] bytes;

        // check the remaining size
        if (fileBytes.Length > maxFragmentSize) {
          // take maximum allowed bytes and make a fragment
          bytes = fileBytes.Take(maxFragmentSize).ToArray();

          // shift
          fileBytes = fileBytes.Skip(maxFragmentSize).ToArray();
        }
        else {
          // take whole fragment
          bytes = fileBytes;
          fileBytes = new byte[0];
        }

        // add the fragment to the list
        fragmentList.Add((ushort)fragmentList.Count, bytes);
      }

      // create a message
      var message = new Message((ushort)fragmentList.Count, fragmentList) {
        RemoteEndPoint = remoteEndPoint,
        FileName = file
      };

      // return the message
      return message;
    }

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
      var message = new Message((ushort) fragmentList.Count, fragmentList) {
        RemoteEndPoint = remoteEndPoint,
        Text = messageString
      };

      // return the message
      return message;
    }

    /// <summary>
    ///   Gets data from a data fragment.
    /// </summary>
    public static byte[] GetData(byte[] fragment) {
      // data begins at sixth byte
      return fragment.Skip(5).ToArray();
    }

    /// <summary>
    ///   Get file name from a prepare file fragment.
    /// </summary>
    public static string GetFileName(byte[] fragment) {
      // get file name size
      var size = fragment.Skip(3).ToArray()[0];

      // get bytes
      var bytes = fragment.Skip(5).Take(size).ToArray();

      // convert and return
      return Encoding.ASCII.GetString(bytes);
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
    ///   Gets the list of missing fragments from a missing fragment.
    /// </summary>
    public static List<ushort> GetMissingFragments(byte[] fragment) {
      // start at fourth byte
      var byteList = fragment.Skip(3).ToArray();

      // make a list
      var list = new List<ushort>();

      // add missing fragment numbers
      while (byteList.Length > 0) {
        // get number
        list.Add(BitConverter.ToUInt16(byteList.Take(2).ToArray(), 0));

        // shift
        byteList = byteList.Skip(2).ToArray();
      }

      // return the list
      return list;
    }

    /// <summary>
    ///   Gets the number of a message part.
    /// </summary>
    public static ushort GetPartNumber(byte[] fragment) {
      // same implementation
      return GetFragmentCount(fragment);
    }

    /// <summary>
    ///   Gets the remote name from a prepared fragment.
    /// </summary>
    public static string GetPreparedName(byte[] fragment) {
      // the name starts at the fourth byte
      var bytes = fragment.Skip(3).ToArray();

      // convert and return
      return Encoding.ASCII.GetString(bytes);
    }

    /// <summary>
    ///   Gets remote name from a prepare file fragment.
    /// </summary>
    public static string GetPrepareFileName(byte[] fragment) {
      // get file name size
      var size = fragment.Skip(3).ToArray()[0];

      // get bytes
      var bytes = fragment.Skip(5).Skip(size).ToArray();

      // convert and return
      return Encoding.ASCII.GetString(bytes);
    }

    /// <summary>
    ///   Gets the remote name from a prepare fragment.
    /// </summary>
    public static string GetPrepareName(byte[] fragment) {
      // the name starts at the sixth byte
      var bytes = fragment.Skip(5).ToArray();

      // convert and return
      return Encoding.ASCII.GetString(bytes);
    }

    /// <summary>
    ///   Makes a data fragment for a fragment of a message.
    /// </summary>
    public static byte[] MakeDataFragment(Message message, ushort number) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Data);

      // add the id
      data.AddRange(message.ID);

      // add the fragment number
      data.AddRange(BitConverter.GetBytes(number));

      // add data
      data.AddRange(message.PartList[number]);

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes an end fragment.
    /// </summary>
    public static byte[] MakeEndFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.End);

      // add the id
      data.AddRange(message.ID);

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes a missing fragment.
    /// </summary>
    public static byte[] MakeMissingFragment(Message message, List<ushort> missingList) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Missing);

      // add the id
      data.AddRange(message.ID);

      // add missing fragments
      foreach (var missingFragment in missingList) {
        data.AddRange(BitConverter.GetBytes(missingFragment));
      }

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes an okay fragment.
    /// </summary>
    public static byte[] MakeOkayFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Okay);

      // add the id
      data.AddRange(message.ID);

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes a prepared fragment.
    /// </summary>
    public static byte[] MakePreparedFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Prepared);

      // add the id
      data.AddRange(message.ID);

      // add name
      data.AddRange(Encoding.ASCII.GetBytes(Options.Name));

      // return data
      return data.ToArray();
    }

    /// <summary>
    ///   Makes a prepare fragment.
    /// </summary>
    public static byte[] MakePrepareFragment(Message message) {
      // the resulting array of bytes
      var data = new List<byte>();

      // add the type
      data.Add((byte) FragmentType.Prepare);

      // add the id
      data.AddRange(message.ID);

      // add fragment count
      data.AddRange(BitConverter.GetBytes(message.PartCount));

      // add name
      data.AddRange(Encoding.ASCII.GetBytes(Options.Name));

      // return data
      return data.ToArray();
    }

  }

}
