using System.Collections.Generic;
using System.Net;

namespace Udpit {

  /// <summary>
  ///   Message information and fragments.
  /// </summary>
  internal class Message {

    /// <summary>
    ///   Number of fragments.
    /// </summary>
    private ushort _fragmentCount;

    /// <summary>
    ///   The sorted list of fragments.
    /// </summary>
    /// <remarks>
    ///   In the source this is a list of all fragments.
    ///   In the destination this is a list of received and checked fragments.
    /// </remarks>
    private List<byte[]> _fragmentList = new List<byte[]>();

    /// <summary>
    ///   Message id.
    /// </summary>
    private byte[] _id = new byte[2];

    /// <summary>
    ///   Remote's ip and port.
    /// </summary>
    private IPEndPoint _remoteEndPoint;

    /// <summary>
    ///   Remote's name.
    /// </summary>
    private string _remoteName;

  }

}
