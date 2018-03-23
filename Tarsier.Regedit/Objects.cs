using Newtonsoft.Json;
using System;
namespace Tarsier.Regedit
{
    public static class Objects {
        public static string SerializeT<T>(this T objToSerialize) {
            return JsonConvert.SerializeObject(objToSerialize);
        }

        public static T DeserializeT<T>(this string toDeserialize) {
            if(String.IsNullOrEmpty(toDeserialize)) {
                return default(T); ;
            }
            return (T)JsonConvert.DeserializeObject<T>(toDeserialize);
        }
    }
}