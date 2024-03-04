namespace Library_Management.Borrowing_Records
{
    partial class frmReturnTheBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnTheBook));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBorrowABook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbAddEditImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnRe_Book = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nupBorrowingDays = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpBorrowing_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCopyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpActualReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBorrowingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(51, 99);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(36, 22);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Back";
            // 
            // lblBorrowABook
            // 
            this.lblBorrowABook.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowABook.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowABook.Location = new System.Drawing.Point(107, 22);
            this.lblBorrowABook.Name = "lblBorrowABook";
            this.lblBorrowABook.Size = new System.Drawing.Size(212, 39);
            this.lblBorrowABook.TabIndex = 20;
            this.lblBorrowABook.Text = "Return the book";
            // 
            // pbAddEditImage
            // 
            this.pbAddEditImage.Image = ((System.Drawing.Image)(resources.GetObject("pbAddEditImage.Image")));
            this.pbAddEditImage.Location = new System.Drawing.Point(9, 12);
            this.pbAddEditImage.Name = "pbAddEditImage";
            this.pbAddEditImage.ShadowDecoration.Parent = this.pbAddEditImage;
            this.pbAddEditImage.Size = new System.Drawing.Size(92, 59);
            this.pbAddEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddEditImage.TabIndex = 19;
            this.pbAddEditImage.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(9, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 18;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancel.Location = new System.Drawing.Point(429, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(151, 47);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRe_Book
            // 
            this.btnRe_Book.Animated = true;
            this.btnRe_Book.BorderRadius = 15;
            this.btnRe_Book.CheckedState.Parent = this.btnRe_Book;
            this.btnRe_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRe_Book.CustomImages.Parent = this.btnRe_Book;
            this.btnRe_Book.FillColor = System.Drawing.Color.Green;
            this.btnRe_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe_Book.ForeColor = System.Drawing.Color.White;
            this.btnRe_Book.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRe_Book.HoverState.Parent = this.btnRe_Book;
            this.btnRe_Book.Image = ((System.Drawing.Image)(resources.GetObject("btnRe_Book.Image")));
            this.btnRe_Book.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRe_Book.Location = new System.Drawing.Point(602, 536);
            this.btnRe_Book.Name = "btnRe_Book";
            this.btnRe_Book.ShadowDecoration.Parent = this.btnRe_Book;
            this.btnRe_Book.Size = new System.Drawing.Size(151, 47);
            this.btnRe_Book.TabIndex = 41;
            this.btnRe_Book.Text = "Re-Book";
            this.btnRe_Book.Click += new System.EventHandler(this.btnRe_Book_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(15, 348);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(101, 19);
            this.guna2HtmlLabel7.TabIndex = 40;
            this.guna2HtmlLabel7.Text = "Borrowing Days";
            // 
            // nupBorrowingDays
            // 
            this.nupBorrowingDays.AutoRoundedCorners = true;
            this.nupBorrowingDays.BackColor = System.Drawing.Color.Transparent;
            this.nupBorrowingDays.BorderRadius = 18;
            this.nupBorrowingDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupBorrowingDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupBorrowingDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupBorrowingDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupBorrowingDays.DisabledState.Parent = this.nupBorrowingDays;
            this.nupBorrowingDays.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupBorrowingDays.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupBorrowingDays.Enabled = false;
            this.nupBorrowingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupBorrowingDays.FocusedState.Parent = this.nupBorrowingDays;
            this.nupBorrowingDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupBorrowingDays.ForeColor = System.Drawing.Color.Black;
            this.nupBorrowingDays.Location = new System.Drawing.Point(137, 338);
            this.nupBorrowingDays.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupBorrowingDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBorrowingDays.Name = "nupBorrowingDays";
            this.nupBorrowingDays.ShadowDecoration.Parent = this.nupBorrowingDays;
            this.nupBorrowingDays.Size = new System.Drawing.Size(118, 38);
            this.nupBorrowingDays.TabIndex = 39;
            this.nupBorrowingDays.ThousandsSeparator = true;
            this.nupBorrowingDays.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.nupBorrowingDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(36, 217);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel8.TabIndex = 38;
            this.guna2HtmlLabel8.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Animated = true;
            this.txtBookID.AutoRoundedCorners = true;
            this.txtBookID.BorderColor = System.Drawing.Color.Silver;
            this.txtBookID.BorderRadius = 19;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.DefaultText = "";
            this.txtBookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.DisabledState.Parent = this.txtBookID;
            this.txtBookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.Enabled = false;
            this.txtBookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.FocusedState.Parent = this.txtBookID;
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.HoverState.Parent = this.txtBookID;
            this.txtBookID.Location = new System.Drawing.Point(111, 207);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookID.PlaceholderText = "Book ID";
            this.txtBookID.SelectedText = "";
            this.txtBookID.ShadowDecoration.Parent = this.txtBookID;
            this.txtBookID.Size = new System.Drawing.Size(271, 40);
            this.txtBookID.TabIndex = 37;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(4, 274);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(100, 19);
            this.guna2HtmlLabel4.TabIndex = 36;
            this.guna2HtmlLabel4.Text = "Borrowing Date";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Enabled = false;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(410, 219);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel3.TabIndex = 35;
            this.guna2HtmlLabel3.Text = "Copy ID";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(759, 216);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(48, 19);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "User ID";
            // 
            // dtpBorrowing_Date
            // 
            this.dtpBorrowing_Date.Animated = true;
            this.dtpBorrowing_Date.AutoRoundedCorners = true;
            this.dtpBorrowing_Date.BorderColor = System.Drawing.Color.Silver;
            this.dtpBorrowing_Date.BorderRadius = 19;
            this.dtpBorrowing_Date.BorderThickness = 1;
            this.dtpBorrowing_Date.CheckedState.Parent = this.dtpBorrowing_Date;
            this.dtpBorrowing_Date.Enabled = false;
            this.dtpBorrowing_Date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpBorrowing_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowing_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBorrowing_Date.HoverState.Parent = this.dtpBorrowing_Date;
            this.dtpBorrowing_Date.Location = new System.Drawing.Point(110, 265);
            this.dtpBorrowing_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowing_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowing_Date.Name = "dtpBorrowing_Date";
            this.dtpBorrowing_Date.ShadowDecoration.Parent = this.dtpBorrowing_Date;
            this.dtpBorrowing_Date.Size = new System.Drawing.Size(229, 40);
            this.dtpBorrowing_Date.TabIndex = 33;
            this.dtpBorrowing_Date.TextOffset = new System.Drawing.Point(30, 0);
            this.dtpBorrowing_Date.Value = new System.DateTime(2024, 2, 24, 15, 17, 44, 0);
            // 
            // txtCopyID
            // 
            this.txtCopyID.Animated = true;
            this.txtCopyID.AutoRoundedCorners = true;
            this.txtCopyID.BorderColor = System.Drawing.Color.Silver;
            this.txtCopyID.BorderRadius = 19;
            this.txtCopyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopyID.DefaultText = "";
            this.txtCopyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCopyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCopyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.DisabledState.Parent = this.txtCopyID;
            this.txtCopyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.Enabled = false;
            this.txtCopyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopyID.FocusedState.Parent = this.txtCopyID;
            this.txtCopyID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyID.ForeColor = System.Drawing.Color.Black;
            this.txtCopyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopyID.HoverState.Parent = this.txtCopyID;
            this.txtCopyID.Location = new System.Drawing.Point(469, 207);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.PasswordChar = '\0';
            this.txtCopyID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCopyID.PlaceholderText = "Copy ID";
            this.txtCopyID.SelectedText = "";
            this.txtCopyID.ShadowDecoration.Parent = this.txtCopyID;
            this.txtCopyID.Size = new System.Drawing.Size(271, 40);
            this.txtCopyID.TabIndex = 32;
            // 
            // txtUserID
            // 
            this.txtUserID.Animated = true;
            this.txtUserID.AutoRoundedCorners = true;
            this.txtUserID.BorderColor = System.Drawing.Color.Silver;
            this.txtUserID.BorderRadius = 19;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.Parent = this.txtUserID;
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.Enabled = false;
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.FocusedState.Parent = this.txtUserID;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.HoverState.Parent = this.txtUserID;
            this.txtUserID.Location = new System.Drawing.Point(830, 207);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(271, 40);
            this.txtUserID.TabIndex = 31;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(348, 274);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(61, 19);
            this.guna2HtmlLabel5.TabIndex = 44;
            this.guna2HtmlLabel5.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Animated = true;
            this.dtpDueDate.AutoRoundedCorners = true;
            this.dtpDueDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpDueDate.BorderRadius = 19;
            this.dtpDueDate.BorderThickness = 1;
            this.dtpDueDate.CheckedState.Parent = this.dtpDueDate;
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDueDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpDueDate.HoverState.Parent = this.dtpDueDate;
            this.dtpDueDate.Location = new System.Drawing.Point(415, 265);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShadowDecoration.Parent = this.dtpDueDate;
            this.dtpDueDate.Size = new System.Drawing.Size(229, 40);
            this.dtpDueDate.TabIndex = 43;
            this.dtpDueDate.TextOffset = new System.Drawing.Point(30, 0);
            this.dtpDueDate.Value = new System.DateTime(2024, 2, 24, 15, 17, 44, 0);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(665, 274);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(120, 19);
            this.guna2HtmlLabel6.TabIndex = 46;
            this.guna2HtmlLabel6.Text = "Actual Return Date";
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.Animated = true;
            this.dtpActualReturnDate.AutoRoundedCorners = true;
            this.dtpActualReturnDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpActualReturnDate.BorderRadius = 19;
            this.dtpActualReturnDate.BorderThickness = 1;
            this.dtpActualReturnDate.CheckedState.Parent = this.dtpActualReturnDate;
            this.dtpActualReturnDate.Enabled = false;
            this.dtpActualReturnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtpActualReturnDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpActualReturnDate.HoverState.Parent = this.dtpActualReturnDate;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(791, 265);
            this.dtpActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.ShadowDecoration.Parent = this.dtpActualReturnDate;
            this.dtpActualReturnDate.Size = new System.Drawing.Size(229, 40);
            this.dtpActualReturnDate.TabIndex = 45;
            this.dtpActualReturnDate.TextOffset = new System.Drawing.Point(30, 0);
            this.dtpActualReturnDate.Value = new System.DateTime(2024, 2, 24, 15, 17, 44, 0);
            // 
            // pbBookImage
            // 
            this.pbBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBookImage.Image = global::Library_Management.Properties.Resources.No_Book;
            this.pbBookImage.Location = new System.Drawing.Point(885, 327);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(135, 209);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 47;
            this.pbBookImage.TabStop = false;
            this.pbBookImage.Tag = "0";
            // 
            // frmReturnTheBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1135, 625);
            this.Controls.Add(this.dtpBorrowing_Date);
            this.Controls.Add(this.pbBookImage);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.dtpActualReturnDate);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRe_Book);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.nupBorrowingDays);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtCopyID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblBorrowABook);
            this.Controls.Add(this.pbAddEditImage);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturnTheBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return The Book";
            this.Shown += new System.EventHandler(this.frmReturnTheBook_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBorrowingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBorrowABook;
        private Guna.UI2.WinForms.Guna2PictureBox pbAddEditImage;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnRe_Book;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupBorrowingDays;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrowing_Date;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDueDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.PictureBox pbBookImage;
    }
}