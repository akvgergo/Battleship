using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class PrimaryBoard {
        PrimaryTile[,] tiles = new PrimaryTile[10, 10];
        List<Ship> Ships = new List<Ship>(5);
        public int Lives { get { return Ships.Select(s => s.UndamagedTiles.Count).Sum(); } }
        public int Populated { get; set; }
        readonly int[] ClassicShipLengths = { 5, 4, 3, 3, 2 };

        public PrimaryTile this[CoordPair cp] {
            get { return tiles[cp.Y, cp.X]; }
            set {
                var old = tiles[cp.Y, cp.X];
                tiles[cp.Y, cp.X] = value;
                BoardChanged?.Invoke(this, new BoardChangedEventArgs(cp, old));
            }
        }

        public PrimaryTile this[int x, int y] {
            get { return tiles[y, x]; }
            set {
                var old = tiles[y, x];
                tiles[y, x] = value;
                BoardChanged?.Invoke(this, new BoardChangedEventArgs(new CoordPair(x, y), old));
            }
        }

        public void RandomFill(int seed, Difficulty diff) {
            Random r = new Random(seed);
            CoordSet filled;
            int i = 0;

            switch (diff) {

                case Difficulty.Easy:

                    while (i < 5) {
                        Ship s = Ship.CreateRandom(r, ClassicShipLengths[i]);
                        if (TryAddShip(s)) i++;
                    }
                    break;

                case Difficulty.Medium:

                    filled = new CoordSet();
                    while (i < 5) {
                        Ship s = Ship.CreateRandom(r, ClassicShipLengths[i]);
                        if (filled.Overlaps(s.GetOccupiedArea(0))) continue;

                        filled.Add(s.GetOccupiedArea(1));

                        TryAddShip(s);
                        i++;
                    }
                    break;

                case Difficulty.Hard:

                    filled = new CoordSet();
                    var ineffective = new CoordSet();
                    for (int j = 0; j < 10; j++) {
                        ineffective.Add(new CoordPair(0, j));
                        ineffective.Add(new CoordPair(j, 0));
                        ineffective.Add(new CoordPair(9, j));
                        ineffective.Add(new CoordPair(j, 9));
                    }

                    while (i < 5) {
                        Ship s = Ship.CreateRandom(r, ClassicShipLengths[i]);
                        var shipArea = s.GetOccupiedArea(0);
                        if (filled.Overlaps(shipArea)) continue;
                        shipArea.IntersectWith(ineffective);
                        if (r.NextDouble() < shipArea.Count * 0.3) continue;

                        filled.Add(s.GetOccupiedArea(1));

                        TryAddShip(s);
                        i++;
                    }

                    break;
            }
        }

        public bool TryAddShip(Ship ship) {
            var shipArea = ship.GetOccupiedArea(0).GetAllCoords();

            foreach (CoordPair C in shipArea) {
                if (tiles[C.Y, C.X] == PrimaryTile.Ship) return false;
            }

            foreach (CoordPair C in shipArea) {
                tiles[C.Y, C.X] = PrimaryTile.Ship;
            }

            Ships.Add(ship);

            return true;
        }

        public bool TryHit(CoordPair coord) {
            if (this[coord] == PrimaryTile.Ship) {
                this[coord] = PrimaryTile.Hit;
                return true;
            }
            this[coord] = PrimaryTile.Miss;
            return false;
        }

        public event EventHandler<BoardChangedEventArgs> BoardChanged;

        public class BoardChangedEventArgs : EventArgs {
            public CoordPair Location { get; }
            public PrimaryTile OldTile { get; }

            public BoardChangedEventArgs(CoordPair loc, PrimaryTile oldTile) {
                Location = loc;
                OldTile = oldTile;
            }
        }
    }

    public enum PrimaryTile : byte {
        Water = 0,
        Ship = 1,
        Miss = 2,
        Hit = 3
    }
}
