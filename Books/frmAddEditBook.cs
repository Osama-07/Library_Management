using System;
using System.Windows.Forms;
using Library_Management.Properties;
using LibraryBusiness;

namespace Library_Management.Books
{
    public partial class frmAddEditBook : Form
    {
       public enum enMode { AddNew = 1, Update = 2}
        public enMode Mode;

        private frmBooks _frmBooks;

        private int _BookID { get; set; }

        public frmAddEditBook(frmBooks frmBooks)
        {
            InitializeComponent();

            this._frmBooks = frmBooks; // for back to previos form.
            ctrlAddEditBook1.Mode = Books.Controls.ctrlAddEditBook.enMode.AddNew;
            Mode = enMode.AddNew;
        }

        public frmAddEditBook(frmBooks frmBooks, int BookID)
        {
            InitializeComponent();

            this._frmBooks = frmBooks; // for back to previos form.
            this._BookID = BookID;
            Mode = enMode.Update;
            ctrlAddEditBook1.Mode = Books.Controls.ctrlAddEditBook.enMode.Update;
        }

        private void _LoadImageMode()
        {
            if (Mode == enMode.AddNew)
            {
                pbAddEditImage.Image = Resources.Add_Book;
                lblAddEditTitle.Text = "Add Book";
            }
            else
            {
                pbAddEditImage.Image = Resources.Edit_Book;
                lblAddEditTitle.Text = "Edit Book";
            }
        }

        private void _FillBookInfo()
        {
            ctrlAddEditBook1.LoadBookInfo(_BookID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            _frmBooks.Show();
            _frmBooks.TitlePage = _frmBooks.Text;
            _frmBooks.Referesh(); // referesh Books list.

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private void frmAddEditBook_Shown(object sender, EventArgs e)
        {
            _LoadImageMode();

            if (Mode == enMode.Update)
                _FillBookInfo();
        }

        private void ctrlAddEditBook1_OnSaveed()
        {
            btnBack.PerformClick();
        }
    }
}
