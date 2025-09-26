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
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageMenuItems = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(100, 100);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 40);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageMenuItems
            // 
            this.btnManageMenuItems.Location = new System.Drawing.Point(100, 160);
            this.btnManageMenuItems.Name = "btnManageMenuItems";
            this.btnManageMenuItems.Size = new System.Drawing.Size(200, 40);
            this.btnManageMenuItems.TabIndex = 1;
            this.btnManageMenuItems.Text = "Manage Menu Items";
            this.btnManageMenuItems.UseVisualStyleBackColor = true;
            this.btnManageMenuItems.Click += new System.EventHandler(this.btnManageMenuItems_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(123, 215);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 48);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageMenuItems);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);

        }

        private Button btnLogout;
    }
}
