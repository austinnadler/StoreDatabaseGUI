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
    public partial class CustomerViewForm : Form
    {
        DataTable dataTable = new DataTable(); // Create a DataTable to store the data selected. Outside so it can be cleared at the beginning of selection. Also allows for filtering without hitting the database again.
        private const string connectionString = "Server=localhost;Database=Store;Integrated Security=True";
        private SelectOrderCustomer parent = null;

        public CustomerViewForm()
        {
            InitializeComponent();
        }

        public CustomerViewForm(SelectOrderCustomer parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        #region Utilities
        private void loadCustomerData()
        {
            try
            {
                dataTable.Clear();

                string queryString = "select id as 'ID', firstName as 'First name', lastName as 'Last name', phoneNumber as 'Phone number', emailAddress as 'Email address', streetAddress as 'Street address', city as 'City', state as 'State', zip as 'ZIP', created as 'Created on', updated as 'Updated on' from customer";

                SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection

                if (txtSearchString.Text != "")
                {
                    queryString += $" where concat(id, firstName, lastName, phoneNumber, emailAddress, streetAddress, city, state, zip, created, updated) like @Search";
                    command = new SqlCommand(queryString, connection); // reassign with new queryString
                    command.Parameters.AddWithValue("@Search", $"%{txtSearchString.Text}%");
                }

                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command); // Create a SqlDataAdapter and run the command, putting the result set in da
                da.Fill(dataTable);
                connection.Close();
                da.Dispose();
                dgvCustomers.DataSource = dataTable; // Put the DataTable into the DataGridView    
                dgvCustomers.AutoResizeColumns(); // Format the dgv
                dgvCustomers.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clearFields()
        {
            txtId.Text = txtFirst.Text = txtLast.Text = txtPhone.Text = txtEmail.Text = txtStreetAddress.Text = txtCity.Text = txtZip.Text = txtSearchString.Text = "";
            cboState.Text = null;
            btnSave.Enabled = btnInsert.Enabled = btnDelete.Enabled = false;
        }

        /// <summary>
        ///     Set the required parameters for the type of SQL query.
        /// </summary>
        /// <param name="command">The SQL command to set parameters on</param>
        /// <param name="needId">specifies if the query to be executed needs a record ID (update, delete)</param>
        private void setParameters(SqlCommand command, bool needId)
        {
            if(needId)
            {
                command.Parameters.AddWithValue("@Id", txtId.Text);
            }
            command.Parameters.AddWithValue("@FirstName", txtFirst.Text);
            command.Parameters.AddWithValue("@LastName", txtLast.Text);
            command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
            command.Parameters.AddWithValue("@StreetAddress", txtStreetAddress.Text);
            command.Parameters.AddWithValue("@City", txtCity.Text);
            command.Parameters.AddWithValue("@State", cboState.Text);
            command.Parameters.AddWithValue("@Zip", txtZip.Text);
            command.Parameters.AddWithValue("@Created", DateTime.Now.ToString()); // Automatically changes to SQL format when used in a query
            command.Parameters.AddWithValue("@Updated", DateTime.Now.ToString());
        }

    #endregion

    #region Events
        
        private void Home_Load(object sender, EventArgs e)
        {
            loadCustomerData();
            txtId.Text = txtFirst.Text = txtLast.Text = txtPhone.Text = txtEmail.Text = txtStreetAddress.Text = txtCity.Text = txtZip.Text = txtSearchString.Text = "";
            cboState.Text = null;
            btnSave.Enabled = btnInsert.Enabled = btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadCustomerData();
        }
       

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentCell != null)
            {
                DataGridViewRow row = dgvCustomers.Rows[dgvCustomers.CurrentCell.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtFirst.Text = row.Cells[1].Value.ToString();
                txtLast.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtStreetAddress.Text = row.Cells[5].Value.ToString();
                txtCity.Text = row.Cells[6].Value.ToString();
                cboState.Text = row.Cells[7].Value.ToString();
                txtZip.Text = row.Cells[8].Value.ToString();
                btnSave.Enabled = true;
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtLast.Text != "")
            { 
                if(txtId.Text == "") // if inserting new customer
                {
                    try
                    {
                        string queryString = "insert into customer (firstName, lastName, phoneNumber, emailAddress, streetAddress, city, state, zip, created) values(@FirstName, @LastName, @PhoneNumber, @EmailAddress, @StreetAddress, @City, @State, @Zip, @Created)";

                        SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                        SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                        setParameters(command, false);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                    // Don't do anything, no row is selected
                        MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // if updating existing customer
                {
                    try
                    {
                        string queryString = "update customer set firstName=@FirstName, lastName=@LastName, phoneNumber=@PhoneNumber, emailAddress=@EmailAddress, streetAddress=@StreetAddress, city=@City, state=@State, zip=@Zip, updated=@Updated where id=@Id";

                        SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                        SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                        setParameters(command, true);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Don't do anything, no row is selected
                        MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
                loadCustomerData();
            }
            else
            {
                MessageBox.Show("A customer must at least have a first and last name.", "Invalid insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtFirst.Text != "" && txtLast.Text != "")
            {
                try
                {
                    string queryString = "insert into customer (firstName, lastName, phoneNumber, emailAddress, streetAddress, city, state, zip, created) values(@FirstName, @LastName, @PhoneNumber, @EmailAddress, @StreetAddress, @City, @State, @Zip, @Created)";

                    SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                    setParameters(command, false); // Call setParameters to insert with new values
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    loadCustomerData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
            else
            {
                MessageBox.Show("A customer must at least have a first and last name.", "Invalid insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                try
                {
                    string tqueryString = $"select COUNT(*) from [order] where customer$id={txtId.Text}";

                    SqlConnection tconnection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                    SqlCommand tcommand = new SqlCommand(tqueryString, tconnection);   // Create a SQL command with the query to be ran, and the database connection
                    tconnection.Open();
                    setParameters(tcommand, true);
                    int numOrders = (Int32)tcommand.ExecuteScalar();
                    tconnection.Close();

                    if(numOrders > 0)
                    {
                        MessageBox.Show("This customer cannot be deleted because they have orders. Go to the order form and delete this customer's orders before deleting them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*DialogResult delete = MessageBox.Show($"Are you sure you want to delete {txtLast.Text},  {txtFirst.Text}?\n\nNumber of existing orders {numOrders}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);*/
                        DialogResult delete = MessageBox.Show($"Are you sure you want to delete {txtLast.Text},  {txtFirst.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (delete == DialogResult.Yes)
                        {
                            string queryString = "delete from customer where id=@Id";

                            SqlConnection connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                            SqlCommand command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                            connection.Open();
                            setParameters(command, true);
                            command.ExecuteNonQuery();

                            queryString = "delete from [order] where customer$id=@Id";
                            connection = new SqlConnection(connectionString); // Set up the database connection with the connection string
                            command = new SqlCommand(queryString, connection);   // Create a SQL command with the query to be ran, and the database connection
                            connection.Open();
                            setParameters(command, true);
                            command.ExecuteNonQuery();

                            connection.Close();
                            loadCustomerData();
                            clearFields();
                        }
                    }
                  
                    
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                    
            }
        }
        
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                btnInsert.Enabled = btnDelete.Enabled = false;                }
            else
            {
                btnInsert.Enabled = btnDelete.Enabled = true;
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            loadCustomerData();
            clearFields();
        }

        #endregion

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            enableSave();
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            enableSave();
        }

        private void enableSave()
        {
            if (txtFirst.Text != "" && txtLast.Text != "")
            {
                btnSave.Enabled = btnInsert.Enabled = true;
            }
            else
            {
                btnSave.Enabled = btnInsert.Enabled = false;
            }
        }

        private void CustomerViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(parent != null)
            {
                parent.Activate();
            }
        }

        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            loadCustomerData();
        }
    }
}