using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLDMAXTOOL
{
    class Tools
    {
        public static void Encode(byte[] data)
        {
            for (int a = 1; a < data.Length; a++)
            {
                data[a] = (byte)((data[a] - ((a * 1234567) >> 8)) ^ data[a - 1]);
            }
        }

        /// <summary>
        /// Inplace Decode function from NX2 / NXA
        /// </summary>
        /// <param name="data">Decoded data to encode</param>
        public static void Decode(byte[] data)
        {
            for (int a = data.Length - 1; a > 0; a--)
            {
                data[a] = (byte)((data[a] ^ data[a - 1]) + ((a * 1234567) >> 8));
            }
        }
        /// <summary>
        /// Combines "a1", "a2", "a3" byte arrays into a single byte array.
        /// </summary>
        /// <param name="a1">First byte array</param>
        /// <param name="a2">Second byte array</param>
        /// <param name="a3">Third byte array</param>
        /// <returns>a1 + a2 + a3</returns>
        public static byte[] Combine(byte[] a1, byte[] a2, byte[] a3)
        {
            byte[] ret = new byte[a1.Length + a2.Length + a3.Length];
            Array.Copy(a1, 0, ret, 0, a1.Length);
            Array.Copy(a2, 0, ret, a1.Length, a2.Length);
            Array.Copy(a3, 0, ret, a1.Length + a2.Length, a3.Length);
            return ret;
        }

        /// <summary>
        /// Calculates a Adler32 for a byte array in the specified range.
        /// </summary>
        /// <param name="data">The data to calculate adler</param>
        /// <param name="len">How many bytes to use</param>
        /// <param name="startValue">Adler Start Value</param>
        /// <returns></returns>
        public static uint adler32(byte[] data, int len, uint startValue)
        {
            return adler32(data, 0, len, startValue);
        }

        /// <summary>
        /// Calculates a Adler32 for a byte array in the specified range.
        /// </summary>
        /// <param name="data">The data to calculate adler</param>
        /// <param name="start">The starting byte</param>
        /// <param name="len">How many bytes to use</param>
        /// <param name="startValue">Adler Start Value</param>
        /// <returns></returns>
        public static uint adler32(byte[] data, uint start, int len, uint startValue)
        {
            uint s1 = startValue & 0xffff;
            uint s2 = (startValue >> 16) & 0xffff;

            for (uint n = start; n < start + len; n++)
            {
                s1 = (s1 + data[n]) % 65521;
                s2 = (s2 + s1) % 65521;
            }

            return (s2 << 16) + s1;
        }
    }
}
