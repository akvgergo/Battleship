using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Battleship {

    public class PrimaryBoardControl : Control {

        PrimaryBoard Source;

        #region Properties

        Color _hitColor = Color.Red;
        Color _missColor = Color.Pink;
        Color _shipColor = Color.Gray;
        Color _waterColor = Color.LightBlue;
        float _lineWidth = 3;

        public float LineWidth {
            get { return _lineWidth; }
            set {
                _lineWidth = value;
                Invalidate();
            }
        }

        public Color WaterColor {
            get { return _waterColor; }
            set {
                _waterColor = value;
                Invalidate();
            }
        }

        public Color ShipColor {
            get { return _shipColor; }
            set {
                _shipColor = value;
                Invalidate();
            }
        }

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

        #endregion Properties

        public PrimaryBoardControl() {

        }

        public void SetSource(PrimaryBoard board) {
            Source = board;
            Source.BoardChanged += (o, e) => Invalidate();
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

                var water = new SolidBrush(WaterColor);
                var hit = new SolidBrush(HitColor);
                var miss = new SolidBrush(MissColor);
                var ship = new SolidBrush(ShipColor);

                for (int x = 0; x < 10; x++) {
                    for (int y = 0; y < 10; y++) {
                        switch (Source[x, y]) {
                            case PrimaryTile.Ship:
                                g.FillRectangle(ship, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                            case PrimaryTile.Miss:
                                g.FillRectangle(miss, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                            case PrimaryTile.Hit:
                                g.FillRectangle(hit, tileSize * x, tileSize * y, tileSize, tileSize);
                                break;
                            case PrimaryTile.Water:
                                g.FillRectangle(water, tileSize * x, tileSize * y, tileSize, tileSize);
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
