namespace TestRBACControl.prc
{
    partial class prcMain
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
            this.nKnightButton1 = new nKnight.RBACControl.nKnightButton();
            this.SuspendLayout();
            // 
            // nKnightButton1
            // 
            this.nKnightButton1.GroupUniqueID = "3dbf3818-5d64-49bc-8d30-de96119b5319";
            this.nKnightButton1.Location = new System.Drawing.Point(114, 121);
            this.nKnightButton1.Name = "nKnightButton1";
            this.nKnightButton1.Size = new System.Drawing.Size(75, 23);
            this.nKnightButton1.TabIndex = 0;
            this.nKnightButton1.Text = "nKnightButton1";
            this.nKnightButton1.UseVisualStyleBackColor = true;
            // 
            // prcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.nKnightButton1);
            this.Name = "prcMain";
            this.Text = "prcMain";
            this.ResumeLayout(false);

        }

        #endregion

        private nKnight.RBACControl.nKnightButton nKnightButton1;
    }
}