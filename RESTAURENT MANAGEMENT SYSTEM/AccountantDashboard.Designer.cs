namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class AccountantDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnProfit = new System.Windows.Forms.Button();
            this.btnSlManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accountant Dashboard";
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Black;
            this.btnSales.Location = new System.Drawing.Point(416, 95);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(136, 43);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales Reports";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.White;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.Location = new System.Drawing.Point(416, 154);
            this.btnExpense.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(136, 39);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "Expense ";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnProfit
            // 
            this.btnProfit.BackColor = System.Drawing.Color.White;
            this.btnProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfit.Location = new System.Drawing.Point(416, 275);
            this.btnProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(136, 39);
            this.btnProfit.TabIndex = 3;
            this.btnProfit.Text = "Profit Summary ";
            this.btnProfit.UseVisualStyleBackColor = false;
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // btnSlManagement
            // 
            this.btnSlManagement.BackColor = System.Drawing.Color.White;
            this.btnSlManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlManagement.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlManagement.Location = new System.Drawing.Point(416, 213);
            this.btnSlManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlManagement.Name = "btnSlManagement";
            this.btnSlManagement.Size = new System.Drawing.Size(136, 39);
            this.btnSlManagement.TabIndex = 4;
            this.btnSlManagement.Text = "Salary Management";
            this.btnSlManagement.UseVisualStyleBackColor = false;
            this.btnSlManagement.Click += new System.EventHandler(this.btnSlManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(416, 332);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 41);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AccountantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(632, 417);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSlManagement);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountantDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnProfit;
        private System.Windows.Forms.Button btnSlManagement;
        private System.Windows.Forms.Button btnLogout;
    }
}