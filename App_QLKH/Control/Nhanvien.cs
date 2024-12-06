using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace App_QLKH.Control
{
    internal class Nhanvien
    {
        private string Manv { get; set; }
        private string Tennv { get; set; }
        private string Chucvu { get; set; }
        private string Sodienthoai { get; set; }
        private string Email { get; set; }
        private string Diachi { get; set; }
        private string Gioitinh {  get; set; }
        public Nhanvien(string Manv, string Tennv, string Chucvu, string Sodienthoai, string Email, string Diachi, string Gioitinh)
        {
            this.Manv = Manv;
            this.Tennv = Tennv;
            this.Chucvu = Chucvu;
            this.Sodienthoai = Sodienthoai;
            this.Email = Email;
            this.Diachi = Diachi;
            this.Gioitinh = Gioitinh;
        }
    }
}
