using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_QLKH.Model;

namespace App_QLKH.Controller
{
    internal class HanghoaController
    {
        private Hanghoa model;

        public HanghoaController()
        {
            model = new Hanghoa();
        }

        public (int TongNhap, int TongXuat) LaySoLuongNhapXuat()
        {
            return model.GetSoLuongNhapXuat();
        }
    }
}
