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
    public partial class QuanLyGiaoVien : UserControl
    {
        public QuanLyGiaoVien()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()
        {
            dgDanhsach.DataSource = new BUS_GiaoVien().SelectAll();
            cbTrinhDo.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            string query = "where ";
            if (txbMa_HS.Text != "")
            {
                query += " Ma_GiaoVien='" + txbMa_HS.Text + "'";
            }
            if (txbTen_HS.Text != "")
            {
                query += " Ten_GiaoVien=N'" + txbTen_HS.Text + "'";
            }
            if (cbGioiTinh.SelectedIndex == 0)
            {

            }
            else
            {
                string gt;
                if (cbGioiTinh.SelectedIndex == 1)
                    gt = "True";
                else
                    gt = "False";
                query += " GioiTinh='" + gt + "'";
            }
            if (cbTrinhDo.SelectedIndex == 0)
            {

            }
            else
            {
                query += " TrinhDo =N'" + cbTrinhDo.SelectedItem.ToString() + "'";
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool gt;
            if (cbGioiTinh.SelectedIndex == 0)
            {
                MessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                gt = cbGioiTinh.SelectedIndex == 1 ? true : false;
            }
            string TrinhDo;
            if (cbTrinhDo.SelectedIndex == 0)
            {
                MessageBox.Show("Trình độ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                TrinhDo = cbTrinhDo.SelectedItem.ToString();
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                EC_GiaoVien HocSinh = new EC_GiaoVien(txbMa_HS.Text, txbTen_HS.Text, dateTimePicker1.Value, gt, txbDiaChi.Text, txbSDT.Text, txbEmail.Text, TrinhDo, "");
                BUS_GiaoVien busHS = new BUS_GiaoVien();
                busHS.ThemDuLieu(HocSinh);
                MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm học sinh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
