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
            set {
                var old = tiles[C.Y, C.X];
                tiles[C.Y, C.X] = value;
                BoardChanged?.Invoke(this, new BoardChangedEventArgs(C, old));
            }
        }

        public TrackerTile this[int x, int y] {
            get { return tiles[y, x]; }
            set {
                var old = tiles[y, x];
                tiles[y, x] = value;
                BoardChanged?.Invoke(this, new BoardChangedEventArgs(new CoordPair(x, y), old));
            }
        }

        public void DisplaySet(CoordSet cs) {
            tiles = new TrackerTile[10, 10];
            foreach (var item in cs.GetAllCoords()) {
                this[item] = TrackerTile.Hit;
            }
        }

        public event EventHandler<BoardChangedEventArgs> BoardChanged;

        public class BoardChangedEventArgs : EventArgs {
            public CoordPair Location { get; }
            public TrackerTile OldTile { get; }

            public BoardChangedEventArgs(CoordPair loc, TrackerTile oldTile) {
                Location = loc;
                OldTile = oldTile;
            }
        }
    }

    public enum TrackerTile : byte {
        Unknown = 0,
        Miss = 1,
        Hit = 2
    }

}
