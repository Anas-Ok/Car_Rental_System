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
    public partial class frmShowBookingInfo : Form
    {
        public int BookingId { get; set; }
        public frmShowBookingInfo(int bookingId)
        {
            InitializeComponent();

            BookingId = bookingId;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookingInfo_Load(object sender, EventArgs e)
        {
            clsBooking booking = clsBooking.Find(BookingId);

            ctrlShowBookingInfo1.Load(booking);

        }

    }
}
