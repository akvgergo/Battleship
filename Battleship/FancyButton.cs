using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Battleship {
    public partial class FancyButton : Control {

        public Bitmap Icon { get; set; }

        public Color SecondaryForeColor { get; set; }

        Font _secondaryFont;
        public Font SecondaryFont {
            get { return _secondaryFont ?? Font; }
            set { _secondaryFont = value; }
        }

        bool _highlighted = false;
        public bool HighLight {
            get { return _highlighted; }
            set {
                _highlighted = value;
                Invalidate();
            }
        }

        bool _showIcon;
        public bool ShowIcon {
            get { return _showIcon; }
            set {
                _showIcon = value;
                Invalidate();
            }
        }

        public FancyButton() {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            MouseEnter += (o, e) => { HighLight = true; ShowIcon = true; };
            MouseLeave += (o, e) => { HighLight = false; ShowIcon = false; };
        }

        protected override void OnPaint(PaintEventArgs pe) {
            Color actualColor = HighLight ? SecondaryForeColor : ForeColor;
            Font actualFont = HighLight ? SecondaryFont : Font;
            Size textSize = TextRenderer.MeasureText(Text, actualFont);
            if (Icon == null || !ShowIcon) {
                Size = textSize;
                pe.Graphics.DrawString(Text, actualFont, new SolidBrush(actualColor), new Point());
                return;
            }
            Size = new Size(textSize.Width + 32, Math.Max(textSize.Height, 32));

            if (textSize.Height > 32) {
                pe.Graphics.DrawImage(Icon, new Rectangle(0, (textSize.Height - 32) / 2, 32, 32));
                pe.Graphics.DrawString(Text, actualFont, new SolidBrush(actualColor), new Point(32, 0));
            } else {
                pe.Graphics.DrawImage(Icon, new Rectangle(0, 0, 32, 32));
                pe.Graphics.DrawString(Text, actualFont, new SolidBrush(actualColor), new Point(32, (32 - textSize.Height) / 2));
            }
        }
    }
}
