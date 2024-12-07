using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLKH.Model
{
    internal class Baocaosolieu
    {

         private Ketnoi kn = new Ketnoi();

        public DataSet GetReportData(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = kn.GetConnection())
            {
                //conn.Open();

                string query = @"
                    SELECT h.Mahang, h.Tenhang, h.Soluong, h.Gia, h.Donvitinh,
                           hn.Ngaynhap, hx.Ngayxuat, pn.Soluongtn, px.Soluongxuat
                    FROM HangHoa h
                    LEFT JOIN PhieuNhap pn ON h.Mahang = pn.Mahang
                    LEFT JOIN HangNhap hn ON pn.Sophieunhap = hn.Sophieunhap
                    LEFT JOIN PhieuXuat px ON h.Mahang = px.Mahang
                    LEFT JOIN HangXuat hx ON px.Sophieuxuat = hx.Sophieuxuat
                    WHERE (hn.Ngaynhap BETWEEN @StartDate AND @EndDate) OR 
                          (hx.Ngayxuat BETWEEN @StartDate AND @EndDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                try
                {
                    da.Fill(ds, "HangHoaReport");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    return null;
                }

                return ds;
            }
        }
    }
}
