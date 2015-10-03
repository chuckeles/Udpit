using System;

namespace Udpit {

  /// <summary>
  ///   Contains byte manipulation utilities.
  /// </summary>
  internal static class ByteUtility {

    /// <summary>
    ///   Converts string to byte array.
    /// </summary>
    /// <source>http://stackoverflow.com/a/10380166</source>
    public static byte[] GetBytes(string str) {
      var bytes = new byte[str.Length * sizeof (char)];
      Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
      return bytes;
    }

    /// <summary>
    ///   Converts byte array to string.
    /// </summary>
    /// <source>http://stackoverflow.com/a/10380166</source>
    public static string GetString(byte[] bytes) {
      var chars = new char[bytes.Length / sizeof (char)];
      Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
      return new string(chars);
    }

  }

}
