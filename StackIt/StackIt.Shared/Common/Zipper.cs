using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace StackIt.Common {
    public static class Zipper {
        public static String Zip(String content) {
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            using (var output = new MemoryStream()) {
                using (var zipstream = new GZipStream(output, CompressionMode.Compress)) {
                    input.CopyTo(zipstream);
                }
                return Encoding.UTF8.GetString(output.ToArray(), 0, (int)output.Length);
            }
        }
        public static String Unzip(String content) {
            using (var input = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            using (var output = new MemoryStream()) {
                using (var zipstream = new GZipStream(input, CompressionMode.Decompress)) {
                    zipstream.CopyTo(output);
                }
                return Encoding.UTF8.GetString(output.ToArray(), 0, (int)output.Length);
            }
        }
    }
}
