using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class AdminFinancialForm : Form
    {
        private DataAccess Da = new DataAccess();

        public AdminFinancialForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void LoadGridData()
        {
            string start = dtpStart.Value.ToString("yyyy-MM-dd");
            string end = dtpEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                // 1️⃣ Revenue from Orders
                string sqlRevenue =
                    "SELECT O.OrderID, O.TableNo, O.OrderDate, O.Status, " +
                    "SUM(I.Qty * I.Price) AS TotalAmount " +
                    "FROM Orders O " +
                    "JOIN OrderItems I ON O.OrderID = I.OrderID " +
                    "WHERE CONVERT(date, O.OrderDate) >= '" + start + "' " +
                    "AND CONVERT(date, O.OrderDate) <= '" + end + "' " +
                    "GROUP BY O.OrderID, O.TableNo, O.OrderDate, O.Status";

                DataTable dtRevenue = Da.ExecuteQueryTable(sqlRevenue);
                dgvRevenue.DataSource = dtRevenue;

                // 2️⃣ Salaries Paid
                string sqlSalaries =
                    "SELECT S.SalaryID, U.Username, S.BaseSalary, S.Bonus, S.Deduction, " +
                    "(S.BaseSalary + S.Bonus - S.Deduction) AS NetSalary, " +
                    "S.SalaryMonth, S.PaymentDate " +
                    "FROM Salary S " +
                    "JOIN Users U ON S.UserID = U.UserID " +
                    "WHERE CONVERT(date, S.PaymentDate) >= '" + start + "' " +
                    "AND CONVERT(date, S.PaymentDate) <= '" + end + "'";

                DataTable dtSalaries = Da.ExecuteQueryTable(sqlSalaries);
                dgvSalaries.DataSource = dtSalaries;

                // 3️⃣ Raw Material Purchases
                string sqlMaterials =
                    "SELECT P.PurchaseID, M.Name AS MaterialName, P.QuantityPurchased, P.UnitPrice, " +
                    "(P.QuantityPurchased * P.UnitPrice) AS TotalCost, P.PurchaseDate " +
                    "FROM RawMaterialPurchases P " +
                    "JOIN RawMaterials M ON P.RawMaterialID = M.RawMaterialID " +
                    "WHERE CONVERT(date, P.PurchaseDate) >= '" + start + "' " +
                    "AND CONVERT(date, P.PurchaseDate) <= '" + end + "'";

                DataTable dtMaterials = Da.ExecuteQueryTable(sqlMaterials);
                dgvMaterials.DataSource = dtMaterials;

                // Totals
                decimal totalRevenue = 0, totalSalaries = 0, totalCost = 0;

                foreach (DataRow r in dtRevenue.Rows)
                    totalRevenue += Convert.ToDecimal(r["TotalAmount"]);

                foreach (DataRow r in dtSalaries.Rows)
                    totalSalaries += Convert.ToDecimal(r["NetSalary"]);

                foreach (DataRow r in dtMaterials.Rows)
                    totalCost += Convert.ToDecimal(r["TotalCost"]);

                decimal totalProfit = totalRevenue - totalSalaries - totalCost;

                txtTotalRevenue.Text = totalRevenue.ToString("0.00");
                txtTotalSalaries.Text = totalSalaries.ToString("0.00");
                txtTotalCost.Text = totalCost.ToString("0.00");
                txtTotalProfit.Text = totalProfit.ToString("0.00");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading financial data: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 100;
            Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 10);

            e.Graphics.DrawString("Restaurant Financial Report", titleFont, Brushes.Black, 300, yPos);
            yPos += 40;
            e.Graphics.DrawString("From " + dtpStart.Value.ToLongDateString() + " To " + dtpEnd.Value.ToLongDateString(), normalFont, Brushes.Black, 100, yPos);

            yPos += 40;
            e.Graphics.DrawString("Total Revenue: " + txtTotalRevenue.Text, normalFont, Brushes.Black, 100, yPos);
            yPos += 25;
            e.Graphics.DrawString("Total Salaries: " + txtTotalSalaries.Text, normalFont, Brushes.Black, 100, yPos);
            yPos += 25;
            e.Graphics.DrawString("Total Material Cost: " + txtTotalCost.Text, normalFont, Brushes.Black, 100, yPos);
            yPos += 25;
            e.Graphics.DrawString("Total Profit: " + txtTotalProfit.Text, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, 100, yPos);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
