using Library_Management.Global;
using LibraryBusiness;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Borrowing_Records
{
    public partial class frmBorrowABook : Form
    {
        private frmBorrowingRecords _frmBorrowingRecords;

        private int _BookID { get; }
        private int _CopyID
        {
            get
            {
                return clsBookCopies.GetFirstAvailableCopyID(_BookID)?? 0; // if return null will convert to 0.
            }
        }

        public frmBorrowABook(frmBorrowingRecords frmBorrowingRecords, int bookID)
        {
            InitializeComponent();

            _frmBorrowingRecords = frmBorrowingRecords;
            _BookID = bookID;
        }

        private void _LoadBorrowingInfo()
        {
            txtBookID.Text = _BookID.ToString();
            txtCopyID.Text = _CopyID.ToString();
            txtUserID.Focus();
            dtpBorrowing_Date.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(1);
        }

        private bool _CheckUserID()
        {
            int UserID = Convert.ToInt32(txtUserID.Text);

            if (!string.IsNullOrEmpty(txtUserID.Text) && UserID > 0)
            {
                if (clsUsers.IsExist(UserID))
                {
                    // check if user already borrower or not.
                    if (!clsBorrowingRecords.IsUserBorrower(UserID))
                        return true;
                    else
                    {
                        MessageBox.Show("This user is already borrowed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
                else
                {
                    // this user is not exists.
                    txtUserID.BorderColor = Color.Red;
                    MessageBox.Show($"this user ID is not found.\n\nGo to add user.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            else
            {
                // if txtUserID is empty Or UserID = 1, this ID for admin cannot borrow with him.
                txtUserID.BorderColor = Color.Red;
                MessageBox.Show($"this user ID is not found.\n\nGo to add user.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private bool _Save()
        {
            int UserID = Convert.ToInt32(txtUserID.Text);
            int BorrowingDays = Convert.ToInt32(nupBorrowingDays.Value);

            return clsBorrowingRecords.SetBorrowed(_CopyID, UserID, BorrowingDays);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmBorrowingRecords.Referesh();
            _frmBorrowingRecords.Show();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private void frmBorrowABook_Shown(object sender, EventArgs e)
        {
            _LoadBorrowingInfo();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckUserID())
            {
                //MessageBox.Show($"this user ID is not found.\n\nGo to add user.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_Save())
            {
                btnSave.Enabled = false;
                int UserID = Convert.ToInt32(txtUserID.Text);
                
                MessageBox.Show($"The book has been borrowed successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnBack.PerformClick();

                // Send borrow book has been complete email to user.
                await Task.Run(() =>
                {
                    clsGlobal.SendBorrowConfirmationEmail(UserID, _BookID);
                });
            }
            else
                MessageBox.Show($"Sorry, cannot will be borrow this book.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void nupBorrowingDays_ValueChanged(object sender, EventArgs e)
        {
            int Days = Convert.ToInt16(nupBorrowingDays.Value);
            dtpDueDate.Value = DateTime.Now.AddDays(Days);
        }
    }
}
