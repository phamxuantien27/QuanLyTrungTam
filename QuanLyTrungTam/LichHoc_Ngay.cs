using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QuanLyTrungTam_BUS;
using System.Data.SqlClient;

namespace QuanLyTrungTam
{
    public partial class LichHoc_Ngay : UserControl
    {
        private string Ma_HocSinh;
        private DateTime Date;
        function ft = new function();
        public LichHoc_Ngay(string _Ma_HocSinh, DateTime date)
        {
            Ma_HocSinh = _Ma_HocSinh;
            Date = date;
            InitializeComponent();
            LoadDataPn(Date);
        }
        void LoadDataPn(DateTime dt)
        {
            string date = dt.DayOfWeek.ToString();
            DataTable table = ft.LayLichHoc_Ngay(Ma_HocSinh, dt);
            foreach (DataRow row in table.Rows)
            {
                string tenMH = row["Ten_MonHoc"].ToString();
                int kip = Convert.ToInt32(row["KipHoc"].ToString());
                if (kip == 1)
                {
                    button2.Text = "Kíp 1: " + tenMH;
                    button2.BackColor = Color.Green;
                }
                else if (kip == 2)
                {
                    button1.Text = "Kíp 2: " + tenMH;
                    button1.BackColor = Color.Green;
                }
                else if (kip == 3)
                {
                    button3.Text = "Kíp 3: " + tenMH;
                    button3.BackColor = Color.Green;
                }
                else if (kip == 4)
                {
                    button4.Text = "Kíp 4: " + tenMH;
                    button4.BackColor = Color.Green;
                }
                else if (kip == 5)
                {
                    button5.Text = "Kíp 5: " + tenMH;
                    button5.BackColor = Color.Green;
                }
                else
                {
                    button6.Text = "Kíp 6: " + tenMH;
                    button6.BackColor = Color.Green;
                }
            }
        }
    }
}
