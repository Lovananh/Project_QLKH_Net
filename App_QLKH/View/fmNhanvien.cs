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
    public partial class fmNhanvien : Form
    {
        private NhanvienController controller = new NhanvienController();
        public fmNhanvien()
        {
            InitializeComponent();
            //dataGridViewNhanvien.CellClick += dataGridViewNhanvien_CellContentClick;
            getData();
        }

        public void getData()
        {
            dataGridViewNhanvien.DataSource = controller.GetAllNhanVien().Tables[0];
            //btnLammoi.PerformClick();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewNhanvien.DataSource = controller.SearchNhanVien(txtTimkiem.Text).Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (controller.AddNhanVien(
                    txtManv.Text, txtTennv.Text, txtChucvu.Text,
                    txtSodienthoai.Text, txtEmail.Text, txtDiachi.Text, txtGioitinh.Text))
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
            if (controller.UpdateNhanVien(
                    txtManv.Text, txtTennv.Text, txtChucvu.Text,
                    txtSodienthoai.Text, txtEmail.Text, txtDiachi.Text, txtGioitinh.Text))
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
            if (controller.DeleteNhanVien(txtManv.Text))
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
            txtManv.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtManv.Text = "";
            txtTennv.Text = "";
            txtTimkiem.Text = "";
            txtChucvu.Text = "";
            txtSodienthoai.Text = "";
            txtEmail.Text = "";
            txtDiachi.Text = "";
            txtGioitinh.Text = "";
            getData();
        }

        private void dataGridViewNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtManv.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtManv.Text = dataGridViewNhanvien.Rows[r].Cells["Manv"].Value.ToString();
                txtTennv.Text = dataGridViewNhanvien.Rows[r].Cells["Tennv"].Value.ToString();
                txtChucvu.Text = dataGridViewNhanvien.Rows[r].Cells["Chucvu"].Value.ToString();
                txtSodienthoai.Text = dataGridViewNhanvien.Rows[r].Cells["Sodienthoai"].Value.ToString();
                txtEmail.Text = dataGridViewNhanvien.Rows[r].Cells["Email"].Value.ToString();
                txtDiachi.Text = dataGridViewNhanvien.Rows[r].Cells["Diachi"].Value.ToString();
                txtGioitinh.Text = dataGridViewNhanvien.Rows[r].Cells["Gioitinh"].Value.ToString();
            }
        }

        private void fmNhanvien_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
