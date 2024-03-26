using LibraryBusiness;
using System;
using System.Windows.Forms;

namespace Library_Management.Reservations
{
    public partial class frmCompleteReservation : Form
    {
        private frmReservations _frmReservations;

        private int _NewReservationID { get; set; }
        private int _Book_ID { get;}
        private int _Copy_ID
        {
            get
            {
                return clsReservations.GetCopyIDForReservation(_Book_ID);
            }
        }

        public frmCompleteReservation(frmReservations frmReservations, int book_ID)
        {
            InitializeComponent();

            _frmReservations = frmReservations;
            _Book_ID = book_ID;
        }

        private void _FillReservationInfo()
        {
            txtCopyID.Text = _Copy_ID.ToString();
            dtpBorrowing_Date.Value = DateTime.Now;
            txtUserID.Focus();
        }

        private Nullable<int> _AddReservation()
        {
            clsReservations Reservation = new clsReservations();

            Reservation.User_ID = Convert.ToInt32(txtUserID.Text);
            Reservation.Copy_ID = _Copy_ID;
            Reservation.ReservationDate = DateTime.Now;

            if (Reservation.Save())
            {
                _NewReservationID = Reservation.Reservation_ID?? 0;
                return _NewReservationID;
            }
            else
                return null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmReservations.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBack.PerformClick();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                btnSave.Enabled = false;
                return;
            }
            else
                btnSave.Enabled = true;

        }

        private void frmCompleteReservation_Shown(object sender, EventArgs e)
        {
            _FillReservationInfo();
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits if person id is selected
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserID.Text, out int User_ID))
            {
                if (clsUsers.IsExist(User_ID))
                {
                    if (clsReservations.IsUserHasNewReservation(User_ID))
                    {
                        MessageBox.Show("You already have Reservation.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        btnBack.PerformClick();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"User with ID {User_ID} is not exists.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            if (_AddReservation() != null)
                MessageBox.Show($"Reservation has been completed.\n\nReservation ID is : {_NewReservationID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Reservation is Failed.\n\nTry again later.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            btnBack.PerformClick();
        }


    }
}