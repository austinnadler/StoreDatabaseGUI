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
    public partial class crudItems : Form
    {

        private DataTable dataTable = new DataTable();
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";

        public crudItems()
        {
            InitializeComponent();
        }
    #region Utilities
        private void loadData()
        {
            dataTable.Clear();
            try
            {
                string queryString = "select id as 'ID', manufacturer as 'Manufacturer', name as 'Name', price as 'Price' from item";

                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection

                if (txtSearchString.Text != "")
                {
                    queryString += $" where concat(id, manufacturer, name, price) like @Search";
                    command = new SqlCommand(queryString, connection); // reassign with new queryString
                    command.Parameters.AddWithValue("@Search", $"%{txtSearchString.Text}%");
                }

                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                connection.Open();
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

        private void enableSaveDelete()
        {
            bool enable = txtMfg.Text != "" && txtName.Text != "" && txtPrice.Text != ""; // If all fields are not empty, enable the save and delete buttons
            if (enable)
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void clearFields()
        {
            txtId.Text = "";
            txtMfg.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtSearchString.Text = "";
            dgvItems.ClearSelection();
        }
        #endregion

    #region Events
        private void ItemManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.CurrentCell != null)
            {
                DataGridViewRow row = dgvItems.Rows[dgvItems.CurrentCell.RowIndex];
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
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                btnInsert.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = false;
            }
        }

        private void txtMfg_TextChanged(object sender, EventArgs e)
        {
            enableSaveDelete();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            enableSaveDelete();
        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {
            enableSaveDelete();
        }
        #endregion

        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
