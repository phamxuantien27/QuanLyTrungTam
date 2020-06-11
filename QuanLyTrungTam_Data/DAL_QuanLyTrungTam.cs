using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang_Entity;

namespace QuanLyTrungTam_Data
{
    public class DAL_QuanLyTrungTam
    {
        KetNoi_DB con = new KetNoi_DB();
        //Hàm thêm dữ liệu
        public void ThemDuLieu(EC_QuanLyTrungTam ec)
        {
            con.ThucThiCauLenhSQL(@"INSERT INTO QuanLyTrungTam
                  (ID, Hoten, LienHe)
                    VALUES ('"+ec.ID+"', N'"+ec.HoTen+"', '"+ec.LienHe+"')");
        }
        //Hàm sửa
        public void SuaDuLieu(EC_QuanLyTrungTam ec)
        {
            con.ThucThiCauLenhSQL(@"UPDATE QuanLyTrungTam
                    SET HoTen = N'"+ec.HoTen+"', LienHe = '"+ec.LienHe+"' where ID = '"+ec.ID+"'");
        }
        //Hàm xóa
        public void XoaDuLieu(EC_QuanLyTrungTam ec)
        {
            con.ThucThiCauLenhSQL(@"DELETE FROM QuanLyTrungTam where ID = '"+ec.ID+"'");
        }
        //Hàm lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            DataTable result = new DataTable();
            result = con.GetData("SELECT * FROM QuanLyTrungTam " + DieuKien);
            return result;
        }
    }
}
