using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{

    public partial class Feedback : Form
    {
        private DataAccess da;
        public Feedback()
        {
            InitializeComponent();
            da = new DataAccess();

            cmbRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cmbRating.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCustomerName.Text.Trim();
                int tableNo = (int)numTableNumber.Value;
                int rating = 0;

                if (cmbRating.SelectedItem != null)
                {
                    rating = Convert.ToInt32(cmbRating.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Please select a rating.");
                    return;
                }


                string feedbackText = txtFeedback.Text.Trim();

                if (name == "" || feedbackText == "")
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                string sql = $@"
                    INSERT INTO CustomerFeedback (CustomerName, TableNumber, Rating, FeedbackText)
                    VALUES ('{name}', {tableNo}, {rating}, '{feedbackText}')";

                int rows = da.ExecuteUpdateQuery(sql);

                if (rows > 0)
                {
                    MessageBox.Show("Feedback saved successfully!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to save feedback.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM CustomerFeedback ORDER BY FeedbackDate  DESC";
                DataTable dt = da.ExecuteQueryTable(sql);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SDashboard d1 = new SDashboard();
            d1.Show();
            this.Hide();
        }
        private void ClearForm()
        {
            txtCustomerName.Clear();
            numTableNumber.Value = 0;
            txtFeedback.Clear();

            cmbRating.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
