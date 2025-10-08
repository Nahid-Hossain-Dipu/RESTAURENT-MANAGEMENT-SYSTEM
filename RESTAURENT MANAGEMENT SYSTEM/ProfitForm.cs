using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class ProfitForm : Form
    {
        private DataAccess Da = new DataAccess();

        public ProfitForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string start = dtpStart.Value.ToString("yyyy-MM-dd");
            string end = dtpEnd.Value.ToString("yyyy-MM-dd");

            string sql =
                "SELECT " +
                "ISNULL(( " +
                "   SELECT SUM(O.Qty * O.Price) " +
                "   FROM OrderItems O " +
                "   JOIN Orders R ON O.OrderID = R.OrderID " +
                "   WHERE CONVERT(date, R.OrderDate) >= '" + start + "' " +
                "   AND CONVERT(date, R.OrderDate) <= '" + end + "' " +
                "), 0) AS TotalRevenue, " +

                "ISNULL(( " +
                "   SELECT SUM(S.BaseSalary + S.Bonus - S.Deduction) " +
                "   FROM Salary S " +
                "   WHERE CONVERT(date, S.SalaryMonth) >= '" + start + "' " +
                "   AND CONVERT(date, S.SalaryMonth) <= '" + end + "' " +
                "), 0) AS TotalSalaries, " +

                "ISNULL(( " +
                "   SELECT SUM(P.QuantityPurchased * P.UnitPrice) " +
                "   FROM RawMaterialPurchases P " +
                "   WHERE CONVERT(date, P.PurchaseDate) >= '" + start + "' " +
                "   AND CONVERT(date, P.PurchaseDate) <= '" + end + "' " +
                "), 0) AS RawMaterialCost";

            try
            {
                DataTable dt = Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    decimal revenue = Convert.ToDecimal(dt.Rows[0]["TotalRevenue"]);
                    decimal salaries = Convert.ToDecimal(dt.Rows[0]["TotalSalaries"]);
                    decimal materialCost = Convert.ToDecimal(dt.Rows[0]["RawMaterialCost"]);
                    decimal profit = revenue - salaries - materialCost;

                    txtRevenue.Text = revenue.ToString("0.00");
                    txtSalaries.Text = salaries.ToString("0.00");
                    txtMaterials.Text = materialCost.ToString("0.00");
                    txtProfit.Text = profit.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating profit: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccountantDashboard acc = new AccountantDashboard();
            acc.Show();
            this.Hide();
        }
    }
}
