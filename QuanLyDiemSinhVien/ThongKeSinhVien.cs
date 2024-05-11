using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class ThongKeSinhVien : Form
    {
        public ThongKeSinhVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ThongKeSinhVien_Load(object sender, EventArgs e)
        {
            btnTKmoi1.Enabled = false;
            btnTKmoi2.Enabled = false;
            HienThiComboBox();
            HienThiDSsinhvien1();
            HienThiDSsinhvien2();

        }

        private void HienThiComboBox()
        {
            List<Lop_DTO> lstThongtin = Lop_BUS.LayDSlop();
            cboTKlop.DataSource = lstThongtin;
            cboTKlop.DisplayMember = "TenLop1";
            cboTKlop.ValueMember = "MaLop1";

            List<Khoa_DTO> lstKhoa = Khoa_BUS.LayDSkhoa();
            cboTKkhoa.DataSource = lstKhoa;
            cboTKkhoa.DisplayMember = "TenKhoa1";
            cboTKkhoa.ValueMember = "MaKhoa1";


        }

        private void HienThiDSsinhvien1()
        {
            List<SinhVien_DTO> lstSinhvien = SinhVien_BUS.LayDSsinhvien();
            dataGridView4.DataSource = lstSinhvien;

            dataGridView4.Columns["MaSV1"].HeaderText = "Mã sinh viên";
            dataGridView4.Columns["MaSV1"].Width = 80;

            dataGridView4.Columns["TenSV1"].HeaderText = "Họ tên";
            dataGridView4.Columns["TenSV1"].Width = 110;

            dataGridView4.Columns["MaLop1"].HeaderText = "Lớp";
            dataGridView4.Columns["MaLop1"].Width = 60;

            dataGridView4.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView4.Columns["GioiTinh1"].Width = 40;

            dataGridView4.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView4.Columns["NgaySinh1"].Width = 90;

            dataGridView4.Columns["QueQuan1"].HeaderText = "Quê quán";
            dataGridView4.Columns["QueQuan1"].Width = 70;

            dataGridView4.Columns["MaKhoa1"].HeaderText = "Khoa";
            dataGridView4.Columns["MaKhoa1"].Width = 120;

            dataGridView4.Columns["MaHeDT1"].HeaderText = "Hệ ĐT";
            dataGridView4.Columns["MaHeDT1"].Width = 60;

            dataGridView4.Columns["MaKhoaHoc1"].HeaderText = "Khóa học";
            dataGridView4.Columns["MaKhoaHoc1"].Width = 100;

        }
        private void HienThiDSsinhvien2()
        {
            List<SinhVien_DTO> lstSinhvien = SinhVien_BUS.LayDSsinhvien();
            dataGridView5.DataSource = lstSinhvien;

            dataGridView5.Columns["MaSV1"].HeaderText = "Mã sinh viên";
            dataGridView5.Columns["MaSV1"].Width = 80;

            dataGridView5.Columns["TenSV1"].HeaderText = "Họ tên";
            dataGridView5.Columns["TenSV1"].Width = 110;

            dataGridView5.Columns["MaLop1"].HeaderText = "Lớp";
            dataGridView5.Columns["MaLop1"].Width = 60;

            dataGridView5.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView5.Columns["GioiTinh1"].Width = 40;

            dataGridView5.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView5.Columns["NgaySinh1"].Width = 90;

            dataGridView5.Columns["QueQuan1"].HeaderText = "Quê quán";
            dataGridView5.Columns["QueQuan1"].Width = 70;

            dataGridView5.Columns["MaKhoa1"].HeaderText = "Khoa";
            dataGridView5.Columns["MaKhoa1"].Width = 120;

            dataGridView5.Columns["MaHeDT1"].HeaderText = "Hệ ĐT";
            dataGridView5.Columns["MaHeDT1"].Width = 60;

            dataGridView5.Columns["MaKhoaHoc1"].HeaderText = "Khóa học";
            dataGridView5.Columns["MaKhoaHoc1"].Width = 100;

        }

        private void ctnXem1_Click(object sender, EventArgs e)
        {
            btnTKmoi1.Enabled = true;
            ctnXem1.Enabled = false;
            // Kiểm tra dữ liệu có bị bỏ trống
            if (string.IsNullOrEmpty(cboTKkhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa cần xem!");
                return;
            }

            string timKiem = cboTKkhoa.Text;
            List<SinhVien_DTO> lstsv = SinhVien_BUS.TimSinhVienTheoKhoa(timKiem);

            dataGridView4.DataSource = lstsv;

        }

        private void btnTKmoi1_Click(object sender, EventArgs e)
        {
            cboTKkhoa.Text = "";
            ctnXem1.Enabled = true;
            btnTKmoi1.Enabled = false;
            HienThiDSsinhvien1();
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            btnTKmoi2.Enabled = true;
            btnXem2.Enabled = false;
            // Kiểm tra dữ liệu có bị bỏ trống
            if (string.IsNullOrEmpty(cboTKkhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xem!");
                return;
            }

            string timKiem = cboTKlop.Text;
            List<SinhVien_DTO> lstsv = SinhVien_BUS.TimSinhVienTheoLop(timKiem);

            dataGridView5.DataSource = lstsv;
        }

        private void btnTKmoi2_Click(object sender, EventArgs e)
        {
            cboTKlop.Text = "";
            btnXem2.Enabled = true;
            btnTKmoi2.Enabled = false;
            HienThiDSsinhvien2();
        }
    }
}
