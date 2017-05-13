using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Battleship {

    public static class Util {

        //Bit minták
        const ulong pattern1  = 0x5555555555555555; //01010101...
        const ulong pattern2  = 0x3333333333333333; //00110011...
        const ulong pattern4  = 0x0f0f0f0f0f0f0f0f; //00001111...
        const ulong pattern8  = 0x00ff00ff00ff00ff;
        const ulong pattern16 = 0x0000ffff0000ffff;
        const ulong pattern32 = 0x00000000ffffffff;
        const ulong pattern64 = 0xffffffffffffffff;
        const ulong popcnt256 = 0x0101010101010101; //minden byte értéke 1

        /// <summary>
        /// Population Count. Megszámolja a nem 0 értékű biteket. Ez modern processzorokba manapság már beépített utasítás,
        /// de c#-ból kideríteni hogy hívhatjuk-e tovább tartana mintha mi magunk csinálnánk.
        /// </summary>
        public static int Popcnt(ulong x) {
            unchecked {
                x -= (x >> 1) & pattern1;
                x = (x & pattern2) + ((x >> 2) & pattern2);
                x = (x + (x >> 4)) & pattern4;
                return Convert.ToInt32((x * popcnt256) >> 56);
            }
        }
        /// <summary>
        /// Megállapítja hogy a két byte sorozat egyenlő-e
        /// </summary>
        public static bool CompareBytes(byte[] byte1, byte[] byte2) {
            if (byte1.Length != byte2.Length) return false;
            return NativeMethods.memcmp(byte1, byte2, byte2.Length) == 0;
        }

        static class NativeMethods {
            /// <summary>
            /// Assemby-be írt platform-optimális metódus. Ennél sokkal gyorsabb úgyse lesz, úgyhogy ezt egyszerűbb hívni mintha magam
            /// kezdenék el mutatókkal szórakozni
            /// </summary>
            [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern int memcmp(byte[] b1, byte[] b2, long count);

        }   
    }
}
