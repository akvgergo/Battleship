using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {

    public class BattleshipGame {

        public PrimaryBoard Player1;
        public PrimaryBoard Player2;
        public TrackerBoard Player1Tracker;
        public TrackerBoard Player2Tracker;
        public TrackerBoardControl TrackerControl { get; private set; }
        public PrimaryBoardControl PrimaryControl { get; private set; }


        public int Round { get; private set; }

        public BattleshipGame(int seed) {
            Player1 = new PrimaryBoard();
            Player2 = new PrimaryBoard();
            Player1Tracker = new TrackerBoard();
            Player2Tracker = new TrackerBoard();
        }
    }

    public enum Difficulty {
        Easy,
        Medium,
        Hard
    }

}
