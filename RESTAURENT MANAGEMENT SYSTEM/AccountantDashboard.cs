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
    public partial class AccountantDashboard : Form
    {
        public AccountantDashboard()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesReport s1 = new SalesReport();
            s1.Show();
            this.Close();
        }

        private void btnSlManagement_Click(object sender, EventArgs e)
        {
            SalaryManagement sl = new SalaryManagement();
            sl.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Close();
        }
    }
}
