using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.Extensions {
    public static class IntegerUtils {
        public static int ToSafeInteger(this object integerValue) {
			if(integerValue!=null){
				return integerValue.ToString().ToSafeInteger();
			}            
            return 0;
        }

        public static int ToSafeInteger(this string integerValue) {
            if(String.IsNullOrWhiteSpace(integerValue)) {
                return 0;
            }
            int outInt = 0;
            if(int.TryParse(integerValue.Trim(), out outInt)) {
                return outInt;
            }
            return 0;
        }
    }
}
