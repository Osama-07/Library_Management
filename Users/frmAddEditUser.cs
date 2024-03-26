using Library_Management.Profile;
using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Text.RegularExpressions;
using Library_Management.Global;
using LibraryBusiness;
using Util;

namespace Library_Management.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 1, Update = 2};
        enMode _Mode;


        private frmUsers _frmUsers;

        private int _UserID { get; set; }
        private clsUsers _UserInfo
        {
            get
            {
                return clsUsers.FindByUser_ID(this._UserID);
            }
        }

        public frmAddEditUser(frmUsers frmUsers)
        {
            InitializeComponent();

            _frmUsers = frmUsers;
            _Mode = enMode.AddNew;
            lblAddEditTitle.Text = "Add User";
        }

        public frmAddEditUser(frmUsers frmUsers, int UserID)
        {
            InitializeComponent();

            _frmUsers = frmUsers;
            _UserID = UserID;
            _Mode = enMode.Update;
            lblAddEditTitle.Text = "Edit User";
        }

        // Validation Fields.
        private bool _ValidatingNullOrEmpty(Guna2TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "This field is required.");
                textBox.BorderColor = Color.Red;
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
                textBox.BorderColor = Color.Silver;
                return true;
            }

        }

        private bool _ValidateEmail()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "This field is required.");
                txtEmail.BorderColor = Color.Red;
                return false;
            }
            else
            {
                if (!clsValidating.ValidateEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Enter your email correctly.");
                    txtEmail.BorderColor = Color.Red;
                    return false;
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "");
                    txtEmail.BorderColor = Color.Silver;
                    return true;
                }
            }
        }

        private bool _ValidateConfirmPassword()
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "This field is required.");
                txtConfirmPassword.BorderColor = Color.Red;
                return false;
            }
            else
            {
                // check if (txtPassword) == (txtConfirmPassword).
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    errorProvider1.SetError(txtConfirmPassword, "It should be like a password.");
                    txtConfirmPassword.BorderColor = Color.Red;
                    return false;
                }
                else
                {
                    errorProvider1.SetError(txtConfirmPassword, "");
                    txtConfirmPassword.BorderColor = Color.Silver;
                    return true;
                }
            }
        }

        private bool _CheckBeforeSave()
        {
            if (!this.ValidateChildren())
                return false;

            if (!_ValidateEmail())
                return false;

            if (!_ValidateConfirmPassword())
                return false;

            if (!_ValidatingNullOrEmpty(txtName))
                return false;

            if (!_ValidatingNullOrEmpty(txtPhone))
                return false;

            if (!_ValidatingNullOrEmpty(txtUsername))
                return false;

            if (!_ValidatingNullOrEmpty(txtPassword))
                return false;

            return true;
        }

        // Update Mode.
        private void _FillUserInfo()
        {
            txtName.Text = _UserInfo.Name;
            txtPhone.Text = _UserInfo.Phone;
            txtEmail.Text = _UserInfo.Email;
            txtUsername.Text = _UserInfo.Username;
            txtPassword.Text = _UserInfo.Password;
            txtConfirmPassword.Text = _UserInfo.Password;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            chkAgree.Enabled = false;
            chkAgree.Checked = true;
        }

        private bool _Save()
        {
            if (_Mode == enMode.AddNew)
            { 
                clsUsers User = new clsUsers();

                User.Name = txtName.Text;
                User.Phone = txtPhone.Text;
                User.Email = txtEmail.Text;
                User.Username = txtUsername.Text;
                User.Password = clsUtil.ComputeHash(txtPassword.Text);
                
                if (User.Save())
                {
                    _UserID = User.User_ID ?? 0; // if the User ID is null instead it as 0.
                    MessageBox.Show($"Added User Successfully.\n\nUser ID is: {_UserID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            
            if (_Mode == enMode.Update)
            {
                clsUsers User = clsUsers.FindByUser_ID(_UserID);

                User.Name = txtName.Text;
                User.Phone = txtPhone.Text;
                User.Email = txtEmail.Text;
                User.Username = txtUsername.Text;

                if (User.Save())
                {
                    MessageBox.Show($"Updated User Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }

            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmUsers.Show();
            _frmUsers.Referesh();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckBeforeSave())
            {
                MessageBox.Show("please enter the user information correctly", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_Save())
            {
                btnBack.PerformClick();
            }
            else
                MessageBox.Show($"Add User is failed, Try again later.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ValidatingNullOrEmpty((Guna2TextBox) sender);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ValidateEmail();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            _ValidateConfirmPassword();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmAddEditUser_Shown(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
                _FillUserInfo();
        }
    }
}
