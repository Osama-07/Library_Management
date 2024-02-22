using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Borrowing_Records
{
    public partial class frmBorrowingRecords : Form
    {
        private frmMainMenue _frmMainMenue;

        public frmBorrowingRecords(frmMainMenue frmMainMenue)
        {
            InitializeComponent();

            _frmMainMenue = frmMainMenue;
        }

    }
}
