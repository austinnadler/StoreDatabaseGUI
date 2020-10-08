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
using StoreDatabaseGUI;

namespace Customer_and_Order_Management
{
    public partial class SelectOrderCustomer : Form
    {
        private DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private int? customerId = null;
        private string customerName = null;
        
        createOrder createOrderParent = null;
        OrderViewForm crudOrderParent = null;

        public SelectOrderCustomer(createOrder createOrderParent)
        {
            InitializeComponent();
            this.createOrderParent = createOrderParent;
        }

        public SelectOrderCustomer(OrderViewForm crudOrderParent)
        {
            InitializeComponent();
            this.crudOrderParent = crudOrderParent;
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

                if (txtSearchString.Text != "")
                {
                    queryString += $" where concat(id, ' ', lastName, ', ', firstName,' ', phoneNumber,' ', streetAddress, ' ', city, ' ', state, ' ', zip) like @Search";
                    command = new SqlCommand(queryString, connection); // reassign with new queryString
                    command.Parameters.AddWithValue("@Search", $"%{txtSearchString.Text}%");
                }

                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                connection.Open();
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

        private void selectCustomer() // set the parents customer id fields

        {
            if(dgvCustomer.CurrentCell != null)
            {
                customerId = (int)dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[0].Value;
                customerName = (string)dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[1].Value;
                if (createOrderParent != null)
                {
                    createOrderParent.txtCustomerId.Text = customerId.ToString();
                    createOrderParent.txtCustomerName.Text = customerName;
                }
                else if(crudOrderParent != null)
                {
                    crudOrderParent.txtCustomerId.Text = customerId.ToString();
                    crudOrderParent.txtCustomerName.Text = customerName;
                }

                
                this.Close();
            }
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerViewForm child = new CustomerViewForm(this);
            child.Show();
        }

        private void SelectCustomerForOrderForm_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
