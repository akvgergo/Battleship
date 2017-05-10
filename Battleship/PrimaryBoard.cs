using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class PrimaryBoard {
        FriendlyTile[,] tiles = new FriendlyTile[10, 10];
        List<Ship> Ships = new List<Ship>(5);
        public int Lives { get; private set; }

        readonly int[] ClassicShipLengths = { 5, 4, 3, 3, 2 };

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
                if (tiles[C.Y, C.X] == FriendlyTile.Ship) return false;
            }

            foreach (CoordPair C in shipArea) {
                tiles[C.Y, C.X] = FriendlyTile.Ship;
            }

            Ships.Add(ship);

            Lives += ship.Length;

            return true;
        }

        public bool TryHit(CoordPair coord) {
            if (tiles[coord.Y, coord.X] == FriendlyTile.Ship) {
                tiles[coord.Y, coord.X] = FriendlyTile.Hit;
                Lives--;
                return true;
            }
            tiles[coord.Y, coord.X] = FriendlyTile.Miss;
            return false;
        }

        public void DebugPrint() {
            string s = "";

            for (int y = 0; y < 10; y++) {
                for (int x = 0; x < 10; x++) {
                    switch (tiles[y, x]) {
                        case FriendlyTile.Water:
                            s += "W";
                            break;
                        case FriendlyTile.Ship:
                            s += "S";
                            break;
                        case FriendlyTile.Miss:
                            s += "M";
                            break;
                        case FriendlyTile.Hit:
                            s += "H";
                            break;
                    }
                }
                s += "\n";
            }

            Console.WriteLine(s);

            foreach (var item in Ships) {
                Console.WriteLine("{0}, {1}, {2}, {3}", item.Location.X, item.Location.Y, item.Length, item.Horizontal);
            }
        }
    }

    public enum FriendlyTile : byte {
        Water = 0,
        Ship = 1,
        Miss = 2,
        Hit = 3
    }


}
