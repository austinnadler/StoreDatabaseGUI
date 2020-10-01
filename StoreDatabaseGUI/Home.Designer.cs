namespace StoreDatabaseGUI
{
    partial class Home
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
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnManageItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(12, 12);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(200, 50);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(12, 68);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(200, 50);
            this.btnManageOrders.TabIndex = 1;
            this.btnManageOrders.Text = "Manage orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnManageItems
            // 
            this.btnManageItems.Location = new System.Drawing.Point(12, 124);
            this.btnManageItems.Name = "btnManageItems";
            this.btnManageItems.Size = new System.Drawing.Size(200, 50);
            this.btnManageItems.TabIndex = 2;
            this.btnManageItems.Text = "Manage items";
            this.btnManageItems.UseVisualStyleBackColor = true;
            this.btnManageItems.Click += new System.EventHandler(this.btnManageItems_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 186);
            this.Controls.Add(this.btnManageItems);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageCustomers);
            this.MaximumSize = new System.Drawing.Size(240, 225);
            this.MinimumSize = new System.Drawing.Size(240, 225);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnManageItems;
    }
}