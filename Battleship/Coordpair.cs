using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    /// <summary>
    /// Egy koordináta. Az index arra szolgál hogy majd hashtable-höz hasonlóan tudjak tárolni egy teljes játékmezőt egy bit sorozatban.
    /// </summary>
    public struct CoordPair {
        public int X { get; }
        public int Y { get; }
        public int Index { get; }

        public CoordPair(int x, int y) {
            if (!IsValidCoords(x, y)) throw new ArgumentException("invalid coordinates");
            X = x;
            Y = y;
            Index = X + Y * 10;
        }

        public CoordPair(int index) {
            X = index % 10;
            Y = index / 10;
            Index = index;
            if (!IsValidCoords(X, Y)) throw new ArgumentException("invalid coordinates");

        }

        public static bool IsValidCoords(int x, int y) {
            return !(x > 9 || x < 0 || y > 9 || y < 0);
        }

        public static bool IsValidCoords(int x, int y, out CoordPair s) {
            if (IsValidCoords(x, y)) {
                s = new CoordPair(x, y);
                return true;
            }
            s = new CoordPair(0, 0);
            return false;
        }

        public override string ToString() {
            return string.Format("({0}, {1})", X, Y);
        }
    }


}
