namespace Car_Rental_System
{
    partial class frmTransactionBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblReturnID = new System.Windows.Forms.Label();
            this.lblInitialTotalDueAmount = new System.Windows.Forms.Label();
            this.lblActualTotalDueAmount = new System.Windows.Forms.Label();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.lblTotalRefundedAmount = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblUpdatedTransactionDate = new System.Windows.Forms.Label();
            this.txtPaymentDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new ReaLTaiizor.Controls.CyberButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Booking ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Initial Total Due Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Actual Total Due Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Remaining:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 604);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 40);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Refunded Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 737);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 40);
            this.label10.TabIndex = 9;
            this.label10.Text = "Updated Transaction Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 670);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 40);
            this.label11.TabIndex = 10;
            this.label11.Text = "Transaction Date:";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.Location = new System.Drawing.Point(385, 149);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(62, 35);
            this.lblTransactionID.TabIndex = 11;
            this.lblTransactionID.Text = "N/a";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(385, 215);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 31);
            this.lblBookingID.TabIndex = 12;
            this.lblBookingID.Text = "N/a";
            // 
            // lblReturnID
            // 
            this.lblReturnID.AutoSize = true;
            this.lblReturnID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnID.Location = new System.Drawing.Point(385, 280);
            this.lblReturnID.Name = "lblReturnID";
            this.lblReturnID.Size = new System.Drawing.Size(60, 31);
            this.lblReturnID.TabIndex = 13;
            this.lblReturnID.Text = "N/a";
            // 
            // lblInitialTotalDueAmount
            // 
            this.lblInitialTotalDueAmount.AutoSize = true;
            this.lblInitialTotalDueAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialTotalDueAmount.Location = new System.Drawing.Point(384, 403);
            this.lblInitialTotalDueAmount.Name = "lblInitialTotalDueAmount";
            this.lblInitialTotalDueAmount.Size = new System.Drawing.Size(66, 40);
            this.lblInitialTotalDueAmount.TabIndex = 15;
            this.lblInitialTotalDueAmount.Text = "N/a";
            // 
            // lblActualTotalDueAmount
            // 
            this.lblActualTotalDueAmount.AutoSize = true;
            this.lblActualTotalDueAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTotalDueAmount.Location = new System.Drawing.Point(384, 472);
            this.lblActualTotalDueAmount.Name = "lblActualTotalDueAmount";
            this.lblActualTotalDueAmount.Size = new System.Drawing.Size(66, 40);
            this.lblActualTotalDueAmount.TabIndex = 16;
            this.lblActualTotalDueAmount.Text = "N/a";
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.AutoSize = true;
            this.lblTotalRemaining.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRemaining.Location = new System.Drawing.Point(384, 539);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(66, 40);
            this.lblTotalRemaining.TabIndex = 17;
            this.lblTotalRemaining.Text = "N/a";
            // 
            // lblTotalRefundedAmount
            // 
            this.lblTotalRefundedAmount.AutoSize = true;
            this.lblTotalRefundedAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefundedAmount.Location = new System.Drawing.Point(384, 604);
            this.lblTotalRefundedAmount.Name = "lblTotalRefundedAmount";
            this.lblTotalRefundedAmount.Size = new System.Drawing.Size(66, 40);
            this.lblTotalRefundedAmount.TabIndex = 18;
            this.lblTotalRefundedAmount.Text = "N/a";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.Location = new System.Drawing.Point(384, 670);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(66, 40);
            this.lblTransactionDate.TabIndex = 19;
            this.lblTransactionDate.Text = "N/a";
            // 
            // lblUpdatedTransactionDate
            // 
            this.lblUpdatedTransactionDate.AutoSize = true;
            this.lblUpdatedTransactionDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedTransactionDate.Location = new System.Drawing.Point(384, 737);
            this.lblUpdatedTransactionDate.Name = "lblUpdatedTransactionDate";
            this.lblUpdatedTransactionDate.Size = new System.Drawing.Size(66, 40);
            this.lblUpdatedTransactionDate.TabIndex = 20;
            this.lblUpdatedTransactionDate.Text = "N/a";
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentDetails.DefaultText = "";
            this.txtPaymentDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaymentDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.IconRight = global::Car_Rental_System.Properties.Resources.car;
            this.txtPaymentDetails.Location = new System.Drawing.Point(391, 332);
            this.txtPaymentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.PasswordChar = '\0';
            this.txtPaymentDetails.PlaceholderText = "";
            this.txtPaymentDetails.SelectedText = "";
            this.txtPaymentDetails.Size = new System.Drawing.Size(235, 48);
            this.txtPaymentDetails.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Alpha = 20;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Background = true;
            this.btnAdd.Background_WidthPen = 4F;
            this.btnAdd.BackgroundPen = true;
            this.btnAdd.ColorBackground = System.Drawing.Color.DimGray;
            this.btnAdd.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnAdd.Effect_1 = true;
            this.btnAdd.Effect_1_ColorBackground = System.Drawing.Color.DimGray;
            this.btnAdd.Effect_1_Transparency = 25;
            this.btnAdd.Effect_2 = true;
            this.btnAdd.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnAdd.Effect_2_Transparency = 20;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAdd.Lighting = false;
            this.btnAdd.LinearGradient_Background = true;
            this.btnAdd.LinearGradientPen = true;
            this.btnAdd.Location = new System.Drawing.Point(313, 835);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PenWidth = 15;
            this.btnAdd.RGB = true;
            this.btnAdd.Rounding = true;
            this.btnAdd.RoundingInt = 70;
            this.btnAdd.Size = new System.Drawing.Size(223, 73);
            this.btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Tag = "Cyber";
            this.btnAdd.TextButton = "Add ";
            this.btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAdd.Timer_Effect_1 = 5;
            this.btnAdd.Timer_RGB = 300;
            // 
            // frmTransactionBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 941);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPaymentDetails);
            this.Controls.Add(this.lblUpdatedTransactionDate);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblTotalRefundedAmount);
            this.Controls.Add(this.lblTotalRemaining);
            this.Controls.Add(this.lblActualTotalDueAmount);
            this.Controls.Add(this.lblInitialTotalDueAmount);
            this.Controls.Add(this.lblReturnID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransactionBooking";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmTransactionBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblReturnID;
        private System.Windows.Forms.Label lblInitialTotalDueAmount;
        private System.Windows.Forms.Label lblActualTotalDueAmount;
        private System.Windows.Forms.Label lblTotalRemaining;
        private System.Windows.Forms.Label lblTotalRefundedAmount;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblUpdatedTransactionDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPaymentDetails;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
    }
}