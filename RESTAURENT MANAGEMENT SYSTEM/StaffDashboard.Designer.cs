namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class StaffDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.txtSelectedItem = new System.Windows.Forms.TextBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowDrop = true;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(8, 24);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.ReadOnly = true;
            this.dgvMenuItems.Size = new System.Drawing.Size(520, 404);
            this.dgvMenuItems.TabIndex = 0;
            this.dgvMenuItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellClick);
            this.dgvMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellContentClick);
            // 
            // txtSelectedItem
            // 
            this.txtSelectedItem.Location = new System.Drawing.Point(947, 23);
            this.txtSelectedItem.Name = "txtSelectedItem";
            this.txtSelectedItem.ReadOnly = true;
            this.txtSelectedItem.Size = new System.Drawing.Size(100, 20);
            this.txtSelectedItem.TabIndex = 1;
            this.txtSelectedItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Location = new System.Drawing.Point(947, 80);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTableNumber.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(947, 132);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddOrder.Location = new System.Drawing.Point(949, 178);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(98, 44);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(8, 437);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(1049, 194);
            this.dgvOrders.TabIndex = 5;
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedItem.Location = new System.Drawing.Point(830, 24);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(101, 19);
            this.lblSelectedItem.TabIndex = 16;
            this.lblSelectedItem.Text = "Selected Item";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableNo.Location = new System.Drawing.Point(830, 81);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(74, 19);
            this.lblTableNo.TabIndex = 15;
            this.lblTableNo.Text = "Table No.";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(830, 133);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.Location = new System.Drawing.Point(829, 178);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(102, 44);
            this.btnDeleteOrder.TabIndex = 9;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(823, 589);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(82, 31);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "Total ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(708, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.Location = new System.Drawing.Point(579, 178);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(115, 44);
            this.btnConfirmOrder.TabIndex = 12;
            this.btnConfirmOrder.Text = "Confirm";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(579, 240);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(230, 44);
            this.btnUpdateOrder.TabIndex = 17;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(579, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 44);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StaffDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1069, 643);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.txtSelectedItem);
            this.Controls.Add(this.dgvMenuItems);
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.TextBox txtSelectedItem;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnUpdateOrder; // NEW BUTTON
        private System.Windows.Forms.Button btnBack;
    }
}
