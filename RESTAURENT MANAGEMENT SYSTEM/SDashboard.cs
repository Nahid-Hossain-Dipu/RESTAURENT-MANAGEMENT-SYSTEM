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
    public partial class SDashboard : Form
    {
        public SDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffDashboard l = new StaffDashboard();
            this.Hide();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ReservationForm l2 = new  ReservationForm();
            this.Hide();
            l2.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.Show();
            this.Hide();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            OrderStatus o = new OrderStatus();
            o.Show();
            this.Hide();
        }
    }
}
