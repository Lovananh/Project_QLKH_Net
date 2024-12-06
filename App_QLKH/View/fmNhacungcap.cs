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
    public partial class fmNhacungcap : Form
    {
        public fmNhacungcap()
        {
            InitializeComponent();
            dataGridViewNhacungcap.CellClick += dataGridViewNhacungcap_CellContentClick;
        }
        Ketnoi kn = new Ketnoi();

        public void getData()
        {
            string query = "SELECT*FROM NhaCungCap";
            DataSet ds = kn.Laydulieu(query);
            dataGridViewNhacungcap.DataSource = ds.Tables[0];
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
            "select NhaCungCap.* from NhaCungCap where NhaCungCap.Tenncc like N'%{0}%'",
            txtTimkiem.Text
        );

            DataSet ds = kn.Laydulieu(query);
            dataGridViewNhacungcap.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string query = string.Format(
                 "INSERT INTO NhaCungCap (Mancc, Tenncc, Diachi, Email, Sodienthoai) " +
                 "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')",
                txtMancc.Text,
                txtTenncc.Text,
                txtDiachi.Text,
                txtEmail.Text,
                txtSodienthoai.Text
             );
            if (string.IsNullOrEmpty(txtMancc.Text) || string.IsNullOrEmpty(txtTenncc.Text))
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
                "UPDATE NhaCungCap SET Tenncc = N'{1}', Diachi = N'{2}', Email = N'{3}', Sodienthoai = N'{4}', where Mancc = N'{0}'",
                txtMancc.Text,
                txtTenncc.Text,
                txtDiachi.Text,
                txtEmail.Text,
                txtSodienthoai.Text
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
            string query = string.Format(
                "DELETE FROM NhaCungCap WHERE Mancc = '{0}'",
                txtMancc.Text
            );
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
                txtSodienthoai.Text = dataGridViewNhacungcap.Rows[r].Cells["Sodienthoai"].Value.ToString();
                txtEmail.Text = dataGridViewNhacungcap.Rows[r].Cells["Email"].Value.ToString();
                txtDiachi.Text = dataGridViewNhacungcap.Rows[r].Cells["Diachi"].Value.ToString();
            }
        }

        private void fmNhacungcap_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
