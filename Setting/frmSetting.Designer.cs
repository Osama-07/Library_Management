namespace Library_Management.Setting
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnServicePrices = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.BorderRadius = 16;
            this.guna2CustomGradientPanel2.Controls.Add(this.btnServicePrices);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnStock);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(220, 656);
            this.guna2CustomGradientPanel2.TabIndex = 66;
            // 
            // btnServicePrices
            // 
            this.btnServicePrices.Animated = true;
            this.btnServicePrices.AutoRoundedCorners = true;
            this.btnServicePrices.BackColor = System.Drawing.Color.Transparent;
            this.btnServicePrices.BorderRadius = 24;
            this.btnServicePrices.CheckedState.Parent = this.btnServicePrices;
            this.btnServicePrices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicePrices.CustomImages.Parent = this.btnServicePrices;
            this.btnServicePrices.FillColor = System.Drawing.Color.Transparent;
            this.btnServicePrices.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicePrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnServicePrices.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnServicePrices.HoverState.Parent = this.btnServicePrices;
            this.btnServicePrices.Image = global::Library_Management.Properties.Resources.Fines;
            this.btnServicePrices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServicePrices.ImageSize = new System.Drawing.Size(40, 40);
            this.btnServicePrices.Location = new System.Drawing.Point(0, 112);
            this.btnServicePrices.Name = "btnServicePrices";
            this.btnServicePrices.ShadowDecoration.Parent = this.btnServicePrices;
            this.btnServicePrices.Size = new System.Drawing.Size(220, 51);
            this.btnServicePrices.TabIndex = 77;
            this.btnServicePrices.Text = "Service Prices";
            this.btnServicePrices.Click += new System.EventHandler(this.btnServicePrices_Click);
            // 
            // btnStock
            // 
            this.btnStock.Animated = true;
            this.btnStock.AutoRoundedCorners = true;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BorderRadius = 24;
            this.btnStock.CheckedState.Parent = this.btnStock;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.CustomImages.Parent = this.btnStock;
            this.btnStock.FillColor = System.Drawing.Color.Transparent;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStock.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStock.HoverState.Parent = this.btnStock;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStock.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStock.Location = new System.Drawing.Point(0, 61);
            this.btnStock.Name = "btnStock";
            this.btnStock.ShadowDecoration.Parent = this.btnStock;
            this.btnStock.Size = new System.Drawing.Size(220, 51);
            this.btnStock.TabIndex = 69;
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(220, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(930, 656);
            this.panelForms.TabIndex = 67;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 656);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Shown += new System.EventHandler(this.frmSetting_Shown);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnServicePrices;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private System.Windows.Forms.Panel panelForms;
    }
}