using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Car_Rental_BusinessL;

namespace Car_Rental_System
{
    public partial class frmShowBookings : Form
    {
        private DataTable bookingsTable;

        public frmShowBookings()
        {
            InitializeComponent();
        }

        private void frmShowBookings_Load(object sender, EventArgs e)
        {
            cbSearchCategory.SelectedIndex = 0;
            bookingsTable = clsBooking.GetAllBookings();
            FilterBookings();
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBookings();
        }

        private void FilterBookings()
        {
            DataView view = new DataView(bookingsTable);

            if (cbSearchCategory.SelectedIndex == 0)
            {
                view.RowFilter = string.Empty;
                tbSearch.Visible = true;
            }
            else if (cbSearchCategory.SelectedIndex == 2)
            {
                view.RowFilter = "IsActive = 1";
                tbSearch.Visible = false;
            }

            dgvAllBookings.DataSource = view;
        }



        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                dgvAllBookings.DataSource = clsBooking.GetAllBookings();
                return;
            }

            DataView view = new DataView(bookingsTable);

            if (cbSearchCategory.SelectedIndex == 1)
            {
                tbSearch.Visible = true;

                if (int.TryParse(tbSearch.Text, out int CustomerID))
                {
                    view.RowFilter = $"CustomerID = {CustomerID}";
                }
                else
                {
                    view.RowFilter = "CustomerID = -1";
                }

            }
            else if (cbSearchCategory.SelectedIndex == 0)
            {
                tbSearch.Visible = true;

                view.RowFilter = $"VehicleID = {tbSearch.Text}";
            }

            dgvAllBookings.DataSource = view;
        }

        private void tsmShowInformation_Click(object sender, EventArgs e)
        {
            frmShowBookingInfo frm = new frmShowBookingInfo(Convert.ToInt32(dgvAllBookings.CurrentRow.Cells[0].Value));

            frm.ShowDialog();
        }
    }
}
