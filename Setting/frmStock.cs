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
    public partial class frmStock : Form
    {
        private frmSetting _frmSetting;

        public frmStock(frmSetting frmSetting)
        {
            InitializeComponent();

            _frmSetting = frmSetting;
        }
    }
}
