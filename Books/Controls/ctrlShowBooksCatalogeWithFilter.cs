using LibraryBusiness;
using System;
using System.Windows.Forms;

namespace Library_Management.Books.Controls
{
    public partial class ctrlShowBooksCatalogeWithFilter : UserControl
    {
        public ctrlShowBooksCatalogeWithFilter()
        {
            InitializeComponent();
        }

        public class BtnBookClick
        {
            public int BookID { get; set; }
            public clsBooks BookInfo
            {
                get
                {
                    return clsBooks.FindByBook_ID(BookID);
                }
            }

            public BtnBookClick(int bookID)
            {
                this.BookID = bookID;
            }
        }

        public event EventHandler<BtnBookClick> OnBtnBookClick;

        private void RaiseOnBtnBookClick(int BookID)
        {
            RaiseOnBtnBookClick(new BtnBookClick(BookID));
        }

        protected void RaiseOnBtnBookClick(BtnBookClick e)
        {
            OnBtnBookClick?.Invoke(this, e);
        }

        public int CountControls
        {
            get
            {
                return ctrlShowBooksCataloge1.CountControls; // Number of controls Book in screen.
            }
        }

        public void Reset()
        {
            ctrlShowBooksCataloge1.Referesh();
            cmbFilter.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void _ChangeTextSearch()
        {
            switch (cmbFilter.Text)
            {
                case "All":
                    {
                        txtSearch.Visible = false;
                        txtSearch.Clear();
                        btnSearch.Enabled = false;
                        _Search();
                    }
                    break;
                case "Book ID":
                    {
                        txtSearch.Visible = true;
                        txtSearch.Clear();
                        btnSearch.Enabled = true;
                        txtSearch.PlaceholderText = "Enter Book ID";
                    }
                    break;
                case "Book Name":
                    {
                        txtSearch.Visible = true;
                        txtSearch.Clear();
                        btnSearch.Enabled = true;
                        txtSearch.PlaceholderText = "Enter Book Name";
                    }
                    break;
            }
        }

        private void _Search()
        {
            switch (cmbFilter.Text)
            {
                case "All":
                    {
                        ctrlShowBooksCataloge1.Referesh();
                    }
                    break;
                case "Book ID":
                    {
                        if (int.TryParse(txtSearch.Text, out int ID))
                        {
                            ctrlShowBooksCataloge1.dvBookControls.RowFilter = $"Book_ID = {ID}";
                            ctrlShowBooksCataloge1.LoadBookControls();
                        }

                    }
                    break;
                case "Book Name":
                    {
                        string FilterExpression = $"[Title] = '{txtSearch.Text}'";
                        ctrlShowBooksCataloge1.dvBookControls.RowFilter = FilterExpression;
                        if (ctrlShowBooksCataloge1.dvBookControls.Count > 0)
                        {
                            ctrlShowBooksCataloge1.LoadBookControls(); // if has record will show it.
                        }
                        else
                            MessageBox.Show($"Book With Name {txtSearch.Text} is Not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
            }
        }

        public void LoadBookControls()
        {
            ctrlShowBooksCataloge1.Referesh();
            cmbFilter.SelectedIndex = 0;
        }


        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ChangeTextSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                ctrlShowBooksCataloge1.Referesh();
                return;
            }
            _Search();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void ctrlShowBooksCataloge1_OnBtnBookClick(object sender, ctrlShowBooksCataloge.BtnBookClick e)
        {
            RaiseOnBtnBookClick(e.BookID);
        }

        public void ClearControls()
        {
            ctrlShowBooksCataloge1.ClearControls();
        }

    }
}
