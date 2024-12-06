using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLKH.Connect;

namespace App_QLKH.View
{
    public partial class fmNhanvien : Form
    {
        public fmNhanvien()
        {
            InitializeComponent();
            dataGridViewNhanvien.CellClick += dataGridViewNhanvien_CellContentClick;
        }

        Ketnoi kn = new Ketnoi();
        public void getData()
        {
            string query = "select*from NhanVien";
            DataSet ds = kn.Laydulieu(query);
            dataGridViewNhanvien.DataSource = ds.Tables[0];

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
              "select NhanVien.* from NhanVien where NhanVien.Tennv like N'%{0}%'",
              txtTimkiem.Text
          );

            DataSet ds = kn.Laydulieu(query);
            dataGridViewNhanvien.DataSource = ds.Tables[0];
    }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                 "INSERT INTO Nhanvien (Manv, Tennv, Chucvu, Sodienthoai, Email, Diachi, Gioitinh) " +
                 "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')",
                txtManv.Text,
                txtTennv.Text,
                txtChucvu.Text,
                txtSodienthoai.Text,
                txtEmail.Text,
                txtDiachi.Text,
                txtGioitinh.Text
             );
            if (string.IsNullOrEmpty(txtManv.Text) || string.IsNullOrEmpty(txtTennv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công !");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("thêm thất bại !");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "UPDATE NhanVien SET Tennv = N'{1}', Chucvu = N'{2}', Sodienthoai = N'{3}', Email = N'{4}', Diachi = N'{5}', Gioitinh = N'{6}' where Manv = N'{0}'",
                txtManv.Text,
                txtTennv.Text,
                txtChucvu.Text,
                txtSodienthoai.Text,
                txtEmail.Text,
                txtDiachi.Text,
                txtGioitinh.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("DELETE FROM NhanVien WHERE Manv = N'{0}'", txtManv.Text);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnLammoi.PerformClick();
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
