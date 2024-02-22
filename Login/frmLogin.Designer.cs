namespace Library_Management.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pbImageTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.login1 = new ctrlLoginInfo.Login();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.login1);
            this.guna2GradientPanel1.Controls.Add(this.pbImageTitle);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox3);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Indigo;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(831, 441);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderRadius = 2;
            this.guna2ControlBox3.BorderThickness = 1;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(771, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(24, 25);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 2;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(801, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(26, 25);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // pbImageTitle
            // 
            this.pbImageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbImageTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbImageTitle.Image")));
            this.pbImageTitle.Location = new System.Drawing.Point(291, 12);
            this.pbImageTitle.Name = "pbImageTitle";
            this.pbImageTitle.ShadowDecoration.Parent = this.pbImageTitle;
            this.pbImageTitle.Size = new System.Drawing.Size(207, 146);
            this.pbImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageTitle.TabIndex = 9;
            this.pbImageTitle.TabStop = false;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.Transparent;
            this.login1.ButtonLoginColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login1.ButtonLoginForeColor = System.Drawing.Color.Black;
            this.login1.FillColorPassword = System.Drawing.Color.White;
            this.login1.FillColorRememberMe_Checked = System.Drawing.Color.Lime;
            this.login1.FillColorRememberMe_UnChecked = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.login1.FillColorUsername = System.Drawing.Color.White;
            this.login1.ForeColorlabelPassword = System.Drawing.SystemColors.ControlText;
            this.login1.ForeColorlabelUsername = System.Drawing.SystemColors.ControlText;
            this.login1.ForeColorPassword = System.Drawing.Color.Black;
            this.login1.ForeColorUsername = System.Drawing.Color.Black;
            this.login1.Location = new System.Drawing.Point(263, 191);
            this.login1.Name = "login1";
            this.login1.PlaceholderPassword = "Password";
            this.login1.PlaceholderUsername = "Username";
            this.login1.Size = new System.Drawing.Size(272, 173);
            this.login1.TabIndex = 10;
            this.login1.OnLoginClick += new System.EventHandler<ctrlLoginInfo.Login.LoginInfoEventArgs>(this.login1_OnLoginClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 441);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ctrlLoginInfo.Login login1;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageTitle;
    }
}