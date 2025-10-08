using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class PurchaseEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbRawMaterial;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetStock;
        private System.Windows.Forms.DataGridView dgvRawMaterials;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSupplier;

        private System.Windows.Forms.Label lblRawMaterial;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSupplier;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbRawMaterial = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetStock = new System.Windows.Forms.Button();
            this.dgvRawMaterials = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblRawMaterial = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRawMaterial
            // 
            this.cmbRawMaterial.Location = new System.Drawing.Point(120, 20);
            this.cmbRawMaterial.Name = "cmbRawMaterial";
            this.cmbRawMaterial.Size = new System.Drawing.Size(200, 21);
            this.cmbRawMaterial.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(120, 84);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 20);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(120, 180);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPurchaseDate.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Purchase";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetStock
            // 
            this.btnResetStock.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetStock.ForeColor = System.Drawing.Color.White;
            this.btnResetStock.Location = new System.Drawing.Point(120, 255);
            this.btnResetStock.Name = "btnResetStock";
            this.btnResetStock.Size = new System.Drawing.Size(200, 30);
            this.btnResetStock.TabIndex = 7;
            this.btnResetStock.Text = "Reset Stock";
            this.btnResetStock.UseVisualStyleBackColor = false;
            this.btnResetStock.Click += new System.EventHandler(this.btnResetStock_Click);
            // 
            // dgvRawMaterials
            // 
            this.dgvRawMaterials.Location = new System.Drawing.Point(350, 20);
            this.dgvRawMaterials.Name = "dgvRawMaterials";
            this.dgvRawMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterials.Size = new System.Drawing.Size(480, 265);
            this.dgvRawMaterials.TabIndex = 8;
            this.dgvRawMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRawMaterials_CellClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
            "Vegetables",
            "Meat",
            "Seafood",
            "Dairy",
            "Beverages",
            "Spices",
            "Grains",
            "Others"});
            this.cmbCategory.Location = new System.Drawing.Point(120, 116);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(120, 148);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(200, 20);
            this.txtSupplier.TabIndex = 4;
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.AutoSize = true;
            this.lblRawMaterial.Location = new System.Drawing.Point(30, 23);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Size = new System.Drawing.Size(72, 13);
            this.lblRawMaterial.TabIndex = 9;
            this.lblRawMaterial.Text = "Raw Material:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(30, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(30, 87);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(30, 183);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(81, 13);
            this.lblPurchaseDate.TabIndex = 14;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 119);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(30, 151);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Supplier:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 39);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PurchaseEntryForm
            // 
            this.ClientSize = new System.Drawing.Size(850, 310);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbRawMaterial);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnResetStock);
            this.Controls.Add(this.dgvRawMaterials);
            this.Controls.Add(this.lblRawMaterial);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblPurchaseDate);
            this.Name = "PurchaseEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnBack;
    }
}
