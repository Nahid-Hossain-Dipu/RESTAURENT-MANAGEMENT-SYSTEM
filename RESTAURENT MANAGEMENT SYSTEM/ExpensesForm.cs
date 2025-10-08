using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class ExpensesForm : Form
    {
        private DataAccess Da = new DataAccess();

        public ExpensesForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string start = dtpStart.Value.ToString("yyyy-MM-dd");
            string end = dtpEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                // Combine both salary and purchase expenses into one dataset
                string sql =
                    "SELECT 'Salary Payment' AS ExpenseType, " +
                    "U.Username AS Description, " +
                    "(S.BaseSalary + S.Bonus - S.Deduction) AS Amount, " +
                    "CONVERT(date, S.PaymentDate) AS Date " +
                    "FROM Salary S " +
                    "JOIN Users U ON S.UserID = U.UserID " +
                    "WHERE CONVERT(date, S.PaymentDate) BETWEEN '" + start + "' AND '" + end + "' " +
                    "UNION ALL " +
                    "SELECT 'Raw Material Purchase' AS ExpenseType, " +
                    "R.Name AS Description, " +
                    "(P.QuantityPurchased * P.UnitPrice) AS Amount, " +
                    "CONVERT(date, P.PurchaseDate) AS Date " +
                    "FROM RawMaterialPurchases P " +
                    "JOIN RawMaterials R ON P.RawMaterialID = R.RawMaterialID " +
                    "WHERE CONVERT(date, P.PurchaseDate) BETWEEN '" + start + "' AND '" + end + "' " +
                    "ORDER BY Date";

                DataTable dt = Da.ExecuteQueryTable(sql);
                dgvExpenses.DataSource = dt;

                // Calculate total expense
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["Amount"]);
                }

                txtTotalExpense.Text = total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expenses: " + ex.Message);
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
