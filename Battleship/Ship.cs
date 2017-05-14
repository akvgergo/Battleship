using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class Ship {
        public int Length { get; }
        public bool Horizontal { get; }
        public bool Sank { get { return UndamagedTiles.Count == 0; } }
        public CoordPair Location { get; }
        public CoordSet UndamagedTiles { get; }
        public CoordSet DamagedTiles { get; }


        public Ship(CoordPair loc, int length, bool horizontal) {
            if (length > 5 || length < 2) throw new ArgumentException("Invalid Length");
            if (horizontal) {
                if (length + loc.X - 1 > 9) throw new ArgumentException("Invalid Coordinates");
            } else {
                if (length + loc.Y - 1 > 9) throw new ArgumentException("Invalid Coordinates");
            }
            Location = loc;
            Length = length;
            Horizontal = horizontal;
            UndamagedTiles = GetOccupiedArea(0);
            DamagedTiles = new CoordSet();
        }

        public CoordSet GetOccupiedArea(int range) {
            CoordSet cs = new CoordSet();
            int firstX = Location.X - range;
            int firstY = Location.Y - range;
            int lastX = Location.X + range + (Horizontal ? Length -1 : 0);
            int lastY = Location.Y + range + (Horizontal ? 0 : Length - 1);

            for (int x = firstX; x <= lastX; x++) {
                for (int y = firstY; y <= lastY; y++) {
                    if (CoordPair.IsValidCoords(x, y)) cs.Add(new CoordPair(x, y));
                }
            }

            return cs;
        }

        public static Ship CreateRandom(Random rnd, int length) {
            bool horizontal = rnd.NextDouble() < 0.5;
            CoordPair loc;

            if (horizontal) {
                loc = new CoordPair(rnd.Next(11 - length), rnd.Next(10));
            } else {
                loc = new CoordPair(rnd.Next(10), rnd.Next(11 - length));
            }

            return new Ship(loc, length, horizontal);
        }

        public override string ToString() {
            return string.Format("{0}, {1}, {2}", Location.ToString(), Length, Horizontal);
        }

        public bool Hit(CoordPair cp) {
            if (UndamagedTiles.Remove(cp)) {
                DamagedTiles.Add(cp);
                return true;
            }
            return false;
        }
    }
}
