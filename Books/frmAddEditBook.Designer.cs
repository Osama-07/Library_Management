namespace Library_Management.Books
{
    partial class frmAddEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditBook));
            this.pbAddEditImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblAddEditTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlAddEditBook1 = new Library_Management.Books.Controls.ctrlAddEditBook();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAddEditImage
            // 
            this.pbAddEditImage.Image = global::Library_Management.Properties.Resources.Add_Book;
            this.pbAddEditImage.Location = new System.Drawing.Point(3, 2);
            this.pbAddEditImage.Name = "pbAddEditImage";
            this.pbAddEditImage.ShadowDecoration.Parent = this.pbAddEditImage;
            this.pbAddEditImage.Size = new System.Drawing.Size(92, 59);
            this.pbAddEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddEditImage.TabIndex = 11;
            this.pbAddEditImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancel.Location = new System.Drawing.Point(791, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(3, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.Location = new System.Drawing.Point(101, 12);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(129, 39);
            this.lblAddEditTitle.TabIndex = 12;
            this.lblAddEditTitle.Text = "Add Book";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 89);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(36, 22);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Back";
            // 
            // ctrlAddEditBook1
            // 
            this.ctrlAddEditBook1.Location = new System.Drawing.Point(218, 89);
            this.ctrlAddEditBook1.Name = "ctrlAddEditBook1";
            this.ctrlAddEditBook1.Size = new System.Drawing.Size(785, 508);
            this.ctrlAddEditBook1.TabIndex = 1;
            this.ctrlAddEditBook1.OnSaveed += new System.Action(this.ctrlAddEditBook1_OnSaveed);
            // 
            // frmAddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.pbAddEditImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ctrlAddEditBook1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.Shown += new System.EventHandler(this.frmAddEditBook_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Controls.ctrlAddEditBook ctrlAddEditBook1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2PictureBox pbAddEditImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddEditTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}