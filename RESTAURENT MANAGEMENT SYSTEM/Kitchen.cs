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

        // Load orders with status 'Confirmed', 'Cooking', or 'Ready'
        private void LoadKitchenOrders()
        {
            try
            {
                string sql = @"
                    SELECT 
                        oi.OrderItemID, 
                        o.OrderID, 
                        o.TableNo AS TableNumber, 
                        m.Name AS ItemName, 
                        oi.Qty AS Quantity, 
                        oi.Price AS ItemPrice, 
                        o.Status AS OrderStatus,  -- Fetching Status from Orders table
                        o.OrderDate AS OrderTime
                    FROM OrderItems oi
                    INNER JOIN Orders o ON oi.OrderID = o.OrderID  -- Joining with Orders table
                    INNER JOIN MenuItems m ON oi.ItemID = m.ItemID
                    WHERE o.Status IN ('Confirmed', 'Cooking', 'Ready')  -- Filtering based on Orders' Status
                    ORDER BY o.OrderDate ASC";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvKitchenOrders.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgvKitchenOrders.Columns["OrderItemID"].Visible = false;
                    dgvKitchenOrders.Columns["OrderID"].HeaderText = "Order ID";
                    dgvKitchenOrders.Columns["TableNumber"].HeaderText = "Table No";
                    dgvKitchenOrders.Columns["ItemName"].HeaderText = "Food Name";
                    dgvKitchenOrders.Columns["Quantity"].HeaderText = "Qty";
                    dgvKitchenOrders.Columns["ItemPrice"].HeaderText = "Price";
                    dgvKitchenOrders.Columns["OrderStatus"].HeaderText = "Status";
                    dgvKitchenOrders.Columns["OrderTime"].HeaderText = "Order Time";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        // Start Cooking button click handler
        private void Start_Cooking_Click(object sender, EventArgs e)
        {
            if (dgvKitchenOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order item first.");
                return;
            }

            try
            {
                // Get the OrderID as a string (not int)
                string orderId = dgvKitchenOrders.SelectedRows[0].Cells["OrderID"].Value.ToString();

                // Wrap orderId in single quotes in SQL because it's a string
                string sql = "UPDATE Orders SET Status = 'Cooking' WHERE OrderID = '" + orderId + "'";

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Order marked as Cooking.");
                    LoadKitchenOrders();  // Reload orders to show updated status
                }
                else
                {
                    MessageBox.Show("Failed to update order status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        // Mark Ready button click handler
        private void Mark_Ready_Click(object sender, EventArgs e)
        {
            if (dgvKitchenOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order item first.");
                return;
            }

            try
            {
                // Get the OrderID as a string (not int)
                string orderId = dgvKitchenOrders.SelectedRows[0].Cells["OrderID"].Value.ToString();

                // Wrap orderId in single quotes in SQL because it's a string
                string sql = "UPDATE Orders SET Status = 'Ready' WHERE OrderID = '" + orderId + "'";

                int result = da.ExecuteUpdateQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Order marked as Ready.");
                    LoadKitchenOrders();  // Reload orders to show updated status
                }
                else
                {
                    MessageBox.Show("Failed to update order status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        // Refresh button click handler
        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadKitchenOrders();
        }

        // Back button click handler
        private void Back_Click(object sender, EventArgs e)
        {
            ChefDashboard dashboard = new ChefDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
