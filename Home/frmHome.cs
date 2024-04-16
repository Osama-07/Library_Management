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

        private void ctrlShowBooksCatalogeWithFilter1_OnBtnBookClick(object sender, Books.Controls.ctrlShowBooksCatalogeWithFilter.BtnBookClick e)
        {
            MessageBox.Show("Here Home Form.", "Home", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmHome_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                ctrlShowBooksCatalogeWithFilter1.ClearControls();
            else
                ctrlShowBooksCatalogeWithFilter1.LoadBookControls();
        }
    }
}
