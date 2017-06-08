using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battleship.Properties;

namespace Battleship {
    public partial class ShipPlacerControl : BoardBase {

        public ShipPlacerControl() {
            InitializeComponent();
            Click += (o, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe) {
            pe.Graphics.Clear(Color.LightBlue);
            base.OnPaint(pe);

            pe.Graphics.DrawImage(Resources.Destroyer, GetBoardArea(2, 2, 3, 2));
            pe.Graphics.DrawImage(Resources.Submarine, GetBoardArea(2, 3, 4, 3));
            pe.Graphics.DrawImage(Resources.Cruiser, GetBoardArea(2, 4, 4, 4));
            pe.Graphics.DrawImage(Resources.Battleship, GetBoardArea(2, 5, 5, 5));
            pe.Graphics.DrawImage(Resources.Carrier, GetBoardArea(2, 6, 6, 6));
        }


    }
}
