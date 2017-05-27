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
        public bool Populated { get; set; }
        readonly int[] ClassicShipLengths = { 5, 4, 3, 3, 2 };

        public PrimaryTile this[CoordPair cp] {
            get { return tiles[cp.Y, cp.X]; }
            set {
                var old = tiles[cp.Y, cp.X];
                tiles[cp.Y, cp.X] = value;
                TileChanged?.Invoke(this, new TileChangedEventArgs(cp, old));
            }
        }

        public PrimaryTile this[int x, int y] {
            get { return tiles[y, x]; }
            set {
                var old = tiles[y, x];
                tiles[y, x] = value;
                TileChanged?.Invoke(this, new TileChangedEventArgs(new CoordPair(x, y), old));
            }
        }

        public PrimaryBoard() {
            TileChanged += (o, e) => BoardChanged?.Invoke(this, new EventArgs());
            
        }

        public void RandomFill(int seed, Difficulty diff) {
            if (Populated) tiles = new PrimaryTile[10, 10];
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
                    var border = new CoordSet();

                    for (int j = 0; j < 10; j++) {
                        border.Add(new CoordPair(0, j));
                        border.Add(new CoordPair(j, 0));
                        border.Add(new CoordPair(9, j));
                        border.Add(new CoordPair(j, 9));
                    }

                    while (i < 5) {
                        Ship s = Ship.CreateRandom(r, ClassicShipLengths[i]);
                        var shipArea = s.GetOccupiedArea(0);

                        if (shipArea.Overlaps(filled)) continue;

                        var weakArea = new CoordSet(border);
                        weakArea.IntersectWith(shipArea);
                        if (r.NextDouble() < weakArea.Count * 0.4) continue;

                        border.Add(s.GetOccupiedArea(1));
                        filled.Add(shipArea);

                        TryAddShip(s);
                        i++;
                    }
                    break;
            }
            Populated = true;
            BoardChanged?.Invoke(this, new EventArgs());
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

        public event EventHandler<TileChangedEventArgs> TileChanged;
        public event EventHandler BoardChanged;

        public class TileChangedEventArgs : EventArgs {
            public CoordPair Location { get; }
            public PrimaryTile OldTile { get; }

            public TileChangedEventArgs(CoordPair loc, PrimaryTile oldTile) {
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
