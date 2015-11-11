namespace nKnight
{
    namespace RBAC
    {
        partial class frmAssignsSecurityGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignsSecurityGroup));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lvwUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSecurityGroup = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAssign = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpAssign.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(534, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Map";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(8, 325);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // lvwUser
            // 
            this.lvwUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwUser.FullRowSelect = true;
            this.lvwUser.GridLines = true;
            this.lvwUser.HideSelection = false;
            this.lvwUser.Location = new System.Drawing.Point(0, 0);
            this.lvwUser.MultiSelect = false;
            this.lvwUser.Name = "lvwUser";
            this.lvwUser.OwnerDraw = true;
            this.lvwUser.ShowItemToolTips = true;
            this.lvwUser.Size = new System.Drawing.Size(202, 446);
            this.lvwUser.TabIndex = 2;
            this.lvwUser.UseCompatibleStateImageBehavior = false;
            this.lvwUser.View = System.Windows.Forms.View.Details;
            this.lvwUser.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwUser_ColumnWidthChanged);
            this.lvwUser.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwUser_DrawColumnHeader);
            this.lvwUser.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwUser_DrawSubItem);
            this.lvwUser.Click += new System.EventHandler(this.lvwUser_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User name";
            this.columnHeader1.Width = 1000;
            // 
            // lvwSecurityGroup
            // 
            this.lvwSecurityGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvwSecurityGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSecurityGroup.FullRowSelect = true;
            this.lvwSecurityGroup.GridLines = true;
            this.lvwSecurityGroup.Location = new System.Drawing.Point(0, 0);
            this.lvwSecurityGroup.Name = "lvwSecurityGroup";
            this.lvwSecurityGroup.OwnerDraw = true;
            this.lvwSecurityGroup.ShowItemToolTips = true;
            this.lvwSecurityGroup.Size = new System.Drawing.Size(402, 446);
            this.lvwSecurityGroup.TabIndex = 3;
            this.lvwSecurityGroup.UseCompatibleStateImageBehavior = false;
            this.lvwSecurityGroup.View = System.Windows.Forms.View.Details;
            this.lvwSecurityGroup.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwSecurityGroup_ColumnWidthChanged);
            this.lvwSecurityGroup.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwSecurityGroup_DrawColumnHeader);
            this.lvwSecurityGroup.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwSecurityGroup_DrawSubItem);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Security Group";
            this.columnHeader2.Width = 1000;
            // 
            // grpAssign
            // 
            this.grpAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAssign.BackColor = System.Drawing.Color.Transparent;
            this.grpAssign.Controls.Add(this.splitContainer1);
            this.grpAssign.ForeColor = System.Drawing.Color.White;
            this.grpAssign.Location = new System.Drawing.Point(4, 5);
            this.grpAssign.Name = "grpAssign";
            this.grpAssign.Size = new System.Drawing.Size(614, 465);
            this.grpAssign.TabIndex = 0;
            this.grpAssign.TabStop = false;
            this.grpAssign.Text = "Assign Security Group";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwSecurityGroup);
            this.splitContainer1.Size = new System.Drawing.Size(608, 446);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 0;
            // 
            // frmAssignsSecurityGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 529);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAssign);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAssignsSecurityGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User & Security Group Mapping";
            this.Load += new System.EventHandler(this.frmAssignsSecurityGroup_Load);
            this.grpAssign.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button btnSave;
            private System.Windows.Forms.Label lblMessage;
            private System.Windows.Forms.ListView lvwUser;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ListView lvwSecurityGroup;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.GroupBox grpAssign;
            private System.Windows.Forms.SplitContainer splitContainer1;
        }
    }
}