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
    public partial class frmCustomerMain : Form
    {
        public frmCustomerMain()
        {
            InitializeComponent();

            ShowFormInPanel(new frmCustomerList());
        }

        void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelchild.Controls.Clear();
            panelchild.Controls.Add(form);
            form.Show();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmCustomerList());
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddNewCustomer());
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmFindCustomer());
        }
    }
}
