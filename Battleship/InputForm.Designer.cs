namespace Battleship {
    partial class InputForm {
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.UserCancelButton = new System.Windows.Forms.Button();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(12, 51);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // UserCancelButton
            // 
            this.UserCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserCancelButton.Location = new System.Drawing.Point(93, 51);
            this.UserCancelButton.Name = "UserCancelButton";
            this.UserCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UserCancelButton.TabIndex = 1;
            this.UserCancelButton.Text = "Cancel";
            this.UserCancelButton.UseVisualStyleBackColor = true;
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(12, 25);
            this.SeedTextBox.MaxLength = 8;
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(156, 20);
            this.SeedTextBox.TabIndex = 2;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(12, 9);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(35, 13);
            this.SeedLabel.TabIndex = 3;
            this.SeedLabel.Text = "Seed:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 82);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.UserCancelButton);
            this.Controls.Add(this.NewGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Seed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button UserCancelButton;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label SeedLabel;
    }
}