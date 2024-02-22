using System;
using System.Windows.Forms;

namespace Library_Management.Home
{
    public partial class frmHome : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmHome(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            ctrlShowBooksCatalogeWithFilter1.LoadBookControls();
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            frmHome_Shown(null, null);
        }
    }
}
