namespace StoreDatabaseGUI
{
    partial class CustomerViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(5, 269);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(974, 480);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(320, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email address";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(336, 68);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(56, 13);
            this.lblLast.TabIndex = 16;
            this.lblLast.Text = "Last name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(316, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 13);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone number";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(337, 42);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(55, 13);
            this.lblFirst.TabIndex = 14;
            this.lblFirst.Text = "First name";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(397, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Submit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(397, 65);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(158, 20);
            this.txtLast.TabIndex = 1;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(397, 91);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(397, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(397, 39);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(158, 20);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(577, 42);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(75, 13);
            this.lblStreetAddress.TabIndex = 18;
            this.lblStreetAddress.Text = "Street address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(658, 39);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(158, 20);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(658, 65);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(628, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "City";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(658, 121);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(158, 20);
            this.txtZip.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(628, 124);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 13);
            this.lblZip.TabIndex = 22;
            this.lblZip.Text = "ZIP";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(620, 97);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 24;
            this.lblState.Text = "State";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(658, 94);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(158, 21);
            this.cboState.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 44);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(158, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(478, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(566, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(316, 154);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSearchString
            // 
            this.txtSearchString.Location = new System.Drawing.Point(6, 17);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(327, 20);
            this.txtSearchString.TabIndex = 12;
            this.txtSearchString.TextChanged += new System.EventHandler(this.txtSearchString_TextChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchString);
            this.grpSearch.Location = new System.Drawing.Point(5, 214);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(349, 49);
            this.grpSearch.TabIndex = 36;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(-26, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblCustomerId);
            this.grpCustomer.Controls.Add(this.txtZip);
            this.grpCustomer.Controls.Add(this.txtFirst);
            this.grpCustomer.Controls.Add(this.btnDelete);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.btnInsert);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.btnClear);
            this.grpCustomer.Controls.Add(this.txtLast);
            this.grpCustomer.Controls.Add(this.lblId);
            this.grpCustomer.Controls.Add(this.btnSave);
            this.grpCustomer.Controls.Add(this.txtId);
            this.grpCustomer.Controls.Add(this.lblFirst);
            this.grpCustomer.Controls.Add(this.cboState);
            this.grpCustomer.Controls.Add(this.lblPhone);
            this.grpCustomer.Controls.Add(this.lblState);
            this.grpCustomer.Controls.Add(this.lblLast);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.lblStreetAddress);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtStreetAddress);
            this.grpCustomer.Controls.Add(this.lblCity);
            this.grpCustomer.Location = new System.Drawing.Point(5, 9);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(974, 196);
            this.grpCustomer.TabIndex = 37;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Create, Update, or Delete";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(105, 47);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(18, 13);
            this.lblCustomerId.TabIndex = 30;
            this.lblCustomerId.Text = "ID";
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.dgvCustomers);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "CustomerViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerViewForm_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustomerId;
    }
}

