using Library_Management.Global;
using LibraryBusiness;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Library_Management.Fines
{
    public partial class frmFines : Form
    {
        private frmMainMenue _frmMainMenue;

        private static DataTable _dtListFines = new DataTable();
        private DataView _dvListFines = new DataView(_dtListFines);

        public frmFines(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        public void Referesh()
        {
            _FillListFines();
            cbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            txtSearch.Clear();
            btnSearch.Enabled = false;
        }

        private void _FillListFines()
        {
            _dtListFines = clsFines.GetAllFines();
            _dvListFines = _dtListFines.DefaultView;

            dgvListFines.DataSource = _dvListFines;

            if (dgvListFines.Rows.Count > 0)
            {
                lblNothing.Visible = false;

                dgvListFines.Columns[0].HeaderText = "Fine_ID";
                dgvListFines.Columns[0].Width = 40;

                dgvListFines.Columns[1].HeaderText = "User_ID";
                dgvListFines.Columns[1].Width = 40;

                dgvListFines.Columns[2].HeaderText = "Name";
                dgvListFines.Columns[2].Width = 160;

                dgvListFines.Columns[3].HeaderText = "Email";
                dgvListFines.Columns[3].Width = 100;

                dgvListFines.Columns[4].HeaderText = "Amount";
                dgvListFines.Columns[4].Width = 50;

                dgvListFines.Columns[5].HeaderText = "Days Of Late";
                dgvListFines.Columns[5].Width = 100;

                dgvListFines.Columns[6].HeaderText = "Payment Status";
                dgvListFines.Columns[6].Width = 170;

            }
            else
                lblNothing.Visible = true;

        }

        private void _FilterByNone()
        {
            _dvListFines.RowFilter = "1 = 1";
            dgvListFines.DataSource = _dvListFines;

            // Message no users.
            if (dgvListFines.Rows.Count == 0)
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

            if (cbFilterBy.Text == "Amount" && txtSearch.Text != "")
            {
                _dvListFines.RowFilter = string.Format("[Amount] = {0}", txtSearch.Text);
                dgvListFines.DataSource = _dvListFines;

                // Message no Fines.
                if (dgvListFines.Rows.Count == 0)
                    lblNothing.Visible = true;
                else
                    lblNothing.Visible = false;

                return;
            }

            if (cbFilterBy.Text == "Days Of Late" && txtSearch.Text != "")
            {
                _dvListFines.RowFilter = string.Format("[DaysOfLate] = {0}", txtSearch.Text);
                dgvListFines.DataSource = _dvListFines;

                // Message no Fines.
                if (dgvListFines.Rows.Count == 0)
                    lblNothing.Visible = true;
                else
                    lblNothing.Visible = false;

                return;
            }

            if (cbFilterBy.Text == "User ID" && txtSearch.Text != "")
            {
                _dvListFines.RowFilter = string.Format("[User_ID] = {0}", txtSearch.Text);
                dgvListFines.DataSource = _dvListFines;
            }
            else
                _dvListFines.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilterBy.Text.Replace(" ", ""), txtSearch.Text);

            // Message no users.
            if (dgvListFines.Rows.Count == 0)
                lblNothing.Visible = true;
            else
                lblNothing.Visible = false;

        }

        private void frmFines_Shown(object sender, EventArgs e)
        {
            _FillListFines();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Referesh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_dtListFines.Rows.Count > 0)
                _Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Fine ID" || cbFilterBy.Text == "Amount" || cbFilterBy.Text == "Days Of Late")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
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

        private async void SetPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvListFines.CurrentRow.Cells["Fine_ID"].Value.ToString(), out int FineID))
            {
                clsFines Fine = clsFines.FindByFine_ID(FineID);

                if (Fine != null)
                {
                    if (Fine.SetFinePaid())
                    {
                        await Task.Run(() => 
                        {
                            int UserID = (int)dgvListFines.CurrentRow.Cells["User_ID"].Value;

                            clsGlobal.SendPaymentConfirmationEmail(UserID, FineID);

                            MessageBox.Show("Fine Paid Successfully.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                    }
                    else
                        MessageBox.Show("Failed to pay the fine.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Choose the fine correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);

            Referesh();
        }

        private void sendEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // here send email.
        }

        private void cmsSettingsUsers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool PaymentStatus = dgvListFines.CurrentRow.Cells["PaymentStatus"].Value.ToString() == "Paid" ? true : false;

            if (PaymentStatus)
            {
                SetPaidToolStripMenuItem.Enabled = false;
                //sendEmailToolStripMenuItem.Visible = false;
            }
            else
                SetPaidToolStripMenuItem.Enabled = true;
        }

    }
}
