namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class Kitchen
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        /// <param name="disposing">If true, dispose managed resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;

            this.dgvKitchenOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKitchenOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitchenOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvKitchenOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKitchenOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitchenOrders.Location = new System.Drawing.Point(30, 60);
            this.dgvKitchenOrders.Name = "dgvKitchenOrders";
            this.dgvKitchenOrders.ReadOnly = true;
            this.dgvKitchenOrders.RowHeadersWidth = 51;
            this.dgvKitchenOrders.RowTemplate.Height = 24;
            this.dgvKitchenOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitchenOrders.Size = new System.Drawing.Size(850, 300);
            this.dgvKitchenOrders.TabIndex = 0;

            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Refresh.Location = new System.Drawing.Point(30, 400);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(140, 40);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);

            // 
            // Start_Cooking
            // 
            this.Start_Cooking.BackColor = System.Drawing.Color.DarkOrange;
            this.Start_Cooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Cooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Start_Cooking.Location = new System.Drawing.Point(220, 400);
            this.Start_Cooking.Name = "Start_Cooking";
            this.Start_Cooking.Size = new System.Drawing.Size(170, 40);
            this.Start_Cooking.TabIndex = 2;
            this.Start_Cooking.Text = "Start Cooking";
            this.Start_Cooking.UseVisualStyleBackColor = false;
            this.Start_Cooking.Click += new System.EventHandler(this.Start_Cooking_Click);

            // 
            // Mark_Ready
            // 
            this.Mark_Ready.BackColor = System.Drawing.Color.DarkOrange;
            this.Mark_Ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mark_Ready.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Mark_Ready.Location = new System.Drawing.Point(430, 400);
            this.Mark_Ready.Name = "Mark_Ready";
            this.Mark_Ready.Size = new System.Drawing.Size(160, 40);
            this.Mark_Ready.TabIndex = 3;
            this.Mark_Ready.Text = "Mark Ready";
            this.Mark_Ready.UseVisualStyleBackColor = false;
            this.Mark_Ready.Click += new System.EventHandler(this.Mark_Ready_Click);

            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkOrange;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(640, 400);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 40);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitchen Orders";

            // 
            // Kitchen Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(920, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mark_Ready);
            this.Controls.Add(this.Start_Cooking);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dgvKitchenOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
