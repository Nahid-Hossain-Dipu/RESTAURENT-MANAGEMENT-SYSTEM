using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT role FROM Users WHERE Username=@username AND password=@password";

            DataAccess da = new DataAccess();   // 🔥 No using, just normal object
            try
            {
                SqlCommand cmd = new SqlCommand(query, da.Sqlcon);
                cmd.Parameters.AddWithValue("@username", this.textUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", this.textPassword.Text.Trim());

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["role"].ToString();
                    MessageBox.Show("Login Successful as " + role);

                    Form dashboard = null;
                    switch (role)
                    {
                        case "Admin":
                            dashboard = new AdminDashboard();
                            break;
                        case "Staff":
                            dashboard = new SDashboard();
                            break;
                        case "Chef":
                            dashboard = new ChefDashboard();
                            break;
                        case "Accountant":
                            dashboard = new AccountantDashboard();
                            break;
                        default:
                            MessageBox.Show("Unknown role!");
                            return;
                    }

                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Login Invalid!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (da.Sqlcon != null && da.Sqlcon.State == ConnectionState.Open)
                    da.Sqlcon.Close();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            textPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }
    }
}
