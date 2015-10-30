using System;
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
      fragment = fragment.Concat(BitConverter.GetBytes(checksum)).ToArray();
    }

    /// <summary>
    ///   Checks a fragment and removes the checksum.
    /// </summary>
    public static bool CheckFragment(ref byte[] fragment) {
      // remove last 2 bytes, that's the checksum 
      var checksum = BitConverter.ToUInt16(fragment.Reverse().Take(2).Reverse().ToArray(), 0);
      fragment = fragment.Reverse().Skip(2).Reverse().ToArray();

      // generate checksum and compare
      return (checksum == GetChecksum(fragment));
    }

    /// <summary>
    ///   Generates a checksum.
    /// </summary>
    private static ushort GetChecksum(byte[] fragment) {
      // TODO: Figure this out and write your own
      ushort Polynominal = 0x1021;
      ushort InitValue = 0x0;

      ushort i, j, index = 0;
      ushort CRC = InitValue;
      ushort Remainder, tmp, short_c;
      for (i = 0; i < fragment.Length; i++) {
        short_c = (ushort)(0x00ff & (ushort)fragment[index]);
        tmp = (ushort)((CRC >> 8) ^ short_c);
        Remainder = (ushort)(tmp << 8);
        for (j = 0; j < 8; j++) {

          if ((Remainder & 0x8000) != 0) {
            Remainder = (ushort)((Remainder << 1) ^ Polynominal);
          }
          else {
            Remainder = (ushort)(Remainder << 1);
          }
        }
        CRC = (ushort)((CRC << 8) ^ Remainder);
        index++;
      }
      return CRC;
    }

  }

}
