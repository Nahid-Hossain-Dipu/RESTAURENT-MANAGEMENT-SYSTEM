namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class SalesReport
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnThisWeek = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Repotrs";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(185, 75);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 22);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(185, 115);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 22);
            this.dtpTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(109, 272);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(606, 225);
            this.dgvSales.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(202, 172);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(133, 37);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(564, 75);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(141, 37);
            this.btnToday.TabIndex = 7;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.BackColor = System.Drawing.Color.White;
            this.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesterday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.Location = new System.Drawing.Point(564, 118);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(141, 37);
            this.btnYesterday.TabIndex = 8;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = false;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.BackColor = System.Drawing.Color.White;
            this.btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisWeek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisWeek.Location = new System.Drawing.Point(564, 161);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(141, 37);
            this.btnThisWeek.TabIndex = 9;
            this.btnThisWeek.Text = "ThisWeek";
            this.btnThisWeek.UseVisualStyleBackColor = false;
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(564, 216);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(141, 37);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(698, 602);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.BackColor = System.Drawing.Color.Red;
            this.lblTotalOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrders.Location = new System.Drawing.Point(153, 550);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(133, 31);
            this.lblTotalOrders.TabIndex = 12;
            this.lblTotalOrders.Text = "Total Sales:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Red;
            this.lblTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(548, 550);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(167, 31);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(818, 651);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnThisWeek);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnThisWeek;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}