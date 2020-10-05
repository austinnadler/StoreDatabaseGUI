using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_and_Order_Management
{
    public partial class SelectCustomerForOrderForm : Form
    {
        private DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        NewOrderForm parent = null;
        private int? customerId = null;
        private string customerName = null;

        public SelectCustomerForOrderForm(NewOrderForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

    #region Utilities
        private void loadData()
        {
            dataTable.Clear();
            try
            {
                string queryString = "select id as 'ID', CONCAT(lastName, ', ', firstName) as 'Name', phoneNumber as 'Phone number', streetAddress as 'Street address', city as 'City', state as 'State', zip as 'ZIP' from customer";

                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                da.Fill(dataTable);
                connection.Close();
                da.Dispose();
                dgvCustomer.DataSource = dataTable; // Put the DataTable into the DataGridView

                // Format the dgv
                dgvCustomer.AutoResizeColumns();
                dgvCustomer.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    #region Events
        private void SelectCustomerForOrderForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectCustomer();
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentCell != null)
            {
                DataGridViewRow row = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex];
                customerId = (int)row.Cells[0].Value;
                customerName = (string)row.Cells[1].Value;
            }
        }
        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCustomer();
        }

        private void selectCustomer()
        {
            if(dgvCustomer.CurrentCell != null)
            {
                customerId = (int)dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[0].Value;
                customerName = (string)dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[1].Value;
                parent.txtCustomerId.Text = customerId.ToString();
                parent.txtCustomerName.Text = customerName;
                this.Close();
            }
        }
        #endregion


    }
}
