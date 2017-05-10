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
        public BattleshipControl TrackerControl;
        public BattleshipControl PrimaryControl;

        public int Round { get; private set; }

        public BattleshipGame() {
            Player1 = new PrimaryBoard();
            Player2 = new PrimaryBoard();
            Player1Tracker = new TrackerBoard(Player2);
            Player2Tracker = new TrackerBoard(Player1);
        }

        

    }

    public enum Difficulty {
        Easy,
        Medium,
        Hard
    }

}
