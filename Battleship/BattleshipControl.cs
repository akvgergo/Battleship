using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace Battleship {
    public partial class BattleshipControl : Control {

        public BattleshipGame Game;
        public bool TrackingMode { get; set; }
        public BattleshipControl Friend;

        public BattleshipControl() {
            Game = new BattleshipGame();
            _graphics = CreateGraphics();
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if (Height != Width) {
                Height = Width;
            }
        }
    }
}
