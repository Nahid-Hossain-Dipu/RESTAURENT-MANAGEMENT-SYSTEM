using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    public partial class ReservationForm : Form
    {
        private DataAccess da;

        public ReservationForm()
        {
            InitializeComponent();  
            da = new DataAccess();

           
            cmbStatus.Items.AddRange(new string[] { "Pending", "Confirmed", "Cancelled" });

            LoadReservations();
        }

        private void LoadReservations()
        {
            string sql = "SELECT * FROM Reservation";
            DataTable dt = da.ExecuteQueryTable(sql);
            dgvReservations.DataSource = dt;
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            string reservationTime = dtpReservationTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            int tableNumber = Convert.ToInt32(cmbTableNumber.Value);

            string sql = $@" INSERT INTO Reservation (ReservationTime, CustomerName, TableNumber, Status)
        VALUES ('{reservationTime}', '{txtCustomerName.Text}', {tableNumber}, '{cmbStatus.Text}')";

            int result = da.ExecuteUpdateQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Reservation saved successfully!");

                 
                LoadReservations();
            }
            else
            {
                MessageBox.Show("Failed to save reservation.");
            }
        }
        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                txtCustomerName.Text = dgvReservations.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                dtpReservationTime.Value = Convert.ToDateTime(dgvReservations.SelectedRows[0].Cells["ReservationTime"].Value);
                cmbTableNumber.Value = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["TableNumber"].Value);
                cmbStatus.Text = dgvReservations.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to update.");
                return;
            }

             
            int reservationId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationId"].Value);

           
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }

            int tableNumber = Convert.ToInt32(cmbTableNumber.Value);
            if (tableNumber <= 0)
            {
                MessageBox.Show("Please enter a valid table number.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

             
            string sql = $@"PDATE Reservation
            SET ReservationTime = '{dtpReservationTime.Value}',
            CustomerName = '{txtCustomerName.Text.Trim()}',
            TableNumber = {tableNumber},
            Status = '{cmbStatus.Text}'
        WHERE ReservationId = {reservationId}";

            
            try
            {
                int result = da.ExecuteUpdateQuery(sql);  
                if (result > 0)
                {
                    MessageBox.Show("Reservation updated successfully!");
                    LoadReservations();  
                }
                else
                {
                    MessageBox.Show("No changes were made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.");
                return;
            }

           
            int reservationId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationId"].Value);

            
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this reservation?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            // Prepare SQL query
            string sql = $"DELETE FROM Reservation WHERE ReservationId = {reservationId}";

            try
            {
                 
                int result = da.ExecuteUpdateQuery(sql);  

                if (result > 0)
                {
                    MessageBox.Show("Reservation deleted successfully!");
                    LoadReservations(); 
                }
                else
                {
                    MessageBox.Show("Delete failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SDashboard s = new SDashboard();
            s.Show();
            this.Hide();
        }
    }
}
