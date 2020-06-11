using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTam_BUS;
using QuanLyNhaHang_Entity;
using System.Data;

namespace QuanLyTrungTam
{
    public partial class LopHoc_DangHoc : UserControl
    {
        private string Ma_HocSinh;
        int select;
        public LopHoc_DangHoc(string _Ma, int _select)
        {
            Ma_HocSinh = _Ma;
            select = _select;
            InitializeComponent();
            Load();
        }
        function ft = new function();
        void Load()
        {
            DataTable tb = new DataTable();
            if (select == 1)
            {
                tb = ft.LopHoc_DangHoc(Ma_HocSinh);
            }
            else if(select == 2)
            {
                tb = ft.LopHoc_DaHoc(Ma_HocSinh);
            }
            else if(select == 3)
            {
                tb = ft.HocPhi_Thang(Ma_HocSinh);
            }
            else if(select == 7)
            {
            }
            else if(select == 4)
            {
                List<EC_TaiKhoan> list = new BUS_TaiKhoan().SelectAll();
                foreach(EC_TaiKhoan tk in list)
                {
                    tb.Rows.Add(tk.ID, tk.TenDangNhap, tk.MatKhau);
                }
            }
            else if(select == 6)
            {
                List<EC_GiaoVien> listGiaoVien = new BUS_GiaoVien().SelectAll();
                foreach(EC_GiaoVien ecGiaoVien in listGiaoVien)
                {
                    tb.Rows.Add(ecGiaoVien.Ma_GiaoVien, ecGiaoVien.Ten_GiaoVien, ecGiaoVien.GioiTinh, ecGiaoVien.NgaySinh, ecGiaoVien.TrinhDo, ecGiaoVien.Email, ecGiaoVien.SDT);
                }
            }
            dataGridView1.DataSource = tb;
        }
    }
}
