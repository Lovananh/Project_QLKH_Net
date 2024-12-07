using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLKH.Model
{
    internal class Ketnoi
    {
        string conStr = "Data Source=LOVANANH-2812;Initial Catalog=Quanlykhohang;Integrated Security=True";
        SqlConnection conn;

        public Ketnoi()
        {
            conn = new SqlConnection(conStr); 
        }
        //phuong thuc tra ve doi tuong SqlConnection

        public SqlConnection GetConnection()
        {
            return conn;
        }

        // phuong thuc lay du lieu tu co so du lieu
        public DataSet Laydulieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
