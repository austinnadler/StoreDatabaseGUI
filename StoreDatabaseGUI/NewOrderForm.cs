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
    public partial class NewOrderForm : Form
    {
        DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private OrderViewForm parent = null;
        private int? orderItemId = null;

        public NewOrderForm(OrderViewForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void clearFields()
        {
            txtOrderId.Text = txtCustomerId.Text = txtCustomerName.Text = null;
        }
    #region Utilities
        private void loadData()
        {
            if(txtOrderId.Text != "")
            {
                dataTable.Clear();
                try
                {
                    string queryString = $"select oi.item$id as 'Item ID', i.name as 'Item name', i.price as 'Item Price', oi.qty as 'Quantity' from order_item as oi, item as i where oi.order$id=@OrderId and oi.item$id = i.id";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    connection.Open();
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                    SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                    da.Fill(dataTable);
                    connection.Close();
                    da.Dispose();
                    dgvOrderItems.DataSource = dataTable; // Put the DataTable into the DataGridView

                    // Format the dgv
                    dgvOrderItems.AutoResizeColumns();
                    dgvOrderItems.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

    #region Events
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrderItems.Rows[e.RowIndex];
                int orderItemId = (int)row.Cells[0].Value;

            }
        }

         private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtOrderId.Text != "")
            {
                SelectOrderItem soi = new SelectOrderItem(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtCustomerId.Text), dgvOrderItems);
                soi.Show();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                try
                {
                    string queryString = $"insert into [order] (customer$id, created) values (@CustomerId ,GETDATE()) select SCOPE_IDENTITY()";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    connection.Open();
                    command.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(txtCustomerId.Text));
                    int orderId = Convert.ToInt32(command.ExecuteScalar());
                    txtOrderId.Text = orderId.ToString();
                    connection.Close();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer ID is required.", "Invalid insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text != "")
            {
                try
                {
                    DataTable temp = new DataTable();
                    string queryString = $"update [order] set customer$id=@CustomerId, status='Received', created=GETDATE() where id=@OrderId select SCOPE_IDENTITY()";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(txtCustomerId.Text));
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                    connection.Open();
                    command.ExecuteScalar();

                    queryString = $"select distinct i.price, oi.qty from item as i, order_item as oi, [order] as o where oi.item$id = i.id and order$id=@OrderId";
                    command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                    SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                    da.Fill(temp);
                    decimal orderPrice = 0;
                    for(int i = 0; i < temp.Rows.Count; i++)
                    {
                        orderPrice += Convert.ToDecimal(temp.Rows[i][0].ToString()) * Convert.ToDecimal(temp.Rows[i][1].ToString());
                    }
                    connection.Close();
                    da.Dispose();

                    queryString = $"update [order] set customer$id=@CustomerId, status='Received', totalPrice=@Price, created=GETDATE() where id=@OrderId select SCOPE_IDENTITY()";
                    connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(txtCustomerId.Text));
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                    command.Parameters.AddWithValue("@Price", orderPrice);
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();

                    connection.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Order ID is required.", "Invalid insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NewOrder_Close(object sender, FormClosingEventArgs e)
        {
            parent.loadOrders();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (orderItemId != null)
            {
                string queryString = $"delete from [order_item] where order$id=@OrderId";
                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                loadData();
            }
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            txtCustomerId.ReadOnly = true;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            SelectCustomerForOrderForm sc = new SelectCustomerForOrderForm(this);
            sc.Show();
        }


        private void dgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrderItems.Rows[e.RowIndex];
                orderItemId = (int)row.Cells[0].Value;
            }
        }
        #endregion

        private void NewOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
