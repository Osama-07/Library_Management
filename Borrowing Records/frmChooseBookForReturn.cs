using System.Data;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using LibraryBusiness;
using Library_Management.Global;
using System.Linq;

namespace Library_Management.Borrowing_Records
{
    public partial class frmChooseBookForReturn : Form
    {
        public frmChooseBookForReturn()
        {
            InitializeComponent();
        }

        private Dictionary<int, string> BorrwedUserBooks = new Dictionary<int, string>();

        public delegate void ChooseBook(object sender, int BookID);
        public event ChooseBook OnChooseBook;


        private void _FillBooksInComboBox()
        {
            int User_ID = (int)clsGlobal.CurrentUser.User_ID;

            BorrwedUserBooks = clsBorrowingRecords.GetBorrowedUserBooks(User_ID);

            foreach (var item in BorrwedUserBooks)
            {
                cmbBooks.Items.Add(item.Value);
            }

            if (cmbBooks.Items.Count > 0)
                cmbBooks.SelectedIndex = 0;
            else
            {
                MessageBox.Show("You don't have borrowed books.", "Go to borrow book", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private Nullable<int> _GetBookID()
        {
            Nullable<int> BookID = null;

            BorrwedUserBooks.Where(b => b.Value == cmbBooks.Text);

            foreach (var item in BorrwedUserBooks)
            {
                if (item.Value == cmbBooks.Text)
                {
                    BookID = item.Key;
                    break;
                }
            }

            return BookID;
        }

        private void frmChooseBookForReturn_Shown(object sender, EventArgs e)
        {
            _FillBooksInComboBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedIndex >= 0)
            {
                int BookID = _GetBookID()?? 0;

                if (OnChooseBook != null && BookID > 0)
                {
                    OnChooseBook?.Invoke(this, BookID);
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
