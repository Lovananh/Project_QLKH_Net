using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLKH.Model;

namespace App_QLKH.Model
{
    internal class NhanVien
    {
        //private string Manv { get; set; }
        //private string Tennv { get; set; }
        //private string Chucvu { get; set; }
        //private string Sodienthoai { get; set; }
        //private string Email { get; set; }
        //private string Diachi { get; set; }
        //private string Gioitinh { get; set; }

        private Ketnoi kn = new Ketnoi();

        public DataSet GetAllNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            return kn.Laydulieu(query);
        }

        public bool AddNhanVien(string manv, string tennv, string chucvu, string sodienthoai, string email, string diachi, string gioitinh)
        {
            string query = string.Format(
                "INSERT INTO NhanVien (Manv, Tennv, Chucvu, Sodienthoai, Email, Diachi, Gioitinh) " +
                "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')",
                manv, tennv, chucvu, sodienthoai, email, diachi, gioitinh);
            return kn.ThucThi(query);
        }

        public bool UpdateNhanVien(string manv, string tennv, string chucvu, string sodienthoai, string email, string diachi, string gioitinh)
        {
            string query = string.Format(
                "UPDATE NhanVien SET Tennv = N'{1}', Chucvu = N'{2}', Sodienthoai = N'{3}', Email = N'{4}', Diachi = N'{5}', Gioitinh = N'{6}' WHERE Manv = N'{0}'",
                manv, tennv, chucvu, sodienthoai, email, diachi, gioitinh);
            return kn.ThucThi(query);
        }

        public bool DeleteNhanVien(string manv)
        {
            string query = string.Format("DELETE FROM NhanVien WHERE Manv = N'{0}'", manv);
            return kn.ThucThi(query);
        }

        public DataSet SearchNhanVien(string keyword)
        {
            string query = string.Format("SELECT * FROM NhanVien WHERE Tennv LIKE N'%{0}%'", keyword);
            return kn.Laydulieu(query);
        }
    }
}
