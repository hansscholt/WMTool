using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLDMAXTOOL
{
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
        public static byte[] ToUTF8ByteArray(this String str, int length)
        {
            byte[] arr = new byte[length];
            byte[] strArrEncoding = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(str));

            for (int i = 0; i < length; i++)
            {
                arr[i] = i < strArrEncoding.Length ? strArrEncoding[i] : (byte)0x00;
            }

            return arr;
        }

        public static byte[] ToUTF8ByteArray(this String str)
        {
            return Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(str));
        }

        public static string ToStringFromUTF8(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes).Split('\0')[0];
        }
        public static UInt32 ReverseBytes(this UInt32 value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                   (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }
    }
}
