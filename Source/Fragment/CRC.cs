using System;
using System.Linq;

namespace Udpit {

  /// <summary>
  ///   The CRC thing to check and generate checksums for fragments. Uses CRC-16.
  /// </summary>
  public static class CRC {

    /// <summary>
    /// CRC-16-IBM polynomial.
    /// </summary>
    private const ushort Polynomial = 0x8005;

    /// <summary>
    /// Testing polynomial.
    /// </summary>
    private const byte SimplePolynomial = 0xD5;

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
    private static byte GetChecksum(byte[] fragment) {
      // TODO: Use CRC-16, ushort

      // the remainder
      byte remainder = 0;

      // iterate bytes
      foreach (var fragmentByte in fragment) {
        // bring the byte to the remainder
        remainder ^= fragmentByte; // TODO: fragmentByte << 8

        // perform division, a bit at a time
        for (short bit = 8; bit > 0; --bit) {
          if ((remainder & (1 << 7)) > 0) // TODO: Use 1 << 15
            remainder = (byte) ((remainder << 1) ^ SimplePolynomial);
          else
            remainder = (byte) (remainder << 1);
        }
      }
      
      // final remainder is the checksum
      return remainder;
    }

  }

}
