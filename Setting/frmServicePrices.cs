using Guna.UI2.WinForms;
using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Setting
{
    public partial class frmServicePrices : Form
    {
        private frmSetting _frmSetting;

        private Dictionary<string, int> _Settings { get; set; }

        public frmServicePrices(frmSetting frmSetting)
        {
            InitializeComponent();

            _frmSetting = frmSetting;
        }

        private void _FillSettingsInfo()
        {
            _Settings = clsSettings.GetSettingsInfo();

            txtBorrowingRate.Text = _Settings["BorrowingRate"].ToString();
            txtFinePrice.Text = _Settings["FinePrice"].ToString();
        }

        private bool _ValidatingTextBox(Guna2TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BorderColor = Color.Red;
                return false;
            }
            else
                textBox.BorderColor = Color.Silver;

            return true;
        }

        private bool _SaveSettings()
        {
            _Settings["BorrowingRate"] = Convert.ToInt32(txtBorrowingRate.Text);
            _Settings["FinePrice"] = Convert.ToInt32(txtFinePrice.Text);

            return clsSettings.UpdateSettings(_Settings["BorrowingRate"], _Settings["FinePrice"]);
        }


        private void frmServicePrices_Shown(object sender, EventArgs e)
        {
            _FillSettingsInfo();
        }

        private void txtFinePrice_Validating(object sender, CancelEventArgs e)
        {
            _ValidatingTextBox((Guna2TextBox)sender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidatingTextBox(txtBorrowingRate) || !_ValidatingTextBox(txtFinePrice))
            {
                MessageBox.Show("Enter the data correctly.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_SaveSettings())
                MessageBox.Show("Updated Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update Settings is Failed, try again later.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void txtFinePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
