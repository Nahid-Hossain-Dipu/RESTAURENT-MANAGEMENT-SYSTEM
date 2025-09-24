using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class Inventory : Form
    {
        private DataAccess da;

        public Inventory()
        {
            InitializeComponent();
            da = new DataAccess();

            LoadInventoryData();

            dataGridView1.CellClick += DataGridView1_CellClick;
            btnRequest.Click += btnRequest_Click;
            Back.Click += Back_Click;
        }

        private void LoadInventoryData()
        {
            try
            {
                string query = "SELECT Name, Category, StockLevel, RequestedQuantity FROM RawMaterials";
                DataTable dt = da.ExecuteQueryTable(query);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["Name"].HeaderText = "Item Name";
                dataGridView1.Columns["Category"].HeaderText = "Category";
                dataGridView1.Columns["StockLevel"].HeaderText = "In Stock";
                dataGridView1.Columns["RequestedQuantity"].HeaderText = "Requested Qty";

                cmbItem.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbItem.Items.Add(row["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["Name"].Value != null)
                {
                    string selectedItemName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    cmbItem.SelectedItem = selectedItemName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting item: " + ex.Message);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem == null || numQty.Value <= 0)
            {
                MessageBox.Show("Please select an item and enter a valid quantity.");
                return;
            }

            string itemName = cmbItem.SelectedItem.ToString();
            int quantity = (int)numQty.Value;

            try
            {
                // Escape single quotes for SQL safety
                string safeName = itemName.Replace("'", "''");

                // Simple update query adding the requested quantity
                string query = "UPDATE RawMaterials SET RequestedQuantity = ISNULL(RequestedQuantity, 0) + " + quantity +
                               " WHERE Name = '" + safeName + "'";

                int rowsAffected = da.ExecuteUpdateQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Successfully requested {quantity} of '{itemName}'.");

                    // Reset operation inside btnRequest:
                    LoadInventoryData();
                    cmbItem.SelectedIndex = -1;
                    numQty.Value = 0;
                }
                else
                {
                    MessageBox.Show("Item not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while requesting item: " + ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ChefDashboard dash = new ChefDashboard();
            dash.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (cmbItem.SelectedItem == null || numQty.Value <= 0)
            {
                MessageBox.Show("Please select an item and enter a valid quantity.");
                return;
            }

            string itemName = cmbItem.SelectedItem.ToString();
            int quantity = (int)numQty.Value;

            try
            {
                // Escape single quotes in itemName to prevent SQL errors
                string safeName = itemName.Replace("'", "''");

                // Update query to overwrite RequestedQuantity
                string query = "UPDATE RawMaterials SET RequestedQuantity = " + quantity + " WHERE Name = '" + safeName + "'";


                int rowsAffected = da.ExecuteUpdateQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Requested quantity for '{itemName}' updated to {quantity}.");

                    // Reset UI and reload data
                    LoadInventoryData();
                    cmbItem.SelectedIndex = -1;
                    numQty.Value = 0;
                }
                else
                {
                    MessageBox.Show("Update failed: Item not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating requested quantity: " + ex.Message);
            }
        }

    }
}

