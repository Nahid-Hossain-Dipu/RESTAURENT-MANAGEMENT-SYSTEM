using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class ManageMenuItems
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblAvailability;
        private NumericUpDown nudAvailability;
        private ComboBox cmbFilterCategory;
        private Button btnAddItem;
        private Button btnUpdateItem;
        private Button btnDeleteItem;
        private Button btnClear;
        private DataGridView dataGridViewMenuItems;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.nudAvailability = new System.Windows.Forms.NumericUpDown();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewMenuItems = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(20, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
            "Main Course",
            "Snacks",
            "Drinks",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(100, 60);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(20, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // lblAvailability
            // 
            this.lblAvailability.Location = new System.Drawing.Point(20, 140);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(70, 20);
            this.lblAvailability.TabIndex = 6;
            this.lblAvailability.Text = "Availability:";
            // 
            // nudAvailability
            // 
            this.nudAvailability.Location = new System.Drawing.Point(100, 140);
            this.nudAvailability.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAvailability.Name = "nudAvailability";
            this.nudAvailability.Size = new System.Drawing.Size(180, 20);
            this.nudAvailability.TabIndex = 7;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.Items.AddRange(new object[] {
            "All",
            "Main Course",
            "Snacks",
            "Drinks",
            "Dessert"});
            this.cmbFilterCategory.Location = new System.Drawing.Point(320, 20);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(150, 21);
            this.cmbFilterCategory.TabIndex = 8;
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategory_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(20, 180);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(110, 180);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateItem.TabIndex = 10;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(200, 180);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(290, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridViewMenuItems
            // 
            this.dataGridViewMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenuItems.ColumnHeadersHeight = 34;
            this.dataGridViewMenuItems.Location = new System.Drawing.Point(20, 230);
            this.dataGridViewMenuItems.MultiSelect = false;
            this.dataGridViewMenuItems.Name = "dataGridViewMenuItems";
            this.dataGridViewMenuItems.ReadOnly = true;
            this.dataGridViewMenuItems.RowHeadersWidth = 62;
            this.dataGridViewMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenuItems.Size = new System.Drawing.Size(450, 220);
            this.dataGridViewMenuItems.TabIndex = 13;
            this.dataGridViewMenuItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuItems_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(371, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 39);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageMenuItems
            // 
            this.ClientSize = new System.Drawing.Size(500, 470);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.nudAvailability);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridViewMenuItems);
            this.Name = "ManageMenuItems";
            this.Text = "Manage Menu Items";
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnBack;
    }
}
