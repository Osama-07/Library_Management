using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Profile
{
    public partial class frmProfile : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmProfile(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }
    }
}
