using Library_Management.Global;
using LibraryBusiness;
using System;
using System.Drawing;
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
            if (clsUsers.IsExist(Convert.ToInt32(txtUserID.Text)))
            {
                return true;
            }
            else
            {
                txtUserID.BorderColor = Color.Red;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckUserID())
            {
                MessageBox.Show($"this user ID is not found.\n\nGo to add user.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_Save())
            {
                MessageBox.Show($"The book has been borrowed successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnBack.PerformClick();
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
