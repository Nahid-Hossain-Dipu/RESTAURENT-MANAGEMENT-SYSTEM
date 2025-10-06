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
    public partial class CookingHistory : Form
    {
        private DataAccess da;
        public CookingHistory()
        {
            InitializeComponent();
            da = new DataAccess();
            LoadCookingHistory("TODAY"); // Load today's history by default
        }
        private void LoadCookingHistory(string filterType)
        {
            try
            {
                string sql = @"SELECT 
                                o.OrderID,
                                o.TableNo AS TableNumber,
                                o.Status AS OrderStatus,
                                o.OrderDate AS OrderDate,
                                SUM(oi.Price) AS TotalAmount
                            FROM Orders o
                            INNER JOIN OrderItems oi ON o.OrderID = oi.OrderID
                            WHERE o.Status IN ('Ready', 'Done')";

                // Add filter conditions
                if (filterType == "TODAY")
                    sql += " AND CAST(o.OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                else if (filterType == "WEEK")
                    sql += " AND o.OrderDate >= DATEADD(DAY, -7, GETDATE())";
                else if (filterType == "MONTH")
                    sql += " AND MONTH(o.OrderDate) = MONTH(GETDATE()) AND YEAR(o.OrderDate) = YEAR(GETDATE())";
                else if (filterType == "CUSTOM")
                    sql += $" AND o.OrderDate BETWEEN '{dtpFrom.Value:yyyy-MM-dd}' AND '{dtpTo.Value:yyyy-MM-dd}'";

                sql += " GROUP BY o.OrderID, o.TableNo, o.Status, o.OrderDate ORDER BY o.OrderDate DESC";

                DataTable dt = da.ExecuteQueryTable(sql);
                dgvCookingHistory.DataSource = dt;

                // Calculate totals
                int totalOrders = dt.Rows.Count;
                // decimal totalRevenue = 0;

                //foreach (DataRow row in dt.Rows)
                //{
                //    if (decimal.TryParse(row["TotalAmount"].ToString(), out decimal val))
                //        totalRevenue += val;
                //}

                lblTotalOrders.Text = $"Total Orders Cooked: {totalOrders}";
                //lblTotalAmount.Text = $"Total Revenue: {totalRevenue} Tk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cooking history: " + ex.Message);
            }
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChefDashboard dashboard = new ChefDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            LoadCookingHistory("MONTH");
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            LoadCookingHistory("WEEK");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            LoadCookingHistory("TODAY");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCookingHistory("CUSTOM");
        }
    }
}