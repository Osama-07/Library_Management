namespace Library_Management.Setting
{
    partial class frmServicePrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicePrices));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBorrowingRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFinePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Prices Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBorrowingRate
            // 
            this.txtBorrowingRate.Animated = true;
            this.txtBorrowingRate.AutoRoundedCorners = true;
            this.txtBorrowingRate.BorderColor = System.Drawing.Color.Transparent;
            this.txtBorrowingRate.BorderRadius = 22;
            this.txtBorrowingRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowingRate.DefaultText = "";
            this.txtBorrowingRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBorrowingRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBorrowingRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingRate.DisabledState.Parent = this.txtBorrowingRate;
            this.txtBorrowingRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingRate.FocusedState.Parent = this.txtBorrowingRate;
            this.txtBorrowingRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowingRate.ForeColor = System.Drawing.Color.Black;
            this.txtBorrowingRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingRate.HoverState.Parent = this.txtBorrowingRate;
            this.txtBorrowingRate.Location = new System.Drawing.Point(232, 238);
            this.txtBorrowingRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBorrowingRate.Name = "txtBorrowingRate";
            this.txtBorrowingRate.PasswordChar = '\0';
            this.txtBorrowingRate.PlaceholderText = "Borrowing rate per day";
            this.txtBorrowingRate.SelectedText = "";
            this.txtBorrowingRate.ShadowDecoration.Parent = this.txtBorrowingRate;
            this.txtBorrowingRate.Size = new System.Drawing.Size(267, 47);
            this.txtBorrowingRate.TabIndex = 3;
            this.txtBorrowingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinePrice_KeyPress);
            this.txtBorrowingRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinePrice_Validating);
            // 
            // txtFinePrice
            // 
            this.txtFinePrice.Animated = true;
            this.txtFinePrice.AutoRoundedCorners = true;
            this.txtFinePrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtFinePrice.BorderRadius = 22;
            this.txtFinePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinePrice.DefaultText = "";
            this.txtFinePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinePrice.DisabledState.Parent = this.txtFinePrice;
            this.txtFinePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinePrice.FocusedState.Parent = this.txtFinePrice;
            this.txtFinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinePrice.ForeColor = System.Drawing.Color.Black;
            this.txtFinePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinePrice.HoverState.Parent = this.txtFinePrice;
            this.txtFinePrice.Location = new System.Drawing.Point(567, 238);
            this.txtFinePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinePrice.Name = "txtFinePrice";
            this.txtFinePrice.PasswordChar = '\0';
            this.txtFinePrice.PlaceholderText = "Fine price per day";
            this.txtFinePrice.SelectedText = "";
            this.txtFinePrice.ShadowDecoration.Parent = this.txtFinePrice;
            this.txtFinePrice.Size = new System.Drawing.Size(267, 47);
            this.txtFinePrice.TabIndex = 4;
            this.txtFinePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinePrice_KeyPress);
            this.txtFinePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinePrice_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(238, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrowing rate per day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(572, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fine Price per day";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(461, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(151, 47);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmServicePrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 617);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinePrice);
            this.Controls.Add(this.txtBorrowingRate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicePrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServicePrices";
            this.Shown += new System.EventHandler(this.frmServicePrices_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowingRate;
        private Guna.UI2.WinForms.Guna2TextBox txtFinePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}