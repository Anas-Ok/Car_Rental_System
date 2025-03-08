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
    public partial class ctrlShowBookingInfo : UserControl
    {
        public ctrlShowBookingInfo()
        {
            InitializeComponent();
        }

        public void Load(clsBooking booking)
        {
            lbBookingID.Text = booking.BookingID.ToString();
            lblCustomerID.Text = booking.CustomerID.ToString();
            lblPickUpLocation.Text = booking.PickupLocation;
            lblDropOffLocation.Text = booking.DropoffLocation;
            lblIntialCheckNotes.Text = booking.InitialCheckNotes;
            lblVehicleID.Text = booking.CustomerID.ToString();
            lblRentalStartDate.Text = booking.RentalStartDate?.ToString("dd/MM/yyyy");
            lblRentalStartDate.Text = booking.RentalEndDate?.ToString("dd/MM/yyyy");
            lblInitialRentalDays.Text = booking.InitialRentalDays.ToString();
            lblRentalPricePerDay.Text = booking.RentalPricePerDay.ToString();
            lblInitialTotalDueAmount.Text = booking.InitialTotalDueAmount.ToString();
        }

        private void ctrlShowBookingInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
