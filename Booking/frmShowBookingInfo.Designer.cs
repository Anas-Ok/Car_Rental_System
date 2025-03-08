namespace Car_Rental_System
{
    partial class frmShowBookingInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ctrlShowBookingInfo1 = new Car_Rental_System.ctrlShowBookingInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::Car_Rental_System.Properties.Resources.cross;
            this.pbExit.ImageRotate = 0F;
            this.pbExit.Location = new System.Drawing.Point(928, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbExit.Size = new System.Drawing.Size(57, 52);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 2;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // ctrlShowBookingInfo1
            // 
            this.ctrlShowBookingInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlShowBookingInfo1.Location = new System.Drawing.Point(1, 0);
            this.ctrlShowBookingInfo1.Name = "ctrlShowBookingInfo1";
            this.ctrlShowBookingInfo1.Size = new System.Drawing.Size(984, 517);
            this.ctrlShowBookingInfo1.TabIndex = 0;
            // 
            // frmShowBookingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 519);
            this.ControlBox = false;
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.ctrlShowBookingInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowBookingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowBookingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowBookingInfo ctrlShowBookingInfo1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbExit;
    }
}