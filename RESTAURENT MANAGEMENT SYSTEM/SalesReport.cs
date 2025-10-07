using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class SalesReport : Form
    {
        DataAccess da = new DataAccess();
        public SalesReport()
        { 
            InitializeComponent();
            LoadSalesData("ALL");
        }

        private void LoadSalesData(string filterType, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                string query = @"
                    SELECT 
                        o.OrderID,
                        o.TableNo AS TableNumber,
                        o.OrderDate,
                        SUM(oi.Qty * oi.Price) AS TotalAmount
                    FROM Orders o
                    INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                    WHERE o.Status = 'Served'";

                // Apply filters
                if (filterType == "TODAY")
                    query += " AND CAST(o.OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                else if (filterType == "YESTERDAY")
                    query += " AND CAST(o.OrderDate AS DATE) = CAST(DATEADD(day, -1, GETDATE()) AS DATE)";
                else if (filterType == "WEEK")
                    query += " AND DATEPART(week, o.OrderDate) = DATEPART(week, GETDATE()) AND YEAR(o.OrderDate) = YEAR(GETDATE())";
                else if (filterType == "CUSTOM" && startDate.HasValue && endDate.HasValue)
                    query += $" AND o.OrderDate BETWEEN '{startDate.Value:yyyy-MM-dd}' AND '{endDate.Value:yyyy-MM-dd}'";

                query += " GROUP BY o.OrderID, o.TableNo, o.OrderDate ORDER BY o.OrderDate DESC";

                DataTable dt = da.ExecuteQueryTable(query);
                dgvSales.DataSource = dt;

                // Formatting columns
                if (dt.Rows.Count > 0)
                {
                    dgvSales.Columns["OrderID"].HeaderText = "Order ID";
                    dgvSales.Columns["TableNumber"].HeaderText = "Table No";
                    dgvSales.Columns["OrderDate"].HeaderText = "Order Date";
                    dgvSales.Columns["TotalAmount"].HeaderText = "Total Amount (Tk)";
                }

                // Summary
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                    total += Convert.ToDecimal(row["TotalAmount"]);

                lblTotalOrders.Text = "Total Orders: " + dt.Rows.Count;
                lblTotalAmount.Text = "Total Amount: Tk " + total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccountantDashboard A = new AccountantDashboard();
            A.Show();
            this.Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            LoadSalesData("TODAY");
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            LoadSalesData("YESTERDAY");
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            LoadSalesData("WEEK");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadSalesData("ALL");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadSalesData("CUSTOM", dtpFrom.Value, dtpTo.Value);
        }
    }
}
