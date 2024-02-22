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

        public int CountControls
        {
            get
            {
                return ctrlShowBooksCataloge1.CountControls; // Number of controls Book in screen.
            }
        }

        public void Reset()
        {
            ctrlShowBooksCataloge1.Reset();
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
                        ctrlShowBooksCataloge1.Reset();
                    }
                    break;
                case "Book ID":
                    {
                        if (int.TryParse(txtSearch.Text, out int ID))
                        {
                            ctrlShowBooksCataloge1.dvBookControls.RowFilter = $"Book_ID = {ID}";
                            ctrlShowBooksCataloge1.LoadBookControls();
                        }
                        else
                            MessageBox.Show($"Book With ID {ID} is Not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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
            ctrlShowBooksCataloge1.Reset();
            cmbFilter.SelectedIndex = 0;
        }


        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ChangeTextSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //_Search();
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
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

    }
}
