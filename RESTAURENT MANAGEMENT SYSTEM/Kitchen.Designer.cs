namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class Kitchen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKitchenOrders = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Start_Cooking = new System.Windows.Forms.Button();
            this.Mark_Ready = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitchenOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvKitchenOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKitchenOrders.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKitchenOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKitchenOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitchenOrders.Location = new System.Drawing.Point(31, 67);
            this.dgvKitchenOrders.Name = "dgvKitchenOrders";
            this.dgvKitchenOrders.RowHeadersWidth = 51;
            this.dgvKitchenOrders.RowTemplate.Height = 24;
            this.dgvKitchenOrders.Size = new System.Drawing.Size(853, 267);
            this.dgvKitchenOrders.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Orange;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(31, 426);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(145, 40);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Start_Cooking
            // 
            this.Start_Cooking.BackColor = System.Drawing.Color.Orange;
            this.Start_Cooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Cooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Cooking.ForeColor = System.Drawing.Color.Black;
            this.Start_Cooking.Location = new System.Drawing.Point(253, 425);
            this.Start_Cooking.Name = "Start_Cooking";
            this.Start_Cooking.Size = new System.Drawing.Size(172, 40);
            this.Start_Cooking.TabIndex = 2;
            this.Start_Cooking.Text = "Start Cooking";
            this.Start_Cooking.UseVisualStyleBackColor = false;
            this.Start_Cooking.Click += new System.EventHandler(this.Start_Cooking_Click);
            // 
            // Mark_Ready
            // 
            this.Mark_Ready.BackColor = System.Drawing.Color.Orange;
            this.Mark_Ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mark_Ready.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark_Ready.Location = new System.Drawing.Point(496, 426);
            this.Mark_Ready.Name = "Mark_Ready";
            this.Mark_Ready.Size = new System.Drawing.Size(173, 39);
            this.Mark_Ready.TabIndex = 3;
            this.Mark_Ready.Text = "Mark Ready";
            this.Mark_Ready.UseVisualStyleBackColor = false;
            this.Mark_Ready.Click += new System.EventHandler(this.Mark_Ready_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Orange;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(747, 426);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 39);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitchen Orders";
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(911, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mark_Ready);
            this.Controls.Add(this.Start_Cooking);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dgvKitchenOrders);
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitchenOrders;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Start_Cooking;
        private System.Windows.Forms.Button Mark_Ready;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}