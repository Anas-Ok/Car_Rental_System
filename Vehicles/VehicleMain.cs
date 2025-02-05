using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class VehicleMain : Form
    {
        public VehicleMain()
        {
            InitializeComponent();
            ShowFormInPanel(new frmVehicleList());
        }
        void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelchild.Controls.Clear();
            panelchild.Controls.Add(form);
            form.Show();
        }
        private void btnVehicleList_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmVehicleList());
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddNewVehicle());

        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmDeleteVehicle());

        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmFindVehicle());

        }
    }
}
