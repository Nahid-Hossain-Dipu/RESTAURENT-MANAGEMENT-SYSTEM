using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class ManageMenuItems : Form
    {
        private DataAccess dataAccess;
        private int selectedItemId = -1;

        public ManageMenuItems()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            cmbFilterCategory.SelectedIndex = 0;
            LoadMenuItems("All");
        }

        private void LoadMenuItems(string categoryFilter = "All")
        {
            try
            {
                string query = "SELECT ItemID, Name, Category, Price, Availability FROM MenuItems";
                SqlCommand cmd;

                if (categoryFilter != "All")
                {
                    query += " WHERE Category = @category";
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                    cmd.Parameters.AddWithValue("@category", categoryFilter);
                }
                else
                {
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewMenuItems.DataSource = dt;

                if (dataGridViewMenuItems.Columns["ItemID"] != null)
                    dataGridViewMenuItems.Columns["ItemID"].Visible = false;

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            cmbCategory.SelectedIndex = -1;
            txtPrice.Text = "";
            nudAvailability.Value = 0;
            selectedItemId = -1;
            btnAddItem.Enabled = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter item name.");
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            if (nudAvailability.Value < 0)
            {
                MessageBox.Show("Availability cannot be negative.");
                return false;
            }

            return true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem.ToString();
            decimal price = decimal.Parse(txtPrice.Text.Trim());
            int availability = (int)nudAvailability.Value;

            try
            {
                string query = "INSERT INTO MenuItems (Name, Category, Price, Availability) VALUES (@name, @category, @price, @availability)";
                SqlCommand cmd = new SqlCommand(query, dataAccess.Sqlcon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@availability", availability);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Menu item added successfully!");
                    LoadMenuItems(cmbFilterCategory.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Failed to add menu item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding menu item: " + ex.Message);
            }
        }

        private void dataGridViewMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMenuItems.Rows[e.RowIndex];
                selectedItemId = Convert.ToInt32(row.Cells["ItemID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                cmbCategory.SelectedItem = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                nudAvailability.Value = Convert.ToInt32(row.Cells["Availability"].Value);

                btnAddItem.Enabled = false;
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (selectedItemId == -1)
            {
                MessageBox.Show("Please select a menu item to update.");
                return;
            }

            if (!ValidateInputs()) return;

            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem.ToString();
            decimal price = decimal.Parse(txtPrice.Text.Trim());
            int availability = (int)nudAvailability.Value;

            try
            {
                string query = "UPDATE MenuItems SET Name = @name, Category = @category, Price = @price, Availability = @availability WHERE ItemID = @itemId";
                SqlCommand cmd = new SqlCommand(query, dataAccess.Sqlcon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@availability", availability);
                cmd.Parameters.AddWithValue("@itemId", selectedItemId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Menu item updated successfully!");
                    LoadMenuItems(cmbFilterCategory.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Failed to update menu item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu item: " + ex.Message);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (selectedItemId == -1)
            {
                MessageBox.Show("Please select a menu item to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this menu item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM MenuItems WHERE ItemID = @itemId";
                    SqlCommand cmd = new SqlCommand(query, dataAccess.Sqlcon);
                    cmd.Parameters.AddWithValue("@itemId", selectedItemId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Menu item deleted successfully!");
                        LoadMenuItems(cmbFilterCategory.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete menu item.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting menu item: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dataGridViewMenuItems.ClearSelection();
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbFilterCategory.SelectedItem.ToString();
            LoadMenuItems(selectedCategory);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
