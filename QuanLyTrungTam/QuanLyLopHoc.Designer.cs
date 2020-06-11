namespace QuanLyTrungTam
{
    partial class QuanLyLopHoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLopHoc = new System.Windows.Forms.DataGridView();
            this.Ma_LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.dtNgayBatdau = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSoBuoi = new System.Windows.Forms.TextBox();
            this.txbTongHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.txbMaGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLopHoc
            // 
            this.dgLopHoc.AllowUserToAddRows = false;
            this.dgLopHoc.AllowUserToResizeRows = false;
            this.dgLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgLopHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLopHoc.ColumnHeadersHeight = 30;
            this.dgLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_LopHoc,
            this.Ma_GiaoVien,
            this.Ten_GiaoVien,
            this.Ten_MonHoc,
            this.Phong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLopHoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLopHoc.GridColor = System.Drawing.Color.White;
            this.dgLopHoc.Location = new System.Drawing.Point(698, 56);
            this.dgLopHoc.Name = "dgLopHoc";
            this.dgLopHoc.ReadOnly = true;
            this.dgLopHoc.RowHeadersVisible = false;
            this.dgLopHoc.RowHeadersWidth = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgLopHoc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLopHoc.RowTemplate.Height = 50;
            this.dgLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLopHoc.Size = new System.Drawing.Size(906, 855);
            this.dgLopHoc.TabIndex = 2;
            // 
            // Ma_LopHoc
            // 
            this.Ma_LopHoc.DataPropertyName = "Ma_LopHoc";
            this.Ma_LopHoc.HeaderText = "Mã lớp học";
            this.Ma_LopHoc.Name = "Ma_LopHoc";
            this.Ma_LopHoc.ReadOnly = true;
            // 
            // Ma_GiaoVien
            // 
            this.Ma_GiaoVien.DataPropertyName = "Ma_GiaoVien";
            this.Ma_GiaoVien.HeaderText = "Mã giáo viên";
            this.Ma_GiaoVien.Name = "Ma_GiaoVien";
            this.Ma_GiaoVien.ReadOnly = true;
            // 
            // Ten_GiaoVien
            // 
            this.Ten_GiaoVien.DataPropertyName = "Ten_GiaoVien";
            this.Ten_GiaoVien.HeaderText = "Tên giáo viên";
            this.Ten_GiaoVien.Name = "Ten_GiaoVien";
            this.Ten_GiaoVien.ReadOnly = true;
            // 
            // Ten_MonHoc
            // 
            this.Ten_MonHoc.DataPropertyName = "Ten_MonHoc";
            this.Ten_MonHoc.HeaderText = "Môn học";
            this.Ten_MonHoc.Name = "Ten_MonHoc";
            this.Ten_MonHoc.ReadOnly = true;
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phòng học";
            this.Phong.Name = "Phong";
            this.Phong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbTenMon);
            this.panel1.Controls.Add(this.cbTrinhDo);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.dtNgayBatdau);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbSoBuoi);
            this.panel1.Controls.Add(this.txbTongHP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.txbMaGV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Location = new System.Drawing.Point(53, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 855);
            this.panel1.TabIndex = 3;
            // 
            // cbTenMon
            // 
            this.cbTenMon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(210, 109);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(305, 34);
            this.cbTenMon.TabIndex = 21;
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Items.AddRange(new object[] {
            "Tất cả",
            "Nâng cao",
            "Cơ bản"});
            this.cbTrinhDo.Location = new System.Drawing.Point(210, 400);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(305, 34);
            this.cbTrinhDo.TabIndex = 20;
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Tất cả"});
            this.cbLop.Location = new System.Drawing.Point(210, 209);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(305, 34);
            this.cbLop.TabIndex = 19;
            // 
            // dtNgayBatdau
            // 
            this.dtNgayBatdau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatdau.Location = new System.Drawing.Point(210, 698);
            this.dtNgayBatdau.Name = "dtNgayBatdau";
            this.dtNgayBatdau.Size = new System.Drawing.Size(305, 34);
            this.dtNgayBatdau.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lớp học";
            // 
            // txbSoBuoi
            // 
            this.txbSoBuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoBuoi.Location = new System.Drawing.Point(210, 594);
            this.txbSoBuoi.Name = "txbSoBuoi";
            this.txbSoBuoi.Size = new System.Drawing.Size(305, 34);
            this.txbSoBuoi.TabIndex = 15;
            // 
            // txbTongHP
            // 
            this.txbTongHP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongHP.Location = new System.Drawing.Point(210, 497);
            this.txbTongHP.Name = "txbTongHP";
            this.txbTongHP.Size = new System.Drawing.Size(305, 34);
            this.txbTongHP.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng số buổi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng học phí";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(334, 787);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(194, 43);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txbMaGV
            // 
            this.txbMaGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaGV.Location = new System.Drawing.Point(210, 303);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.Size = new System.Drawing.Size(305, 34);
            this.txbMaGV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trình độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên môn học";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(55, 787);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(196, 43);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgLopHoc);
            this.Name = "QuanLyLopHoc";
            this.Size = new System.Drawing.Size(1663, 990);
            ((System.ComponentModel.ISupportInitialize)(this.dgLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgLopHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txbMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSoBuoi;
        private System.Windows.Forms.TextBox txbTongHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DateTimePicker dtNgayBatdau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
    }
}
