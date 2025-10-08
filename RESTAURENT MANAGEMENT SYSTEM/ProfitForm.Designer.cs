namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class ProfitForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtSalaries;
        private System.Windows.Forms.TextBox txtMaterials;
        private System.Windows.Forms.TextBox txtProfit;

        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtSalaries = new System.Windows.Forms.TextBox();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(30, 30);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 23);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(30, 70);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(100, 23);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(136, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(136, 70);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(136, 109);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Profit";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.Location = new System.Drawing.Point(30, 160);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblRevenue.TabIndex = 5;
            this.lblRevenue.Text = "Total Revenue:";
            // 
            // lblSalaries
            // 
            this.lblSalaries.Location = new System.Drawing.Point(30, 190);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(100, 23);
            this.lblSalaries.TabIndex = 7;
            this.lblSalaries.Text = "Total Salaries:";
            // 
            // lblMaterials
            // 
            this.lblMaterials.Location = new System.Drawing.Point(30, 220);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(100, 23);
            this.lblMaterials.TabIndex = 9;
            this.lblMaterials.Text = "Raw Material Cost:";
            // 
            // lblProfit
            // 
            this.lblProfit.Location = new System.Drawing.Point(30, 250);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(100, 23);
            this.lblProfit.TabIndex = 11;
            this.lblProfit.Text = "Estimated Profit:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(136, 157);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtRevenue.TabIndex = 6;
            // 
            // txtSalaries
            // 
            this.txtSalaries.Location = new System.Drawing.Point(136, 187);
            this.txtSalaries.Name = "txtSalaries";
            this.txtSalaries.Size = new System.Drawing.Size(100, 20);
            this.txtSalaries.TabIndex = 8;
            // 
            // txtMaterials
            // 
            this.txtMaterials.Location = new System.Drawing.Point(136, 220);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(100, 20);
            this.txtMaterials.TabIndex = 10;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(136, 250);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(100, 20);
            this.txtProfit.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(251, 277);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProfitForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.lblSalaries);
            this.Controls.Add(this.txtSalaries);
            this.Controls.Add(this.lblMaterials);
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.txtProfit);
            this.Name = "ProfitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnBack;
    }
}
