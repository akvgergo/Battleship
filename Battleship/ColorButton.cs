using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship {
    public partial class ColorButton : UserControl {

        ColorDialog ColorDialog { get; set; }

        // Valamiért a UserControl alapból elrejti a Text tulajdonságot, ezért láthatóvá kell tennünk
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get { return TextLabel.Text; }
            set { TextLabel.Text = value; }
        }

        Color _selectedColor = Color.White;
        public Color SelectedColor {
            get { return _selectedColor; }
            set {
                _selectedColor = value;
                SelectedColorChanged?.Invoke(this, new EventArgs());
            }
        }

        public ColorButton() {
            InitializeComponent();
            ColorBox.Click += HandleClick;
            TextLabel.TextChanged += HandleTextChanged;
            SelectedColorChanged += HandleColorChanged;
            SetToolTips();
        }

        private void SetToolTips() {
            var text = SelectedColor.IsNamedColor ? SelectedColor.Name : "Unnamed color: #" + Convert.ToString(SelectedColor.ToArgb(), 16).Remove(0, 2);
            ColorToolTip.SetToolTip(ColorBox, text);
            ColorToolTip.SetToolTip(this, text);
            ColorToolTip.SetToolTip(TextLabel, text);
        }

        private void HandleColorChanged(object sender, EventArgs e) {
            ColorBox.BackColor = SelectedColor;
            SetToolTips();
        }

        private void HandleTextChanged(object sender, EventArgs e) {
            if (AutoSize) {
                Width = 20 + TextLabel.Width;
            }
        }

        private void HandleClick(object sender, EventArgs e) {
            if (ColorDialog == null) {
                ColorDialog = new ColorDialog();
                ColorDialog.SolidColorOnly = true;
            }
            ColorDialog.Color = SelectedColor;
            ColorDialog.ShowDialog();
            SelectedColor = ColorDialog.Color;
        }

        public ColorButton(string text) : this() {
            Text = text;
        }

        public event EventHandler SelectedColorChanged;
    }
}
