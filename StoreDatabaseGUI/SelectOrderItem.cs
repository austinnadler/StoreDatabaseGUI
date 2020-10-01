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
    public partial class SelectOrderItem : Form
    {
        private DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private int? orderId = null;
        private int? custId = null;

        public SelectOrderItem()
        {
            InitializeComponent();
        }

        public SelectOrderItem(int orderId, int custId, DataGridView orderItemDgv)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.custId = custId;
            txtOrderId.Text = orderId.ToString();
        }

        private void dgvItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItems.Rows[e.RowIndex];
                txtItemId.Text = row.Cells[0].Value.ToString();
                txtMfg.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtQty.Text = "1";
            }
        }

        private void SelectOrderItem_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            try
            {
                string queryString = "select * from item";

                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                da.Fill(dataTable);
                connection.Close();
                da.Dispose();
                dgvItems.DataSource = dataTable; // Put the DataTable into the DataGridView

                // Format the dgv
                dgvItems.AutoResizeColumns();
                dgvItems.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemId.Text = "";
            txtMfg.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            dgvItems.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text != "")
            {
                try
                {
                    string queryString = "insert into order_item (order$id, customer$id, item$id, qty) values (@OrderId, @CustId, @ItemId, @Qty)";
                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@CustId", custId);
                    command.Parameters.AddWithValue("@ItemId", Convert.ToInt32(txtItemId.Text));
                    command.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQty.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
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
                MessageBox.Show("Customer ID is required.", "Invalid insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
