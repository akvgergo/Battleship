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
            this.primaryBoardControl1 = new Battleship.PrimaryBoardControl();
            this.trackerBoardControl1 = new Battleship.TrackerBoardControl();
            this.SuspendLayout();
            // 
            // primaryBoardControl1
            // 
            this.primaryBoardControl1.HitColor = System.Drawing.Color.Pink;
            this.primaryBoardControl1.LineWidth = 2F;
            this.primaryBoardControl1.Location = new System.Drawing.Point(67, 46);
            this.primaryBoardControl1.MissColor = System.Drawing.Color.Red;
            this.primaryBoardControl1.Name = "primaryBoardControl1";
            this.primaryBoardControl1.ShipColor = System.Drawing.Color.LightBlue;
            this.primaryBoardControl1.Size = new System.Drawing.Size(392, 392);
            this.primaryBoardControl1.TabIndex = 0;
            this.primaryBoardControl1.Text = "primaryBoardControl1";
            // 
            // trackerBoardControl1
            // 
            this.trackerBoardControl1.HitColor = System.Drawing.Color.Pink;
            this.trackerBoardControl1.LineWidth = 2F;
            this.trackerBoardControl1.Location = new System.Drawing.Point(474, 46);
            this.trackerBoardControl1.MissColor = System.Drawing.Color.Red;
            this.trackerBoardControl1.Name = "trackerBoardControl1";
            this.trackerBoardControl1.Size = new System.Drawing.Size(392, 392);
            this.trackerBoardControl1.TabIndex = 1;
            this.trackerBoardControl1.Text = "trackerBoardControl1";
            this.trackerBoardControl1.UnknownColor = System.Drawing.Color.Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.trackerBoardControl1);
            this.Controls.Add(this.primaryBoardControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PrimaryBoardControl primaryBoardControl1;
        private TrackerBoardControl trackerBoardControl1;
    }
}

