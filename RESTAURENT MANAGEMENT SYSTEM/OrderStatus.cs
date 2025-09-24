using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class OrderStatus : Form
    {
        DataAccess da = new DataAccess();

        public OrderStatus()
        {
            InitializeComponent();
            LoadOrderStatus(); // Load data on form load
        }

        // Load all non-served orders into the DataGridView
        private void LoadOrderStatus()
        {
            try
            {
                string query = "SELECT o.OrderID, o.TableNumber, m.Name AS ItemName, o.Quantity, " +
                               "(o.Quantity * m.Price) AS TotalPrice, o.OrderStatus " +
                               "FROM Orders o INNER JOIN MenuItems m ON o.ItemID = m.ItemID " +
                               "WHERE o.OrderStatus != 'Served'";

                DataTable dt = da.ExecuteQueryTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvOrder.DataSource = null;
                    MessageBox.Show("No pending orders.");
                    return;
                }

                dgvOrder.DataSource = dt;

                dgvOrder.Columns["OrderID"].HeaderText = "Order ID";
                dgvOrder.Columns["TableNumber"].HeaderText = "Table No";
                dgvOrder.Columns["ItemName"].HeaderText = "Food Item";
                dgvOrder.Columns["Quantity"].HeaderText = "Qty";
                dgvOrder.Columns["TotalPrice"].HeaderText = "Total Price";
                dgvOrder.Columns["OrderStatus"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        // Refresh button click
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrderStatus();
        }

        // Back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            SDashboard s = new SDashboard();
            s.Show();
            this.Close();
        }

        // Served button click
        private void btnServed_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to mark as served.");
                return;
            }

            int selectedOrderID = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells["OrderID"].Value);

            try
            {
                string updateQuery = "UPDATE Orders SET OrderStatus = 'Served' WHERE OrderID = " + selectedOrderID;
                int rowsAffected = da.ExecuteUpdateQuery(updateQuery);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order marked as served.");
                    LoadOrderStatus(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Failed to update order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }
    }
}
