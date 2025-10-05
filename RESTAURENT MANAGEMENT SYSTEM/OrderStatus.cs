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
            LoadOrderStatus();
        }

        private void LoadOrderStatus()
        {
            try
            {
                string query = @"
                    SELECT 
                        oi.OrderItemID,
                        oi.OrderID,
                        o.TableNo AS TableNumber,
                        m.Name AS ItemName,
                        oi.Qty AS Quantity,
                        (oi.Qty * oi.Price) AS TotalPrice,
                        o.Status AS OrderStatus
                    FROM OrderItems oi
                    INNER JOIN Orders o ON oi.OrderID = o.OrderID
                    INNER JOIN MenuItems m ON oi.ItemID = m.ItemID
                    WHERE o.Status != 'Served'";

                DataTable dt = da.ExecuteQueryTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvOrder.DataSource = null;
                    MessageBox.Show("No pending orders.");
                    return;
                }

                dgvOrder.DataSource = dt;

                dgvOrder.Columns["OrderItemID"].Visible = false;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrderStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SDashboard s = new SDashboard();
            s.Show();
            this.Close();
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order item to mark as served.");
                return;
            }

            try
            {
                string selectedOrderID = dgvOrder.SelectedRows[0].Cells["OrderID"].Value.ToString();

                string updateQuery = "UPDATE Orders SET Status = 'Served' WHERE OrderID = '" + selectedOrderID + "'";
                int rowsAffected = da.ExecuteUpdateQuery(updateQuery);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order marked as served.");
                    LoadOrderStatus();
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
