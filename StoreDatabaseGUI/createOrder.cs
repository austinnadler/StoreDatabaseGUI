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
    public partial class createOrder : Form
    {
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private OrderViewForm parent = null;

        public createOrder(OrderViewForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region Utilities
        private void enableSubmit()
        {
            if (txtCustomerId.Text != "" && txtTotalPrice.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }
        #endregion

        #region Events
        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgvOrderItems.DataSource = null;
            SelectOrderItems child = new SelectOrderItems(this);
            child.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtTotalPrice.Text != "") // if inserting new customer
            {
                try
                {
                    string queryString = "insert into [order] (customer$id, status, totalPrice, created) values (@CustomerId, @Status, @TotalPrice, @Created) select scope_identity()";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
                    command.Parameters.AddWithValue("@Status", "Received");
                    command.Parameters.AddWithValue("@TotalPrice", txtTotalPrice.Text);
                    command.Parameters.AddWithValue("@Created", DateTime.Now.ToString());
                    connection.Open();
                    int orderId = Convert.ToInt32(command.ExecuteScalar());
                    command.Parameters.Clear();

                    queryString = "insert into [order_item] (order$id, item$id, customer$id, qty) values (@OrderId, @ItemId, @CustomerId, @Qty)";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
                    command.Parameters.Add("@ItemId", SqlDbType.Int);
                    command.Parameters.Add("@Qty", SqlDbType.Int);
                    for(int i = 0; i < dgvOrderItems.Rows.Count; i++)
                    {
                        command.Parameters["@ItemId"].Value = Convert.ToInt32(dgvOrderItems.Rows[i].Cells[1].Value);
                        command.Parameters["@Qty"].Value = Convert.ToInt32(dgvOrderItems.Rows[i].Cells[4].Value);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Don't do anything, no row is selected
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NewOrder_Close(object sender, FormClosingEventArgs e)
        {
            parent.loadOrders();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            txtCustomerId.ReadOnly = true;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            SelectOrderCustomer sc = new SelectOrderCustomer(this);
            sc.Show();
        }

        #endregion

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
        }

        private void dgvOrderItems_SelectionChanged(object sender, EventArgs e)
        {
            dgvOrderItems.ClearSelection();
        }

        
    }
}
