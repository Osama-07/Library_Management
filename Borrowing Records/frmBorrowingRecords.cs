using Library_Management.Books;
using Library_Management.Global;
using Library_Management.Reservations;
using Library_Management.Users;
using LibraryBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management.Borrowing_Records
{
    public partial class frmBorrowingRecords : Form
    {
        private frmMainMenue _frmMainMenue;

        private static DataTable _dtBorrowingRecords = new DataTable();
        private DataView _dvBorrowingRecords = new DataView(_dtBorrowingRecords);

        public frmBorrowingRecords(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        public void Referesh()
        {
            _FillBorrowingRecordsInfo();
            cbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            txtSearch.Clear();
            btnSearch.Enabled = false;
        }

        private void _FillBorrowingRecordsInfo()
        {
            _dtBorrowingRecords = clsBorrowingRecords.GetAllBorrowingRecords();
            _dvBorrowingRecords = _dtBorrowingRecords.DefaultView;

            dgvBorrowingRcords.DataSource = _dvBorrowingRecords;

            if (dgvBorrowingRcords.Rows.Count > 0)
            {
                lblNothing.Visible = false;

                dgvBorrowingRcords.Columns[0].HeaderText = "ID";
                dgvBorrowingRcords.Columns[0].Width = 40;

                dgvBorrowingRcords.Columns[1].HeaderText = "Name";
                dgvBorrowingRcords.Columns[1].Width = 150;

                dgvBorrowingRcords.Columns[2].HeaderText = "Title";
                dgvBorrowingRcords.Columns[2].Width = 150;

                dgvBorrowingRcords.Columns[3].HeaderText = "Copy ID";
                dgvBorrowingRcords.Columns[3].Width = 50;

                dgvBorrowingRcords.Columns[4].HeaderText = "Borrowing Date";
                dgvBorrowingRcords.Columns[4].Width = 80;

                dgvBorrowingRcords.Columns[5].HeaderText = "Due Date";
                dgvBorrowingRcords.Columns[5].Width = 80;
                
                dgvBorrowingRcords.Columns[6].HeaderText = "Metaphor Status";
                dgvBorrowingRcords.Columns[6].Width = 140;

            }
            else
                lblNothing.Visible = true;

        }

        private void _FilterByNone()
        {
            _dvBorrowingRecords.RowFilter = "1 = 1";
            dgvBorrowingRcords.DataSource = _dvBorrowingRecords;

            // Message no users.
            if (dgvBorrowingRcords.Rows.Count == 0)
                lblNothing.Visible = true;
            else
                lblNothing.Visible = false;
        }

        private void _Search()
        {

            if (txtSearch.Text == null || txtSearch.Text == "" || cbFilterBy.Text == "None")
            {
                _FilterByNone();
                return;
            }

            if (cbFilterBy.Text == "Copy ID" && txtSearch.Text != "")
            {
                _dvBorrowingRecords.RowFilter = string.Format("[Copy_ID] = {0}", txtSearch.Text);
                dgvBorrowingRcords.DataSource = _dvBorrowingRecords;
            }
            else
                _dvBorrowingRecords.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilterBy.Text, txtSearch.Text);

            // Message no users.
            if (dgvBorrowingRcords.Rows.Count == 0)
                lblNothing.Visible = true;
            else
                lblNothing.Visible = false;

        }

        private void frmBorrowingRecords_Shown(object sender, EventArgs e)
        {
            Referesh();
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

        private void btnRe_Book_Click(object sender, EventArgs e)
        {
            frmSelectUser frm = new frmSelectUser();

            frm.OnChooseBook += OpenChooseBookForReturnPage;

            frm.ShowDialog();
        }

        private void OpenChooseBookForReturnPage(object sender, int UserID)
        {
            if (clsBorrowingRecords.IsUserBorrower(UserID))
            {
                frmChooseBookForReturn frm = new frmChooseBookForReturn(UserID);

                frm.OnChooseBook += OpenRe_BookPage;

                frm.ShowDialog();
            }
            else
                MessageBox.Show("You don't have borrowed books.", "Go to Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenRe_BookPage(object sender, int BookID, int UserID)
        {
            if (BookID > 0)
            {
                frmReturnTheBook frm = new frmReturnTheBook(this, BookID, UserID);

                _frmMainMenue.OpenChildSubForm(frm);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Referesh();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text != "None")
            {
                txtSearch.Visible = true;
                btnSearch.Enabled = true;
                txtSearch.Focus();
            }
            else
            {
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
                _Search();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Copy ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
