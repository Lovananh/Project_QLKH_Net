using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QLKH.Controller;
using Microsoft.Reporting.WinForms;

namespace App_QLKH.View
{
    public partial class fmBaocaosolieu : Form
    {
        private BaocaosolieuController reportController;
        public fmBaocaosolieu()
        {
            InitializeComponent();
            reportController = new  BaocaosolieuController();
        }

        private void fmBaocaosolieu_Load(object sender, EventArgs e)
        {

            reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
            LoadReport(DateTime.MinValue, DateTime.MinValue);
        }

        private void BtnBaocao_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerTungay.Value.Date;
            DateTime endDate = dateTimePickerDenngay.Value.Date;

            if (startDate <= endDate)
            {
                LoadReport(startDate, endDate);
                reportViewer1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.");
            }
        }

        private void LoadReport(DateTime startDate, DateTime endDate)
        {
            // Gọi phương thức từ controller để lấy dữ liệu
            var reportData = reportController.GetReportData(startDate, endDate);

            if (reportData == null)
            {
                MessageBox.Show("Không thể lấy dữ liệu báo cáo.");
                return;
            }

            // Gắn dữ liệu vào ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", reportData);
            reportViewer1.LocalReport.ReportPath = "ReportBaocaohanghoa.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
