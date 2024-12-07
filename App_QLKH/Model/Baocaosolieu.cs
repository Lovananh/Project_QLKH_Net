using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLKH.Model
{
    internal class Baocaosolieu
    {
        private string Mahh;
        private string Tenhh;
        private string Dvt;
        private decimal Dongia;
        private int Soluong;
        private decimal Thanhtien => Dongia * Soluong;
    }
}
