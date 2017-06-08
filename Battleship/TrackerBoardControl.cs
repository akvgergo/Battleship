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

    public class TrackerBoardControl : BoardBase {

        TrackerBoard Source;

        #region Properties

        Color _hitColor = Color.Red;
        Color _missColor = Color.Gray;
        Color _unknownColor = Color.LightBlue;

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

        #endregion Properties

        public TrackerBoardControl() {
            MouseClick += HandleClick;
        }

        private void HandleClick(object sender, MouseEventArgs e) {

        }

        public void SetSource(TrackerBoard board) {
            Source = board;
            Source.TileChanged += (o, e) => Invalidate();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            var g = e.Graphics;

            if (Source != null) {
                
                float tileSize = Width / 10f;

                var unknown = new SolidBrush(Enabled ? UnknownColor : UnknownColor.HalveHue());
                var hit = new SolidBrush(Enabled ? HitColor : HitColor.HalveHue());
                var miss = new SolidBrush(Enabled ? MissColor : MissColor.HalveHue());

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
            base.OnPaint(e);
        }
    }
}
