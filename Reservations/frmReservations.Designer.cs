namespace Library_Management.Reservations
{
    partial class frmReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservations));
            this.ctrlShowBooksCatalogeWithFilter1 = new Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter();
            this.btnReservations = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancelReservation = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ctrlShowBooksCatalogeWithFilter1
            // 
            this.ctrlShowBooksCatalogeWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowBooksCatalogeWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowBooksCatalogeWithFilter1.Name = "ctrlShowBooksCatalogeWithFilter1";
            this.ctrlShowBooksCatalogeWithFilter1.Size = new System.Drawing.Size(1150, 656);
            this.ctrlShowBooksCatalogeWithFilter1.TabIndex = 0;
            this.ctrlShowBooksCatalogeWithFilter1.OnBtnBookClick += new System.EventHandler<Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick>(this.ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick);
            // 
            // btnReservations
            // 
            this.btnReservations.Animated = true;
            this.btnReservations.BorderRadius = 15;
            this.btnReservations.CheckedState.Parent = this.btnReservations;
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.CustomImages.Parent = this.btnReservations;
            this.btnReservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReservations.FillColor2 = System.Drawing.Color.Green;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.HoverState.Parent = this.btnReservations;
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReservations.Location = new System.Drawing.Point(755, 12);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.ShadowDecoration.Parent = this.btnReservations;
            this.btnReservations.Size = new System.Drawing.Size(180, 62);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Reservation";
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Animated = true;
            this.btnCancelReservation.BorderRadius = 15;
            this.btnCancelReservation.CheckedState.Parent = this.btnCancelReservation;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.CustomImages.Parent = this.btnCancelReservation;
            this.btnCancelReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelReservation.FillColor2 = System.Drawing.Color.Maroon;
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.HoverState.Parent = this.btnCancelReservation;
            this.btnCancelReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelReservation.Image")));
            this.btnCancelReservation.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCancelReservation.Location = new System.Drawing.Point(958, 12);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.ShadowDecoration.Parent = this.btnCancelReservation;
            this.btnCancelReservation.Size = new System.Drawing.Size(180, 62);
            this.btnCancelReservation.TabIndex = 2;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1150, 656);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.ctrlShowBooksCatalogeWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Shown += new System.EventHandler(this.frmReservations_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Books.Controls.ctrlShowBooksCatalogeWithFilter ctrlShowBooksCatalogeWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnReservations;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelReservation;
    }
}