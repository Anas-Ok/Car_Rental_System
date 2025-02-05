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

namespace Car_Rental_System
{
    public partial class frmDeleteVehicle : Form
    {
        public frmDeleteVehicle()
        {
            InitializeComponent();
        }

        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void frmDeleteVehicle_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                return;
            }

            if (cbCategory.SelectedIndex == 0)
            {
                ctrlVehicleInfo1.Load(Convert.ToInt32(txtSearch.Text));
            }
            else 
            {
                ctrlVehicleInfo1.Load(txtSearch.Text); 
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsVehicle vehicle = clsVehicle.Find(ctrlVehicleInfo1.VehicleID);
                if (vehicle != null)
                {
                    vehicle.Delete();
                    MessageBox.Show("Vehicle has been deleted successfully.",  "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
