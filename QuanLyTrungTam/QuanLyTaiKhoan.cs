using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang_Entity;
using QuanLyTrungTam_BUS;

namespace QuanLyTrungTam
{
    public partial class QuanLyTaiKhoan : UserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadForm();
        }
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        void LoadForm()
        {
            dgDanhsach.DataSource = busTK.SelectAll();
            btLuu.Text = "Thêm";
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string ID = txbID1.Text;
            dgDanhsach.DataSource = busTK.SelectByMa(ID);

        }

        private void dgDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            string ID = dgDanhsach.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string TenDangNhap = dgDanhsach.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
            string MatKhau = dgDanhsach.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
            txbID.Text = ID;
            txbTenDN.Text = TenDangNhap;
            txbMatKhau.Text = MatKhau;
            btLuu.Text = "Lưu";

            BUS_GiaoVien busGv = new BUS_GiaoVien();
            BUS_HocSinh busHs = new BUS_HocSinh();
            BUS_QuanLyTrungTam busQl = new BUS_QuanLyTrungTam();

            if (busQl.TaoBang("where ID='" + ID + "'").Rows.Count != 0)
            {
                cbLoai.SelectedIndex = 0;
                txbMa.Text = "";
            }
            else if (busHs.SelectByFields("ID", ID).Count != 0)
            {
                cbLoai.SelectedIndex = 2;
                txbMa.Text = busHs.SelectByFields("ID", ID)[0].Ma_HocSinh;
            }
            else if (busGv.SelectByFields("ID", ID).Count != 0)  
            {
                cbLoai.SelectedIndex = 1;
                txbMa.Text = busGv.SelectByFields("ID", ID)[0].Ma_GiaoVien;
            }
            else
            {
                return;
            }
            txbID.Enabled = txbMa.Enabled = txbTenDN.Enabled = cbLoai.Enabled = false;
        }

        string TaoID()
        {
            List<EC_TaiKhoan> tb = busTK.SelectAll();
            string old_id = tb[0].ID;
            string old_number = old_id.Substring(2);
            string new_id = (Convert.ToInt32(old_number) + 1).ToString();
            return new_id;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (btLuu.Text == "Lưu")
            {
                EC_TaiKhoan ecTK = new EC_TaiKhoan(txbID.Text, txbTenDN.Text, txbMatKhau.Text);
                busTK.SuaDuLieu(ecTK);
                btLuu.Text = "Thêm";
                txbID.Enabled = txbMa.Enabled = txbTenDN.Enabled = cbLoai.Enabled = true;
            }
            else if (btLuu.Text == "Thêm")
            {
                string ID = TaoID();
                EC_TaiKhoan ecTK = new EC_TaiKhoan(ID, txbTenDN.Text, txbMatKhau.Text);
                if (cbLoai.SelectedIndex == 0)
                {
                    EC_QuanLyTrungTam ecQl = new EC_QuanLyTrungTam();
                    ecQl.ID = ID;
                }
                else if (cbLoai.SelectedIndex == 1)
                {
                    BUS_GiaoVien busGv = new BUS_GiaoVien();
                    if (busGv.Select_ByPrimaryKey(txbMa.Text) == null) 
                    {
                        MessageBox.Show("Không tồn tại giáo viên");
                        return;
                    }
                    busGv.ThemID(txbMa.Text, ID);
                }
                else if(cbLoai.SelectedIndex==2)
                {
                    BUS_HocSinh busHS = new BUS_HocSinh();
                    if(busHS.Select_ByPrimaryKey(txbMa.Text) == null)
                    {
                        MessageBox.Show("Không tồn tại học sinh");
                        return;
                    }
                    busHS.ThemID(txbMa.Text, ID);
                }
            }
            else
            {

            }
            LoadForm();
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex == 0)
            {
                txbMa.Enabled = false;
            }
            else
            {
                txbMa.Enabled = true;
            }
        }

        private void btThemAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
