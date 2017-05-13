using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class TrackerBoard {
        TrackerTile[,] tiles = new TrackerTile[10, 10];

        public TrackerTile this[CoordPair C] {
            get { return tiles[C.Y, C.X]; }
        }



    }

    public enum TrackerTile : byte {
        Unknown = 0,
        Miss = 1,
        Hit = 2
    }

}
