using Library_Management.Books;
using static Library_Management.Books.Controls.ctrlShowBooksCatalogeWithFilter;
using System.Windows.Forms;
using System;
using LibraryBusiness;

namespace Library_Management.Reservations
{
    public partial class frmReservations : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmReservations(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        private void OpenReservationPage(object sender, int BookID)
        {

            if (!clsBookCopies.IsThereACopyAvailable(BookID))
            {
                frmCompleteReservation frm = new frmCompleteReservation(this, BookID);

                _frmMainMenue.OpenChildSubForm(frm);
            }
            else
                MessageBox.Show("this book is already has available copies, go to Borrowing Records.", "already exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void frmReservations_Shown(object sender, EventArgs e)
        {
            ctrlShowBooksCatalogeWithFilter1.LoadBookControls();
        }

        private void ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick(object sender, BtnBookClick e)
        {
            MessageBox.Show("Book ID " + e.BookID, "Book ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            frmCancelReservation frm = new frmCancelReservation();

            frm.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            frmChooseBook frm = new frmChooseBook();

            frm.OnChooseBookName += OpenReservationPage;

            frm.ShowDialog();
        }

    }
}
