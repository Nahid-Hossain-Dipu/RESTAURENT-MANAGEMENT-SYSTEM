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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsersForm = new ManageUsers();
            manageUsersForm.Show();
            this.Hide();
        }
        private void btnManageMenuItems_Click(object sender, EventArgs e)
        {
            ManageMenuItems manageMenuItemsForm = new ManageMenuItems();
            manageMenuItemsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
