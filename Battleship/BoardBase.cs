using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Battleship {

    public class BoardBase : Control {

        float _lineWidth = 3;
        public float LineWidth {
            get { return _lineWidth; }
            set {
                _lineWidth = value;
                Invalidate();
            }
        }

        public BoardBase() {
            DoubleBuffered = true;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if (Height != Width) {
                Height = Width;
            }
        }

        public RectangleF GetTileArea(CoordPair cp) {
            return GetTileArea(cp.X, cp.Y);
        }

        public RectangleF GetTileArea(int x, int y) {
            float tileWidth = (Width - 11 * LineWidth) / 10;
            return new RectangleF(LineWidth + (LineWidth + tileWidth) * x, LineWidth + (LineWidth + tileWidth) * y, tileWidth, tileWidth);
        }

        public RectangleF GetBoardArea(CoordPair loc1, CoordPair loc2) {
            return GetBoardArea(loc1.X, loc1.Y, loc2.X, loc2.Y);
        }

        public RectangleF GetBoardArea(int loc1X, int loc1Y, int loc2X, int loc2Y) {
            CoordPair TL, BR;
            if (loc1X < loc2X) {
                if (loc1Y < loc2Y) {
                    TL = new CoordPair(loc1X, loc1Y);
                    BR = new CoordPair(loc2X, loc2Y);
                } else {
                    TL = new CoordPair(loc1X, loc2Y);
                    BR = new CoordPair(loc2X, loc1Y);
                }
            } else {
                if (loc1Y < loc2Y) {
                    TL = new CoordPair(loc2X, loc1Y);
                    BR = new CoordPair(loc1X, loc2Y);
                } else {
                    TL = new CoordPair(loc2X, loc2Y);
                    BR = new CoordPair(loc1X, loc1Y);
                }
            }

            float tileWidth = (Width - 11 * LineWidth) / 10;

            return new RectangleF(LineWidth + (LineWidth + tileWidth) * TL.X, LineWidth + (LineWidth + tileWidth) * TL.Y, tileWidth + (tileWidth + LineWidth) * (BR.X - TL.X), tileWidth + (tileWidth + LineWidth) * (BR.Y - TL.Y));
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var g = e.Graphics;
            var linePen = new Pen(ForeColor, LineWidth);
            var drawArea = new RectangleF(LineWidth / 2, LineWidth / 2, Width - LineWidth, Height - LineWidth);

            for (int i = 0; i <= 10; i++) {
                float loc = drawArea.Location.X + drawArea.Width / 10 * i;
                g.DrawLine(linePen, loc, 0, loc, Width);
                g.DrawLine(linePen, 0, loc, Width, loc);
            }
        }
    }
}
