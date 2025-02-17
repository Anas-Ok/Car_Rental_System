namespace Car_Rental_System
{
    partial class frmAddNewVehicle
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
            this.txtMake = new Guna.UI2.WinForms.Guna2TextBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.dtpYear = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.cbFuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.foreverLabel6 = new ReaLTaiizor.Controls.ForeverLabel();
            this.cbCarType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.foreverLabel7 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel10 = new ReaLTaiizor.Controls.ForeverLabel();
            this.btnAdd = new ReaLTaiizor.Controls.CyberButton();
            this.cbIsAvailableForRent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudPricePerDay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtPlateNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.foreverLabel8 = new ReaLTaiizor.Controls.ForeverLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.Animated = true;
            this.txtMake.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMake.BorderRadius = 20;
            this.txtMake.BorderThickness = 2;
            this.txtMake.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMake.DefaultText = "";
            this.txtMake.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMake.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMake.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMake.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMake.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMake.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMake.Location = new System.Drawing.Point(189, 45);
            this.txtMake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMake.Name = "txtMake";
            this.txtMake.PasswordChar = '\0';
            this.txtMake.PlaceholderText = "";
            this.txtMake.SelectedText = "";
            this.txtMake.Size = new System.Drawing.Size(318, 40);
            this.txtMake.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMake.TabIndex = 0;
            this.txtMake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMake_KeyPress);
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel1.Location = new System.Drawing.Point(78, 55);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(75, 39);
            this.foreverLabel1.TabIndex = 1;
            this.foreverLabel1.Text = "Make:";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel2.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel2.Location = new System.Drawing.Point(607, 55);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(82, 39);
            this.foreverLabel2.TabIndex = 3;
            this.foreverLabel2.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Animated = true;
            this.txtModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.BorderRadius = 20;
            this.txtModel.BorderThickness = 2;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.DefaultText = "";
            this.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Location = new System.Drawing.Point(725, 45);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.PlaceholderText = "";
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(312, 40);
            this.txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtModel.TabIndex = 1;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel3.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel3.Location = new System.Drawing.Point(78, 149);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(69, 39);
            this.foreverLabel3.TabIndex = 5;
            this.foreverLabel3.Text = "Year:";
            // 
            // dtpYear
            // 
            this.dtpYear.Animated = true;
            this.dtpYear.AutoRoundedCorners = true;
            this.dtpYear.BackColor = System.Drawing.Color.Transparent;
            this.dtpYear.BorderRadius = 21;
            this.dtpYear.Checked = true;
            this.dtpYear.FillColor = System.Drawing.Color.White;
            this.dtpYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYear.Location = new System.Drawing.Point(189, 149);
            this.dtpYear.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpYear.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(328, 45);
            this.dtpYear.TabIndex = 7;
            this.dtpYear.Value = new System.DateTime(2025, 1, 24, 11, 41, 31, 91);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel4.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel4.Location = new System.Drawing.Point(68, 281);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(99, 39);
            this.foreverLabel4.TabIndex = 9;
            this.foreverLabel4.Text = "Mileage:";
            // 
            // txtMileage
            // 
            this.txtMileage.Animated = true;
            this.txtMileage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMileage.BorderRadius = 20;
            this.txtMileage.BorderThickness = 2;
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Location = new System.Drawing.Point(189, 270);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PasswordChar = '\0';
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(318, 40);
            this.txtMileage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMileage.TabIndex = 10;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel5.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel5.Location = new System.Drawing.Point(599, 281);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(120, 39);
            this.foreverLabel5.TabIndex = 11;
            this.foreverLabel5.Text = "Fuel Type:";
            // 
            // cbFuelType
            // 
            this.cbFuelType.AutoRoundedCorners = true;
            this.cbFuelType.BackColor = System.Drawing.Color.Transparent;
            this.cbFuelType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFuelType.BorderRadius = 17;
            this.cbFuelType.BorderThickness = 2;
            this.cbFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFuelType.ItemHeight = 30;
            this.cbFuelType.Location = new System.Drawing.Point(725, 270);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(312, 36);
            this.cbFuelType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbFuelType.TabIndex = 12;
            // 
            // foreverLabel6
            // 
            this.foreverLabel6.AutoSize = true;
            this.foreverLabel6.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel6.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel6.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel6.Location = new System.Drawing.Point(607, 401);
            this.foreverLabel6.Name = "foreverLabel6";
            this.foreverLabel6.Size = new System.Drawing.Size(112, 39);
            this.foreverLabel6.TabIndex = 13;
            this.foreverLabel6.Text = "Car Type:";
            // 
            // cbCarType
            // 
            this.cbCarType.BackColor = System.Drawing.Color.Transparent;
            this.cbCarType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCarType.BorderRadius = 20;
            this.cbCarType.BorderThickness = 2;
            this.cbCarType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCarType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCarType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCarType.ItemHeight = 30;
            this.cbCarType.Location = new System.Drawing.Point(730, 390);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(312, 36);
            this.cbCarType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCarType.TabIndex = 14;
            // 
            // foreverLabel7
            // 
            this.foreverLabel7.AutoSize = true;
            this.foreverLabel7.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel7.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel7.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel7.Location = new System.Drawing.Point(68, 510);
            this.foreverLabel7.Name = "foreverLabel7";
            this.foreverLabel7.Size = new System.Drawing.Size(225, 39);
            this.foreverLabel7.TabIndex = 15;
            this.foreverLabel7.Text = "Rental Price Per Day:";
            // 
            // foreverLabel10
            // 
            this.foreverLabel10.AutoSize = true;
            this.foreverLabel10.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel10.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel10.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel10.Location = new System.Drawing.Point(761, 510);
            this.foreverLabel10.Name = "foreverLabel10";
            this.foreverLabel10.Size = new System.Drawing.Size(210, 39);
            this.foreverLabel10.TabIndex = 17;
            this.foreverLabel10.Text = "Is Available for rent:";
            // 
            // btnAdd
            // 
            this.btnAdd.Alpha = 20;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Background = true;
            this.btnAdd.Background_WidthPen = 4F;
            this.btnAdd.BackgroundPen = true;
            this.btnAdd.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnAdd.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Default;
            this.btnAdd.Effect_1 = false;
            this.btnAdd.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnAdd.Effect_1_Transparency = 25;
            this.btnAdd.Effect_2 = false;
            this.btnAdd.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnAdd.Effect_2_Transparency = 20;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAdd.Lighting = false;
            this.btnAdd.LinearGradient_Background = true;
            this.btnAdd.LinearGradientPen = true;
            this.btnAdd.Location = new System.Drawing.Point(441, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PenWidth = 15;
            this.btnAdd.RGB = true;
            this.btnAdd.Rounding = true;
            this.btnAdd.RoundingInt = 70;
            this.btnAdd.Size = new System.Drawing.Size(372, 75);
            this.btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Tag = "Cyber";
            this.btnAdd.TextButton = "Add";
            this.btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAdd.Timer_Effect_1 = 5;
            this.btnAdd.Timer_RGB = 300;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbIsAvailableForRent
            // 
            this.cbIsAvailableForRent.AutoRoundedCorners = true;
            this.cbIsAvailableForRent.BackColor = System.Drawing.Color.Transparent;
            this.cbIsAvailableForRent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbIsAvailableForRent.BorderRadius = 17;
            this.cbIsAvailableForRent.BorderThickness = 2;
            this.cbIsAvailableForRent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsAvailableForRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsAvailableForRent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsAvailableForRent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsAvailableForRent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsAvailableForRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIsAvailableForRent.ItemHeight = 30;
            this.cbIsAvailableForRent.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsAvailableForRent.Location = new System.Drawing.Point(988, 510);
            this.cbIsAvailableForRent.Name = "cbIsAvailableForRent";
            this.cbIsAvailableForRent.Size = new System.Drawing.Size(123, 36);
            this.cbIsAvailableForRent.TabIndex = 20;
            // 
            // nudPricePerDay
            // 
            this.nudPricePerDay.AutoRoundedCorners = true;
            this.nudPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.nudPricePerDay.BorderRadius = 17;
            this.nudPricePerDay.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.nudPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPricePerDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudPricePerDay.Location = new System.Drawing.Point(308, 510);
            this.nudPricePerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPricePerDay.Name = "nudPricePerDay";
            this.nudPricePerDay.Size = new System.Drawing.Size(103, 36);
            this.nudPricePerDay.TabIndex = 21;
            this.nudPricePerDay.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.nudPricePerDay.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Animated = true;
            this.txtPlateNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlateNumber.BorderRadius = 20;
            this.txtPlateNumber.BorderThickness = 2;
            this.txtPlateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNumber.DefaultText = "";
            this.txtPlateNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlateNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNumber.Location = new System.Drawing.Point(189, 385);
            this.txtPlateNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PasswordChar = '\0';
            this.txtPlateNumber.PlaceholderText = "";
            this.txtPlateNumber.SelectedText = "";
            this.txtPlateNumber.Size = new System.Drawing.Size(318, 40);
            this.txtPlateNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPlateNumber.TabIndex = 23;
            this.txtPlateNumber.TextChanged += new System.EventHandler(this.txtPlateNumber_TextChanged);
            this.txtPlateNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateNumber_KeyPress);
            // 
            // foreverLabel8
            // 
            this.foreverLabel8.AutoSize = true;
            this.foreverLabel8.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel8.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel8.ForeColor = System.Drawing.Color.Black;
            this.foreverLabel8.Location = new System.Drawing.Point(17, 401);
            this.foreverLabel8.Name = "foreverLabel8";
            this.foreverLabel8.Size = new System.Drawing.Size(155, 39);
            this.foreverLabel8.TabIndex = 22;
            this.foreverLabel8.Text = "Plate Number:";
            // 
            // frmAddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 726);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.foreverLabel8);
            this.Controls.Add(this.nudPricePerDay);
            this.Controls.Add(this.cbIsAvailableForRent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.foreverLabel10);
            this.Controls.Add(this.foreverLabel7);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.foreverLabel6);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.foreverLabel5);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.foreverLabel4);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.foreverLabel3);
            this.Controls.Add(this.foreverLabel2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.foreverLabel1);
            this.Controls.Add(this.txtMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewVehicle";
            this.Text = "frmAddNewVehicle";
            this.Load += new System.EventHandler(this.frmAddNewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMake;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpYear;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbFuelType;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cbCarType;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel7;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel10;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsAvailableForRent;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNumber;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel8;
    }
}