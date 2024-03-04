using System.Windows.Forms;

namespace Library_Management.Reservations
{
    public partial class frmReservations : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmReservations(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }
    }
}
