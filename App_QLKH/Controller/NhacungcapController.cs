using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLKH.Model;

namespace App_QLKH.Controller
{
    internal class NhacungcapController
    {
        private NhaCungCap model = new NhaCungCap();

        public DataSet GetAllNhaCungCap()
        {
            return model.GetAllNhaCungCap();
        }

        public bool AddNhacungcap(string mancc, string tenncc, string diachi, string email, string sodienthoai)
        {
            if (string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tenncc))
            {
                Console.WriteLine("Mã nhà cung cấp và tên nhà cung cấp không được để trống.");
                return false;
            }

            if (!email.Contains("@"))
            {
                Console.WriteLine("Email không hợp lệ.");
                return false;
            }

            try
            {
                return model.AddNhacungcap(mancc, tenncc, diachi, email, sodienthoai);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool UpdateNhacungcap(string mancc, string tenncc, string diachi, string email, string sodienthoai)
        {
            return model.UpdateNhacungcap(mancc, tenncc, diachi, email , sodienthoai);
        }

        public bool DeleteNhacungcap(string mancc)
        {
            return model.DeleteNhacungcap(mancc);
        }

        public DataSet SearchNhacungcap(string keyword)
        {
            return model.SearchNhacungcap(keyword);
        }
    }
}
