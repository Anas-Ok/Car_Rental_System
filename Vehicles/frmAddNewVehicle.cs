using Car_Rental_BusinessL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class frmAddNewVehicle : Form
    {
        public frmAddNewVehicle()
        {
            InitializeComponent();
        }

        private void _FillFuelTypesInComoboBox()
        {
            DataTable dtFuelTypes = clsFuelTypes.GetAllFuelTypes();

            foreach (DataRow row in dtFuelTypes.Rows)
            {
                cbFuelType.Items.Add(row["FuelType"]);
            }
            cbFuelType.SelectedIndex = 0;
        }

        private void _ClearInputs()
        {
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPlateNumber.Text = "";
            nudPricePerDay.Value = 0;
        }

        private void _FillCarTypesInComoboBox()
        {
            DataTable dtFuelTypes = clsCarCategory.GetAllCarCategories();

            foreach (DataRow row in dtFuelTypes.Rows)
            {
                cbCarType.Items.Add(row["CategoryName"]);
            }
            cbCarType.SelectedIndex = 0;
            cbIsAvailableForRent.SelectedIndex = 0;
        }

        private void frmAddNewVehicle_Load(object sender, EventArgs e)
        {
            _FillFuelTypesInComoboBox();
            _FillCarTypesInComoboBox();

            dtpYear.MinDate = DateTime.Now.AddYears(-80);
            dtpYear.MaxDate = DateTime.Now.AddYears(0);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsVehicle.IsPlateNumberExist(txtPlateNumber.Text))
            {
                MessageBox.Show("Plate number already exists");
                return;

            }

            if (txtMake.Text == "" || txtModel.Text == "" ||  txtMileage.Text == "" ||  txtPlateNumber.Text == "" || nudPricePerDay.Value == 0)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            clsVehicle vehicle = new clsVehicle();

            vehicle.Make = txtMake.Text;
            vehicle.Model = txtModel.Text;
            vehicle.Year = dtpYear.Value.Year;
            if (int.TryParse(txtMileage.Text, out int mileage))
            {
                vehicle.Mileage = mileage;
            }
            else
            {
                MessageBox.Show("Mileage must be a number");
                return;
            }

            vehicle.FuelTypeID = cbFuelType.SelectedIndex + 1;
            vehicle.PlateNumber = txtPlateNumber.Text;
            vehicle.CarCategoryID = cbCarType.SelectedIndex + 1;
            if (decimal.TryParse(nudPricePerDay.Text, out decimal rentalPricePerDay))
            {
                vehicle.RentalPricePerDay = rentalPricePerDay;
            }
            else
            {
                MessageBox.Show("Rental Price Per Day must be a number");
                return;
            }

            if(cbIsAvailableForRent.SelectedIndex == 0)
            {
                vehicle.IsAvailableForRent = true;
            }
            else
            {
                vehicle.IsAvailableForRent = false;
            }

            if(vehicle.Save())
            {
                MessageBox.Show("Vehicle added successfully");
                _ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to add vehicle");
            }

        }

        private void txtMake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(clsVehicle.IsPlateNumberExist(txtPlateNumber.Text))
            {
                MessageBox.Show("Plate number already exists");
            }
        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
