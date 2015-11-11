namespace nKnight
{
    namespace RBAC
    {
        partial class frmResourceRoleMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResourceRoleMapping));
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.lvwRoles = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpResources = new System.Windows.Forms.GroupBox();
            this.lvwResources = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdMap = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpRoles.SuspendLayout();
            this.grpResources.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRoles
            // 
            this.grpRoles.Controls.Add(this.lvwRoles);
            this.grpRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRoles.ForeColor = System.Drawing.Color.White;
            this.grpRoles.Location = new System.Drawing.Point(0, 0);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Size = new System.Drawing.Size(430, 620);
            this.grpRoles.TabIndex = 0;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Roles";
            // 
            // lvwRoles
            // 
            this.lvwRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader8});
            this.lvwRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoles.ForeColor = System.Drawing.Color.Black;
            this.lvwRoles.FullRowSelect = true;
            this.lvwRoles.GridLines = true;
            this.lvwRoles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwRoles.HideSelection = false;
            this.lvwRoles.Location = new System.Drawing.Point(3, 16);
            this.lvwRoles.MultiSelect = false;
            this.lvwRoles.Name = "lvwRoles";
            this.lvwRoles.OwnerDraw = true;
            this.lvwRoles.Size = new System.Drawing.Size(424, 601);
            this.lvwRoles.TabIndex = 0;
            this.lvwRoles.UseCompatibleStateImageBehavior = false;
            this.lvwRoles.View = System.Windows.Forms.View.Details;
            this.lvwRoles.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwRoles_ColumnWidthChanged);
            this.lvwRoles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwRoles_DrawColumnHeader);
            this.lvwRoles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvwRoles_DrawItem);
            this.lvwRoles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwRoles_DrawSubItem);
            this.lvwRoles.SelectedIndexChanged += new System.EventHandler(this.lvwRoles_SelectedIndexChanged);
            this.lvwRoles.Click += new System.EventHandler(this.lvwRoles_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Roles";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Role Description";
            this.columnHeader10.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            this.columnHeader8.Width = 0;
            // 
            // grpResources
            // 
            this.grpResources.Controls.Add(this.lvwResources);
            this.grpResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResources.ForeColor = System.Drawing.Color.White;
            this.grpResources.Location = new System.Drawing.Point(0, 0);
            this.grpResources.Name = "grpResources";
            this.grpResources.Size = new System.Drawing.Size(852, 620);
            this.grpResources.TabIndex = 1;
            this.grpResources.TabStop = false;
            this.grpResources.Text = "Resources";
            this.grpResources.Enter += new System.EventHandler(this.grpResources_Enter);
            // 
            // lvwResources
            // 
            this.lvwResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader11});
            this.lvwResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwResources.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwResources.ForeColor = System.Drawing.Color.Black;
            this.lvwResources.FullRowSelect = true;
            this.lvwResources.GridLines = true;
            this.lvwResources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwResources.HideSelection = false;
            this.lvwResources.Location = new System.Drawing.Point(3, 16);
            this.lvwResources.Name = "lvwResources";
            this.lvwResources.OwnerDraw = true;
            this.lvwResources.ShowItemToolTips = true;
            this.lvwResources.Size = new System.Drawing.Size(846, 601);
            this.lvwResources.TabIndex = 0;
            this.lvwResources.UseCompatibleStateImageBehavior = false;
            this.lvwResources.View = System.Windows.Forms.View.Details;
            this.lvwResources.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwResources_ColumnWidthChanged);
            this.lvwResources.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwResources_DrawColumnHeader);
            this.lvwResources.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvwResources_DrawItem);
            this.lvwResources.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwResources_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Form";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Id";
            this.columnHeader11.Width = 220;
            // 
            // cmdMap
            // 
            this.cmdMap.BackColor = System.Drawing.Color.White;
            this.cmdMap.Location = new System.Drawing.Point(1229, 638);
            this.cmdMap.Name = "cmdMap";
            this.cmdMap.Size = new System.Drawing.Size(75, 23);
            this.cmdMap.TabIndex = 2;
            this.cmdMap.Text = "Map";
            this.cmdMap.UseVisualStyleBackColor = false;
            this.cmdMap.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.CausesValidation = false;
            this.lblMessage.Location = new System.Drawing.Point(2, 291);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpRoles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpResources);
            this.splitContainer1.Size = new System.Drawing.Size(1292, 620);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmResourceRoleMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 673);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmdMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResourceRoleMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource role mapping";
            this.Load += new System.EventHandler(this.frmResourceRoleMapping_Load);
            this.grpRoles.ResumeLayout(false);
            this.grpResources.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.GroupBox grpRoles;
            private System.Windows.Forms.GroupBox grpResources;
            private System.Windows.Forms.Button cmdMap;
            private System.Windows.Forms.ListView lvwRoles;
            private System.Windows.Forms.ListView lvwResources;
            private System.Windows.Forms.Label lblMessage;
            private System.Windows.Forms.ColumnHeader columnHeader8;
            private System.Windows.Forms.ColumnHeader columnHeader9;
            private System.Windows.Forms.ColumnHeader columnHeader10;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.ColumnHeader columnHeader3;
            private System.Windows.Forms.ColumnHeader columnHeader11;
            private System.Windows.Forms.SplitContainer splitContainer1;
        }
    }
}