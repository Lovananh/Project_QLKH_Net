using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLKH.View
{
    public partial class fmBaocaosolieu : Form
    {
        public fmBaocaosolieu()
        {
            InitializeComponent();
        }

        private void fmBaocaosolieu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
