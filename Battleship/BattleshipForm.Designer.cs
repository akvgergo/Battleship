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
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.AILivesLabel = new System.Windows.Forms.Label();
            this.PlayerLivesLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EasyRButton = new System.Windows.Forms.RadioButton();
            this.MediumRButton = new System.Windows.Forms.RadioButton();
            this.HardRButton = new System.Windows.Forms.RadioButton();
            this.trackerBoardControl1 = new Battleship.TrackerBoardControl();
            this.primaryBoardControl1 = new Battleship.PrimaryBoardControl();
            this.InfoGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoGroupBox
            // 
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
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.HardRButton);
            this.OptionsGroupBox.Controls.Add(this.MediumRButton);
            this.OptionsGroupBox.Controls.Add(this.EasyRButton);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.SettingsButton);
            this.OptionsGroupBox.Controls.Add(this.StartButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(331, 331);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(313, 100);
            this.OptionsGroupBox.TabIndex = 5;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.Location = new System.Drawing.Point(140, 20);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(85, 74);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(6, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 75);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "New Game";
            this.StartButton.UseVisualStyleBackColor = true;
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
            // trackerBoardControl1
            // 
            this.trackerBoardControl1.HitColor = System.Drawing.Color.Red;
            this.trackerBoardControl1.LineWidth = 3F;
            this.trackerBoardControl1.Location = new System.Drawing.Point(331, 12);
            this.trackerBoardControl1.MissColor = System.Drawing.Color.Gray;
            this.trackerBoardControl1.Name = "trackerBoardControl1";
            this.trackerBoardControl1.Size = new System.Drawing.Size(313, 313);
            this.trackerBoardControl1.TabIndex = 3;
            this.trackerBoardControl1.Text = "trackerBoardControl1";
            this.trackerBoardControl1.UnknownColor = System.Drawing.Color.LightBlue;
            // 
            // primaryBoardControl1
            // 
            this.primaryBoardControl1.HitColor = System.Drawing.Color.Red;
            this.primaryBoardControl1.LineWidth = 3F;
            this.primaryBoardControl1.Location = new System.Drawing.Point(12, 12);
            this.primaryBoardControl1.MissColor = System.Drawing.Color.Pink;
            this.primaryBoardControl1.Name = "primaryBoardControl1";
            this.primaryBoardControl1.ShipColor = System.Drawing.Color.Gray;
            this.primaryBoardControl1.Size = new System.Drawing.Size(313, 313);
            this.primaryBoardControl1.TabIndex = 2;
            this.primaryBoardControl1.Text = "primaryBoardControl1";
            this.primaryBoardControl1.WaterColor = System.Drawing.Color.LightBlue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 443);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.trackerBoardControl1);
            this.Controls.Add(this.primaryBoardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Battleship!";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PrimaryBoardControl primaryBoardControl1;
        private TrackerBoardControl trackerBoardControl1;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.Label AILivesLabel;
        private System.Windows.Forms.Label PlayerLivesLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton HardRButton;
        private System.Windows.Forms.RadioButton MediumRButton;
        private System.Windows.Forms.RadioButton EasyRButton;
        private System.Windows.Forms.Label label1;
    }
}

