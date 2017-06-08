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
        const ulong pattern1 = 0x5555555555555555; //01010101...
        const ulong pattern2 = 0x3333333333333333; //00110011...
        const ulong pattern4 = 0x0f0f0f0f0f0f0f0f; //00001111...
        const ulong pattern8 = 0x00ff00ff00ff00ff;
        const ulong pattern16 = 0x0000ffff0000ffff;
        const ulong pattern32 = 0x00000000ffffffff;
        const ulong pattern64 = 0xffffffffffffffff;
        const ulong popcnt256 = 0x0101010101010101; //minden byte értéke 1

        /// <summary>
        /// Population Count. Megszámolja a nem 0 értékű biteket.
        /// </summary>
        public static int Popcnt(ulong x) {
            //Ez modern processzorokba manapság már beépített utasítás, de c#-ból kideríteni hogy hívhatjuk-e 
            //tovább tartana mintha mi magunk csinálnánk. Az alap algoritmust ami egyre növekvő bit eltolásokkal és összeadással rendezi a legelső
            //bájtba a biteket egy szorzással optimizálhatjuk. Ez a valaha ismert legkevesebb operációt igénylő megoldás ha nem számítjuk a
            //{ while (x & x - 1 > 0) count++; }-t használó megoldást, ami néhány esetben gyorsabb. Mivel ez a C standard, ezért ezt használjuk.
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

        /// <summary>
        /// Megadja a megadott szín olvasható ARGB értékét
        /// </summary>
        public static string ToArgbString(this Color color) {
            return string.Format("{0}, {1}, {2}, {3}", color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// Megfelezi a megadott szín mélységét
        /// </summary>
        public static Color HalveHue(this Color color) {
            //Saját találmány. Gyakorlatilag Color.FromArgb(255 - (255 - color.A) / 2, 255 - (255 - color.R) / 2, 255 - (255 - color.G) / 2, 255 - (255 - color.B) / 2),
            //csak bitműveletekkel optimizálva.

            //And-el eltávolítja a felesleges biteket az eltoláshoz
            const int bitmask = unchecked((int)0xFEFEFEFE);
            //A zárójelek szükségesek mivel c#-ban a bitműveletek sorrendjét érmefeldobással döntötték el...
            //Invertálunk, maszkolunk, bit eltolással osztunk kettővel, majd újra invertálunk.
            return Color.FromArgb(~((~color.ToArgb() & bitmask) >> 1));
        }

        static class NativeMethods {
            /// <summary>
            /// Assemby-be írt beépített metódus. Ennél sokkal gyorsabb úgyse lesz, úgyhogy ezt egyszerűbb hívni mintha magam
            /// kezdenék el mutatókkal szórakozni
            /// </summary>
            [DllImport("msvcrt.dll")]
            public static extern int memcmp(byte[] b1, byte[] b2, long count);
        }
    }
}
