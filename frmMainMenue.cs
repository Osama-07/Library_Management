using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Library_Management.Books;
using Library_Management.Borrowing_Records;
using Library_Management.Home;
using Library_Management.Profile;
using Library_Management.Properties;
using Library_Management.Reservations;
using Library_Management.Setting;
using LibraryBusiness;
using Microsoft.VisualBasic.ApplicationServices;

namespace Library_Management
{
    public partial class frmMainMenue : Form
    {
        public enum enImageTitle { Home = 1, Books = 2, Reservations = 3, BorrowingRecords = 4, Profile = 5, Settings = 6 }

        struct stChildForms
        {
            // this forms for can be navigated without having to reload the page.
            public frmHome frmHome { get; set; }
            public frmBooks frmBooks { get; set; }
            public frmReservations frmReservations { get; set; }
            public frmBorrowingRecords frmBorrowingRecords { get; set; }
            public frmUsers frmProfile { get; set; }
            public frmSetting frmSetting { get; set; }
        }
        private stChildForms Forms = new stChildForms();

        public frmMainMenue()
        {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Form activeForm;
        private Form activeSubForm;

        public string TitlePage
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        private void ImageTitle(enImageTitle imageTitle)
        {
            switch (imageTitle)
            {
                case enImageTitle.Home:
                    pbImageTitle.Image = Resources.Home;
                    break;
                case enImageTitle.Books:
                    pbImageTitle.Image = Resources.books__1_;
                    break;
                case enImageTitle.Reservations:
                    pbImageTitle.Image = Resources.reservations;
                    break;
                case enImageTitle.BorrowingRecords:
                    pbImageTitle.Image = Resources.Borrowing;
                    break;
                case enImageTitle.Profile:
                    pbImageTitle.Image = Resources.user;
                    break;
                case enImageTitle.Settings:
                    pbImageTitle.Image = Resources.settings;
                    break;
                default:
                    pbImageTitle.Image = Resources.Home;
                    break;
            }
        }

        public void OpenChailedForm(Form ChildForm, enImageTitle imageTitle)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Hide();

                    if (activeSubForm != null)
                        activeSubForm.Close();
                }

                //ChangeThameColor(ThameColor);
                activeForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                this.panelForms.Controls.Add(ChildForm);
                this.panelForms.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
                lblTitle.Text = ChildForm.Text;
                ImageTitle(imageTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void OpenChildSubForm(Form ChildSubForm)
        {
            try
            {
                if (activeSubForm != null)
                {
                    activeSubForm.Close();
                }

                //ChangeThameColor(ThameColor);
                activeSubForm = ChildSubForm;
                ChildSubForm.TopLevel = false;
                ChildSubForm.FormBorderStyle = FormBorderStyle.None;
                ChildSubForm.Dock = DockStyle.Fill;
                this.panelForms.Controls.Add(ChildSubForm);
                this.panelForms.Tag = ChildSubForm;
                ChildSubForm.BringToFront();
                ChildSubForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmMainMenue_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Forms.frmHome != null)
            {
                OpenChailedForm(Forms.frmHome, enImageTitle.Home);
            }
            else
            {
                Forms.frmHome = new frmHome(this);

                OpenChailedForm(Forms.frmHome, enImageTitle.Home);
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (Forms.frmBooks != null)
            {
                OpenChailedForm(Forms.frmBooks, enImageTitle.Books);
            }
            else
            { 
                Forms.frmBooks = new frmBooks(this);
                
                OpenChailedForm(Forms.frmBooks, enImageTitle.Books);
            }
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (Forms.frmReservations != null)
            {
                OpenChailedForm(Forms.frmReservations, enImageTitle.Reservations);
            }
            else
            {
                Forms.frmReservations = new frmReservations(this);

                OpenChailedForm(Forms.frmReservations, enImageTitle.Reservations);
            }
        }

        private void btnBorrowingRecords_Click(object sender, EventArgs e)
        {
            if (Forms.frmBorrowingRecords != null)
            {
                OpenChailedForm(Forms.frmBorrowingRecords, enImageTitle.BorrowingRecords);
            }
            else
            {
                Forms.frmBorrowingRecords = new frmBorrowingRecords(this);

                OpenChailedForm(Forms.frmBorrowingRecords, enImageTitle.BorrowingRecords);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (Forms.frmProfile != null)
            {
                OpenChailedForm(Forms.frmProfile, enImageTitle.Profile);
            }
            else
            {
                Forms.frmProfile = new frmUsers(this);

                OpenChailedForm(Forms.frmProfile, enImageTitle.Profile);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (Forms.frmSetting != null)
            {
                OpenChailedForm(Forms.frmSetting, enImageTitle.Settings);
            }
            else
            {
                Forms.frmSetting = new frmSetting(this);

                OpenChailedForm(Forms.frmSetting, enImageTitle.Settings);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
