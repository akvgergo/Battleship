using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Battleship {

    public class PrimaryBoardControl : BoardBase {

        PrimaryBoard Source;

        #region Properties

        Color _hitColor = Color.Red;
        Color _missColor = Color.Pink;
        Color _shipColor = Color.Gray;
        Color _waterColor = Color.LightBlue;

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

        public PrimaryBoardControl() { }

        public void SetSource(PrimaryBoard board) {
            Source = board;
            Source.TileChanged += (o, e) => Invalidate();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            var g = e.Graphics;

            if (Source != null) {
                float tileSize = Width / 10f;

                var water = new SolidBrush(Enabled ? WaterColor : WaterColor.HalveHue());
                var hit = new SolidBrush(Enabled ? HitColor : HitColor.HalveHue());
                var miss = new SolidBrush(Enabled ? MissColor : MissColor.HalveHue());
                var ship = new SolidBrush(Enabled ? ShipColor : ShipColor.HalveHue());

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
            base.OnPaint(e);
        }
    }
}
