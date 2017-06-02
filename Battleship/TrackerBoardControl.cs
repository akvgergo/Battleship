using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Battleship.Properties;

namespace Battleship {

    public class TrackerBoardControl : Control {

        TrackerBoard Source;

        #region Properties

        Color _hitColor = Color.Red;
        Color _missColor = Color.Gray;
        Color _unknownColor = Color.LightBlue;
        float _lineWidth = 3;

        public Color HitColor {
            get { return _hitColor; }
            set {
                _hitColor = value;
                Invalidate();
            }
        }

        public Color MissColor {
            get { return _missColor; }
            set {
                _missColor = value;
                Invalidate();
            }
        }

        public Color UnknownColor {
            get { return _unknownColor; }
            set {
                _unknownColor = value;
                Invalidate();
            }
        }

        public float LineWidth {
            get { return _lineWidth; }
            set {
                _lineWidth = value;
                Invalidate();
            }
        }

        #endregion Properties

        public TrackerBoardControl() {
            MouseClick += HandleClick;
            DoubleBuffered = true;
        }

        private void HandleClick(object sender, MouseEventArgs e) {

        }

        public void SetSource(TrackerBoard board) {
            Source = board;
            Source.TileChanged += (o, e) => Invalidate();
            Invalidate();
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

            Pen linePen = new Pen(Enabled ? ForeColor : Color.FromArgb(128, ForeColor), LineWidth);

            if (Source != null) {
                
                float tileSize = Width / 10f;

                var unknown = new SolidBrush(UnknownColor);
                var hit = new SolidBrush(HitColor);
                var miss = new SolidBrush(MissColor);

                for (int x = 0; x < 10; x++) {
                    for (int y = 0; y < 10; y++) {
                        switch (Source[x, y]) {
                            case TrackerTile.Unknown:
                                g.FillRectangle(unknown, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                            case TrackerTile.Miss:
                                g.FillRectangle(miss, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                            case TrackerTile.Hit:
                                g.FillRectangle(hit, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                        }
                    }
                }
            }

            g.DrawRectangle(linePen, LineWidth / 2, LineWidth / 2, Width - LineWidth, Height - LineWidth);

            for (int i = 1; i < 10; i++) {
                float loc = Width / 10f * i - LineWidth / 2;
                g.DrawLine(linePen, loc, 0, loc, Width);
                g.DrawLine(linePen, 0, loc, Width, loc);
            }
        }
    }
}
