using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class PurchaseEntryForm : Form
    {
        private DataAccess Da = new DataAccess();
        private DataTable rawMaterialsTable;

        public PurchaseEntryForm()
        {
            InitializeComponent();
            LoadRawMaterials();
            LoadRawMaterialGrid();
        }

        private void LoadRawMaterials()
        {
            string sql = "SELECT RawMaterialID, Name FROM RawMaterials";
            rawMaterialsTable = Da.ExecuteQueryTable(sql);

            cmbRawMaterial.DataSource = rawMaterialsTable;
            cmbRawMaterial.DisplayMember = "Name";
            cmbRawMaterial.ValueMember = "RawMaterialID";
        }

        private void LoadRawMaterialGrid()
        {
            string sql =
                "SELECT " +
                "R.RawMaterialID, " +
                "R.Name, " +
                "R.Category, " +
                "R.SupplierName, " +
                "R.StockLevel, " +
                "R.RequestedQuantity, " +
                "ISNULL((SELECT TOP 1 UnitPrice FROM RawMaterialPurchases P WHERE P.RawMaterialID = R.RawMaterialID ORDER BY P.PurchaseDate DESC), 0) AS UnitPrice " +
                "FROM RawMaterials R";

            dgvRawMaterials.DataSource = Da.ExecuteQueryTable(sql);
            dgvRawMaterials.Columns["UnitPrice"].HeaderText = "Last Unit Price";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = cmbRawMaterial.Text.Trim();
                decimal quantity = Convert.ToDecimal(txtQuantity.Text);
                decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                string category = cmbCategory.Text.Trim();
                string supplier = txtSupplier.Text.Trim();
                string purchaseDate = dtpPurchaseDate.Value.ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Raw Material Name is required.");
                    return;
                }

                // Check if item exists
                string checkSql = "SELECT * FROM RawMaterials WHERE Name = '" + name + "'";
                DataTable dt = Da.ExecuteQueryTable(checkSql);

                int rawMaterialId;
                int requestedQty = 0;

                if (dt.Rows.Count == 0)
                {
                    // Insert new material
                    if (string.IsNullOrEmpty(category)) category = "Uncategorized";
                    if (string.IsNullOrEmpty(supplier)) supplier = "Unknown";

                    string insertRaw =
                        "INSERT INTO RawMaterials (Name, Category, StockLevel, SupplierName, RequestedQuantity) " +
                        "VALUES ('" + name + "', '" + category + "', 0, '" + supplier + "', 0)";
                    Da.ExecuteUpdateQuery(insertRaw);

                    // Get new ID
                    DataTable newRaw = Da.ExecuteQueryTable("SELECT RawMaterialID FROM RawMaterials WHERE Name = '" + name + "'");
                    rawMaterialId = Convert.ToInt32(newRaw.Rows[0]["RawMaterialID"]);
                }
                else
                {
                    rawMaterialId = Convert.ToInt32(dt.Rows[0]["RawMaterialID"]);
                    requestedQty = Convert.ToInt32(dt.Rows[0]["RequestedQuantity"]);
                }

                // Insert purchase
                string insertPurchase =
                    "INSERT INTO RawMaterialPurchases (RawMaterialID, QuantityPurchased, UnitPrice, PurchaseDate) " +
                    "VALUES (" + rawMaterialId + ", " + quantity + ", " + unitPrice + ", '" + purchaseDate + "')";
                Da.ExecuteUpdateQuery(insertPurchase);

                // Update stock and remaining request
                int remainingRequest = requestedQty - Convert.ToInt32(quantity);
                if (remainingRequest < 0) remainingRequest = 0;

                string updateStock =
                    "UPDATE RawMaterials SET StockLevel = StockLevel + " + quantity +
                    ", RequestedQuantity = " + remainingRequest + " WHERE RawMaterialID = " + rawMaterialId;
                Da.ExecuteUpdateQuery(updateStock);

                MessageBox.Show("Purchase saved successfully.");

                LoadRawMaterials();
                LoadRawMaterialGrid();

                // Clear inputs
                txtQuantity.Text = "";
                txtUnitPrice.Text = "";
                cmbCategory.SelectedIndex = -1;
                txtSupplier.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvRawMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRawMaterials.Rows[e.RowIndex];
                cmbRawMaterial.Text = row.Cells["Name"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtSupplier.Text = row.Cells["SupplierName"].Value.ToString();
            }
        }

        private void btnResetStock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset all stock levels to 0?",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string resetSql = "UPDATE RawMaterials SET StockLevel = 0";
                    int rowsAffected = Da.ExecuteUpdateQuery(resetSql);

                    MessageBox.Show("All stock levels have been reset to 0 successfully.");

                    LoadRawMaterialGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting stock: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
