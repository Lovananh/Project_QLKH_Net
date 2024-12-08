using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLKH.Model
{
    internal class Hanghoa
    {

        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public int Soluong { get; set; }
        public decimal Gia { get; set; }
        public string Donvitinh { get; set; }

        private Ketnoi kn = new Ketnoi();

        public DataTable GetAllHanghoa()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = kn.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                h.Mahang, h.Tenhang, h.Soluong, h.Gia, h.Donvitinh,
                hn.Ngaynhap, hx.Ngayxuat, pn.Soluongtn, px.Soluongxuat
            FROM HangHoa h
            LEFT JOIN PhieuNhap pn ON h.Mahang = pn.Mahang
            LEFT JOIN HangNhap hn ON pn.Sophieunhap = hn.Sophieunhap
            LEFT JOIN PhieuXuat px ON h.Mahang = px.Mahang
            LEFT JOIN HangXuat hx ON px.Sophieuxuat = hx.Sophieuxuat";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable SearchHanghoa(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT 
                h.Mahang, h.Tenhang, h.Soluong, h.Gia, h.Donvitinh,
                hn.Ngaynhap, hx.Ngayxuat, pn.Soluongtn, px.Soluongxuat
            FROM HangHoa h
            LEFT JOIN PhieuNhap pn ON h.Mahang = pn.Mahang
            LEFT JOIN HangNhap hn ON pn.Sophieunhap = hn.Sophieunhap
            LEFT JOIN PhieuXuat px ON h.Mahang = px.Mahang
            LEFT JOIN HangXuat hx ON px.Sophieuxuat = hx.Sophieuxuat
            WHERE h.Tenhang LIKE @Keyword";

            using (SqlConnection conn = kn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public (int TongNhap, int TongXuat) GetSoLuongNhapXuat()
        {
            int tongNhap = 0;
            int tongXuat = 0;

            using (SqlConnection conn = kn.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT 
                    ISNULL(SUM(Soluongtn), 0) AS TongNhap,
                    ISNULL(SUM(Soluongxuat), 0) AS TongXuat
                FROM HangHoa h
                LEFT JOIN PhieuNhap pn ON h.Mahang = pn.Mahang
                LEFT JOIN PhieuXuat px ON h.Mahang = px.Mahang";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tongNhap = Convert.ToInt32(reader["TongNhap"]);
                    tongXuat = Convert.ToInt32(reader["TongXuat"]);
                }
            }
            return (tongNhap, tongXuat);
        }
    }
}
