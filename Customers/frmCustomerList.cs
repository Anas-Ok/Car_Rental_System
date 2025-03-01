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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();

            dgvAllCustomers.DataSource = clsCustomer.GetAllCustomers();
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CustomerID = Convert.ToInt32(dgvAllCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                clsCustomer.Delete(CustomerID);
                dgvAllCustomers.DataSource = clsCustomer.GetAllCustomers();
            }
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking frm = new frmBooking(Convert.ToInt32(dgvAllCustomers.SelectedRows[0].Cells["CustomerID"].Value));
            frm.ShowDialog();
        }
    }
}
