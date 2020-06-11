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
    public partial class ThongTinTaiKhoan : UserControl
    {
        int Quyen;
        private string ID;
        public ThongTinTaiKhoan(int _Quyen, string _ID)
        {
            ID = _ID;
            Quyen = _Quyen;
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            LayDuLieu();
        }

        void LayDuLieu()
        {
            DataTable tb = new DataTable();
            if (Quyen == 2)
            {
                EC_GiaoVien GiaoVien = new BUS_GiaoVien().SelectByFields("ID", ID)[0];
                txbTrinhDo.Text = GiaoVien.TrinhDo;
                lbTrinhDo.Text = "Trình độ";
                txbHoTen.Text = GiaoVien.Ten_GiaoVien;
                txbMa.Text = GiaoVien.Ma_GiaoVien;
                txbNgaySinh.Text = GiaoVien.NgaySinh.ToString();
                txbDiaChi.Text = GiaoVien.DiaChi;
                txbEmail.Text = GiaoVien.Email;
                txbSDT.Text = GiaoVien.SDT;
                comboBox1.SelectedIndex = GiaoVien.GioiTinh == true ? 0 : 1;
            }
            else if (Quyen == 3)
            {
                EC_HocSinh hs = new BUS_HocSinh().SelectByFields("ID", ID)[0];
                txbTrinhDo.Text = hs.Lop.ToString();
                lbTrinhDo.Text = "Lớp";
                txbHoTen.Text = hs.Ten_HocSinh;
                txbMa.Text = hs.Ma_HocSinh;
                txbNgaySinh.Text = hs.NgaySinh.ToString();
                txbDiaChi.Text = hs.DiaChi;
                txbEmail.Text = hs.Email;
                txbSDT.Text = hs.SDT;
                comboBox1.SelectedIndex = hs.GioiTinh == true ? 0 : 1;
            }

            BUS_TaiKhoan busTK = new BUS_TaiKhoan();
            EC_TaiKhoan TaiKhoan = busTK.SelectByMa(ID);
            txbID.Text = ID;
            txbTenDN.Text = TaiKhoan.TenDangNhap;
            txbMatKhau.UseSystemPasswordChar = false;
            txbMatKhau.PasswordChar = '*';
            txbMatKhau.Text = TaiKhoan.MatKhau;
        }

        private void btThayDoiThongTin_Click(object sender, EventArgs e)
        {
            if (groupBox2.Enabled == false)
            {
                groupBox2.Enabled = true;
            }
        }

        private void btThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (btThayDoiMatKhau.Text == "Thay đổi mật khẩu")
            {
                if (groupBox1.Enabled == false)
                {
                    groupBox1.Enabled = true;
                }
                btThayDoiMatKhau.Text = "Lưu sửa đổi";
            }
            else if(btThayDoiMatKhau.Text=="Lưu sửa đổi")
            {
                if (groupBox1.Enabled == true)
                {
                    groupBox1.Enabled = false;
                }
                BUS_TaiKhoan busTK = new BUS_TaiKhoan();
                EC_TaiKhoan ecTK = new EC_TaiKhoan(ID, txbTenDN.Text, txbMatKhau.Text);
                busTK.SuaDuLieu(ecTK);
                btThayDoiMatKhau.Text = "Thay đổi mật khẩu";
            }
        }
    }
}
