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
    public partial class frmTransactionBooking : Form
    {
        private int BookingID { get; set; }
        public frmTransactionBooking(int bookingid)
        {
            InitializeComponent();

            BookingID = bookingid;
        }

        private void frmTransactionBooking_Load(object sender, EventArgs e)
        {
            clsBooking booking = clsBooking.Find(BookingID);

            lblBookingID.Text = booking.BookingID.ToString();
            lblInitialTotalDueAmount.Text = booking.InitialTotalDueAmount.ToString();


        }
    }
}
