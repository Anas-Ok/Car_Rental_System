using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_BusinessL;
using ReaLTaiizor.Forms;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }



        void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Clear();
            panelForm.Controls.Add(form);
            form.Show();
        }

     

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            test testForm = new test();
            ShowFormInPanel(testForm);

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            VehicleMain main = new VehicleMain();

            ShowFormInPanel(main);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            frmCustomerMain main = new frmCustomerMain();

            ShowFormInPanel(main);
        }
    }
}
