namespace Library_Management.Books.Controls
{
    partial class ctrlShowBooksCataloge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBooks = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SuspendLayout();
            // 
            // panelBooks
            // 
            this.panelBooks.BorderRadius = 30;
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBooks.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBooks.Location = new System.Drawing.Point(0, 0);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.ShadowDecoration.Parent = this.panelBooks;
            this.panelBooks.Size = new System.Drawing.Size(933, 514);
            this.panelBooks.TabIndex = 0;
            // 
            // ctrlShowBooksCataloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBooks);
            this.Name = "ctrlShowBooksCataloge";
            this.Size = new System.Drawing.Size(933, 514);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelBooks;
    }
}
