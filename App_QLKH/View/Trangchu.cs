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
using App_QLKH.View;

namespace App_QLKH
{
    public partial class Trangchu : Form
    {
        private HanghoaController controller;
        public Trangchu()
        {
            InitializeComponent();
            controller = new HanghoaController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null && currentFormChild.GetType() == childForm.GetType())
            {
                // Nếu form đang mở là cùng loại với form mới, thoát khỏi phương thức
                return;
            }

            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {

        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {

        }

        private void btnHangnhap_Click(object sender, EventArgs e)
        {

        }

        private void btnHangxuat_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmNhanvien());
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmNhacungcap());
        }

        private void btnBaocaosolieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmBaocaosolieu());
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            if (currentFormChild == null || currentFormChild.GetType() != typeof(Trangchu))
            {
                OpenChildForm(new Trangchu());
            }

        }

        private void toolNhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmNhacungcap());
        }

        private void toolNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fmNhanvien());
        }

        private void toolKhohang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new fmKhohang());
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //loc
            Hanghoa hanghoaModel = new Hanghoa();
            var (tongNhap, tongXuat) = hanghoaModel.GetSoLuongNhapXuat();

            lblSohn.Text = $"Số lượng nhập: {tongNhap}";
            lblSohx.Text = $"Số lượng xuất: {tongXuat}";
            lblTonkho.Text = $"Số lượng tồn kho:{tongNhap - tongXuat}";


        }

        private void dataGridViewHanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Trangchu_Load(object sender, EventArgs e)
        {
            Hanghoa hanghoaModel = new Hanghoa();
            DataTable dtHanghoa = hanghoaModel.GetAllHanghoa();

            dataGridViewHanghoa.DataSource = dtHanghoa;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtLoc.Text.Trim(); // Lấy từ khóa từ TextBox
            Hanghoa hanghoaModel = new Hanghoa();
            DataTable dtTimkiem;

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không nhập từ khóa, hiển thị toàn bộ dữ liệu
                dtTimkiem = hanghoaModel.GetAllHanghoa();
            }
            else
            {
                // Tìm kiếm theo từ khóa
                dtTimkiem = hanghoaModel.SearchHanghoa(keyword);
            }

            // Hiển thị dữ liệu trong DataGridView
            if (dtTimkiem.Rows.Count > 0)
            {
                dataGridViewHanghoa.DataSource = dtTimkiem;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng hóa nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewHanghoa.DataSource = null; // Xóa dữ liệu cũ trong DataGridView
            }
        }
    }
}
