using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Setting
{
    public partial class frmSetting : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmSetting(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }
    }
}
