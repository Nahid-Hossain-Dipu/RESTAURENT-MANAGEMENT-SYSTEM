using System;
using System.Data;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class SalaryManagement : Form
    {
        DataAccess da = new DataAccess();

        public SalaryManagement()
        {
            InitializeComponent();
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadSalaryRecords();
        }

        private void LoadUsers()
        {
            string query = "SELECT UserID, Username FROM Users";
            DataTable dt = da.ExecuteQueryTable(query);

            cmbRole.DisplayMember = "Username";
            cmbRole.ValueMember = "UserID";
            cmbRole.DataSource = dt;
        }

        private void CmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedValue != null && int.TryParse(cmbRole.SelectedValue.ToString(), out int userId))
            {
                string query = "SELECT Role FROM Users WHERE UserID = " + userId;
                DataTable dt = da.ExecuteQueryTable(query);
                if (dt.Rows.Count > 0)
                {
                    textBox1.Text = dt.Rows[0]["Role"].ToString();
                }
            }

            // Reset Bonus and Deduction
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void BtnPaySalary_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            int userId = Convert.ToInt32(cmbRole.SelectedValue);
            decimal baseSalary = 0, bonus = 0, deduction = 0;

            if (!decimal.TryParse(textBox2.Text, out baseSalary))
            {
                MessageBox.Show("Invalid Base Salary");
                return;
            }

            decimal.TryParse(textBox3.Text, out bonus);
            decimal.TryParse(textBox4.Text, out deduction);

            string salaryMonth = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = "INSERT INTO Salary (UserID, BaseSalary, Bonus, Deduction, SalaryMonth) " +
                           "VALUES (" + userId + ", " + baseSalary + ", " + bonus + ", " + deduction + ", '" + salaryMonth + "')";

            int rowsAffected = da.ExecuteUpdateQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Salary paid successfully!");
                LoadSalaryRecords();
            }
            else
            {
                MessageBox.Show("Failed to pay salary.");
            }
        }

        private void LoadSalaryRecords()
        {
            string query = "SELECT s.SalaryID, u.Username, u.Role, s.BaseSalary, s.Bonus, s.Deduction, " +
                           "s.NetSalary, s.SalaryMonth, s.PaymentDate " +
                           "FROM Salary s " +
                           "JOIN Users u ON s.UserID = u.UserID " +
                           "ORDER BY s.PaymentDate ASC";

            DataTable dt = da.ExecuteQueryTable(query);
            dataGridView1.DataSource = dt;

            CalculateTotalSalary(dt);
        }

        private void BtnFilterSalary_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker2.Value.Date;
            DateTime to = dateTimePicker3.Value.Date;

            // Adjust 'to' to include the entire day
            to = to.AddDays(1).AddTicks(-1);

            string query = "SELECT s.SalaryID, u.Username, u.Role, s.BaseSalary, s.Bonus, s.Deduction, " +
                           "s.NetSalary, s.SalaryMonth, s.PaymentDate " +
                           "FROM Salary s " +
                           "JOIN Users u ON s.UserID = u.UserID " +
                           "WHERE s.PaymentDate IS NOT NULL AND s.PaymentDate BETWEEN '"
                           + from.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + to.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                           "ORDER BY s.PaymentDate ASC";

            DataTable dt = da.ExecuteQueryTable(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No salary records found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = dt;

            CalculateTotalSalary(dt);
        }

        private void CalculateTotalSalary(DataTable dt)
        {
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["NetSalary"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["NetSalary"]);
                }
            }

            label12.Text = "Total Salary Paid: " + total.ToString("0.00");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AccountantDashboard acc = new AccountantDashboard();
            acc.Show();
            this.Close();
        }
    }
}
