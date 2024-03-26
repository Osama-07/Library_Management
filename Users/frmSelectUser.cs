using LibraryBusiness;
using System;
using System.Windows.Forms;

namespace Library_Management.Users
{
    public partial class frmSelectUser : Form
    {
        public frmSelectUser()
        {
            InitializeComponent();
        }

        public delegate void ChooseBookEventArgs(object sender, int UserID);
        public event ChooseBookEventArgs OnChooseBook;

        private void btnNext_Click(object sender, EventArgs e)
        {
            int UserID = ctrlGetUserInfo1.User_ID;

            if (!clsUsers.IsExist(UserID))
            {
                MessageBox.Show($"User with ID {UserID} is Not Exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (OnChooseBook != null)
                OnChooseBook?.Invoke(this, UserID);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
