using Customer_and_Order_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDatabaseGUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerViewForm c = new CustomerViewForm();
            c.Show();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            OrderViewForm o = new OrderViewForm();
            o.Show();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            crudItems imf = new crudItems();
            imf.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
