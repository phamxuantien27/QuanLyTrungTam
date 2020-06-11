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
    public partial class QuanLyHocSinh : UserControl
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            BUS_HocSinh busHs = new BUS_HocSinh();
            dgDanhsach.DataSource = busHs.SelectAll();
            cbLop.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string query = "where ";
            if (txbMa_HS.Text != "")
            {
                query += " Ma_HocSinh='" + txbMa_HS.Text + "'";
            }
            if (txbTen_HS.Text != "")
            {
                query += " Ten_HocSinh=N'" + txbTen_HS.Text + "'";
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
            if (cbLop.SelectedIndex == 0)
            {

            }
            else
            {
                query += " Lop="+Int32.Parse(cbLop.SelectedItem.ToString());
            }
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            LoadForm();
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
            int Lop;
            if (cbLop.SelectedIndex == 0)
            {
                MessageBox.Show("Lớp không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Lop = Int32.Parse(cbLop.SelectedItem.ToString());
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                EC_HocSinh HocSinh = new EC_HocSinh(txbMa_HS.Text, txbTen_HS.Text, dateTimePicker1.Value, gt, txbDiaChi.Text, txbSDT.Text, txbEmail.Text, Lop, "");
                BUS_HocSinh busHS = new BUS_HocSinh();
                busHS.ThemDuLieu(HocSinh);
                MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm học sinh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDanhsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa học sinh này đi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EC_HocSinh HocSinh = new EC_HocSinh();
                HocSinh.Ma_HocSinh = dgDanhsach.Rows[e.RowIndex].Cells["Ma_HocSinh"].Value.ToString();
                BUS_HocSinh busHS = new BUS_HocSinh();
                busHS.XoaDuLieu(HocSinh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                return;
            }
        }
    }
}
