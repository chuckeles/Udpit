using System;
using System.Linq;

namespace Udpit {

  /// <summary>
  ///   The CRC thing to check and generate checksums for fragments. Uses CRC-16.
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
    /// <remarks>
    ///   http://www.barrgroup.com/Embedded-Systems/How-To/CRC-Calculation-C-Code
    /// </remarks>
    private static ushort GetChecksum(byte[] fragment) {
      // the remainder
      ushort remainder = 0;

      // iterate bytes
      foreach (var fragmentByte in fragment) {
        // bring the byte to the remainder
        remainder ^= (ushort) (fragmentByte << 8);

        // perform division, a bit at a time
        for (short bit = 8; bit > 0; --bit) {
          if ((remainder & TopBit) != 0)
            remainder = (ushort) ((remainder << 1) ^ Polynomial);
          else
            remainder = (ushort) (remainder << 1);
        }
      }

      // final remainder is the checksum
      return remainder;
    }

    /// <summary>
    ///   CRC-16-IBM polynomial.
    /// </summary>
    /// <remarks>
    ///   https://en.wikipedia.org/wiki/Polynomial_representations_of_cyclic_redundancy_checks
    /// </remarks>
    private const ushort Polynomial = 0x8005;

    /// <summary>
    ///   Top bit used in the algorithm.
    /// </summary>
    private const int TopBit = 1 << 15;

  }

}
