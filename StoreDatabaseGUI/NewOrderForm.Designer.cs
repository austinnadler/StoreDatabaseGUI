namespace Customer_and_Order_Management
{
    partial class NewOrderForm
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
            this.gpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.gbOrderItems = new System.Windows.Forms.GroupBox();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.gpCustomer.SuspendLayout();
            this.gbOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCustomer
            // 
            this.gpCustomer.Controls.Add(this.btnSelectCustomer);
            this.gpCustomer.Controls.Add(this.txtCustomerName);
            this.gpCustomer.Controls.Add(this.txtCustomerId);
            this.gpCustomer.Controls.Add(this.lblCustomerName);
            this.gpCustomer.Controls.Add(this.lblCustomerId);
            this.gpCustomer.Location = new System.Drawing.Point(20, 20);
            this.gpCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpCustomer.Name = "gpCustomer";
            this.gpCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpCustomer.Size = new System.Drawing.Size(555, 123);
            this.gpCustomer.TabIndex = 0;
            this.gpCustomer.TabStop = false;
            this.gpCustomer.Text = "Specify the customer, then click get order id";
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(441, 29);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(105, 38);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Select";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(207, 69);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(223, 26);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(207, 29);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(223, 26);
            this.txtCustomerId.TabIndex = 2;
            this.txtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(78, 74);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(122, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer name";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(100, 34);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // gbOrderItems
            // 
            this.gbOrderItems.Controls.Add(this.dgvOrderItems);
            this.gbOrderItems.Location = new System.Drawing.Point(584, 20);
            this.gbOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrderItems.Name = "gbOrderItems";
            this.gbOrderItems.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrderItems.Size = new System.Drawing.Size(556, 308);
            this.gbOrderItems.TabIndex = 1;
            this.gbOrderItems.TabStop = false;
            this.gbOrderItems.Text = "Order items. Add or remove items from the order";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AllowUserToResizeRows = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(9, 29);
            this.dgvOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(538, 269);
            this.dgvOrderItems.TabIndex = 0;
            this.dgvOrderItems.TabStop = false;
            this.dgvOrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellClick);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(891, 337);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 35);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(1012, 337);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(117, 35);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(460, 152);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(112, 35);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Get order id";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(226, 152);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(223, 26);
            this.txtOrderId.TabIndex = 5;
            this.txtOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(20, 337);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(591, 337);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(147, 160);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(70, 20);
            this.lblOrderId.TabIndex = 9;
            this.lblOrderId.Text = "Order ID";
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 360);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gbOrderItems);
            this.Controls.Add(this.gpCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1171, 416);
            this.MinimumSize = new System.Drawing.Size(1171, 416);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.Activated += new System.EventHandler(this.btnRefresh_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrder_Close);
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.gpCustomer.ResumeLayout(false);
            this.gpCustomer.PerformLayout();
            this.gbOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCustomer;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.GroupBox gbOrderItems;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Label lblOrderId;
    }
}