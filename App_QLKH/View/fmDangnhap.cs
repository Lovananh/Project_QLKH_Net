using App_QLKH.Model;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLKH.View
{
    public partial class fmDangnhap : Form
    {
        public fmDangnhap()
        {
            InitializeComponent();
        }

		private void btndangnhap_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTendangnhap.Text.Trim();
			string matKhau = txtMatkhau.Text.Trim();

			// Kiểm tra nếu tên đăng nhập hoặc mật khẩu rỗng
			if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra thông tin đăng nhập
			if (tenDangNhap == "vanh" && matKhau == "1234")
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Mở form trang chủ
				Trangchu formtc = new Trangchu();
				formtc.Show();
				this.Hide(); // Ẩn form đăng nhập
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
