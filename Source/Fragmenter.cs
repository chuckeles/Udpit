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

  }

}
