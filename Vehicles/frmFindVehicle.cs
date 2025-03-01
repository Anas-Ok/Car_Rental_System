using Car_Rental_BusinessL;
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
    public partial class frmFindVehicle : Form
    {
        public frmFindVehicle()
        {
            InitializeComponent();

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvVehicles.DataSource = clsVehicle.GetAllVehicles();
                return;
            }

            if (cbCategory.SelectedIndex == 0)
            {
                dgvVehicles.DataSource = clsVehicle.GetVehicleListByID(Convert.ToInt32(txtSearch.Text));
            }
            else if (cbCategory.SelectedIndex == 1)
            {
                dgvVehicles.DataSource = clsVehicle.GetVehicleListByPlateNumber(txtSearch.Text);
            }
            else if (cbCategory.SelectedIndex == 2)
            {
                dgvVehicles.DataSource = clsVehicle.GetVehicleListByMake(txtSearch.Text);
            }
            else if (cbCategory.SelectedIndex == 3)
            {
                dgvVehicles.DataSource = clsVehicle.GetVehicleListByModel(txtSearch.Text);
            }
            else if (cbCategory.SelectedIndex == 4)
            {
                dgvVehicles.DataSource = clsVehicle.GetVehicleListByYear(Convert.ToInt32(txtSearch.Text));
            }
            else if (cbCategory.SelectedIndex == 5)
            {
                dgvVehicles.DataSource = clsVehicle.GetAllAvailableVehicles();
            }
        }

        private void frmFindVehicle_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
        }
    }
}
