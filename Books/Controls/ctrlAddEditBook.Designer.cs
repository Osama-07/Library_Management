namespace Library_Management.Books.Controls
{
    partial class ctrlAddEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddEditBook));
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGenere = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdditinalDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpPublication_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nupNumberOfCopies = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBookImage = new System.Windows.Forms.LinkLabel();
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberOfCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.AutoRoundedCorners = true;
            this.txtTitle.BorderColor = System.Drawing.Color.Silver;
            this.txtTitle.BorderRadius = 19;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(101, 64);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(271, 40);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxes_Validating);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Animated = true;
            this.txtAuthor.AutoRoundedCorners = true;
            this.txtAuthor.BorderColor = System.Drawing.Color.Silver;
            this.txtAuthor.BorderRadius = 19;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.Parent = this.txtAuthor;
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.FocusedState.Parent = this.txtAuthor;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.HoverState.Parent = this.txtAuthor;
            this.txtAuthor.Location = new System.Drawing.Point(502, 7);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.ShadowDecoration.Parent = this.txtAuthor;
            this.txtAuthor.Size = new System.Drawing.Size(271, 40);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxes_Validating);
            // 
            // txtISBN
            // 
            this.txtISBN.Animated = true;
            this.txtISBN.AutoRoundedCorners = true;
            this.txtISBN.BorderColor = System.Drawing.Color.Silver;
            this.txtISBN.BorderRadius = 19;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.Parent = this.txtISBN;
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.FocusedState.Parent = this.txtISBN;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.Black;
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.HoverState.Parent = this.txtISBN;
            this.txtISBN.Location = new System.Drawing.Point(101, 121);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtISBN.PlaceholderText = "ISBN";
            this.txtISBN.SelectedText = "";
            this.txtISBN.ShadowDecoration.Parent = this.txtISBN;
            this.txtISBN.Size = new System.Drawing.Size(271, 40);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxes_Validating);
            // 
            // txtGenere
            // 
            this.txtGenere.Animated = true;
            this.txtGenere.AutoRoundedCorners = true;
            this.txtGenere.BorderColor = System.Drawing.Color.Silver;
            this.txtGenere.BorderRadius = 19;
            this.txtGenere.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenere.DefaultText = "";
            this.txtGenere.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenere.DisabledState.Parent = this.txtGenere;
            this.txtGenere.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenere.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenere.FocusedState.Parent = this.txtGenere;
            this.txtGenere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenere.ForeColor = System.Drawing.Color.Black;
            this.txtGenere.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenere.HoverState.Parent = this.txtGenere;
            this.txtGenere.Location = new System.Drawing.Point(101, 178);
            this.txtGenere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.PasswordChar = '\0';
            this.txtGenere.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGenere.PlaceholderText = "Genere";
            this.txtGenere.SelectedText = "";
            this.txtGenere.ShadowDecoration.Parent = this.txtGenere;
            this.txtGenere.Size = new System.Drawing.Size(271, 40);
            this.txtGenere.TabIndex = 4;
            this.txtGenere.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxes_Validating);
            // 
            // txtAdditinalDetails
            // 
            this.txtAdditinalDetails.Animated = true;
            this.txtAdditinalDetails.BorderColor = System.Drawing.Color.Silver;
            this.txtAdditinalDetails.BorderRadius = 27;
            this.txtAdditinalDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditinalDetails.DefaultText = "";
            this.txtAdditinalDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditinalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditinalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditinalDetails.DisabledState.Parent = this.txtAdditinalDetails;
            this.txtAdditinalDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditinalDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditinalDetails.FocusedState.Parent = this.txtAdditinalDetails;
            this.txtAdditinalDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditinalDetails.ForeColor = System.Drawing.Color.Black;
            this.txtAdditinalDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditinalDetails.HoverState.Parent = this.txtAdditinalDetails;
            this.txtAdditinalDetails.Location = new System.Drawing.Point(502, 121);
            this.txtAdditinalDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdditinalDetails.Multiline = true;
            this.txtAdditinalDetails.Name = "txtAdditinalDetails";
            this.txtAdditinalDetails.PasswordChar = '\0';
            this.txtAdditinalDetails.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdditinalDetails.PlaceholderText = "Additinal Details";
            this.txtAdditinalDetails.SelectedText = "";
            this.txtAdditinalDetails.ShadowDecoration.Parent = this.txtAdditinalDetails;
            this.txtAdditinalDetails.Size = new System.Drawing.Size(271, 158);
            this.txtAdditinalDetails.TabIndex = 5;
            // 
            // dtpPublication_Date
            // 
            this.dtpPublication_Date.Animated = true;
            this.dtpPublication_Date.AutoRoundedCorners = true;
            this.dtpPublication_Date.BorderColor = System.Drawing.Color.Silver;
            this.dtpPublication_Date.BorderRadius = 19;
            this.dtpPublication_Date.BorderThickness = 1;
            this.dtpPublication_Date.CheckedState.Parent = this.dtpPublication_Date;
            this.dtpPublication_Date.FillColor = System.Drawing.Color.White;
            this.dtpPublication_Date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublication_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPublication_Date.HoverState.Parent = this.dtpPublication_Date;
            this.dtpPublication_Date.Location = new System.Drawing.Point(502, 64);
            this.dtpPublication_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPublication_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPublication_Date.Name = "dtpPublication_Date";
            this.dtpPublication_Date.ShadowDecoration.Parent = this.dtpPublication_Date;
            this.dtpPublication_Date.Size = new System.Drawing.Size(271, 40);
            this.dtpPublication_Date.TabIndex = 6;
            this.dtpPublication_Date.Value = new System.DateTime(2024, 2, 16, 19, 54, 26, 0);
            // 
            // nupNumberOfCopies
            // 
            this.nupNumberOfCopies.AutoRoundedCorners = true;
            this.nupNumberOfCopies.BackColor = System.Drawing.Color.Transparent;
            this.nupNumberOfCopies.BorderRadius = 18;
            this.nupNumberOfCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupNumberOfCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupNumberOfCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupNumberOfCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupNumberOfCopies.DisabledState.Parent = this.nupNumberOfCopies;
            this.nupNumberOfCopies.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupNumberOfCopies.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupNumberOfCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupNumberOfCopies.FocusedState.Parent = this.nupNumberOfCopies;
            this.nupNumberOfCopies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumberOfCopies.ForeColor = System.Drawing.Color.Black;
            this.nupNumberOfCopies.Location = new System.Drawing.Point(155, 241);
            this.nupNumberOfCopies.Name = "nupNumberOfCopies";
            this.nupNumberOfCopies.ShadowDecoration.Parent = this.nupNumberOfCopies;
            this.nupNumberOfCopies.Size = new System.Drawing.Size(136, 38);
            this.nupNumberOfCopies.TabIndex = 7;
            this.nupNumberOfCopies.ThousandsSeparator = true;
            this.nupNumberOfCopies.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.nupNumberOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(46, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(31, 19);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Title";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 131);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(32, 19);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "ISBN";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(449, 16);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(46, 19);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Author";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(390, 74);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(106, 19);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = "Publication Date";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(32, 188);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(46, 19);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Genere";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(390, 131);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(107, 19);
            this.guna2HtmlLabel6.TabIndex = 15;
            this.guna2HtmlLabel6.Text = "Additinal Details";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(26, 250);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(117, 19);
            this.guna2HtmlLabel7.TabIndex = 16;
            this.guna2HtmlLabel7.Text = "Number Of Copies";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(26, 19);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel8.TabIndex = 18;
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
            this.txtBookID.Location = new System.Drawing.Point(101, 9);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookID.PlaceholderText = "Book ID";
            this.txtBookID.SelectedText = "";
            this.txtBookID.ShadowDecoration.Parent = this.txtBookID;
            this.txtBookID.Size = new System.Drawing.Size(271, 40);
            this.txtBookID.TabIndex = 17;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            this.txtBookID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxes_Validating);
            // 
            // lblBookImage
            // 
            this.lblBookImage.AutoSize = true;
            this.lblBookImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBookImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookImage.Location = new System.Drawing.Point(32, 309);
            this.lblBookImage.Name = "lblBookImage";
            this.lblBookImage.Size = new System.Drawing.Size(69, 17);
            this.lblBookImage.TabIndex = 20;
            this.lblBookImage.TabStop = true;
            this.lblBookImage.Text = "Set image";
            this.lblBookImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBookImage_LinkClicked);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(109, 309);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(57, 17);
            this.lblRemove.TabIndex = 21;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove";
            this.lblRemove.Visible = false;
            this.lblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbBookImage
            // 
            this.pbBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBookImage.Image = global::Library_Management.Properties.Resources.No_Book;
            this.pbBookImage.Location = new System.Drawing.Point(46, 343);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(109, 157);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 22;
            this.pbBookImage.TabStop = false;
            this.pbBookImage.Tag = "0";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(675, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(98, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlAddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbBookImage);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblBookImage);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nupNumberOfCopies);
            this.Controls.Add(this.dtpPublication_Date);
            this.Controls.Add(this.txtAdditinalDetails);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "ctrlAddEditBook";
            this.Size = new System.Drawing.Size(778, 506);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberOfCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private Guna.UI2.WinForms.Guna2TextBox txtGenere;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditinalDetails;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPublication_Date;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupNumberOfCopies;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private System.Windows.Forms.LinkLabel lblBookImage;
        private System.Windows.Forms.LinkLabel lblRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbBookImage;
    }
}
