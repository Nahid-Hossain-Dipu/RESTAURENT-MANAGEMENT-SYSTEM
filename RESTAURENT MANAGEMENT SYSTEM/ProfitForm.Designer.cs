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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(31, 102);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(122, 23);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(30, 147);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(123, 23);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(184, 107);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(184, 152);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(372, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Profit";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(31, 263);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(167, 23);
            this.lblRevenue.TabIndex = 5;
            this.lblRevenue.Text = "Total Revenue:";
            // 
            // lblSalaries
            // 
            this.lblSalaries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaries.ForeColor = System.Drawing.Color.White;
            this.lblSalaries.Location = new System.Drawing.Point(31, 300);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(143, 23);
            this.lblSalaries.TabIndex = 7;
            this.lblSalaries.Text = "Total Salaries:";
            // 
            // lblMaterials
            // 
            this.lblMaterials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterials.ForeColor = System.Drawing.Color.White;
            this.lblMaterials.Location = new System.Drawing.Point(30, 339);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(192, 23);
            this.lblMaterials.TabIndex = 9;
            this.lblMaterials.Text = "Raw Material Cost:";
            // 
            // lblProfit
            // 
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.Color.White;
            this.lblProfit.Location = new System.Drawing.Point(31, 379);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(181, 23);
            this.lblProfit.TabIndex = 11;
            this.lblProfit.Text = "Estimated Profit:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(228, 270);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(100, 22);
            this.txtRevenue.TabIndex = 6;
            // 
            // txtSalaries
            // 
            this.txtSalaries.Location = new System.Drawing.Point(228, 307);
            this.txtSalaries.Name = "txtSalaries";
            this.txtSalaries.Size = new System.Drawing.Size(100, 22);
            this.txtSalaries.TabIndex = 8;
            // 
            // txtMaterials
            // 
            this.txtMaterials.Location = new System.Drawing.Point(228, 340);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.Size = new System.Drawing.Size(100, 22);
            this.txtMaterials.TabIndex = 10;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(228, 380);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(100, 22);
            this.txtProfit.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(447, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 39);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Profit Calculation";
            // 
            // ProfitForm
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 491);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}
