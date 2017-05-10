using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace Battleship {
    partial class BattleshipControl {

        Color _shipColor = Color.LightBlue;
        Color _hitColor = Color.Pink;
        Color _missColor = Color.Red;
        float _lineWidth = 2;

        Graphics _graphics;

        #region Properties

        public Color ShipColor {
            get { return _shipColor; }
            set {
                _shipColor = value;
                RePaint();
            }
        }

        public Color HitColor {
            get { return _hitColor; }
            set {
                _hitColor = value;
                RePaint();
            }
        }

        public Color MissColor {
            get { return _missColor; }
            set {
                _missColor = value;
                RePaint();
            }
        }

        public float LineWidth {
            get { return _lineWidth; }
            set {
                _lineWidth = value;
                RePaint();
            }
        }

        #endregion properties

        protected void RePaint() {
            OnPaint(new PaintEventArgs(_graphics, new Rectangle(0, 0, Width, Height)));
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var g = e.Graphics;

            Pen linePen = new Pen(ForeColor, LineWidth);
            g.DrawRectangle(linePen, LineWidth / 2, LineWidth / 2, Width - LineWidth, Height - LineWidth);

            for (int i = 1; i < 10; i++) {
                float loc = Width / 10f * i - LineWidth / 2;
                g.DrawLine(linePen, loc, 0, loc, Width);
                g.DrawLine(linePen, 0, loc, Width, loc);
            }

            if (TrackingMode) {
                for (int y = 0; y < 10; y++) {
                    for (int x = 0; x < 10; x++) {

                    }
                }
            }
        }
    }
}
