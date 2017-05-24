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

        Timer t = new Timer();
        PrimaryBoard pb = new PrimaryBoard();
        int count = 0;

        public Form1() {
            InitializeComponent();
            t.Interval = 1500;
            t.Tick += T_Tick;
            t.Start();
            pb.RandomFill(count++, Difficulty.Hard);
            primaryBoardControl1.SetSource(pb);

            TrackerBoard tb = new TrackerBoard();
            trackerBoardControl1.SetSource(tb);

            CoordSet cs = new CoordSet();
            cs.GetEnumerator();

            //for (int i = 0; i < 100; i += 3) {
            //    tb[9 - i % 10, i / 10] = TrackerTile.Hit;
            //}


            //for (int i = 0; i < 4; i++) {
            //    tb[new CoordPair(6 + i, i)] = TrackerTile.Hit;
            //    tb[new CoordPair(i, i + 6)] = TrackerTile.Hit;
            //}
            //for (int i = 0; i < 8; i++) {
            //    tb[new CoordPair(i + 2, i)] = TrackerTile.Hit;
            //    tb[new CoordPair(i, i + 2)] = TrackerTile.Hit;
            //}



            //for (int i = 0; i < 10; i++) {
            //    tb[new CoordPair(i, i)] = TrackerTile.Hit;
            //}
            //for (int i = 0; i < 5; i++) {
            //    tb[new CoordPair(5 + i, i)] = TrackerTile.Hit;
            //    tb[new CoordPair(i, 5 + i)] = TrackerTile.Hit;
            //}

        }

        private void T_Tick(object sender, EventArgs e) {
            pb.RandomFill(count++, Difficulty.Hard);
        }
    }
}
