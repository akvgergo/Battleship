using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class BattleshipGame {

        public PrimaryBoard Player;
        public PrimaryBoard AI;
        public TrackerBoard PlayerTracker;
        public TrackerBoard AITracker;
        public TrackerBoardControl TrackerControl { get; private set; }
        public PrimaryBoardControl PrimaryControl { get; private set; }

        public bool ControlsBound;
        public int Seed;

        AIMemory memory = new AIMemory();

        public Difficulty Difficulty { get; private set; }
        public int Round { get; private set; }

        public BattleshipGame(int seed, Difficulty diff) {
            Player = new PrimaryBoard();
            AI = new PrimaryBoard();
            PlayerTracker = new TrackerBoard();
            AITracker = new TrackerBoard();
            Difficulty = diff;
            Seed = seed;
        }

        public void BindControls(TrackerBoardControl tracker, PrimaryBoardControl primary) {
            PrimaryControl = primary;
            TrackerControl = tracker;
            ControlsBound = true;
        }

        public void PlayerHit(CoordPair cp) {
            if (AI.TryHit(cp)) {
                PlayerTracker[cp] = TrackerTile.Hit;
            } else {
                PlayerTracker[cp] = TrackerTile.Miss;
            }
        }

        public void AIHit() {
            switch (Difficulty) {

                case Difficulty.Easy:
                    if (!memory.FoundShip){

                    }
                    break;
                case Difficulty.Medium:
                    break;
                case Difficulty.Hard:
                    break;
            }
        }

        //Próbálom rendszerezni a dolgokat ebben az istenverte osztályban
        class AIMemory {
            public CoordSet PossibleShipLocs;
            public List<int> ShipsRemaining = new List<int> { 5, 4, 3, 3, 2 };
            public CoordSet RandomHitCandidates;

            public Random rnd;
            public bool FoundShip;

            public void GenerateRNGHitCandids() {
                int smallestShipUnsunk = ShipsRemaining.Min();
                CoordSet cs = new CoordSet();

                switch (smallestShipUnsunk) {
                    case 2:
                        for (int i = 0; i < 100; i += 2) {
                            cs.Add(new CoordPair(i));
                        }
                        break;
                    case 3:

                        break;
                    
                }
            }
        }
    }

    public enum Difficulty {
        Easy,
        Medium,
        Hard
    }

}
