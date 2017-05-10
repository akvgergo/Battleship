namespace Battleship {
    partial class Form1 {
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
            this.battleshipControl1 = new Battleship.BattleshipControl();
            this.battleshipControl2 = new Battleship.BattleshipControl();
            this.SuspendLayout();
            // 
            // battleshipControl1
            // 
            this.battleshipControl1.HitColor = System.Drawing.Color.Empty;
            this.battleshipControl1.LineWidth = 2F;
            this.battleshipControl1.Location = new System.Drawing.Point(48, 40);
            this.battleshipControl1.MissColor = System.Drawing.Color.Empty;
            this.battleshipControl1.Name = "battleshipControl1";
            this.battleshipControl1.ShipColor = System.Drawing.Color.Empty;
            this.battleshipControl1.Size = new System.Drawing.Size(425, 425);
            this.battleshipControl1.TabIndex = 0;
            this.battleshipControl1.Text = "battleshipControl1";
            this.battleshipControl1.TrackingMode = false;
            // 
            // battleshipControl2
            // 
            this.battleshipControl2.HitColor = System.Drawing.Color.Empty;
            this.battleshipControl2.LineWidth = 2F;
            this.battleshipControl2.Location = new System.Drawing.Point(479, 40);
            this.battleshipControl2.MissColor = System.Drawing.Color.Empty;
            this.battleshipControl2.Name = "battleshipControl2";
            this.battleshipControl2.ShipColor = System.Drawing.Color.Empty;
            this.battleshipControl2.Size = new System.Drawing.Size(425, 425);
            this.battleshipControl2.TabIndex = 1;
            this.battleshipControl2.Text = "battleshipControl2";
            this.battleshipControl2.TrackingMode = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.battleshipControl2);
            this.Controls.Add(this.battleshipControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BattleshipControl battleshipControl1;
        private BattleshipControl battleshipControl2;
    }
}

