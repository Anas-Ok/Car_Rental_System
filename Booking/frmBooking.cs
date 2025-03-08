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
    public partial class frmBooking : Form
    {
        public int CustomerID { get; set; }
        public frmBooking(int customerID)
        {
            InitializeComponent();

            CustomerID = customerID;

        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsVehicle.GetAllAvailableVehicles();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbAllVehicles.Items.Add(row["Make"]);
            }
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
            cbAllVehicles.SelectedIndex = 0;
            dtpStartDate.MinDate = DateTime.Now;
            dtpEndDate.MinDate = DateTime.Now;

            clsCustomer customer = clsCustomer.Find(CustomerID);
            lblCustomerID.Text = CustomerID.ToString();

        }

        private void cbAllVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int? VehicleID = clsVehicle.FindByMake(GetSelectedMake()).VehicleID;
            frmShowVehicleInfo frm = new frmShowVehicleInfo(VehicleID);
            frm.ShowDialog();
        }

        private string GetSelectedMake()
        {
            return cbAllVehicles.SelectedItem?.ToString();
        }

        private void EnabledControls(bool enabled)
        {
            dtpStartDate.Enabled = enabled;
            dtpEndDate.Enabled = enabled;
            txtPickUpLocation.Enabled = enabled;
            txtDropOffLocation.Enabled = enabled;
            txtInitialCheckNotes.Enabled = enabled;
            btnBook.Enabled = enabled;
        }

        private void FillInfo(clsBooking booking)
        {
            lblInitialRentalDays.Text = booking.InitialRentalDays.ToString();
            lblRentalPricePerDay.Text = booking.RentalPricePerDay.ToString();
            lblInitialTotalDueAmount.Text = booking.InitialTotalDueAmount.ToString();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if(dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Start date must be before end date");
                return;
            }

            if(txtDropOffLocation.Text == "" || txtPickUpLocation.Text == "")
            {
                MessageBox.Show("Please fill both pick up and drop off Locations");
                return;
            }

            clsBooking booking = new clsBooking();


            booking.CustomerID = CustomerID;
            booking.VehicleID = clsVehicle.FindByMake(GetSelectedMake()).VehicleID;
            
            clsVehicle vehicle = clsVehicle.Find(booking.VehicleID);

            booking.RentalStartDate = dtpStartDate.Value;
            booking.RentalEndDate = dtpEndDate.Value;
            booking.PickupLocation = txtPickUpLocation.Text;
            booking.DropoffLocation = txtDropOffLocation.Text;
            booking.InitialCheckNotes = txtInitialCheckNotes.Text;
            booking.RentalPricePerDay = vehicle.RentalPricePerDay;

            if (booking.AddNewBooking())
            {
                booking = clsBooking.Find(booking.BookingID.Value);
              
                FillInfo(booking);

                MessageBox.Show("Booking added successfully");


                EnabledControls(false);
            }
            else
            {
                MessageBox.Show("An error occurred while adding the booking");
            }
        }
    }
}
