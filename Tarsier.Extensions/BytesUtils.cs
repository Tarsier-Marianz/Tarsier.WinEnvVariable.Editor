using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.Extensions {
   public static class BytesUtils {
        public static string ToByteSize(this long bytes) {
            string[] units = new string[] { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            int index = 0;
            do {
                bytes /= 1024;
                index++;
            }
            while(bytes >= 1024);
            return string.Format("{0:0.##} {1}", bytes, units[index]);
        }

        // Return a string describing the value as a file size.
        // For example, 1.23 MB.
        public static string ToFileSize(this long value) {
            string[] suffixes = { "bytes", "KB", "MB", "GB","TB", "PB", "EB", "ZB", "YB"};
            for(int i = 0; i < suffixes.Length; i++) {
                if(value <= (Math.Pow(1024, i + 1))) {
                    return ThreeNonZeroDigits(value /Math.Pow(1024, i)) +" " + suffixes[i];
                }
            }

            return ThreeNonZeroDigits(value /
                Math.Pow(1024, suffixes.Length - 1)) +" " + suffixes[suffixes.Length - 1];
        }

        // Return the value formatted to include at most three
        // non-zero digits and at most two digits after the
        // decimal point. Examples:
        //         1
        //       123
        //        12.3
        //         1.23
        //         0.12
        private static string ThreeNonZeroDigits(double value) {
            if(value >= 100) {
                // No digits after the decimal.
                return value.ToString("0,0");
            } else if(value >= 10) {
                // One digit after the decimal.
                return value.ToString("0.0");
            } else {
                // Two digits after the decimal.
                return value.ToString("0.00");
            }
        }
    }
}
