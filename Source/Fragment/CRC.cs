using System.Linq;

namespace Udpit {

  /// <summary>
  ///   The CRC thing to check and generate checksums for fragments.
  /// </summary>
  public static class CRC {

    /// <summary>
    ///   Generates a checksum and appends it to a fragment.
    /// </summary>
    public static void GenerateChecksum(ref byte[] fragment) {
      // get checksum
      var checksum = GetChecksum(fragment);

      // append it
      fragment = fragment.Concat(checksum).ToArray();
    }

    /// <summary>
    ///   Checks a fragment and removes the checksum.
    /// </summary>
    public static bool CheckFragment(ref byte[] fragment) {}

    /// <summary>
    ///   Generates a checksum.
    /// </summary>
    private static byte[] GetChecksum(byte[] fragment) {}

  }

}
