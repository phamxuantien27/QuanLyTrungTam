using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang_Entity
{
    public class EC_QuanLyTrungTam
    {
        private string _ID;
        private string _HoTen;
        private string _LienHe;

        public string ID { get => _ID; set => _ID = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string LienHe { get => _LienHe; set => _LienHe = value; }
    }
}
