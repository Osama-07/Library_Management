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
