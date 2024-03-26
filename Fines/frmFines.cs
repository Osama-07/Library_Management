using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library_Management.Fines
{
    public partial class frmFines : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmFines(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }
    }
}
