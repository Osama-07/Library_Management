using System;
using System.Windows.Forms;
using LibraryBusiness;

namespace Library_Management.Books
{
    public partial class frmBooks : Form
    {
        private frmMainMenue _frmMainMenue;

        public string TitlePage
        {
            get
            {
                return _frmMainMenue.TitlePage;
            }
            set
            {
                _frmMainMenue.TitlePage = value;
            }
        }

        public frmBooks(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        public void Referesh()
        {
            frmBooks_Shown(null, null);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook(this);

            _frmMainMenue.OpenChildSubForm(frm);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ctrlShowBooksCatalogeWithFilter1.CountControls > 0)
            {
                frmChooseBook frm = new frmChooseBook();

                frm.OnChooseBookName += OpenUpdateForm;

                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sorry, Not found books for update.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void OpenUpdateForm(object sender, int BookID)
        {
            frmAddEditBook frm = new frmAddEditBook(this, BookID);

            _frmMainMenue.OpenChildSubForm(frm);
        }

        private void frmBooks_Shown(object sender, EventArgs e)
        {
            ctrlShowBooksCatalogeWithFilter1.LoadBookControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ctrlShowBooksCatalogeWithFilter1.CountControls > 0)
            {
                frmChooseBook frm = new frmChooseBook();

                frm.OnChooseBookName += DeleteBook;

                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sorry, Not found books for Deleted.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void DeleteBook(object sender, int BookID)
        {
            if (MessageBox.Show($"Are you certain you wish to proceed with deleting this book? \n\nCaution:\nDeleting the book will result in the removal of all associated copies from the database.",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsBooks.IsExist(BookID))
                {
                    if (clsBooks.DeleteBookWithCopiesAndControl(BookID))
                    {
                        MessageBox.Show($"Deleted book with ID {BookID} Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Referesh();
                    }
                    else
                        MessageBox.Show($"Delete book with ID {BookID} is failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick(object sender, Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick e)
        {
            MessageBox.Show("Here Books form.", "Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
