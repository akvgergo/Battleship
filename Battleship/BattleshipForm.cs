using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;
using System.Drawing.Drawing2D;
using Battleship.Properties;

namespace Battleship {

    public partial class BattleshipForm : Form {

        BattleshipGame Game;
        Timer AnimationTimer = new Timer();

        public BattleshipForm() {
            InitializeComponent();
            NewGameButton.Click += InitNewGame;
            ContinueGameButton.Click += LoadSavedGame;
            GuideButton.Click += (o, e) => Process.Start("https://en.wikipedia.org/wiki/Battleship");
            ViewSourceButton.Click += (o, e) => Process.Start("https://github.com/akvgergo/Battleship");

            SeedLabel.MouseDoubleClick += HandleSeedlblClick;
            SettingsButton.Click += ShowSettings;
        }

        private void LoadSavedGame(object sender, EventArgs e) {

        }

        private void InitNewGame(object sender, EventArgs e) {
            ShipPlacerForm newGameDialog = new ShipPlacerForm();
            newGameDialog.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (var backBrush = new LinearGradientBrush(ClientRectangle, Color.SkyBlue, Color.LightBlue, 90f)) {
                e.Graphics.FillRectangle(backBrush, new Rectangle(new Point(), Size));
            }
        }

        private void ShowSettings(object sender, EventArgs e) {
            SettingsForm dialog = new SettingsForm();
            dialog.ShowDialog(this);
        }

        private void HandleSeedlblClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Middle) {
                InputForm dialog = new InputForm();
                dialog.Owner = this;
                dialog.ShowDialog();
            }
        }

        public void StartGame(int seed) {
            if (seed < 0) {
                Random r = new Random();
                seed = r.Next();
            }
            Game = new BattleshipGame(seed, GetDifficulty());
            Game.BindControls(UITrackerBoard, UIPrimaryBoard);
            SeedLabel.Text = string.Format("Seed: {0}", Convert.ToString(seed, 16).ToUpper());
        }

        public Difficulty GetDifficulty() {
            if (EasyRButton.Checked) return Difficulty.Easy;
            else if (MediumRButton.Checked) return Difficulty.Medium;
            else return Difficulty.Hard;
        }
    }
}
