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

        AIMemory mem = new AIMemory();

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
            tracker.SetSource(PlayerTracker);
            primary.SetSource(Player);
            ControlsBound = true;
        }

        public void PlayerMove(CoordPair cp) {
            if (AI.TryHit(cp)) {
                PlayerTracker[cp] = TrackerTile.Hit;
            } else {
                PlayerTracker[cp] = TrackerTile.Miss;
            }
        }

        public void AIMove() {
            switch (Difficulty) {

                case Difficulty.Easy:
                    if (!mem.FoundShip) {
                        var move = mem.getRandomMove();
                        mem.RandomHitCandidates.Remove(move);
                        mem.AllMoves.Add(move);
                        if (Player.TryHit(move)) {
                            mem.FoundShip = true;
                            
                        }

                    }
                    break;
                case Difficulty.Medium:
                    break;
                case Difficulty.Hard:
                    break;
            }
        }

        public event EventHandler<MoveEventArgs> MoveFinished;

        public class MoveEventArgs : EventArgs {
            public int Round { get; set; }
            public bool PlayerMove { get; set; }
            public bool Hit { get; set; }
            public CoordPair Location { get; set; }
        }
    }

    public enum Difficulty {
        Easy,
        Medium,
        Hard
    }

}
