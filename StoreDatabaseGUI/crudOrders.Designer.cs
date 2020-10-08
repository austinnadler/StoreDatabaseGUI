namespace StoreDatabaseGUI
{
    partial class OrderViewForm
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
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblUpdatedOn = new System.Windows.Forms.Label();
            this.txtCreatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Location = new System.Drawing.Point(407, 164);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 53;
            this.btnDeleteOrder.TabStop = false;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(816, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(279, 37);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(47, 13);
            this.lblOrderId.TabIndex = 52;
            this.lblOrderId.Text = "Order ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(332, 33);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(150, 20);
            this.txtOrderId.TabIndex = 33;
            this.txtOrderId.TabStop = false;
            this.txtOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(260, 62);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(66, 13);
            this.lblOrderStatus.TabIndex = 44;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(897, 247);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(5, 278);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(967, 474);
            this.dgvOrders.TabIndex = 30;
            this.dgvOrders.TabStop = false;
            this.dgvOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrders_CellMouseClick);
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(25, 35);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerId.TabIndex = 55;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(96, 33);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerId.TabIndex = 54;
            this.txtCustomerId.TabStop = false;
            this.txtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(269, 89);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(57, 13);
            this.lblTotalPrice.TabIndex = 57;
            this.lblTotalPrice.Text = "Total price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(332, 86);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(150, 20);
            this.txtTotalPrice.TabIndex = 56;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Items.AddRange(new object[] {
            "Received",
            "Processing",
            "Shipped",
            "Delivered"});
            this.cboOrderStatus.Location = new System.Drawing.Point(332, 59);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(150, 21);
            this.cboOrderStatus.TabIndex = 58;
            this.cboOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cboOrderStatus_SelectedIndexChanged);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToResizeRows = false;
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(509, 25);
            this.dgvOrderItems.MultiSelect = false;
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(463, 190);
            this.dgvOrderItems.TabIndex = 59;
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Location = new System.Drawing.Point(506, 9);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(76, 13);
            this.lblOrderItems.TabIndex = 60;
            this.lblOrderItems.Text = "Items on Order";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(264, 115);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(59, 13);
            this.lblCreatedOn.TabIndex = 63;
            this.lblCreatedOn.Text = "Created on";
            // 
            // lblUpdatedOn
            // 
            this.lblUpdatedOn.AutoSize = true;
            this.lblUpdatedOn.Location = new System.Drawing.Point(260, 141);
            this.lblUpdatedOn.Name = "lblUpdatedOn";
            this.lblUpdatedOn.Size = new System.Drawing.Size(63, 13);
            this.lblUpdatedOn.TabIndex = 64;
            this.lblUpdatedOn.Text = "Updated on";
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Location = new System.Drawing.Point(332, 112);
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ReadOnly = true;
            this.txtCreatedOn.Size = new System.Drawing.Size(150, 20);
            this.txtCreatedOn.TabIndex = 65;
            // 
            // txtUpdatedOn
            // 
            this.txtUpdatedOn.Location = new System.Drawing.Point(332, 138);
            this.txtUpdatedOn.Name = "txtUpdatedOn";
            this.txtUpdatedOn.ReadOnly = true;
            this.txtUpdatedOn.Size = new System.Drawing.Size(150, 20);
            this.txtUpdatedOn.TabIndex = 66;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(96, 59);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerName.TabIndex = 68;
            this.txtCustomerName.TabStop = false;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(455, 758);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 69;
            this.btnNewOrder.Text = "New order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchString);
            this.grpSearch.Location = new System.Drawing.Point(5, 221);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(342, 49);
            this.grpSearch.TabIndex = 70;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // txtSearchString
            // 
            this.txtSearchString.Location = new System.Drawing.Point(6, 17);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(327, 20);
            this.txtSearchString.TabIndex = 30;
            this.txtSearchString.TextChanged += new System.EventHandler(this.txtSearchString_TextChanged);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(20, 56);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(70, 23);
            this.btnCustomer.TabIndex = 71;
            this.btnCustomer.Text = "Customer...";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblCustomerId);
            this.grpOrder.Controls.Add(this.btnCustomer);
            this.grpOrder.Controls.Add(this.btnSave);
            this.grpOrder.Controls.Add(this.lblOrderStatus);
            this.grpOrder.Controls.Add(this.btnDeleteOrder);
            this.grpOrder.Controls.Add(this.txtCustomerName);
            this.grpOrder.Controls.Add(this.txtOrderId);
            this.grpOrder.Controls.Add(this.txtUpdatedOn);
            this.grpOrder.Controls.Add(this.lblOrderId);
            this.grpOrder.Controls.Add(this.txtCreatedOn);
            this.grpOrder.Controls.Add(this.lblUpdatedOn);
            this.grpOrder.Controls.Add(this.txtCustomerId);
            this.grpOrder.Controls.Add(this.lblCreatedOn);
            this.grpOrder.Controls.Add(this.txtTotalPrice);
            this.grpOrder.Controls.Add(this.lblTotalPrice);
            this.grpOrder.Controls.Add(this.cboOrderStatus);
            this.grpOrder.Location = new System.Drawing.Point(5, 9);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(498, 206);
            this.grpOrder.TabIndex = 72;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Create, Update, or Delete";
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 791);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblOrderItems);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnClear);
            this.MaximumSize = new System.Drawing.Size(1000, 830);
            this.MinimumSize = new System.Drawing.Size(1000, 830);
            this.Name = "OrderViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblUpdatedOn;
        private System.Windows.Forms.TextBox txtCreatedOn;
        private System.Windows.Forms.TextBox txtUpdatedOn;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.Button btnCustomer;
        public System.Windows.Forms.TextBox txtCustomerId;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox grpOrder;
    }
}