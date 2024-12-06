using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLKH.View;

namespace App_QLKH
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            //if (currentFormChild != null && currentFormChild.GetType() == childForm.GetType())
            //{
            //    // Nếu form đang mở là cùng loại với form mới, thoát khỏi phương thức
            //    return;
            //}

            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; ;
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
            OpenChildForm(new Trangchu());

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
    }
}
