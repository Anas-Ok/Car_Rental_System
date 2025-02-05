using Car_Rental_BusinessL;
using Car_Rental_System.Vehicles;
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
    public partial class frmVehicleList : Form
    {
        public enum enIsAvailable { NotAvailable = 0, Available = 1 };
        public enIsAvailable IsAvailable = enIsAvailable.Available;

        public frmVehicleList()
        {
            InitializeComponent();
        }
       

        private void frmVehicleList_Load(object sender, EventArgs e)
        {
            dgvVehicles.DataSource = clsVehicle.GetAllVehicles();
            if (dgvVehicles.Rows.Count > 0)
            {

                dgvVehicles.Columns[0].HeaderText = "Vehicle ID";
                dgvVehicles.Columns[0].Width = 80;

                dgvVehicles.Columns[1].HeaderText = "Make";
                dgvVehicles.Columns[1].Width = 60;


                dgvVehicles.Columns[2].HeaderText = "Model";
                dgvVehicles.Columns[2].Width = 60;

                dgvVehicles.Columns[3].HeaderText = "Year";
                dgvVehicles.Columns[3].Width = 60;


                dgvVehicles.Columns[4].HeaderText = "Mileage";
                dgvVehicles.Columns[4].Width = 70;

                dgvVehicles.Columns[5].HeaderText = "Fuel Type ID";
                dgvVehicles.Columns[5].Width = 100;

                dgvVehicles.Columns[6].HeaderText = "Plate Number";
                dgvVehicles.Columns[6].Width = 100;

                dgvVehicles.Columns[7].HeaderText = "Car Category ID";
                dgvVehicles.Columns[7].Width = 110;

                dgvVehicles.Columns[8].HeaderText = "Rental Price Per Day";
                dgvVehicles.Columns[8].Width = 140;


                dgvVehicles.Columns[9].HeaderText = "Is Active";
                dgvVehicles.Columns[9].Width = 70;


            }

        }

        private void tsmShowInformation_Click(object sender, EventArgs e)
        {
            frmShowVehicleInfo frm = new frmShowVehicleInfo(Convert.ToInt32(dgvVehicles.CurrentRow.Cells[0].Value));

            frm.ShowDialog();
        }

        private void poisonContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(Convert.ToBoolean(dgvVehicles.CurrentRow.Cells[9].Value) == true)
            {
                tsmActive.Text = "Deactivate";
            }
            else
            {
                tsmActive.Text = "Activate";
            }
        }

        private void tsmActive_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgvVehicles.CurrentRow.Cells[9].Value) == true)
            {
                clsVehicle.UpdateVehicleAvailability(Convert.ToInt32(dgvVehicles.CurrentRow.Cells[0].Value), false);
            }
            else
            {
                clsVehicle.UpdateVehicleAvailability(Convert.ToInt32(dgvVehicles.CurrentRow.Cells[0].Value), true);
            }

            frmVehicleList_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsVehicle vehicle = clsVehicle.Find(Convert.ToInt32(dgvVehicles.CurrentRow.Cells[0].Value));
                if (vehicle != null)
                {
                    vehicle.Delete();
                    MessageBox.Show("Vehicle has been deleted successfully.", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            frmVehicleList_Load(null, null);
        }
    }
}
