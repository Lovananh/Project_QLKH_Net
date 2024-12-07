using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLKH.Model;

namespace App_QLKH.Controller
{
    internal class BaocaosolieuController
    {
        private Baocaosolieu reportModel;

        public BaocaosolieuController()
        {
            reportModel = new Baocaosolieu();
        }

        public DataSet GetReportData(DateTime startDate, DateTime endDate)
        {
            //return reportModel.GetReportData(startDate, endDate);
            if (startDate > endDate)
            {
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
            }
            try
            {
                // Lấy dữ liệu từ lớp Model
                var data = reportModel.GetReportData(startDate, endDate);

                // Kiểm tra null trước khi truy cập Rows
                if (data == null)
                {
                    Console.WriteLine("Dữ liệu trả về là null.");
                    return null;
                }

                //// Kiểm tra nếu bảng không có dữ liệu
                //if (data.Rows.Count == 0)
                //{
                //    Console.WriteLine("Không có dữ liệu trong khoảng thời gian được chọn.");
                //    return null; // Trả về null để lớp View xử lý
                //}

                return data;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và ném ngoại lệ lên lớp gọi
                Console.WriteLine($"Lỗi khi lấy dữ liệu báo cáo: {ex.Message}");
                throw; // Ném ngoại lệ để View hoặc tầng khác xử lý
            }
        }
    }
}
