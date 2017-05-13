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
            Bitmap bm = new Bitmap(100, 100);
            for (int i = 0; i < 100; i++) {
                bm.SetPixel(5, i, Color.Red);
            }

        }
    }
}
