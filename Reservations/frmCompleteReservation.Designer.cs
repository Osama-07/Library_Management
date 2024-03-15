namespace Library_Management.Reservations
{
    partial class frmCompleteReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompleteReservation));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCompleteReservation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbAddEditImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpBorrowing_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCopyID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 89);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(36, 22);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Back";
            // 
            // lblCompleteReservation
            // 
            this.lblCompleteReservation.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteReservation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteReservation.Location = new System.Drawing.Point(102, 12);
            this.lblCompleteReservation.Name = "lblCompleteReservation";
            this.lblCompleteReservation.Size = new System.Drawing.Size(288, 39);
            this.lblCompleteReservation.TabIndex = 20;
            this.lblCompleteReservation.Text = "Complete Reservation";
            // 
            // pbAddEditImage
            // 
            this.pbAddEditImage.Image = ((System.Drawing.Image)(resources.GetObject("pbAddEditImage.Image")));
            this.pbAddEditImage.Location = new System.Drawing.Point(4, 2);
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
            this.btnBack.Location = new System.Drawing.Point(4, 80);
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
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancel.Location = new System.Drawing.Point(413, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(151, 47);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(586, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(151, 47);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(135, 243);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(108, 19);
            this.guna2HtmlLabel4.TabIndex = 36;
            this.guna2HtmlLabel4.Text = "Reservation Date";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(194, 173);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(48, 19);
            this.guna2HtmlLabel1.TabIndex = 35;
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
            this.dtpBorrowing_Date.FillColor = System.Drawing.Color.White;
            this.dtpBorrowing_Date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowing_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBorrowing_Date.HoverState.Parent = this.dtpBorrowing_Date;
            this.dtpBorrowing_Date.Location = new System.Drawing.Point(249, 233);
            this.dtpBorrowing_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowing_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowing_Date.Name = "dtpBorrowing_Date";
            this.dtpBorrowing_Date.ShadowDecoration.Parent = this.dtpBorrowing_Date;
            this.dtpBorrowing_Date.Size = new System.Drawing.Size(271, 40);
            this.dtpBorrowing_Date.TabIndex = 34;
            this.dtpBorrowing_Date.TextOffset = new System.Drawing.Point(45, 0);
            this.dtpBorrowing_Date.Value = new System.DateTime(2024, 3, 13, 0, 0, 0, 0);
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
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.FocusedState.Parent = this.txtUserID;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.HoverState.Parent = this.txtUserID;
            this.txtUserID.Location = new System.Drawing.Point(249, 164);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserID.MaxLength = 8;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(271, 40);
            this.txtUserID.TabIndex = 33;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(547, 173);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel3.TabIndex = 38;
            this.guna2HtmlLabel3.Text = "Copy ID";
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
            this.txtCopyID.Location = new System.Drawing.Point(606, 164);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.PasswordChar = '\0';
            this.txtCopyID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCopyID.PlaceholderText = "Copy ID";
            this.txtCopyID.SelectedText = "";
            this.txtCopyID.ShadowDecoration.Parent = this.txtCopyID;
            this.txtCopyID.Size = new System.Drawing.Size(271, 40);
            this.txtCopyID.TabIndex = 37;
            // 
            // frmCompleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 656);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtCopyID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtpBorrowing_Date);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblCompleteReservation);
            this.Controls.Add(this.pbAddEditImage);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompleteReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompleteReservation";
            this.Shown += new System.EventHandler(this.frmCompleteReservation_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEditImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCompleteReservation;
        private Guna.UI2.WinForms.Guna2PictureBox pbAddEditImage;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrowing_Date;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyID;
    }
}