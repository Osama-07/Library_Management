using Library_Management.Books.Controls;

namespace Library_Management.Home
{
    partial class frmHome
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
            this.ctrlShowBooksCatalogeWithFilter1 = new Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter();
            this.SuspendLayout();
            // 
            // ctrlShowBooksCatalogeWithFilter1
            // 
            this.ctrlShowBooksCatalogeWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowBooksCatalogeWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowBooksCatalogeWithFilter1.Name = "ctrlShowBooksCatalogeWithFilter1";
            this.ctrlShowBooksCatalogeWithFilter1.Size = new System.Drawing.Size(1150, 656);
            this.ctrlShowBooksCatalogeWithFilter1.TabIndex = 76;
            this.ctrlShowBooksCatalogeWithFilter1.OnBtnBookClick += new System.EventHandler<Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick>(this.ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1150, 656);
            this.Controls.Add(this.ctrlShowBooksCatalogeWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Shown += new System.EventHandler(this.frmHome_Shown);
            this.VisibleChanged += new System.EventHandler(this.frmHome_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private Books.Controls.ctrlShowBooksCatalogeWithFilter ctrlShowBooksCatalogeWithFilter1;
    }
}