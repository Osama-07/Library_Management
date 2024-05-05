using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Setting
{
    public partial class frmStock : Form
    {
        private frmSetting _frmSetting;

        private static DataTable _dtBookCopiesInfo = new DataTable();
        private DataView _dvBookCopiesInfo = new DataView(_dtBookCopiesInfo);

        public frmStock(frmSetting frmSetting)
        {
            InitializeComponent();

            _frmSetting = frmSetting;
        }

        public void Referesh()
        {
            _FillBookCopiesInfo();
            btnSearch.Enabled = false;
            txtSearch.Clear();
            txtSearch.Visible = false;
            cbFilterBy.SelectedIndex = 0;
        }

        private void _FillBookCopiesInfo()
        {
            _dtBookCopiesInfo = clsBookCopies.GetBookCopiesInfo();
            _dvBookCopiesInfo = _dtBookCopiesInfo.DefaultView;

            dgvStock.DataSource = _dvBookCopiesInfo;

            if (dgvStock.Rows.Count > 0)
            {
                lblNothing.Visible = false;

                dgvStock.Columns[0].HeaderText = "Book ID";
                dgvStock.Columns[0].Width = 110; // تعيين عرض العمود الأول

                dgvStock.Columns[1].HeaderText = "Title";
                dgvStock.Columns[1].Width = 300; // تكبير العمود الثاني

                dgvStock.Columns[2].HeaderText = "Available Copies";
                dgvStock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvStock.Columns[3].HeaderText = "Borrowed Copies";
                dgvStock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvStock.Columns[4].HeaderText = "Total Copies";
                dgvStock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            else
                lblNothing.Visible = true;


        }

        private void _FilterByNone()
        {
            _dvBookCopiesInfo.RowFilter = "1 = 1";
            dgvStock.DataSource = _dvBookCopiesInfo;

            // Message no users.
            if (dgvStock.Rows.Count == 0)
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

            switch (cbFilterBy.Text)
            {
                case "Book ID":
                    {
                        _dvBookCopiesInfo.RowFilter = string.Format("[Book_ID] = {0}", txtSearch.Text);
                        dgvStock.DataSource = _dvBookCopiesInfo;
                    }
                    break;
                default:
                    break;
            }

            // Message no users.
            if (dgvStock.Rows.Count == 0)
                lblNothing.Visible = true;
            else
                lblNothing.Visible = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                txtSearch.Visible = false;
                txtSearch.Clear();

            }
            else
            {
                txtSearch.Visible = true;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
                btnSearch.Enabled = true;
            else
                btnSearch.Enabled = false;

            if (_dtBookCopiesInfo.Rows.Count > 0)
                _Search();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Referesh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        private void frmStock_Shown(object sender, EventArgs e)
        {
            _FillBookCopiesInfo();
        }
    }
}
