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
using System.Text.RegularExpressions;

namespace Customer_and_Order_Management
{
    public partial class ItemManagementForm : Form
    {

        private DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";

        public ItemManagementForm()
        {
            InitializeComponent();
        }
    #region Utilities
        private void loadData()
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

        private void clearFields()
        {
            txtId.Text = "";
            txtMfg.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            dgvItems.ClearSelection();
        }
        #endregion

    #region Events
        private void ItemManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItems.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtMfg.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        string previousInput = "";
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(txtPrice.Text);
            if (m.Success || txtId.Text == "")
            {
               previousInput = txtPrice.Text;
            }
            else
            {
                txtPrice.Text = previousInput;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMfg.Text != "" && txtName.Text != "" && txtPrice.Text !="")
            {
                if (txtId.Text == "") // if creating new item
                {
                    try
                    {
                        string queryString = "insert into item (manufacturer, name, price) values (@Mfg, @Name, @Price)";

                        SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                        SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                        command.Parameters.AddWithValue("@Mfg", txtMfg.Text);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        loadData();
                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // if updating existing item
                {
                    try
                    {
                        string queryString = "update item set manufacturer=@Mfg, name=@Name, price=@Price where id=@Id";

                        SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                        SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                        command.Parameters.AddWithValue("@Mfg", txtMfg.Text);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        loadData();
                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                try
                {
                    string queryString = "delete from item where id=@Id";

                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    loadData();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                try
                {
                    string queryString = "insert into item (manufacturer, name, price) values (@Mfg, @Name, @Price)";

                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    command.Parameters.AddWithValue("@Mfg", txtMfg.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    loadData();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    #endregion
    }
}
