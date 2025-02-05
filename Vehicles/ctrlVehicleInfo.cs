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
    public partial class ctrlVehicleInfo : UserControl
    {
        public ctrlVehicleInfo()
        {
            InitializeComponent();
        }

        public int VehicleID { get; set; }

        public void Load(int ID)
        {
            clsVehicle vehicle = clsVehicle.Find(ID);

            if (vehicle != null)
            {
                VehicleID = vehicle.VehicleID;
                lblVehicleID.Text = vehicle.VehicleID.ToString();
                lblMake.Text = vehicle.Make;
                lblModel.Text = vehicle.Model;
                lblYear.Text = vehicle.Year.ToString();
                lblMileage.Text = vehicle.Mileage.ToString();
                lblFuelType.Text = clsFuelTypes.GetFuelTypeByID(vehicle.FuelTypeID).FuelType.ToString();
                lblVehicleType.Text = clsCarCategory.GetCarCategoryByID(vehicle.CarCategoryID).CategoryName.ToString();
                lblPlateNumber.Text = vehicle.PlateNumber;
                lblRentalPricePerDay.Text = vehicle.RentalPricePerDay.ToString();
                
                if(vehicle.IsAvailableForRent == true)
                {
                    lblIsAvailableForRent.Text = "Yes";
                }
                else
                {
                    lblIsAvailableForRent.Text = "No";
                }
            }

        }

        public void Load(string PlateNumber)
        {
            clsVehicle vehicle = clsVehicle.Find(PlateNumber);

            if (vehicle != null)
            {
                VehicleID = vehicle.VehicleID;
                lblVehicleID.Text = vehicle.VehicleID.ToString();
                lblMake.Text = vehicle.Make;
                lblModel.Text = vehicle.Model;
                lblYear.Text = vehicle.Year.ToString();
                lblFuelType.Text = clsFuelTypes.GetFuelTypeByID(vehicle.FuelTypeID).FuelType.ToString();
                lblMileage.Text = vehicle.Mileage.ToString();
                lblVehicleType.Text = clsCarCategory.GetCarCategoryByID(vehicle.CarCategoryID).CategoryName.ToString();
                lblPlateNumber.Text = vehicle.PlateNumber;
                lblRentalPricePerDay.Text = vehicle.RentalPricePerDay.ToString();

                if (vehicle.IsAvailableForRent == true)
                {
                    lblIsAvailableForRent.Text = "Yes";
                }
                else
                {
                    lblIsAvailableForRent.Text = "No";
                }
            }

        }

       

        private void ctrlVehicleInfo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
