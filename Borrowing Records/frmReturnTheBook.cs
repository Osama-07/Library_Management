using Library_Management.Global;
using LibraryBusiness;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Library_Management.Borrowing_Records
{
    public partial class frmReturnTheBook : Form
    {
        private frmBorrowingRecords _frmBorrowingRecords;

        private int _BookID { get; set; }
        private int _UserID { get; set; }
        private static DataTable dtBorrowedBookInfo = new DataTable();
        private DataView dvBorrowedBookInfo = new DataView(dtBorrowedBookInfo);

        public frmReturnTheBook(frmBorrowingRecords frmBorrowingRecords, int bookID, int userID)
        {
            InitializeComponent();

            _BookID = bookID;
            _UserID = userID;
            _frmBorrowingRecords = frmBorrowingRecords;
        }

        private void _FillInTheBoxesWithInfo()
        {

            if (clsUsers.IsExist(_UserID))
            {
                dtBorrowedBookInfo = clsBorrowingRecords.GetBorrowedBookInfo(_BookID, _UserID);
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

                    pbBookImage.ImageLocation = (string)row["Image"];

                }

            }
        }

        private Nullable<int> _ReturnTheBook()
        {
            int Copy_ID = Convert.ToInt32(txtCopyID.Text);
            int User_ID = Convert.ToInt32(txtUserID.Text);

            return clsBorrowingRecords.ReturnTheBook(Copy_ID, User_ID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmBorrowingRecords.Show();
            _frmBorrowingRecords.Referesh();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private async void btnRe_Book_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want return this book?", "Verifying", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                btnRe_Book.Enabled = false;
                btnCancel.Enabled = false;

                int? fineID = _ReturnTheBook();
                if (fineID == null || fineID == 0) // null or 0 means the user has no fines.
                {
                    MessageBox.Show("The book was returned successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnBack.PerformClick();

                    await Task.Run(() =>
                    {
                        clsGlobal.SendReturnConfirmationEmail(_UserID, _BookID);
                    });
                }
                else
                {
                    MessageBox.Show($"The user is late in returning the book, and a late fine is imposed on him with Fine ID {fineID}.\n\nGo to the fines screen to see the fine details.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.None);
                    MessageBox.Show("The book was returned successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnBack.PerformClick();

                    // Notifying the user of the fine.
                    await Task.Run(() =>
                    { 
                        clsGlobal.SendFineEmail(_UserID, (int)fineID);
                    });

                }
            }
        }

        private void frmReturnTheBook_Shown(object sender, EventArgs e)
        {
            _FillInTheBoxesWithInfo();
        }

    }
}