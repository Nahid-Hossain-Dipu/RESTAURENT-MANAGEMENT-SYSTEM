using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class Kitchen : Form
    {
        private DataAccess da;

        public Kitchen()
        {
            InitializeComponent();
            da = new DataAccess();

            // Setup DataGridView
            dgvKitchenOrders.ReadOnly = true;
            dgvKitchenOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitchenOrders.MultiSelect = false;
            dgvKitchenOrders.AllowUserToAddRows = false;

            LoadKitchenOrders();
        }

        private void LoadKitchenOrders()
        {
            try
            {
                string sql = "SELECT o.OrderID, " +
                             "o.TableNumber, " +
                             "o.ItemID, " +
                             "m.Name AS ItemName, " +
                             "o.Quantity, " +
                             "o.OrderStatus, " +
                             "o.DateTime " +
                             "FROM Orders o " +
                             "JOIN MenuItems m ON o.ItemID = m.ItemID " +
                             "WHERE o.OrderStatus IN ('Confirmed', 'Cooking', 'Ready') " +
                             "ORDER BY o.DateTime DESC";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvKitchenOrders.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgvKitchenOrders.Columns["OrderID"].HeaderText = "Order ID";
                    dgvKitchenOrders.Columns["TableNumber"].HeaderText = "Table No";
                    dgvKitchenOrders.Columns["ItemID"].HeaderText = "Food ID";
                    dgvKitchenOrders.Columns["ItemName"].HeaderText = "Food Name";
                    dgvKitchenOrders.Columns["Quantity"].HeaderText = "Qty";
                    dgvKitchenOrders.Columns["OrderStatus"].HeaderText = "Status";
                    dgvKitchenOrders.Columns["DateTime"].HeaderText = "Order Time";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void Start_Cooking_Click(object sender, EventArgs e)
        {
            if (dgvKitchenOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            try
            {
                int orderId = Convert.ToInt32(dgvKitchenOrders.SelectedRows[0].Cells["OrderID"].Value);
                string sql = "UPDATE Orders SET OrderStatus = 'Cooking' WHERE OrderID = " + orderId;

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Order marked as Cooking.");
                    LoadKitchenOrders();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void Mark_Ready_Click(object sender, EventArgs e)
        {
            if (dgvKitchenOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            try
            {
                int orderId = Convert.ToInt32(dgvKitchenOrders.SelectedRows[0].Cells["OrderID"].Value);
                string sql = "UPDATE Orders SET OrderStatus = 'Ready' WHERE OrderID = " + orderId;

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Order marked as Ready!");
                    LoadKitchenOrders();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadKitchenOrders();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ChefDashboard dashboard = new ChefDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
