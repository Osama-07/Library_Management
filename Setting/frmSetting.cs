using Library_Management.Books;
using Library_Management.Borrowing_Records;
using Library_Management.Fines;
using Library_Management.Home;
using Library_Management.Profile;
using Library_Management.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_Management.frmMainMenue;

namespace Library_Management.Setting
{
    public partial class frmSetting : Form
    {
        private frmMainMenue _frmMainMenue;

        struct stChildForms
        {
            // this forms for can be navigated without having to reload the page.
            public frmStock frmStock { get; set; }
            public frmServicePrices frmServicePrices { get; set; }
        }
        private stChildForms Forms = new stChildForms();

        public frmSetting(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        private Form activeForm;
        private Form activeSubForm;

        public void OpenChailedForm(Form ChildForm)
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
                //lblTitle.Text = ChildForm.Text;
                //ImageTitle(imageTitle);
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
                    //activeForm.Close();
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

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (Forms.frmStock != null)
            {
                OpenChailedForm(Forms.frmStock);
            }
            else
            {
                Forms.frmStock = new frmStock(this);

                OpenChailedForm(Forms.frmStock);
            }
        }

        private void btnServicePrices_Click(object sender, EventArgs e)
        {
            if (Forms.frmServicePrices != null)
            {
                OpenChailedForm(Forms.frmServicePrices);
            }
            else
            {
                Forms.frmServicePrices = new frmServicePrices(this);

                OpenChailedForm(Forms.frmServicePrices);
            }
        }

        private void frmSetting_Shown(object sender, EventArgs e)
        {
            btnStock.PerformClick();
        }
    }
}
