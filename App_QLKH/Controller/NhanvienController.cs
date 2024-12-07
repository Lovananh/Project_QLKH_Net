using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLKH.Model;

namespace App_QLKH.Controller
{
    internal class NhanvienController
    {
        private NhanVien model = new NhanVien();

        public DataSet GetAllNhanVien()
        {
            return model.GetAllNhanVien();
        }

        public bool AddNhanVien(string manv, string tennv, string chucvu, string sodienthoai, string email, string diachi, string gioitinh)
        {
            return model.AddNhanVien(manv, tennv, chucvu, sodienthoai, email, diachi, gioitinh);
        }

        public bool UpdateNhanVien(string manv, string tennv, string chucvu, string sodienthoai, string email, string diachi, string gioitinh)
        {
            return model.UpdateNhanVien(manv, tennv, chucvu, sodienthoai, email, diachi, gioitinh);
        }

        public bool DeleteNhanVien(string manv)
        {
            return model.DeleteNhanVien(manv);
        }

        public DataSet SearchNhanVien(string keyword)
        {
            return model.SearchNhanVien(keyword);
        }
    }
}
