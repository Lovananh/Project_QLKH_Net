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
    public partial class fmDangky : Form
    {
        public fmDangky()
        {
            InitializeComponent();
        }

		private void btnDangky_Click(object sender, EventArgs e)
		{

		}
		
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Hide();
			new fmDangnhap().ShowDialog();
			this.Close();
		}
	}
}
