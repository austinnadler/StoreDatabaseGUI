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
using Customer_and_Order_Management;

namespace StoreDatabaseGUI
{
    public partial class OrderViewForm : Form
    {
        DataTable OrderDataTable = new DataTable();
        DataTable OrderItemDataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";

        public OrderViewForm()
        {
            InitializeComponent();
        }



    #region Utilities
        public void loadOrders()
        {
            OrderDataTable.Clear();
            try
            {
                string queryString = "select o.id as 'Order ID', o.customer$id as 'Customer ID', CONCAT(c.lastName, ', ', c.firstName) as 'Customer', o.status as 'Status', o.totalPrice as 'Total price', o.created as 'Created on', o.updated as 'Updated on'  from [order] as o, customer as c where o.customer$id=c.id";
                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da

                da.Fill(OrderDataTable);
                connection.Close();
                da.Dispose();
                dgvOrders.DataSource = OrderDataTable; // Put the DataTable into the DataGridView

                // Format the dgv
                dgvOrders.AutoResizeColumns();
                dgvOrders.ClearSelection();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadOrderItems(int orderId) // Load order_item data for selected order into the top-right dgv
        {

            OrderItemDataTable.Clear();
            try
            {
                string orderItemsQueryString = "select i.id as 'Item ID', i.name as 'Item', i.price as 'Price', oi.qty as 'Quantity' from [order] as o, [order_item] as oi, [item] as i where o.id = oi.order$id and oi.item$id = i.id and o.id=@OrderId";
                SqlConnection orderItemConnection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand orderItemCommand = new SqlCommand(orderItemsQueryString, orderItemConnection);   // Create a SQL command with the query to be ran, and the database connection
                orderItemConnection.Open();
                SqlDataAdapter orderItemDa = new SqlDataAdapter(orderItemCommand); // Create a SqlDataAdapter and run the command, putting the result set in da
                orderItemCommand.Parameters.Add("@OrderId", SqlDbType.Int);
                orderItemCommand.Parameters["@OrderId"].Value = Convert.ToInt32(txtOrderId.Text);

                orderItemDa.Fill(OrderItemDataTable);
                orderItemConnection.Close();
                orderItemDa.Dispose();
                dgvOrderItems.DataSource = OrderItemDataTable; // Put the DataTable into the DataGridView

                dgvOrderItems.AutoResizeColumns();
                dgvOrderItems.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFields()
        {
            txtOrderId.Text = "";
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            cboOrderStatus.Text = null;
            txtTotalPrice.Text = "";
            txtCreatedOn.Text = "";
            txtUpdatedOn.Text = "";
        }
        #endregion

    #region Events
        private void Orders_Load(object sender, EventArgs e)
        {
            loadOrders();
            btnDeleteOrder.Enabled = false; // property editor not working for some reason so disable this button on load
        }

        private void dgvOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentCell != null)
            {
                DataGridViewRow row = dgvOrders.Rows[dgvOrders.CurrentCell.RowIndex];
                txtOrderId.Text = row.Cells[0].Value.ToString();
                txtCustomerId.Text = row.Cells[1].Value.ToString();
                txtCustomerName.Text = row.Cells[2].Value.ToString();
                cboOrderStatus.Text = row.Cells[3].Value.ToString();
                txtTotalPrice.Text = row.Cells[4].Value.ToString();
                txtCreatedOn.Text = row.Cells[5].Value.ToString();
                txtUpdatedOn.Text = row.Cells[6].Value.ToString();
                loadOrderItems(Convert.ToInt32(txtOrderId.Text));
                btnDeleteOrder.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            dgvOrders.ClearSelection();
            OrderItemDataTable.Clear();
            dgvOrderItems.Refresh();
            btnDeleteOrder.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtOrderId.Text != "")
            {
                try
                {
                    string queryString = "update [order] set status=@Status, updated=@UpdatedOn where id=@OrderId";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                    command.Parameters.AddWithValue("@Status", cboOrderStatus.Text);
                    command.Parameters.AddWithValue("@UpdatedOn", DateTime.Now.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    loadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text != "")
            {
                try
                {
                    DialogResult msg = MessageBox.Show($"Are you sure you want to delete order {txtOrderId.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string queryString = "delete from [order] where id=@OrderId delete from [order_item] where order$id=@OrderId";
                        SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                        SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                        command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(txtOrderId.Text));
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        loadOrders();
                        OrderItemDataTable.Clear();
                        dgvOrderItems.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm no = new NewOrderForm(this);
            no.Show();
        }
        #endregion


    }
}
