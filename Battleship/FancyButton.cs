using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Battleship {
    public partial class FancyButton : Control {

        public Bitmap Icon { get; set; }

        public Color SecondaryForeColor { get; set; }
        public Color PrimaryForeColor { get; set; }

        Task HighlightTask;
        CancellationToken HighlightCT;
        CancellationToken deHighLightCT;

        Font _secondaryFont;
        public Font SecondaryFont {
            get { return _secondaryFont ?? Font; }
            set { _secondaryFont = value; }
        }

        Font _primaryFont;
        public Font PrimaryFont {
            get { return _primaryFont ?? Font; }
            set { _primaryFont = value; }
        }

        bool _highlighted = false;
        public bool Highlighted {
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

        public bool ShiwIconOnHighLight { get; set; }

        public FancyButton() {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            MouseEnter += (o, e) => { HighlightTask = Highlight(); };
            MouseLeave += (o, e) => { HighlightTask = Dehighlight(); };
        }

        public async Task Highlight() {
            ForeColor = SecondaryForeColor;
            if (ShiwIconOnHighLight) ShowIcon = true;
            deHighLightCT = new CancellationToken(true);
            HighlightCT = new CancellationToken();
            while (Font.Size < SecondaryFont.Size && PrimaryFont.Size < SecondaryFont.Size) {
                if (HighlightCT.IsCancellationRequested) return;
                Font = new Font(SecondaryFont.FontFamily, Font.Size + .5f, SecondaryFont.Style);
                await Task.Delay(15);
            }
        }

        public async Task Dehighlight() {
            ForeColor = PrimaryForeColor;
            if (ShiwIconOnHighLight) ShowIcon = false;
            HighlightCT = new CancellationToken(true);
            deHighLightCT = new CancellationToken();
            while (Font.Size > PrimaryFont.Size && SecondaryFont.Size > PrimaryFont.Size) {
                if (deHighLightCT.IsCancellationRequested) return;
                Font = new Font(SecondaryFont.FontFamily, Font.Size - .5f, SecondaryFont.Style);
                await Task.Delay(15);
            }
        }

        protected override void OnPaint(PaintEventArgs pe) {
            Size textSize = TextRenderer.MeasureText(Text, Font);     
            SolidBrush textBrush = new SolidBrush(Enabled ? ForeColor : ForeColor.HalveHue());
            if (Icon == null || !ShowIcon) {
                Size = textSize;
                pe.Graphics.DrawString(Text, Font, textBrush, new Point());
                return;
            }
            Size = new Size(textSize.Width + 32, Math.Max(textSize.Height, 32));

            if (textSize.Height > 32) {
                pe.Graphics.DrawImage(Icon, new Rectangle(0, (textSize.Height - 32) / 2, 32, 32));
                pe.Graphics.DrawString(Text, Font, textBrush, new Point(32, 0));
            } else {
                pe.Graphics.DrawImage(Icon, new Rectangle(0, 0, 32, 32));
                pe.Graphics.DrawString(Text, Font, textBrush, new Point(32, (32 - textSize.Height) / 2));
            }
        }
    }
}
