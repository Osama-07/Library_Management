using Library_Management.Global;
using Library_Management.Profile;
using LibraryBusiness;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Users
{
    public partial class frmEmailVerification : Form
    {
        private frmUsers _frmUsers { get; set; }

        private string _VerificationCode { get; set; }
        private string _RecipientEmail { get; set; }

        public frmEmailVerification(frmUsers frmUsers)
        {
            InitializeComponent();

            _frmUsers = frmUsers;
        }

        private string _CreateVerificationCode()
        {
            Random random = new Random();
            StringBuilder code = new StringBuilder();


            for (int i = 0; i < 6; i++)
            {
                code.Append(random.Next(0, 9));
            }

            return code.ToString();
        }

        private bool IsValidGmailAddress(string email)
        {
            // نمط لفحص صحة عنوان البريد الإلكتروني
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            // فحص تطابق النص مع النمط
            return Regex.IsMatch(email, pattern);
        }


        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (!clsUsers.IsEmailExists(txtEmail.Text))
            {
                if (!IsValidGmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("this email is not valid.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    panelEmail.Visible = false;
                    panelCode.Visible = true;

                    _VerificationCode = _CreateVerificationCode();
                    _RecipientEmail = txtEmail.Text;

                    await Task.Run(() => 
                    {
                        if (clsGlobal.SendVerificationEmail(_RecipientEmail, _VerificationCode))
                            txtCode.Focus();
                        else
                            MessageBox.Show("Sending the code to the email failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    });
                }
            }
            else
                MessageBox.Show("This email has already been used.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidGmailAddress(txtEmail.Text))
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
        }

        private void lblResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnNext.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCode.Visible = false;
            panelEmail.Visible = true;

            txtCode.Clear();
        }

        private void btnVerifi_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == _VerificationCode)
            {
                frmAddEditUser frm = new frmAddEditUser(_frmUsers, txtEmail.Text);

                _frmUsers.frmMainMenue.OpenChildSubForm(frm);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text == _VerificationCode)
                btnVerifi.PerformClick();
        }

    }
}
