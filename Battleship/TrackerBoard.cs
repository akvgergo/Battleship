using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship {


    public class TrackerBoard {
        EnemyTile[,] tiles = new EnemyTile[10, 10];
        public PrimaryBoard Enemy { get; }

        public TrackerBoard(PrimaryBoard enemy) {
            Enemy = enemy;
        }

        public EnemyTile this[CoordPair C] {
            get { return tiles[C.Y, C.X]; }
        }



    }

    public enum EnemyTile : byte {
        Unknown = 0,
        Miss = 1,
        Hit = 2
    }

}
