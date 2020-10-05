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
        private DataTable itemDataTable = new DataTable();
        private DataTable cartDataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private int? orderId = null;
        private int? custId = null;
        private int cartSize = 0;
        NewOrderForm parent = null;

        public SelectOrderItem(NewOrderForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public SelectOrderItem(int orderId, int custId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.custId = custId;
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
            cartDataTable.Columns.Add(new DataColumn("Cart ID"));
            
            cartDataTable.Columns.Add(new DataColumn("Item ID"));
            cartDataTable.Columns.Add(new DataColumn("Item Name"));
            cartDataTable.Columns.Add(new DataColumn("Price"));
            cartDataTable.Columns.Add(new DataColumn("Qty"));
            dgvCart.DataSource = cartDataTable;
            itemDataTable.Clear();
            try
            {
                string queryString = "select id as 'Item ID', manufacturer as 'Manufacturer', name as 'Name', price as 'Price' from item";

                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                da.Fill(itemDataTable);
                connection.Close();
                da.Dispose();

                dgvItems.DataSource = itemDataTable; // Put the DataTable into the DataGridView

                // Format the dgv
                dgvItems.AutoResizeColumns();
                dgvItems.ClearSelection();
                dgvCart.Columns[0].Visible = false;
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
            dgvCart.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToCart();
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addToCart();
        }

        private void addToCart()
        {
            if (txtItemId.Text != "" || dgvItems.CurrentCell.RowIndex < 0)
            {
                DataRow row = cartDataTable.NewRow();
                row[0] = ++cartSize;
                row[1] = txtItemId.Text;
                row[2] = txtName.Text;
                row[3] = txtPrice.Text;
                row[4] = txtQty.Text;
                cartDataTable.Rows.Add(row);
                dgvCart.AutoResizeColumns();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeFromCart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            for(int i = 0; i < cartSize; i++)
            {
                totalPrice += Convert.ToDouble(cartDataTable.Rows[i]["Price"]) * Convert.ToDouble(cartDataTable.Rows[i]["Qty"]);
            }
            parent.txtTotalPrice.Text = totalPrice.ToString();
            parent.dgvOrderItems.DataSource = cartDataTable;
            this.Close();
        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removeFromCart();
        }

        private void removeFromCart()
        {
            cartDataTable.Rows.RemoveAt(dgvCart.CurrentCell.RowIndex);
            dgvCart.AutoResizeColumns();
            cartSize--;
        }
    }
}
