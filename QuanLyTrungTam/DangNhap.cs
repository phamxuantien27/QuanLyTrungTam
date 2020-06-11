using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTam_BUS;
using System.Threading;
using QuanLyNhaHang_Entity;

namespace QuanLyTrungTam
{
    public partial class DangNhap : Form
    {
        int PhanQuyen;
        private string ID;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan busTK = new BUS_TaiKhoan();
            List<EC_TaiKhoan> list1 = busTK.SelectByFields("TenDangNhap", txbTenDangNhap.Text);
            List<EC_TaiKhoan> list2 = busTK.SelectByFields("MatKhau", txbMatKhau.Text);
            EC_TaiKhoan TaiKhoan = new EC_TaiKhoan();

            foreach(EC_TaiKhoan tk1 in list1)
            {
                foreach(EC_TaiKhoan tk2 in list2)
                {
                    if (tk1.ID == tk2.ID)
                    {
                        TaiKhoan = tk1;
                    }
                }
            }

            if (TaiKhoan.ID=="") 
            {
                DialogResult result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    txbMatKhau.Text = "";
                }
                return;
            }

            ID = TaiKhoan.ID; 

            BUS_QuanLyTrungTam busQL = new BUS_QuanLyTrungTam();
            BUS_GiaoVien busGV = new BUS_GiaoVien();
            BUS_HocSinh busHS = new BUS_HocSinh();

            if(busQL.TaoBang("where ID='"+ID+"'").Rows.Count != 0)
            {
                PhanQuyen = 1; // admin co quyen la 1
            }
            else if(busGV.SelectByFields("ID",ID).Count != 0)
            {
                PhanQuyen = 2; //Giao vien co quyen la 2
            }
            else if(busHS.SelectByFields("ID",ID).Count != 0)
            {
                PhanQuyen = 3;
            }
            else
            {
                PhanQuyen = 0;
            }

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Thread thr = new Thread(NewForm);
            thr.Start();
            this.Close();
        }
        void NewForm()
        {
            Form1 form = new Form1(PhanQuyen, ID);
            form.ShowDialog();
        }
    }
}
