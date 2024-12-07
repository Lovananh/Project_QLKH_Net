using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLKH.Controller;
using App_QLKH.Model;

namespace App_QLKH.View
{
    public partial class fmNhacungcap : Form
    {
        private NhacungcapController controllern = new NhacungcapController();
        public fmNhacungcap()
        {
            InitializeComponent();
            //dataGridViewNhacungcap.CellClick += dataGridViewNhacungcap_CellContentClick;
            getData();
        }
        public void getData()
        {
            dataGridViewNhacungcap.DataSource = controllern.GetAllNhaCungCap().Tables[0];
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewNhacungcap.DataSource = controllern.SearchNhacungcap(txtTimkiem.Text).Tables[0];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (controllern.AddNhacungcap(
                    txtMancc.Text, txtTenncc.Text,
                    txtDiachi.Text, txtEmail.Text ,txtSodienthoai.Text))
            {
                MessageBox.Show("Thêm thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        if (controllern.UpdateNhacungcap(
                txtMancc.Text, txtTenncc.Text,
                txtDiachi.Text, txtEmail.Text, txtSodienthoai.Text))
            {
            MessageBox.Show("Sửa thành công!");
            getData();
        }
        else
        {
            MessageBox.Show("Sửa thất bại!");
        }
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (controllern.DeleteNhacungcap(txtMancc.Text))
            {
                MessageBox.Show("Xóa thành công!");
                getData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMancc.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtTimkiem.Text = "";
            txtSodienthoai.Text = "";
            txtEmail.Text = "";
            txtDiachi.Text = "";
            getData(); 
        }

        private void dataGridViewNhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMancc.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMancc.Text = dataGridViewNhacungcap.Rows[r].Cells["Mancc"].Value.ToString();
                txtTenncc.Text = dataGridViewNhacungcap.Rows[r].Cells["Tenncc"].Value.ToString();
                txtDiachi.Text = dataGridViewNhacungcap.Rows[r].Cells["Diachi"].Value.ToString();
                txtEmail.Text = dataGridViewNhacungcap.Rows[r].Cells["Email"].Value.ToString();
                txtSodienthoai.Text = dataGridViewNhacungcap.Rows[r].Cells["Sodienthoai"].Value.ToString();                     
            }
        }

        private void fmNhacungcap_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
