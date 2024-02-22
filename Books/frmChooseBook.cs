using LibraryBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management.Books
{
    public partial class frmChooseBook : Form
    {
        public frmChooseBook()
        {
            InitializeComponent();
        }

        public delegate void DataBackBookName(object sender, int BookID);

        public event DataBackBookName OnChooseBookName;

        static DataTable dtBooks = new DataTable();
        DataView dvBooks = new DataView(dtBooks);

        private void _FillComboBoxWithBooksName()
        {
            dtBooks = clsBooks.GetBooksIdAndName();
            dvBooks = dtBooks.DefaultView;

            cmbBooks.Items.Clear();
            foreach (DataRowView item in dvBooks)
            {
                cmbBooks.Items.Add(item["Title"]);
            }

            cmbBooks.SelectedIndex = 0;
        }

        private Nullable<int> _GetBookID()
        {
            foreach (DataRowView item in dvBooks)
            {
                if (item["Title"].ToString() == cmbBooks.Text)
                {
                    return (int)item["Book_ID"];
                }
            }

            return null;
        }

        private void frmChooseBook_Shown(object sender, EventArgs e)
        {
            _FillComboBoxWithBooksName();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedIndex > -1)// if user choose a book.
            {
                int BookID = _GetBookID()?? 0;

                if (OnChooseBookName != null && BookID > 0)
                {
                    OnChooseBookName?.Invoke(this, BookID);
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
