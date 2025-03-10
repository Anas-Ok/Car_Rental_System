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
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void ClearControls()
        {
            txtName.Text = "";
            txtContactInformation.Text = "";
            txtDriverLicenseNumber.Text = "";      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtContactInformation.Text == "" || txtDriverLicenseNumber.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }   

            clsCustomer customer = new clsCustomer();

            customer.Name = txtName.Text;
            customer.ContactInformation = txtContactInformation.Text;
            customer.DriverLicenseNumber = txtDriverLicenseNumber.Text;

            if (customer.Save())
            {
                lblCustomerID.Text = customer.CustomerID.ToString();
                lblCustomerName.Text = customer.Name;
                lblContactInformation.Text = customer.ContactInformation;
                lblDriverLicenseNumber.Text = customer.DriverLicenseNumber;

                MessageBox.Show("Customer added successfully");
                ClearControls();
            }
            else
            {
                MessageBox.Show("An error occurred while adding the customer");
            }
        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {

        }

     
     
    }
}
