using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLKH.Model
{
    internal class NhaCungCap
    {
        private Ketnoi kn = new Ketnoi();

        public DataSet GetAllNhaCungCap()
        {
            string query = "SELECT * FROM NhaCungCap";
            return kn.Laydulieu(query);
        }

        public bool AddNhacungcap(string mancc, string tenncc, string diachi, string email, string sodienthoai)
        {
            try
            {
                string query = string.Format(
                    "INSERT INTO NhaCungCap (Mancc, Tenncc, Diachi, Email, Sodienthoai) " +
                    "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')",
                    mancc, tenncc, diachi, email, sodienthoai);
                Console.WriteLine($"Query: {query}");
                return kn.ThucThi(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddNhacungcap: {ex.Message}");
                return false;
            }
        }

        public bool UpdateNhacungcap(string mancc, string tenncc, string diachi, string email, string sodienthoai)
        {
            string query = string.Format(
                "UPDATE NhaCungCap SET Tenncc = N'{1}', Diachi = N'{2}', Email = N'{3}', Sodienthoai = N'{4}' WHERE Mancc = N'{0}'",
                mancc, tenncc, diachi, email, sodienthoai);
            return kn.ThucThi(query);
        }

        public bool DeleteNhacungcap(string mancc)
        {
            string query = string.Format("DELETE FROM NhaCungCap WHERE Mancc = N'{0}'", mancc);
            return kn.ThucThi(query);
        }

        public DataSet SearchNhacungcap(string keyword)
        {
            string query = string.Format("SELECT * FROM NhaCungCap WHERE Tenncc LIKE N'%{0}%'", keyword);
            return kn.Laydulieu(query);
        }
    }
}
