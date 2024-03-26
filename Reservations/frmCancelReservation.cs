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

namespace Library_Management.Reservations
{
    public partial class frmCancelReservation : Form
    {
        public frmCancelReservation()
        {
            InitializeComponent();
        }

        private bool CancelReservation(int ReservationID)
        {
            clsReservations Reservation = clsReservations.FindByReservation_ID(ReservationID);

            if (Reservation != null)
            {
                if (Reservation.SetCanceledReservation())
                {
                    MessageBox.Show($"Cancel Reservation with ID {txtReservationID.Text} has been Completed.", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    MessageBox.Show($"Cancel Reservation with ID {txtReservationID.Text} is failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
                MessageBox.Show($"Reservation with ID {txtReservationID.Text} is not found.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            return false;
        }

        private void txtReservationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits if person id is selected
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSave.PerformClick();
        }

        private void txtReservationID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReservationID.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtReservationID.Text, out int ID))
            {
                if (clsReservations.IsExist(ID))
                {
                    if (clsReservations.IsReservationNew(ID))
                    {
                        if (MessageBox.Show($"Are you sure do you want to Cancel this Reservation ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                        {
                            CancelReservation(ID);
                            this.Close();
                            return;
                        }
                    }
                    else
                        MessageBox.Show($"Reservation with ID {txtReservationID.Text} is Completed.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                    MessageBox.Show($"Reservation with ID {txtReservationID.Text} is not found.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            txtReservationID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCancelReservation_Shown(object sender, EventArgs e)
        {
            txtReservationID.Focus();
        }
    }
}
