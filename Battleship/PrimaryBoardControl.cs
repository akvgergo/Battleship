using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Battleship {

    public class PrimaryBoardControl : Control {

        Graphics sourcegraphics;
        PrimaryBoard Source;

        #region Properties

        Color _hitColor = Color.Red;
        Color _missColor = Color.Pink;
        Color _shipColor = Color.Gray;
        Color _waterColor = Color.LightBlue;
        float _lineWidth = 2;

        public float LineWidth {
            get { return _lineWidth; }
            set {
                _lineWidth = value;
                RePaint();
            }
        }

        public Color WaterColor {
            get { return _waterColor; }
            set {
                _waterColor = value;
                RePaint();
            }
        }

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

        #endregion Properties

        public PrimaryBoardControl() {
            sourcegraphics = CreateGraphics();
        }

        public void SetSource(PrimaryBoard board) {
            Source = board;
        }

        protected void RePaint() {
            OnPaint(new PaintEventArgs(sourcegraphics, new Rectangle(0, 0, Width, Height)));
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if (Height != Width) {
                Height = Width;
            }
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

            if (Source == null) return;


        }


    }
}
