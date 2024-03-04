namespace Library_Management.Borrowing_Records
{
    partial class frmBorrowingRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowingRecords));
            this.btnBorrowBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnRe_Book = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlShowBooksCatalogeWithFilter1 = new Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter();
            this.SuspendLayout();
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Animated = true;
            this.btnBorrowBook.BorderColor = System.Drawing.Color.Transparent;
            this.btnBorrowBook.BorderRadius = 10;
            this.btnBorrowBook.BorderThickness = 1;
            this.btnBorrowBook.CheckedState.Parent = this.btnBorrowBook;
            this.btnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowBook.CustomImages.Parent = this.btnBorrowBook;
            this.btnBorrowBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrowBook.HoverState.Parent = this.btnBorrowBook;
            this.btnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBook.Image")));
            this.btnBorrowBook.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBorrowBook.Location = new System.Drawing.Point(808, 12);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.ShadowDecoration.Parent = this.btnBorrowBook;
            this.btnBorrowBook.Size = new System.Drawing.Size(149, 66);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "Borrow a Book";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnRe_Book
            // 
            this.btnRe_Book.Animated = true;
            this.btnRe_Book.BackColor = System.Drawing.Color.Transparent;
            this.btnRe_Book.BorderColor = System.Drawing.Color.Transparent;
            this.btnRe_Book.BorderRadius = 10;
            this.btnRe_Book.BorderThickness = 1;
            this.btnRe_Book.CheckedState.Parent = this.btnRe_Book;
            this.btnRe_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRe_Book.CustomImages.Parent = this.btnRe_Book;
            this.btnRe_Book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRe_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe_Book.ForeColor = System.Drawing.Color.White;
            this.btnRe_Book.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRe_Book.HoverState.Parent = this.btnRe_Book;
            this.btnRe_Book.Image = ((System.Drawing.Image)(resources.GetObject("btnRe_Book.Image")));
            this.btnRe_Book.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRe_Book.Location = new System.Drawing.Point(975, 12);
            this.btnRe_Book.Name = "btnRe_Book";
            this.btnRe_Book.ShadowDecoration.Parent = this.btnRe_Book;
            this.btnRe_Book.Size = new System.Drawing.Size(149, 66);
            this.btnRe_Book.TabIndex = 2;
            this.btnRe_Book.Text = "Re-Book";
            this.btnRe_Book.Click += new System.EventHandler(this.btnRe_Book_Click);
            // 
            // ctrlShowBooksCatalogeWithFilter1
            // 
            this.ctrlShowBooksCatalogeWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowBooksCatalogeWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowBooksCatalogeWithFilter1.Name = "ctrlShowBooksCatalogeWithFilter1";
            this.ctrlShowBooksCatalogeWithFilter1.Size = new System.Drawing.Size(1151, 664);
            this.ctrlShowBooksCatalogeWithFilter1.TabIndex = 0;
            this.ctrlShowBooksCatalogeWithFilter1.OnBtnBookClick += new System.EventHandler<Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick>(this.ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick);
            // 
            // frmBorrowingRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1151, 664);
            this.Controls.Add(this.btnRe_Book);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.ctrlShowBooksCatalogeWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowingRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing Records";
            this.Shown += new System.EventHandler(this.frmBorrowingRecords_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Books.Controls.ctrlShowBooksCatalogeWithFilter ctrlShowBooksCatalogeWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnBorrowBook;
        private Guna.UI2.WinForms.Guna2Button btnRe_Book;
    }
}