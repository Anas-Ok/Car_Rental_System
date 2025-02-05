namespace Car_Rental_System.Vehicles
{
    partial class frmShowVehicleInfo
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
            this.ctrlVehicleInfo1 = new Car_Rental_System.ctrlVehicleInfo();
            this.SuspendLayout();
            // 
            // ctrlVehicleInfo1
            // 
            this.ctrlVehicleInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlVehicleInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlVehicleInfo1.Name = "ctrlVehicleInfo1";
            this.ctrlVehicleInfo1.Size = new System.Drawing.Size(895, 399);
            this.ctrlVehicleInfo1.TabIndex = 0;
            // 
            // frmShowVehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 433);
            this.Controls.Add(this.ctrlVehicleInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowVehicleInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlVehicleInfo ctrlVehicleInfo1;
    }
}