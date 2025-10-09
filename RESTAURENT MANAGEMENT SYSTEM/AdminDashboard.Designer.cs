using System;
using System.Windows.Forms;


namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnManageUsers;
        private Button btnManageMenuItems;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageMenuItems = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageRawMaterials = new System.Windows.Forms.Button();
            this.lblAdminDashboard = new System.Windows.Forms.Label();
            this.btnFinanceStatus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.White;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(514, 99);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(188, 40);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageMenuItems
            // 
            this.btnManageMenuItems.BackColor = System.Drawing.Color.White;
            this.btnManageMenuItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMenuItems.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenuItems.Location = new System.Drawing.Point(514, 166);
            this.btnManageMenuItems.Name = "btnManageMenuItems";
            this.btnManageMenuItems.Size = new System.Drawing.Size(188, 40);
            this.btnManageMenuItems.TabIndex = 1;
            this.btnManageMenuItems.Text = "Manage Menu Items";
            this.btnManageMenuItems.UseVisualStyleBackColor = false;
            this.btnManageMenuItems.Click += new System.EventHandler(this.btnManageMenuItems_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(514, 366);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 48);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageRawMaterials
            // 
            this.btnManageRawMaterials.BackColor = System.Drawing.Color.White;
            this.btnManageRawMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRawMaterials.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRawMaterials.Location = new System.Drawing.Point(514, 233);
            this.btnManageRawMaterials.Name = "btnManageRawMaterials";
            this.btnManageRawMaterials.Size = new System.Drawing.Size(188, 40);
            this.btnManageRawMaterials.TabIndex = 3;
            this.btnManageRawMaterials.Text = "Manage Raw Materials";
            this.btnManageRawMaterials.UseVisualStyleBackColor = false;
            this.btnManageRawMaterials.Click += new System.EventHandler(this.btnManageRawMaterials_Click);
            // 
            // lblAdminDashboard
            // 
            this.lblAdminDashboard.AutoSize = true;
            this.lblAdminDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.lblAdminDashboard.Location = new System.Drawing.Point(240, 31);
            this.lblAdminDashboard.Name = "lblAdminDashboard";
            this.lblAdminDashboard.Size = new System.Drawing.Size(273, 41);
            this.lblAdminDashboard.TabIndex = 4;
            this.lblAdminDashboard.Text = "Admin Dashboard";
            // 
            // btnFinanceStatus
            // 
            this.btnFinanceStatus.BackColor = System.Drawing.Color.White;
            this.btnFinanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceStatus.Location = new System.Drawing.Point(514, 296);
            this.btnFinanceStatus.Name = "btnFinanceStatus";
            this.btnFinanceStatus.Size = new System.Drawing.Size(188, 40);
            this.btnFinanceStatus.TabIndex = 5;
            this.btnFinanceStatus.Text = "Financial Status";
            this.btnFinanceStatus.UseVisualStyleBackColor = false;
            this.btnFinanceStatus.Click += new System.EventHandler(this.btnFinanceStatus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFinanceStatus);
            this.Controls.Add(this.lblAdminDashboard);
            this.Controls.Add(this.btnManageRawMaterials);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageMenuItems);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnLogout;
        private Button btnManageRawMaterials;
        private Label lblAdminDashboard;
        private Button btnFinanceStatus;
        private PictureBox pictureBox1;
    }
}
