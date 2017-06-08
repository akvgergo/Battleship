namespace Battleship {
    partial class BattleshipForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleshipForm));
            this.MenuPanel = new Battleship.CustomPanel();
            this.customFLPanel1 = new Battleship.CustomFLPanel();
            this.NewGameButton = new Battleship.FancyButton();
            this.ContinueGameButton = new Battleship.FancyButton();
            this.GuideButton = new Battleship.FancyButton();
            this.ViewSourceButton = new Battleship.FancyButton();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.GamePanel = new Battleship.CustomPanel();
            this.UIPrimaryBoard = new Battleship.PrimaryBoardControl();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.HardRButton = new System.Windows.Forms.RadioButton();
            this.MediumRButton = new System.Windows.Forms.RadioButton();
            this.EasyRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.UITrackerBoard = new Battleship.TrackerBoardControl();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.AILivesLabel = new System.Windows.Forms.Label();
            this.PlayerLivesLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.customFLPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.customFLPanel1);
            this.MenuPanel.Controls.Add(this.TitlePictureBox);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(656, 443);
            this.MenuPanel.TabIndex = 7;
            // 
            // customFLPanel1
            // 
            this.customFLPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customFLPanel1.Controls.Add(this.NewGameButton);
            this.customFLPanel1.Controls.Add(this.ContinueGameButton);
            this.customFLPanel1.Controls.Add(this.GuideButton);
            this.customFLPanel1.Controls.Add(this.ViewSourceButton);
            this.customFLPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.customFLPanel1.Location = new System.Drawing.Point(12, 141);
            this.customFLPanel1.Name = "customFLPanel1";
            this.customFLPanel1.Size = new System.Drawing.Size(313, 219);
            this.customFLPanel1.TabIndex = 8;
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Transparent;
            this.NewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewGameButton.Highlighted = false;
            this.NewGameButton.Icon = global::Battleship.Properties.Resources.Ship;
            this.NewGameButton.Location = new System.Drawing.Point(3, 3);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.PrimaryFont = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewGameButton.PrimaryForeColor = System.Drawing.SystemColors.ControlText;
            this.NewGameButton.SecondaryFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewGameButton.SecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewGameButton.ShiwIconOnHighLight = true;
            this.NewGameButton.ShowIcon = false;
            this.NewGameButton.Size = new System.Drawing.Size(159, 34);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New game";
            // 
            // ContinueGameButton
            // 
            this.ContinueGameButton.BackColor = System.Drawing.Color.Transparent;
            this.ContinueGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueGameButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContinueGameButton.Highlighted = false;
            this.ContinueGameButton.Icon = global::Battleship.Properties.Resources.Broken_ship;
            this.ContinueGameButton.Location = new System.Drawing.Point(3, 43);
            this.ContinueGameButton.Name = "ContinueGameButton";
            this.ContinueGameButton.PrimaryFont = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContinueGameButton.PrimaryForeColor = System.Drawing.SystemColors.ControlText;
            this.ContinueGameButton.SecondaryFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContinueGameButton.SecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContinueGameButton.ShiwIconOnHighLight = true;
            this.ContinueGameButton.ShowIcon = false;
            this.ContinueGameButton.Size = new System.Drawing.Size(142, 34);
            this.ContinueGameButton.TabIndex = 1;
            this.ContinueGameButton.Text = "Continue";
            // 
            // GuideButton
            // 
            this.GuideButton.BackColor = System.Drawing.Color.Transparent;
            this.GuideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuideButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuideButton.Highlighted = false;
            this.GuideButton.Icon = ((System.Drawing.Bitmap)(resources.GetObject("GuideButton.Icon")));
            this.GuideButton.Location = new System.Drawing.Point(3, 83);
            this.GuideButton.Name = "GuideButton";
            this.GuideButton.PrimaryFont = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuideButton.PrimaryForeColor = System.Drawing.SystemColors.ControlText;
            this.GuideButton.SecondaryFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuideButton.SecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuideButton.ShiwIconOnHighLight = true;
            this.GuideButton.ShowIcon = false;
            this.GuideButton.Size = new System.Drawing.Size(98, 34);
            this.GuideButton.TabIndex = 2;
            this.GuideButton.Text = "Guide";
            // 
            // ViewSourceButton
            // 
            this.ViewSourceButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewSourceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewSourceButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ViewSourceButton.Highlighted = false;
            this.ViewSourceButton.Icon = ((System.Drawing.Bitmap)(resources.GetObject("ViewSourceButton.Icon")));
            this.ViewSourceButton.Location = new System.Drawing.Point(3, 123);
            this.ViewSourceButton.Name = "ViewSourceButton";
            this.ViewSourceButton.PrimaryFont = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ViewSourceButton.PrimaryForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewSourceButton.SecondaryFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ViewSourceButton.SecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewSourceButton.ShiwIconOnHighLight = true;
            this.ViewSourceButton.ShowIcon = false;
            this.ViewSourceButton.Size = new System.Drawing.Size(186, 34);
            this.ViewSourceButton.TabIndex = 3;
            this.ViewSourceButton.Text = "View Source";
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Image = global::Battleship.Properties.Resources.Title;
            this.TitlePictureBox.Location = new System.Drawing.Point(12, 12);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(544, 123);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePictureBox.TabIndex = 0;
            this.TitlePictureBox.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.Controls.Add(this.UIPrimaryBoard);
            this.GamePanel.Controls.Add(this.OptionsGroupBox);
            this.GamePanel.Controls.Add(this.UITrackerBoard);
            this.GamePanel.Controls.Add(this.InfoGroupBox);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(656, 443);
            this.GamePanel.TabIndex = 6;
            // 
            // UIPrimaryBoard
            // 
            this.UIPrimaryBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.UIPrimaryBoard.Enabled = false;
            this.UIPrimaryBoard.HitColor = System.Drawing.Color.Red;
            this.UIPrimaryBoard.LineWidth = 3F;
            this.UIPrimaryBoard.Location = new System.Drawing.Point(12, 12);
            this.UIPrimaryBoard.MissColor = System.Drawing.Color.Pink;
            this.UIPrimaryBoard.Name = "UIPrimaryBoard";
            this.UIPrimaryBoard.ShipColor = System.Drawing.Color.Gray;
            this.UIPrimaryBoard.Size = new System.Drawing.Size(313, 313);
            this.UIPrimaryBoard.TabIndex = 2;
            this.UIPrimaryBoard.Text = "primaryBoardControl1";
            this.UIPrimaryBoard.WaterColor = System.Drawing.Color.LightBlue;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.OptionsGroupBox.Controls.Add(this.HardRButton);
            this.OptionsGroupBox.Controls.Add(this.MediumRButton);
            this.OptionsGroupBox.Controls.Add(this.EasyRButton);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.SettingsButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(331, 331);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(313, 100);
            this.OptionsGroupBox.TabIndex = 5;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // HardRButton
            // 
            this.HardRButton.AutoSize = true;
            this.HardRButton.Location = new System.Drawing.Point(234, 70);
            this.HardRButton.Name = "HardRButton";
            this.HardRButton.Size = new System.Drawing.Size(48, 17);
            this.HardRButton.TabIndex = 6;
            this.HardRButton.Text = "Hard";
            this.HardRButton.UseVisualStyleBackColor = true;
            // 
            // MediumRButton
            // 
            this.MediumRButton.AutoSize = true;
            this.MediumRButton.Location = new System.Drawing.Point(234, 50);
            this.MediumRButton.Name = "MediumRButton";
            this.MediumRButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRButton.TabIndex = 5;
            this.MediumRButton.Text = "Medium";
            this.MediumRButton.UseVisualStyleBackColor = true;
            // 
            // EasyRButton
            // 
            this.EasyRButton.AutoSize = true;
            this.EasyRButton.Checked = true;
            this.EasyRButton.Location = new System.Drawing.Point(234, 30);
            this.EasyRButton.Name = "EasyRButton";
            this.EasyRButton.Size = new System.Drawing.Size(48, 17);
            this.EasyRButton.TabIndex = 4;
            this.EasyRButton.TabStop = true;
            this.EasyRButton.Text = "Easy";
            this.EasyRButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Difficulty:";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.Location = new System.Drawing.Point(140, 19);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(85, 75);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // UITrackerBoard
            // 
            this.UITrackerBoard.Cursor = System.Windows.Forms.Cursors.Cross;
            this.UITrackerBoard.HitColor = System.Drawing.Color.Red;
            this.UITrackerBoard.LineWidth = 3F;
            this.UITrackerBoard.Location = new System.Drawing.Point(331, 12);
            this.UITrackerBoard.MissColor = System.Drawing.Color.Gray;
            this.UITrackerBoard.Name = "UITrackerBoard";
            this.UITrackerBoard.Size = new System.Drawing.Size(313, 313);
            this.UITrackerBoard.TabIndex = 3;
            this.UITrackerBoard.Text = "trackerBoardControl1";
            this.UITrackerBoard.UnknownColor = System.Drawing.Color.LightBlue;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.InfoGroupBox.Controls.Add(this.SeedLabel);
            this.InfoGroupBox.Controls.Add(this.AILivesLabel);
            this.InfoGroupBox.Controls.Add(this.PlayerLivesLabel);
            this.InfoGroupBox.Controls.Add(this.RoundLabel);
            this.InfoGroupBox.Controls.Add(this.TimeLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(12, 331);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(313, 100);
            this.InfoGroupBox.TabIndex = 4;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeedLabel.Location = new System.Drawing.Point(217, 84);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(35, 13);
            this.SeedLabel.TabIndex = 4;
            this.SeedLabel.Text = "Seed:";
            // 
            // AILivesLabel
            // 
            this.AILivesLabel.AutoSize = true;
            this.AILivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AILivesLabel.Location = new System.Drawing.Point(143, 51);
            this.AILivesLabel.Name = "AILivesLabel";
            this.AILivesLabel.Size = new System.Drawing.Size(94, 25);
            this.AILivesLabel.TabIndex = 3;
            this.AILivesLabel.Text = "AI Lives:";
            // 
            // PlayerLivesLabel
            // 
            this.PlayerLivesLabel.AutoSize = true;
            this.PlayerLivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerLivesLabel.Location = new System.Drawing.Point(143, 16);
            this.PlayerLivesLabel.Name = "PlayerLivesLabel";
            this.PlayerLivesLabel.Size = new System.Drawing.Size(136, 25);
            this.PlayerLivesLabel.TabIndex = 2;
            this.PlayerLivesLabel.Text = "Player Lives:";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoundLabel.Location = new System.Drawing.Point(6, 51);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(81, 25);
            this.RoundLabel.TabIndex = 1;
            this.RoundLabel.Text = "Round:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLabel.Location = new System.Drawing.Point(6, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(65, 25);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time:";
            // 
            // BattleshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 443);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.GamePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BattleshipForm";
            this.Text = "Battleship!";
            this.MenuPanel.ResumeLayout(false);
            this.customFLPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PrimaryBoardControl UIPrimaryBoard;
        private TrackerBoardControl UITrackerBoard;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.Label AILivesLabel;
        private System.Windows.Forms.Label PlayerLivesLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.RadioButton HardRButton;
        private System.Windows.Forms.RadioButton MediumRButton;
        private System.Windows.Forms.RadioButton EasyRButton;
        private System.Windows.Forms.Label label1;
        private CustomPanel GamePanel;
        private CustomPanel MenuPanel;
        private System.Windows.Forms.PictureBox TitlePictureBox;
        private FancyButton NewGameButton;
        private FancyButton ContinueGameButton;
        private FancyButton GuideButton;
        private FancyButton ViewSourceButton;
        private CustomFLPanel customFLPanel1;
    }
}

