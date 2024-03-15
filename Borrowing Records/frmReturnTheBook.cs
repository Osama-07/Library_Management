using Library_Management.Global;
using LibraryBusiness;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Util;

namespace Library_Management.Borrowing_Records
{
    public partial class frmReturnTheBook : Form
    {
        private frmBorrowingRecords _frmBorrowingRecords;

        private int _BookID {  get; set; }
        private static DataTable dtBorrowedBookInfo = new DataTable();
        private DataView dvBorrowedBookInfo = new DataView(dtBorrowedBookInfo);

        public frmReturnTheBook(frmBorrowingRecords frmBorrowingRecords, int bookID)
        {
            InitializeComponent();

            _BookID = bookID;
            _frmBorrowingRecords = frmBorrowingRecords;
        }

        private void _FillInTheBoxesWithInfo()
        {
            int User_ID = clsGlobal.CurrentUser.User_ID?? 0;

            if (clsUsers.IsExist(User_ID))
            {
                dtBorrowedBookInfo = clsBorrowingRecords.GetBorrowedBookInfo(_BookID, User_ID);
                dvBorrowedBookInfo = dtBorrowedBookInfo.DefaultView;

                foreach (DataRowView row in dvBorrowedBookInfo)
                {
                    txtBookID.Text = row["Book_ID"].ToString();
                    txtCopyID.Text = row["Copy_ID"].ToString();
                    txtUserID.Text = row["User_ID"].ToString();

                    dtpBorrowing_Date.Value = (DateTime)row["BorrowingDate"];
                    dtpDueDate.Value = (DateTime)row["DueDate"];
                    dtpActualReturnDate.Value = DateTime.Now;

                    nupBorrowingDays.Value = (int)row["BorrowingDays"];

                    pbBookImage.Image = clsUtil.ByteArrayToImage((byte[])row["Image"]);

                }

            }
        }

        private bool _ReturnTheBook()
        {
            int Copy_ID = Convert.ToInt32(txtCopyID.Text);
            int User_ID = Convert.ToInt32(txtUserID.Text);

            return clsBorrowingRecords.ReturnTheBook(Copy_ID, User_ID);
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

        private void btnRe_Book_Click(object sender, EventArgs e)
        {
            int User_ID = Convert.ToInt32(txtUserID.Text);

            if (clsUsers.IsExist(User_ID))
            {
                if (MessageBox.Show("Are you sure do you want return this book?", "Verifying", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    if (_ReturnTheBook())
                        MessageBox.Show("The book was returned successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show($"User With ID {User_ID} is Not Exists.\n\nGo To Add User.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            btnBack.PerformClick();
        }

        private void frmReturnTheBook_Shown(object sender, EventArgs e)
        {
            _FillInTheBoxesWithInfo();
        }

    }
}