namespace Battleship {
    partial class ShipPlacerForm {
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
            this.shipPlacerControl1 = new Battleship.ShipPlacerControl();
            this.SuspendLayout();
            // 
            // shipPlacerControl1
            // 
            this.shipPlacerControl1.LineWidth = 3F;
            this.shipPlacerControl1.Location = new System.Drawing.Point(12, 12);
            this.shipPlacerControl1.Name = "shipPlacerControl1";
            this.shipPlacerControl1.Size = new System.Drawing.Size(421, 421);
            this.shipPlacerControl1.TabIndex = 0;
            this.shipPlacerControl1.Text = "shipPlacerControl1";
            // 
            // ShipPlacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 554);
            this.Controls.Add(this.shipPlacerControl1);
            this.Name = "ShipPlacerForm";
            this.Text = "ShipPlacerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ShipPlacerControl shipPlacerControl1;
    }
}