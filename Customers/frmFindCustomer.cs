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
    public partial class frmFindCustomer : Form
    {
        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            dgvVehicles.DataSource = clsCustomer.GetAllCustomers();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dgvVehicles.DataSource = clsCustomer.GetAllCustomers();
            }
            else
            {
                if (cbCategory.SelectedIndex == 0)
                {
                    dgvVehicles.DataSource = clsCustomer.GetCustomersByID(Convert.ToInt32(txtSearch.Text));
                }
                else
                {
                   dgvVehicles.DataSource = clsCustomer.GetCustomersByName(txtSearch.Text);
                }
            }
        }
    }
}
