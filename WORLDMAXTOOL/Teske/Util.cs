using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WORLDMAXTOOL
{
    class Util
    {
        public ReviewAreaStruct reviewArea;
        public StateAreaStruct stateArea;

        [StructLayout(LayoutKind.Sequential, Size = 324), Serializable]
        public struct ReviewAreaStruct
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] playerid;             //  player name
            public int mileage;                 //  Mileage
            public float reward;                //  (value * 100) / 65 = Reward %
            public float worldmax;              //  (value * 100) / 634 = Worldmax %
            public int playcount;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] currentland;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] currentmission;
            public int kcal;
            public int vo2;
            public short year;
            public byte month;
            public byte day;
            public byte hour;
            public byte min;
            public short seconds;               // Value / 1000
            public int steps;
            public float playtime;              //  minutes
            public float totalcomplete;         //  %
            public float arcadecomplete;        //  %
            public float brainshowercomplete;   //  %
            public float specialcomplete;       //  %
        }

        [StructLayout(LayoutKind.Sequential, Size = 16), Serializable]
        public struct WorldMaxScoreTableStruct
        {
            public int score;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] playerid;             //  player name
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] empty;             //  player name
        }

        [StructLayout(LayoutKind.Sequential, Size = 90544), Serializable]
        public struct StateAreaStruct
        {
            public uint crc;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] usbserial;
            public short year;  //2
            public byte month;  //3
            public byte day;    //4
            public byte hour;   //5
            public byte min;    //6
            public short seconds;//8               // Value / 1000
            public int avatarid;    //12
            public int rank;    //16
            public int countryid;   //20
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] playerid;             //  player name
            public int mileage;                 //  Mileage
            public int playcount;
            public int kcal;
            public int vo2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] worldmaxmappos;
            public float reward;                //  (value * 100) / 65 = Reward %
            public float worldmax;              //  (value * 100) / 634 = Worldmax %
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9628)]
            public byte[] unusedspace1;           //  Size 9631 bytes
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] currentland;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] currentmission;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1280)]
            public WorldMaxScoreTableStruct[] worldmaxscoretable;
            public int dongleid;
            public int unlocksignal;
            public int steps;
            public float playtime;              //  minutes
            public float totalcomplete;         //  %
            public float arcadecomplete;        //  %
            public float brainshowercomplete;   //  %
            public float specialcomplete;       //  %
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4096)]
            public byte[] unusedspace2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 576)]
            public byte[] songlocks;            //  0x40 Unlock the song
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50780)]
            public byte[] unusedspace3;
        }

        public void LoadFromBuffer(byte[] data)
        {
            byte[] buff = new byte[Marshal.SizeOf(typeof(ReviewAreaStruct))];
            int amt = 0;
            while (amt < buff.Length)
            {
                buff[amt] = data[amt];
                amt++;
            }
            GCHandle handle = GCHandle.Alloc(buff, GCHandleType.Pinned);
            reviewArea = (ReviewAreaStruct)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(ReviewAreaStruct));
            handle.Free();
            //buff = new byte[Marshal.SizeOf(typeof(StateAreaStruct)];

            buff = data.SubArray(0x144, Marshal.SizeOf(typeof(StateAreaStruct)));
            Tools.Decode(buff);

            handle = GCHandle.Alloc(buff, GCHandleType.Pinned);
            stateArea = (StateAreaStruct)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(StateAreaStruct));
            handle.Free();
        }
    }
}
