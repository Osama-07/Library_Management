using LibraryBusiness;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Library_Management.Users.Controls
{
    public partial class ctrlGetUserInfo : UserControl
    {
        public ctrlGetUserInfo()
        {
            InitializeComponent();

            txtSearch.Focus();
        }

        public int User_ID { get; set; }

        public void Reset()
        {
            txtSearch.Clear();
            lblUserID.Text = "[????]";
            lblName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblUsername.Text = "[????]";
            lblLibraryCardNumber.Text = "[????]";
            txtSearch.Focus();
        }

        public bool LoadUserInfo(int userID)
        {
            // User ID [1] is for Admin, cannot be changed.
            if (userID <= 1)
            {
                MessageBox.Show($"This User With ID {userID} is Not Found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Reset();
                return false;
            }

            clsUsers User = clsUsers.FindByUser_ID(userID);

            if (User != null)
            {
                User_ID = userID;

                lblUserID.Text = User.User_ID.ToString();
                lblName.Text = User.Name;
                lblEmail.Text = User.Email;
                lblPhone.Text = User.Phone;
                lblUsername.Text = User.Username;
                lblLibraryCardNumber.Text = User.LibraryCardNumber.ToString();

                txtSearch.Text = User_ID.ToString();
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;
                btnReset.Enabled = false;

                return true;
            }
            else
                return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int UserID))
            {
                clsUsers User = clsUsers.FindByUser_ID(UserID);

                if (User != null && UserID != 1)
                {
                    User_ID = UserID;

                    lblUserID.Text = User.User_ID.ToString();
                    lblName.Text = User.Name;
                    lblEmail.Text = User.Email;
                    lblPhone.Text = User.Phone;
                    lblUsername.Text = User.Username;
                    lblLibraryCardNumber.Text = User.LibraryCardNumber.ToString();
                }
                else
                {
                    MessageBox.Show($"User With ID {UserID} is Not exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Reset();
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

    }
}
