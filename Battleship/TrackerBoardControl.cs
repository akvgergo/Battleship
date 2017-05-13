using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Battleship {

    public class TrackerBoardControl : Control {

        Graphics sourcegraphics;
        TrackerBoard Source;

        #region Properties

        Color _hitColor = Color.PaleVioletRed;
        Color _missColor = Color.Gray;
        Color _unknownColor = Color.LightBlue;
        float _lineWidth = 2;

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

        public Color UnknownColor {
            get { return _unknownColor; }
            set {
                _unknownColor = value;
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

        #endregion Properties

        public TrackerBoardControl() {
            sourcegraphics = CreateGraphics();
        }

        protected void RePaint() {
            OnPaint(new PaintEventArgs(sourcegraphics, new Rectangle(0, 0, Width, Height)));
        }

        public void SetSource(TrackerBoard board) {
            Source = board;
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
