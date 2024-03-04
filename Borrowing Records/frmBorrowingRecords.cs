using Library_Management.Books;
using Library_Management.Global;
using Library_Management.Reservations;
using LibraryBusiness;
using System;
using System.Windows.Forms;

namespace Library_Management.Borrowing_Records
{
    public partial class frmBorrowingRecords : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmBorrowingRecords(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        private void frmBorrowingRecords_Shown(object sender, EventArgs e)
        {
            ctrlShowBooksCatalogeWithFilter1.LoadBookControls();
        }

        private void ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick(object sender, Books.Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick e)
        {
            MessageBox.Show("Here Borrowing Records Form.", "Borrowing Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRe_Book_Click(object sender, EventArgs e)
        {
            if (clsBorrowingRecords.IsUserBorrower((int)clsGlobal.CurrentUser.User_ID))
            {
                frmChooseBookForReturn frm = new frmChooseBookForReturn();

                frm.OnChooseBook += OpenRe_BookPage;

                frm.ShowDialog();
            }
            else
                MessageBox.Show("You don't have borrowed books.", "Go to Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenRe_BookPage(object sender, int BookID)
        {
            if (BookID > 0)
            {
                frmReturnTheBook frm = new frmReturnTheBook(this, BookID);

                _frmMainMenue.OpenChildSubForm(frm);
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            // show form for choose book.
            frmChooseBook frm = new frmChooseBook();

            frm.OnChooseBookName += OpenBorrowBookPage; // delegate for return book id after user choose book.

            frm.ShowDialog();
        }

        private void OpenBorrowBookPage(object sender, int BookID)
        {
            // check if was there available book copy ?.
            if (clsBookCopies.IsExist(BookID))
            {
                frmBorrowABook frm = new frmBorrowABook(this, BookID);

                _frmMainMenue.OpenChildSubForm(frm);

                this.Hide();
            }
            else
            {
                MessageBox.Show($"Sorry, there is no copy currently available.\nGo to the reservations page and reserve your copy.", "Sorry",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Show Reservation page.
                frmReservations frm = new frmReservations(_frmMainMenue);

                _frmMainMenue.OpenChailedForm(frm, frmMainMenue.enImageTitle.Reservations);
            }
        }

    }
}
