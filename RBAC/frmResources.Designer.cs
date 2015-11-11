namespace nKnight
{
    namespace RBAC
    {
        partial class frmResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResources));
            this.grpResources = new System.Windows.Forms.GroupBox();
            this.lvwResources = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdSave = new System.Windows.Forms.Button();
            this.grpForms = new System.Windows.Forms.GroupBox();
            this.lvwForms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpResources.SuspendLayout();
            this.grpForms.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResources
            // 
            this.grpResources.Controls.Add(this.lvwResources);
            this.grpResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResources.ForeColor = System.Drawing.Color.White;
            this.grpResources.Location = new System.Drawing.Point(0, 0);
            this.grpResources.Name = "grpResources";
            this.grpResources.Size = new System.Drawing.Size(600, 520);
            this.grpResources.TabIndex = 0;
            this.grpResources.TabStop = false;
            this.grpResources.Text = "Name";
            // 
            // lvwResources
            // 
            this.lvwResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lvwResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwResources.GridLines = true;
            this.lvwResources.HideSelection = false;
            this.lvwResources.Location = new System.Drawing.Point(3, 16);
            this.lvwResources.Name = "lvwResources";
            this.lvwResources.OwnerDraw = true;
            this.lvwResources.Size = new System.Drawing.Size(594, 501);
            this.lvwResources.TabIndex = 1;
            this.lvwResources.UseCompatibleStateImageBehavior = false;
            this.lvwResources.View = System.Windows.Forms.View.Details;
            this.lvwResources.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwResources_ColumnWidthChanged);
            this.lvwResources.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwResources_DrawColumnHeader);
            this.lvwResources.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwResources_DrawSubItem);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Group Unique ID";
            this.columnHeader2.Width = 240;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(771, 538);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // grpForms
            // 
            this.grpForms.Controls.Add(this.lvwForms);
            this.grpForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpForms.ForeColor = System.Drawing.Color.White;
            this.grpForms.Location = new System.Drawing.Point(0, 0);
            this.grpForms.Name = "grpForms";
            this.grpForms.Size = new System.Drawing.Size(305, 520);
            this.grpForms.TabIndex = 3;
            this.grpForms.TabStop = false;
            this.grpForms.Text = "Forms";
            // 
            // lvwForms
            // 
            this.lvwForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwForms.GridLines = true;
            this.lvwForms.HideSelection = false;
            this.lvwForms.Location = new System.Drawing.Point(3, 16);
            this.lvwForms.Name = "lvwForms";
            this.lvwForms.OwnerDraw = true;
            this.lvwForms.ShowItemToolTips = true;
            this.lvwForms.Size = new System.Drawing.Size(299, 501);
            this.lvwForms.TabIndex = 1;
            this.lvwForms.UseCompatibleStateImageBehavior = false;
            this.lvwForms.View = System.Windows.Forms.View.Details;
            this.lvwForms.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvwForms_ColumnWidthChanged);
            this.lvwForms.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvwForms_DrawColumnHeader);
            this.lvwForms.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvwForms_DrawSubItem);
            this.lvwForms.SelectedIndexChanged += new System.EventHandler(this.lvwForms_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 114;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(852, 538);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.grpForms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpResources);
            this.splitContainer1.Size = new System.Drawing.Size(915, 520);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 573);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resources Used";
            this.Load += new System.EventHandler(this.frmResources_Load);
            this.grpResources.ResumeLayout(false);
            this.grpForms.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.GroupBox grpResources;
            private System.Windows.Forms.Button cmdSave;
            private System.Windows.Forms.ListView lvwResources;
            private System.Windows.Forms.ColumnHeader columnHeader4;
            private System.Windows.Forms.ColumnHeader columnHeader5;
            private System.Windows.Forms.GroupBox grpForms;
            private System.Windows.Forms.ListView lvwForms;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.Button cmdClose;
            private System.Windows.Forms.SplitContainer splitContainer1;
        }
    }
}