using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    class AIMemory {
        public CoordSet PossibleShipLocs;
        public List<int> ShipsRemaining = new List<int> { 5, 4, 3, 3, 2 };
        public CoordSet RandomHitCandidates;
        public CoordSet AllMoves = new CoordSet();

        public Random rnd;
        public bool FoundShip;

        public AIMemory() {
            GenRNGHitCandids();
        }

        public void GenRNGHitCandids() {
            CoordSet cs = new CoordSet();

            switch (ShipsRemaining.Min()) {
                case 2:
                    for (int i = 0; i < 100; i += 2) {
                        cs.Add(new CoordPair(i));
                    }
                    break;
                case 3:
                    for (int i = 0; i < 10; i++) {
                        for (int j = 0; j < 10; j++) {
                            cs.Add(new CoordPair(9 - i, j));
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < 4; i++) {
                        cs.Add(new CoordPair(i, i + 6));
                        cs.Add(new CoordPair(i + 6, i));
                    }
                    for (int i = 0; i < 8; i++) {
                        cs.Add(new CoordPair(i, i + 2));
                        cs.Add(new CoordPair(i + 2, i));
                    }
                    break;
                case 5:
                    for (int i = 0; i < 10; i++) {
                        cs.Add(new CoordPair(i, i));
                    }
                    for (int i = 0; i < 5; i++) {
                        cs.Add(new CoordPair(i, i + 5));
                        cs.Add(new CoordPair(i + 5, i));
                    }
                    break;
            }

            cs.ExceptWith(AllMoves);
            RandomHitCandidates = cs;
        }

        public void GetPossibleShipLocs(CoordPair cp) {

        }

        public CoordPair getRandomMove() {
            var all = RandomHitCandidates.GetAllCoords();
            return all[rnd.Next(all.Length)];
        }
    }
}
