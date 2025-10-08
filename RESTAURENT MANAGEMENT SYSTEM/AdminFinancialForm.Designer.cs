namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class AdminFinancialForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;

        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridView dgvMaterials;

        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblMaterials;

        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalSalaries;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalProfit;

        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.TextBox txtTotalSalaries;
        private System.Windows.Forms.TextBox txtTotalCost;

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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalSalaries = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.txtTotalSalaries = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtTotalProfit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(30, 25);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(313, 24);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(55, 13);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(94, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(197, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(374, 20);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(600, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(840, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(720, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.Location = new System.Drawing.Point(30, 85);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.Size = new System.Drawing.Size(900, 160);
            this.dgvRevenue.TabIndex = 10;
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaries.Location = new System.Drawing.Point(30, 285);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.ReadOnly = true;
            this.dgvSalaries.Size = new System.Drawing.Size(900, 160);
            this.dgvSalaries.TabIndex = 11;
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.Location = new System.Drawing.Point(30, 485);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.Size = new System.Drawing.Size(900, 160);
            this.dgvMaterials.TabIndex = 12;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(30, 65);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(94, 13);
            this.lblRevenue.TabIndex = 7;
            this.lblRevenue.Text = "Revenue (Orders):";
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.Location = new System.Drawing.Point(30, 265);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(71, 13);
            this.lblSalaries.TabIndex = 8;
            this.lblSalaries.Text = "Paid Salaries:";
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(30, 465);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(125, 13);
            this.lblMaterials.TabIndex = 9;
            this.lblMaterials.Text = "Raw Material Purchases:";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Location = new System.Drawing.Point(30, 660);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblTotalRevenue.TabIndex = 13;
            this.lblTotalRevenue.Text = "Total Revenue:";
            // 
            // lblTotalSalaries
            // 
            this.lblTotalSalaries.Location = new System.Drawing.Point(250, 660);
            this.lblTotalSalaries.Name = "lblTotalSalaries";
            this.lblTotalSalaries.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSalaries.TabIndex = 15;
            this.lblTotalSalaries.Text = "Total Salaries:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Location = new System.Drawing.Point(470, 660);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCost.TabIndex = 17;
            this.lblTotalCost.Text = "Total Material Cost:";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Location = new System.Drawing.Point(720, 660);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(100, 23);
            this.lblTotalProfit.TabIndex = 19;
            this.lblTotalProfit.Text = "Total Profit:";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(130, 657);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.ReadOnly = true;
            this.txtTotalRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRevenue.TabIndex = 14;
            // 
            // txtTotalSalaries
            // 
            this.txtTotalSalaries.Location = new System.Drawing.Point(350, 657);
            this.txtTotalSalaries.Name = "txtTotalSalaries";
            this.txtTotalSalaries.ReadOnly = true;
            this.txtTotalSalaries.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSalaries.TabIndex = 16;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(600, 657);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 18;
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.Location = new System.Drawing.Point(826, 657);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.Size = new System.Drawing.Size(132, 20);
            this.txtTotalProfit.TabIndex = 20;
            // 
            // AdminFinancialForm
            // 
            this.ClientSize = new System.Drawing.Size(970, 710);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblSalaries);
            this.Controls.Add(this.lblMaterials);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.dgvSalaries);
            this.Controls.Add(this.dgvMaterials);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.txtTotalRevenue);
            this.Controls.Add(this.lblTotalSalaries);
            this.Controls.Add(this.txtTotalSalaries);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.txtTotalProfit);
            this.Name = "AdminFinancialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Financial Overview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTotalProfit;
    }
}
