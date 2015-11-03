namespace TestRBACControl
{
    partial class userManagement
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
            this.createUser = new System.Windows.Forms.Button();
            this.roleCreation = new System.Windows.Forms.Button();
            this.userRoleMapping = new System.Windows.Forms.Button();
            this.resourcesUsed = new System.Windows.Forms.Button();
            this.roleResourceMapping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(12, 12);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(143, 23);
            this.createUser.TabIndex = 0;
            this.createUser.Text = "Create User";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // roleCreation
            // 
            this.roleCreation.Location = new System.Drawing.Point(12, 63);
            this.roleCreation.Name = "roleCreation";
            this.roleCreation.Size = new System.Drawing.Size(143, 23);
            this.roleCreation.TabIndex = 1;
            this.roleCreation.Text = "Role Creation";
            this.roleCreation.UseVisualStyleBackColor = true;
            this.roleCreation.Click += new System.EventHandler(this.roleCreation_Click);
            // 
            // userRoleMapping
            // 
            this.userRoleMapping.Location = new System.Drawing.Point(12, 114);
            this.userRoleMapping.Name = "userRoleMapping";
            this.userRoleMapping.Size = new System.Drawing.Size(143, 23);
            this.userRoleMapping.TabIndex = 2;
            this.userRoleMapping.Text = "User-Role Mapping";
            this.userRoleMapping.UseVisualStyleBackColor = true;
            this.userRoleMapping.Click += new System.EventHandler(this.userRoleMapping_Click);
            // 
            // resourcesUsed
            // 
            this.resourcesUsed.Location = new System.Drawing.Point(12, 165);
            this.resourcesUsed.Name = "resourcesUsed";
            this.resourcesUsed.Size = new System.Drawing.Size(143, 23);
            this.resourcesUsed.TabIndex = 3;
            this.resourcesUsed.Text = "Resources Used";
            this.resourcesUsed.UseVisualStyleBackColor = true;
            this.resourcesUsed.Click += new System.EventHandler(this.resourcesUsed_Click);
            // 
            // roleResourceMapping
            // 
            this.roleResourceMapping.Location = new System.Drawing.Point(12, 216);
            this.roleResourceMapping.Name = "roleResourceMapping";
            this.roleResourceMapping.Size = new System.Drawing.Size(143, 23);
            this.roleResourceMapping.TabIndex = 4;
            this.roleResourceMapping.Text = "Role-Resource Mapping";
            this.roleResourceMapping.UseVisualStyleBackColor = true;
            this.roleResourceMapping.Click += new System.EventHandler(this.roleResourceMapping_Click);
            // 
            // userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.roleResourceMapping);
            this.Controls.Add(this.resourcesUsed);
            this.Controls.Add(this.userRoleMapping);
            this.Controls.Add(this.roleCreation);
            this.Controls.Add(this.createUser);
            this.Name = "userManagement";
            this.Text = "userManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button roleCreation;
        private System.Windows.Forms.Button userRoleMapping;
        private System.Windows.Forms.Button resourcesUsed;
        private System.Windows.Forms.Button roleResourceMapping;
    }
}