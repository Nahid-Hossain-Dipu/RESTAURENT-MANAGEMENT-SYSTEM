using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class ManageUsers : Form
    {
        private DataAccess dataAccess;
        private int selectedUserId = -1;

        public ManageUsers()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            cmbFilter.SelectedIndex = 0;
            LoadUsers("All");
        }

        private void LoadUsers(string roleFilter = "All")
        {
            try
            {
                string query = "SELECT UserID, Username, Role FROM Users";
                SqlCommand cmd;

                if (roleFilter != "All")
                {
                    query += " WHERE Role = @role";
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                    cmd.Parameters.AddWithValue("@role", roleFilter);
                }
                else
                {
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewUsers.DataSource = dt;

                if (dataGridViewUsers.Columns["UserID"] != null)
                    dataGridViewUsers.Columns["UserID"].Visible = false;

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
            btnAddUser.Enabled = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            try
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(query, dataAccess.Sqlcon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("User added successfully!");
                    LoadUsers(cmbFilter.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = "";
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
                btnAddUser.Enabled = false;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill Username and Role fields.");
                return;
            }

            try
            {
                // Update password only if provided, else leave unchanged
                string query;
                SqlCommand cmd;

                if (!string.IsNullOrEmpty(password))
                {
                    query = "UPDATE Users SET Username = @username, Password = @password, Role = @role WHERE UserID = @userId";
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                    cmd.Parameters.AddWithValue("@password", password);
                }
                else
                {
                    query = "UPDATE Users SET Username = @username, Role = @role WHERE UserID = @userId";
                    cmd = new SqlCommand(query, dataAccess.Sqlcon);
                }

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@userId", selectedUserId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("User updated successfully!");
                    LoadUsers(cmbFilter.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Failed to update user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Users WHERE UserID = @userId";
                    SqlCommand cmd = new SqlCommand(query, dataAccess.Sqlcon);
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("User deleted successfully!");
                        LoadUsers(cmbFilter.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dataGridViewUsers.ClearSelection();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbFilter.SelectedItem.ToString();
            LoadUsers(selectedRole);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard  ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
