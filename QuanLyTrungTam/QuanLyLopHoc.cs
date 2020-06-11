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

namespace QuanLyTrungTam
{
    public partial class QuanLyLopHoc : UserControl
    {
        DataTable data = new DataTable();
        function ft = new function();
        public QuanLyLopHoc()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            cbTenMon.Items.Clear();
            cbLop.Items.Clear();
            cbLop.Items.Add("Tất cả");
            for(int j = 1; j <= 12; j++)
            {
                cbLop.Items.Add(j.ToString());
            }
            
            EC_LopHoc ecLop = new EC_LopHoc();
            EC_MonHoc ecMon = new EC_MonHoc();

            dgLopHoc.DataSource = ft.LopHoc_Select_Manager(ecLop, ecMon);

            List<EC_MonHoc> listMonHoc = new BUS_MonHoc().SelectAll();
            List<string> listTen_MonHoc = new List<string>();
            listTen_MonHoc.Add(listMonHoc[0].Ten_MonHoc);
            cbTenMon.Items.Add(listTen_MonHoc[0]);

            foreach(EC_MonHoc MonHoc in listMonHoc)
            {
                if (listTen_MonHoc.IndexOf(MonHoc.Ten_MonHoc) == -1) 
                {
                    cbTenMon.Items.Add(MonHoc.Ten_MonHoc);
                }
                listTen_MonHoc.Add(MonHoc.Ten_MonHoc);
            }

            dtNgayBatdau.Value = DateTime.Now;
            cbLop.SelectedIndex = 12;
            cbTenMon.SelectedIndex = 0;
            cbTrinhDo.SelectedIndex = 0;
        }

        void LayDuLieu()
        {
            string MaGV;
            if (txbMaGV.Text == ""||txbMaGV.Text==null)
            {
                MaGV = "All";
            }
            else
            {
                MaGV = txbMaGV.Text;
            }
            string TrinhDo;
            if (cbTrinhDo.SelectedIndex == 0)
            {
                TrinhDo = "All";
            }
            else
            {
                TrinhDo = cbTrinhDo.SelectedItem.ToString();
            }
            string SoBuoi = txbSoBuoi.Text;
            for(int i = 0; i < SoBuoi.Length; i++)
            {
                if (SoBuoi[i] > 9 || SoBuoi[i] < 0)
                {
                    MessageBox.Show("Số buổi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            int SB;
            if (SoBuoi == "")
            {
                SB = 0;
            }
            else
            {
                SB = Int32.Parse(SoBuoi);
            }
            string TenMon;
            if (cbTenMon.SelectedIndex == 0)
            {
                TenMon = "All";
            }
            else
            {
                TenMon = cbTenMon.SelectedItem.ToString();
            }
            int Lop;
            if (cbLop.SelectedIndex == 0)
            {
                Lop = 0;
            }
            else
            {
                Lop = Convert.ToInt32(cbLop.SelectedItem);
            }
            EC_LopHoc ecLop = new EC_LopHoc("All", "All", "All", TrinhDo, 0, SB, dtNgayBatdau.Value);
            EC_MonHoc ecMon = new EC_MonHoc("All", TenMon, Lop);

            dgLopHoc.DataSource = ft.LopHoc_Select_Manager(ecLop, ecMon);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        string TaoMa_LopHoc()
        {
            List<EC_LopHoc> listLopHoc = new BUS_LopHoc().SelectAll();
            if (listLopHoc.Count == 0)
            {
                return "LH00001";
            }
            string Ma_LopHoc_Cu = listLopHoc[0].Ma_LopHoc;
            foreach(EC_LopHoc LopHoc in listLopHoc)
            {
                if (Convert.ToInt32(LopHoc.Ma_LopHoc.Substring(2)) > Convert.ToInt32(Ma_LopHoc_Cu.Substring(2)))
                {
                    Ma_LopHoc_Cu = LopHoc.Ma_LopHoc;
                }
            }
            string Ma_1 = Ma_LopHoc_Cu.Substring(0, 2);
            string Ma_2 = Ma_LopHoc_Cu.Substring(2);
            int int_Ma_2 = Convert.ToInt32(Ma_2);
            int int_Ma_2_Moi = int_Ma_2 + 1;
            return Ma_1 + int_Ma_2_Moi.ToString();
        }
        string TaoMa_BuoiHoc(string Ma_LopHoc_Cu)
        {
            
            int x = 2;
            for (int i = 2; i < Ma_LopHoc_Cu.Length; i++)
            {
                if (Ma_LopHoc_Cu[i] != '0')
                {
                    x = i;
                }
            }
            string Ma_1 = Ma_LopHoc_Cu.Substring(0, x);
            string Ma_2 = Ma_LopHoc_Cu.Substring(x);
            int int_Ma_2 = Convert.ToInt32(Ma_2);
            int int_Ma_2_Moi = int_Ma_2 + 1;
            return Ma_1 + int_Ma_2_Moi.ToString();
        }
        string LayMa_BuoiHoc_Cu(List<EC_LichHoc> list)
        {
            if (list.Count == 0)
            {
                return "BH00001";
            }
            string ma = list[0].Ma_BuoiHoc;
            foreach(EC_LichHoc LichHoc in list)
            {
                if (Convert.ToInt32(LichHoc.Ma_BuoiHoc.Substring(2))>Convert.ToInt32(ma.Substring(2)))
                {
                    ma = LichHoc.Ma_BuoiHoc;
                }
            }
            return ma;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string Ma_LopHoc = TaoMa_LopHoc();
            string Ten_MonHoc = cbTenMon.SelectedItem.ToString();
            string Ma_MonHoc = "";

            List<EC_MonHoc> list1 = new BUS_MonHoc().SelectByFields("Ten_MonHoc", Ten_MonHoc);
            List<EC_MonHoc> list2 = new BUS_MonHoc().SelectByFields("Lop", cbLop.SelectedItem.ToString());
            foreach(EC_MonHoc ec1 in list1)
            {
                foreach(EC_MonHoc ec2 in list2)
                {
                    if (ec1.Ma_MonHoc == ec2.Ma_MonHoc)
                    {
                        Ma_MonHoc = ec1.Ma_MonHoc;
                    }
                }
            }

            EC_LopHoc ecLop = new EC_LopHoc(Ma_LopHoc, txbMaGV.Text, Ma_MonHoc, cbTrinhDo.SelectedItem.ToString(), Convert.ToInt32(txbTongHP.Text)
                , Convert.ToInt32(txbSoBuoi.Text), dtNgayBatdau.Value);
            new BUS_LopHoc().ThemDuLieu(ecLop);

            int HocPhi_Buoi = Convert.ToInt32(txbTongHP.Text) / Convert.ToInt32(txbSoBuoi.Text);

            string Ma_BuoiHoc_Cu = LayMa_BuoiHoc_Cu(new BUS_LichHoc().SelectAll());

            for (int i = 0; i < Convert.ToInt32(txbSoBuoi.Text); i++)
            {
                string Ma_BuoiHoc = TaoMa_BuoiHoc(Ma_BuoiHoc_Cu);
                EC_LichHoc ecLich = new EC_LichHoc(Ma_LopHoc, DateTime.Now, 1, Ma_BuoiHoc, "", i + 1, HocPhi_Buoi, false);
                new BUS_LichHoc().ThemDuLieu(ecLich);
                Ma_BuoiHoc_Cu = Ma_BuoiHoc;
            }
            DialogResult result = MessageBox.Show("Thêm thành công lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                txbMaGV.Text = "";
                txbSoBuoi.Text = "";
                txbTongHP.Text = "";
            }
        }
    }
}
