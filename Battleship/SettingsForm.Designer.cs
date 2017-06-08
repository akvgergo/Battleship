namespace Battleship {
    partial class SettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UserCancelButton = new System.Windows.Forms.Button();
            this.PrimColBox = new System.Windows.Forms.GroupBox();
            this.MissColorBoxPrimary = new Battleship.ColorButton();
            this.HitColorBoxPrimary = new Battleship.ColorButton();
            this.ShipColorBoxPrimary = new Battleship.ColorButton();
            this.WaterColorBoxPrimary = new Battleship.ColorButton();
            this.TracColBox = new System.Windows.Forms.GroupBox();
            this.HitColorBoxTracking = new Battleship.ColorButton();
            this.MissColorBoxTracking = new Battleship.ColorButton();
            this.UnknownColorBoxTracking = new Battleship.ColorButton();
            this.PrimColBox.SuspendLayout();
            this.TracColBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(106, 251);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 30);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply changes";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // UserCancelButton
            // 
            this.UserCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserCancelButton.Location = new System.Drawing.Point(212, 251);
            this.UserCancelButton.Name = "UserCancelButton";
            this.UserCancelButton.Size = new System.Drawing.Size(100, 30);
            this.UserCancelButton.TabIndex = 1;
            this.UserCancelButton.Text = "Cancel";
            this.UserCancelButton.UseVisualStyleBackColor = true;
            // 
            // PrimColBox
            // 
            this.PrimColBox.Controls.Add(this.MissColorBoxPrimary);
            this.PrimColBox.Controls.Add(this.HitColorBoxPrimary);
            this.PrimColBox.Controls.Add(this.ShipColorBoxPrimary);
            this.PrimColBox.Controls.Add(this.WaterColorBoxPrimary);
            this.PrimColBox.Location = new System.Drawing.Point(12, 12);
            this.PrimColBox.Name = "PrimColBox";
            this.PrimColBox.Size = new System.Drawing.Size(100, 167);
            this.PrimColBox.TabIndex = 3;
            this.PrimColBox.TabStop = false;
            this.PrimColBox.Text = "Primary Colors";
            // 
            // MissColorBoxPrimary
            // 
            this.MissColorBoxPrimary.AutoSize = true;
            this.MissColorBoxPrimary.BackColor = System.Drawing.Color.Transparent;
            this.MissColorBoxPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MissColorBoxPrimary.Location = new System.Drawing.Point(6, 130);
            this.MissColorBoxPrimary.Name = "MissColorBoxPrimary";
            this.MissColorBoxPrimary.SelectedColor = System.Drawing.Color.White;
            this.MissColorBoxPrimary.Size = new System.Drawing.Size(60, 31);
            this.MissColorBoxPrimary.TabIndex = 5;
            this.MissColorBoxPrimary.Text = "Miss";
            // 
            // HitColorBoxPrimary
            // 
            this.HitColorBoxPrimary.AutoSize = true;
            this.HitColorBoxPrimary.BackColor = System.Drawing.Color.Transparent;
            this.HitColorBoxPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HitColorBoxPrimary.Location = new System.Drawing.Point(6, 93);
            this.HitColorBoxPrimary.Name = "HitColorBoxPrimary";
            this.HitColorBoxPrimary.SelectedColor = System.Drawing.Color.White;
            this.HitColorBoxPrimary.Size = new System.Drawing.Size(52, 31);
            this.HitColorBoxPrimary.TabIndex = 4;
            this.HitColorBoxPrimary.Text = "Hit";
            // 
            // ShipColorBoxPrimary
            // 
            this.ShipColorBoxPrimary.AutoSize = true;
            this.ShipColorBoxPrimary.BackColor = System.Drawing.Color.Transparent;
            this.ShipColorBoxPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShipColorBoxPrimary.Location = new System.Drawing.Point(6, 56);
            this.ShipColorBoxPrimary.Name = "ShipColorBoxPrimary";
            this.ShipColorBoxPrimary.SelectedColor = System.Drawing.Color.White;
            this.ShipColorBoxPrimary.Size = new System.Drawing.Size(60, 31);
            this.ShipColorBoxPrimary.TabIndex = 3;
            this.ShipColorBoxPrimary.Text = "Ship";
            // 
            // WaterColorBoxPrimary
            // 
            this.WaterColorBoxPrimary.AutoSize = true;
            this.WaterColorBoxPrimary.BackColor = System.Drawing.Color.Transparent;
            this.WaterColorBoxPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WaterColorBoxPrimary.Location = new System.Drawing.Point(6, 19);
            this.WaterColorBoxPrimary.Name = "WaterColorBoxPrimary";
            this.WaterColorBoxPrimary.SelectedColor = System.Drawing.Color.White;
            this.WaterColorBoxPrimary.Size = new System.Drawing.Size(68, 31);
            this.WaterColorBoxPrimary.TabIndex = 2;
            this.WaterColorBoxPrimary.Text = "Water";
            // 
            // TracColBox
            // 
            this.TracColBox.Controls.Add(this.HitColorBoxTracking);
            this.TracColBox.Controls.Add(this.MissColorBoxTracking);
            this.TracColBox.Controls.Add(this.UnknownColorBoxTracking);
            this.TracColBox.Location = new System.Drawing.Point(118, 12);
            this.TracColBox.Name = "TracColBox";
            this.TracColBox.Size = new System.Drawing.Size(100, 130);
            this.TracColBox.TabIndex = 4;
            this.TracColBox.TabStop = false;
            this.TracColBox.Text = "Tracking Colors";
            // 
            // HitColorBoxTracking
            // 
            this.HitColorBoxTracking.AutoSize = true;
            this.HitColorBoxTracking.BackColor = System.Drawing.Color.Transparent;
            this.HitColorBoxTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HitColorBoxTracking.Location = new System.Drawing.Point(6, 93);
            this.HitColorBoxTracking.Name = "HitColorBoxTracking";
            this.HitColorBoxTracking.SelectedColor = System.Drawing.Color.White;
            this.HitColorBoxTracking.Size = new System.Drawing.Size(52, 31);
            this.HitColorBoxTracking.TabIndex = 7;
            this.HitColorBoxTracking.Text = "Hit";
            // 
            // MissColorBoxTracking
            // 
            this.MissColorBoxTracking.AutoSize = true;
            this.MissColorBoxTracking.BackColor = System.Drawing.Color.Transparent;
            this.MissColorBoxTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MissColorBoxTracking.Location = new System.Drawing.Point(6, 56);
            this.MissColorBoxTracking.Name = "MissColorBoxTracking";
            this.MissColorBoxTracking.SelectedColor = System.Drawing.Color.White;
            this.MissColorBoxTracking.Size = new System.Drawing.Size(60, 31);
            this.MissColorBoxTracking.TabIndex = 6;
            this.MissColorBoxTracking.Text = "Miss";
            // 
            // UnknownColorBoxTracking
            // 
            this.UnknownColorBoxTracking.AutoSize = true;
            this.UnknownColorBoxTracking.BackColor = System.Drawing.Color.Transparent;
            this.UnknownColorBoxTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnknownColorBoxTracking.Location = new System.Drawing.Point(6, 19);
            this.UnknownColorBoxTracking.Name = "UnknownColorBoxTracking";
            this.UnknownColorBoxTracking.SelectedColor = System.Drawing.Color.White;
            this.UnknownColorBoxTracking.Size = new System.Drawing.Size(85, 31);
            this.UnknownColorBoxTracking.TabIndex = 5;
            this.UnknownColorBoxTracking.Text = "Unknown";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 293);
            this.Controls.Add(this.TracColBox);
            this.Controls.Add(this.PrimColBox);
            this.Controls.Add(this.UserCancelButton);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.PrimColBox.ResumeLayout(false);
            this.PrimColBox.PerformLayout();
            this.TracColBox.ResumeLayout(false);
            this.TracColBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button UserCancelButton;
        private ColorButton WaterColorBoxPrimary;
        private System.Windows.Forms.GroupBox PrimColBox;
        private ColorButton MissColorBoxPrimary;
        private ColorButton HitColorBoxPrimary;
        private ColorButton ShipColorBoxPrimary;
        private System.Windows.Forms.GroupBox TracColBox;
        private ColorButton HitColorBoxTracking;
        private ColorButton MissColorBoxTracking;
        private ColorButton UnknownColorBoxTracking;
    }
}