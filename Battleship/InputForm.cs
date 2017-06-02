using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Battleship {
    public partial class InputForm : Form {

        public InputForm() {
            InitializeComponent();
            NewGameButton.Click += CreateNewGame;
        }

        private void CreateNewGame(object sender, EventArgs e) {
            if (Regex.IsMatch(SeedTextBox.Text, "(?i)[^0-9A-F]") || string.IsNullOrWhiteSpace(SeedTextBox.Text)) {
                MessageBox.Show("Invalid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BattleshipForm parent = Owner as BattleshipForm;
            if (parent != null) parent.StartGame(Math.Abs(Convert.ToInt32(SeedTextBox.Text, 16)));
        }
    }
}
