using Library_Management.Users;
using LibraryBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management.Profile
{
    public partial class frmUsers : Form
    {
        public frmMainMenue frmMainMenue;

        private static DataTable _dtListUsers = new DataTable();
        private DataView _dvListUsers = new DataView(_dtListUsers);

        public frmUsers(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            this.frmMainMenue = frmMainMenue;
        }

        public void Referesh()
        {
            _FillListUsers();
            cbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            txtSearch.Clear();
            btnSearch.Enabled = false;
        }

        private void _FillListUsers()
        {
            _dtListUsers = clsUsers.GetAllUsers();
            _dvListUsers = _dtListUsers.DefaultView;

            dgvListUser.DataSource = _dvListUsers;

            if (_dtListUsers.Rows.Count > 0)
            {
                lblNothing.Visible = false;

                dgvListUser.Columns[0].HeaderText = "User ID";
                dgvListUser.Columns[0].Width = 40;

                dgvListUser.Columns[1].HeaderText = "Name";
                dgvListUser.Columns[1].Width = 130;

                dgvListUser.Columns[2].HeaderText = "Email";
                dgvListUser.Columns[2].Width = 90;

                dgvListUser.Columns[3].HeaderText = "Phone";
                dgvListUser.Columns[3].Width = 50;

                dgvListUser.Columns[4].HeaderText = "Username";
                dgvListUser.Columns[4].Width = 50;

                dgvListUser.Columns[5].HeaderText = "Library Card Number";
                dgvListUser.Columns[5].Width = 170;
            }
            else
                lblNothing.Visible = true;

        }

        private void _FilterByNone()
        {
            _dvListUsers.RowFilter = "1 = 1";
            dgvListUser.DataSource = _dvListUsers;
            
            // Message no users.
            if (dgvListUser.Rows.Count == 0)
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

            if (cbFilterBy.Text == "Library Card Number" && txtSearch.Text != "")
            {
                _dvListUsers.RowFilter = string.Format("[LibraryCardNumber] = {0}", txtSearch.Text);
                dgvListUser.DataSource = _dvListUsers;

                // Message no users.
                if (dgvListUser.Rows.Count == 0)
                    lblNothing.Visible = true;
                else
                    lblNothing.Visible = false;

                return;
            }

            if (cbFilterBy.Text == "User ID" && txtSearch.Text != "")
            {
                _dvListUsers.RowFilter = string.Format("[User_ID] = {0}", txtSearch.Text);
                dgvListUser.DataSource = _dvListUsers;
            }
            else
                _dvListUsers.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilterBy.Text, txtSearch.Text);

            // Message no users.
            if (dgvListUser.Rows.Count == 0)
                lblNothing.Visible = true;
            else
                lblNothing.Visible = false;

        }

        private void _OpenEditPage(object sender, int UserID)
        {
            if (UserID > 0)
            {
                frmAddEditUser frm = new frmAddEditUser(this, UserID);

                frmMainMenue.OpenChildSubForm(frm);
            }
        }

        private void frmUsers_Shown(object sender, EventArgs e)
        {
            _FillListUsers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            /*frmAddEditUser frm = new frmAddEditUser(this);

            frmMainMenue.OpenChildSubForm(frm);*/

            frmEmailVerification frm = new frmEmailVerification(this);

            frmMainMenue.OpenChildSubForm(frm);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmSelectUser frm = new frmSelectUser();

            frm.OnChooseBook += _OpenEditPage;

            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNew.PerformClick();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUser.CurrentRow.Cells[0].Value;

            _OpenEditPage(null, UserID);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID" || cbFilterBy.Text == "Library Card Number")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Referesh();
        }
    }
}
