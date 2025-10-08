namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class ExpensesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalExpense;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalExpense = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();

            // Start Label
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(25, 20);
            this.lblStart.Text = "Start Date:";

            // End Label
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(25, 55);
            this.lblEnd.Text = "End Date:";

            // Start Date Picker
            this.dtpStart.Location = new System.Drawing.Point(110, 17);
            this.dtpStart.Size = new System.Drawing.Size(200, 20);

            // End Date Picker
            this.dtpEnd.Location = new System.Drawing.Point(110, 52);
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);

            // Load Button
            this.btnLoad.Location = new System.Drawing.Point(330, 35);
            this.btnLoad.Size = new System.Drawing.Size(100, 30);
            this.btnLoad.Text = "Load Expenses";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // DataGridView
            this.dgvExpenses.Location = new System.Drawing.Point(25, 90);
            this.dgvExpenses.Size = new System.Drawing.Size(520, 200);
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.AllowUserToAddRows = false;

            // Total Label
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(25, 310);
            this.lblTotal.Text = "Total Expense:";

            // Total TextBox
            this.txtTotalExpense.Location = new System.Drawing.Point(110, 307);
            this.txtTotalExpense.Size = new System.Drawing.Size(120, 20);
            this.txtTotalExpense.ReadOnly = true;

            // Back Button
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(460, 305);
            this.btnBack.Size = new System.Drawing.Size(85, 30);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalExpense);
            this.Controls.Add(this.btnBack);
            this.Name = "ExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Report";

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
