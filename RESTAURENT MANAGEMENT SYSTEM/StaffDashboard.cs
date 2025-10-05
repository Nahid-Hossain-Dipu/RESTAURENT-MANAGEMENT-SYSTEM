using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class StaffDashboard : Form
    {
        DataAccess da = new DataAccess();
        private int selectedItemId = -1;
        private int currentTableNumber = -1;
        private DataTable currentCustomerOrders = new DataTable();
        private PrintDocument printDocument = new PrintDocument();
        private string receiptText = "";

        public StaffDashboard()
        {
            InitializeComponent();
            InitializeCurrentCustomerOrders();
            dgvMenuItems.ReadOnly = true;
            dgvOrders.ReadOnly = true;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.MultiSelect = false;
            dgvOrders.MultiSelect = false;
            dgvMenuItems.AllowUserToAddRows = false;
            dgvOrders.AllowUserToAddRows = false;
            LoadMenuItems();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void LoadMenuItems()
        {
            string query = "SELECT ItemID, Name, Category, Price, Availability FROM MenuItems";
            dgvMenuItems.DataSource = da.ExecuteQueryTable(query);

            dgvMenuItems.Columns["ItemID"].HeaderText = "Food ID";
            dgvMenuItems.Columns["Name"].HeaderText = "Food Item";
            dgvMenuItems.Columns["Category"].HeaderText = "Category";
            dgvMenuItems.Columns["Price"].HeaderText = "Price";
            dgvMenuItems.Columns["Availability"].HeaderText = "Available";
        }

        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenuItems.Rows[e.RowIndex];
                selectedItemId = Convert.ToInt32(row.Cells["ItemID"].Value);
                txtSelectedItem.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void InitializeCurrentCustomerOrders()
        {
            currentCustomerOrders.Columns.Add("OrderID", typeof(int));
            currentCustomerOrders.Columns.Add("TableNumber", typeof(int));
            currentCustomerOrders.Columns.Add("ItemID", typeof(int));
            currentCustomerOrders.Columns.Add("ItemName", typeof(string));
            currentCustomerOrders.Columns.Add("Quantity", typeof(int));
            currentCustomerOrders.Columns.Add("Price", typeof(double));
            currentCustomerOrders.Columns.Add("TotalPrice", typeof(double));
            currentCustomerOrders.Columns.Add("OrderStatus", typeof(string));
            currentCustomerOrders.Columns.Add("DateTime", typeof(DateTime));

            dgvOrders.DataSource = currentCustomerOrders;

            dgvOrders.Columns["OrderID"].HeaderText = "Order ID";
            dgvOrders.Columns["TableNumber"].HeaderText = "Table No";
            dgvOrders.Columns["ItemName"].HeaderText = "Food Item";
            dgvOrders.Columns["Quantity"].HeaderText = "Qty";
            dgvOrders.Columns["Price"].HeaderText = "Unit Price";
            dgvOrders.Columns["TotalPrice"].HeaderText = "Total Price";
            dgvOrders.Columns["OrderStatus"].HeaderText = "Status";
            dgvOrders.Columns["DateTime"].HeaderText = "Order Time";

            dgvOrders.Columns["ItemID"].Visible = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTableNumber.Text, out int tableNumber))
            {
                MessageBox.Show("Enter a valid table number");
                return;
            }

            currentTableNumber = tableNumber;

            if (selectedItemId == -1)
            {
                MessageBox.Show("Please select a food item first!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int orderQty) || orderQty <= 0)
            {
                MessageBox.Show("Enter a valid quantity!");
                return;
            }

            string checkStockQuery = "SELECT Availability, Name, Price FROM MenuItems WHERE ItemID = " + selectedItemId;
            DataTable dt = da.ExecuteQueryTable(checkStockQuery);
            if (dt.Rows.Count == 0) return;

            int availableQty = Convert.ToInt32(dt.Rows[0]["Availability"]);
            if (orderQty > availableQty)
            {
                MessageBox.Show("Not enough stock! Only " + availableQty + " left.");
                return;
            }

            string itemName = dt.Rows[0]["Name"].ToString();
            double unitPrice = Convert.ToDouble(dt.Rows[0]["Price"]);
            int tempOrderId = currentCustomerOrders.Rows.Count + 1;

            currentCustomerOrders.Rows.Add(tempOrderId, currentTableNumber, selectedItemId, itemName, orderQty, unitPrice,
                                          orderQty * unitPrice, "Pending", DateTime.Now);
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            double total = 0;
            foreach (DataRow row in currentCustomerOrders.Rows)
                total += Convert.ToDouble(row["TotalPrice"]);

            lblTotalAmount.Text = "Total: " + total + " TK ";
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            int rowIndex = dgvOrders.SelectedRows[0].Index;
            currentCustomerOrders.Rows[rowIndex].Delete();
            currentCustomerOrders.AcceptChanges();

            UpdateTotalLabel();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTableNumber.Clear();
            txtSelectedItem.Clear();
            txtQuantity.Clear();
            selectedItemId = -1;
            currentTableNumber = -1;
            currentCustomerOrders.Rows.Clear();
            UpdateTotalLabel();
        }

        private string GenerateOrderID()
        {
            string sql = "SELECT * FROM Orders ORDER BY OrderID DESC";
            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                string lastId = dt.Rows[0]["OrderID"].ToString(); // e.g. abc-005-def
                string[] parts = lastId.Split('-');

                int number = Convert.ToInt32(parts[1]);
                number++;

                return "abc-" + number.ToString("D3") + "-def";
            }
            else
            {
                return "abc-001-def";
            }
        }





        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (currentCustomerOrders.Rows.Count == 0)
            {
                MessageBox.Show("No orders to confirm!");
                return;
            }

            double totalAmount = 0;
            receiptText = "------ Receipt ------\n";
            receiptText += "Table No: " + currentTableNumber + "\n";
            receiptText += "---------------------\n";

            string newOrderId = GenerateOrderID();

            // 1. Insert into Orders (parent table)
            string insertOrder = "INSERT INTO Orders (OrderID, TableNo, Status) " +
                                 "VALUES ('" + newOrderId + "', " + currentTableNumber + ", 'Confirmed')";
            da.ExecuteUpdateQuery(insertOrder);

            // 2. Loop through each item and insert into OrderItems (child table)
            foreach (DataRow row in currentCustomerOrders.Rows)
            {
                string itemName = row["ItemName"].ToString();
                int itemId = Convert.ToInt32(row["ItemID"]);
                int qty = Convert.ToInt32(row["Quantity"]);
                double unitPrice = Convert.ToDouble(row["Price"]);
                double totalPrice = qty * unitPrice;

                receiptText += itemName + " x " + qty + " = " + totalPrice + "\n";
                totalAmount += totalPrice;

                // Insert into OrderItems
                string insertItem = "INSERT INTO OrderItems (OrderID, ItemID, Qty, Price) " +
                                    "VALUES ('" + newOrderId + "', " + itemId + ", " + qty + ", " + unitPrice + ")";
                da.ExecuteUpdateQuery(insertItem);

                // Update stock in MenuItems
                string updateStock = "UPDATE MenuItems SET Availability = Availability - " + qty +
                                     " WHERE ItemID = " + itemId;
                da.ExecuteUpdateQuery(updateStock);
            }

            receiptText += "---------------------\n";
            receiptText += "Total: " + totalAmount + " TK\n";
            receiptText += "---------------------\nThank you!";

            // Show print preview
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();

            // Clear session
            currentCustomerOrders.Rows.Clear();
            UpdateTotalLabel();
            LoadMenuItems();
            txtTableNumber.Clear();
            txtSelectedItem.Clear();
            txtQuantity.Clear();
            selectedItemId = -1;
            currentTableNumber = -1;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float scale = 1.5f;
            e.Graphics.ScaleTransform(scale, scale);
            e.Graphics.DrawString(receiptText, new Font("Courier New", 12), Brushes.Black, 50, 50);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int newQty) || newQty <= 0)
            {
                MessageBox.Show("Enter a valid new quantity.");
                return;
            }

            int rowIndex = dgvOrders.SelectedRows[0].Index;
            DataRow row = currentCustomerOrders.Rows[rowIndex];

            int oldQty = Convert.ToInt32(row["Quantity"]);
            int itemId = Convert.ToInt32(row["ItemID"]);

            string checkStockQuery = "SELECT Availability, Name, Price FROM MenuItems WHERE ItemID = " + itemId;
            DataTable dt = da.ExecuteQueryTable(checkStockQuery);

            if (dt.Rows.Count == 0) return;

            int availableQty = Convert.ToInt32(dt.Rows[0]["Availability"]);
            double unitPrice = Convert.ToDouble(dt.Rows[0]["Price"]);
            int qtyDifference = newQty - oldQty;

            if (qtyDifference > availableQty)
            {
                MessageBox.Show("Not enough stock! Only " + availableQty + " left.");
                return;
            }

            row["Quantity"] = newQty;
            row["TotalPrice"] = newQty * unitPrice;

            currentCustomerOrders.AcceptChanges();
            UpdateTotalLabel();

            MessageBox.Show("Order updated successfully (only in current session).");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SDashboard s = new SDashboard();
            s.Show();
            this.Close();
        }
    }
}
