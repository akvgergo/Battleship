using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Battleship {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            PrimaryBoard pb = new PrimaryBoard();
            pb.RandomFill(3, Difficulty.Hard);
            primaryBoardControl1.SetSource(pb);

            TrackerBoard tb = new TrackerBoard();
            trackerBoardControl1.SetSource(tb);

            //for (int i = 0; i < 4; i++) {
            //    tb[new CoordPair(i, 3 - i)] = TrackerTile.Hit;
            //    tb[new CoordPair(i + 6, 9 - i)] = TrackerTile.Hit;
            //}
            //for (int i = 0; i < 8; i++) {
            //    tb[new CoordPair(i, 7 - i)] = TrackerTile.Hit;
            //    tb[new CoordPair(i + 2, 9 - i)] = TrackerTile.Hit;
            //}
            for (int i = 0; i < 10; i++) {
                tb[new CoordPair(i, i)] = TrackerTile.Hit;
            }
            for (int i = 0; i < 5; i++) {
                tb[new CoordPair(5 + i, i)] = TrackerTile.Hit;
                tb[new CoordPair(i, 5 + i)] = TrackerTile.Hit;
            }

        }
    }
}
