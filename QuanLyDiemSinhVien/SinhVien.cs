using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS;
using DTO;
using static QuanLyDiemSinhVien.QuanLyDiemDataSet;

namespace QuanLyDiemSinhVien
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        
            btnLuu.Enabled = false;
            btnMoi.Visible = false;
            btnHuy.Visible = false;
            moi.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa các giá trị trong TextBoxes
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cboLop.Text = "";
            txtQueQuan.Text = "";
            cboKhoahoc.Text = "";
            cboKhoa.Text = "";
            cboHedt.Text = "";
            txtTim.Text = "";

            // Đặt lại giá trị mặc định cho các RadioButton
            radNam.Checked = true; // Đặt Nam là giá trị mặc định

            // Đặt lại giá trị mặc định cho DateTimePicker
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày hiện tại

            // Đặt focus vào TextBox MaSV để người dùng có thể bắt đầu nhập lại từ đây
            txtMaSV.Focus();

            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = false;
            btnThoat.Visible = false;
            btnLuu.Enabled = true;
            btnMoi.Visible = true;
            btnHuy.Visible = true;
            HienThiDSsinhvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "" || txtTenSV.Text == "" || cboLop.Text == "" || cboKhoa.Text=="" || cboHedt.Text == "" || cboKhoahoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã sinh viên có độ dài chuỗi hợp lệ hay không
            if (txtMaSV.Text.Length > 9)
            {
                MessageBox.Show("Mã sinh viên tối đa 9 ký tự!");
                return;
            }

            // Cập nhật thông tin sinh viên từ người dùng
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.MaSV1 = txtMaSV.Text;
            sv.TenSV1 = txtTenSV.Text;
            if (radNam.Checked == true)
            {
                sv.GioiTinh1 = "Nam";
            }
            else
            {
                sv.GioiTinh1 = "Nữ";
            }
            sv.NgaySinh1 = DateTime.Parse(dtpNgaySinh.Text);
            sv.QueQuan1 = txtQueQuan.Text;
            sv.MaLop1 = cboLop.Text;
            sv.MaKhoa1 = cboKhoa.Text;
            sv.MaHeDT1 = cboHedt.Text;
            sv.MaKhoaHoc1 = cboKhoahoc.Text;

            // Gọi lớp BUS để cập nhật thông tin sinh viên
            if (SinhVien_BUS.CapNhatSV(sv) )
            {
                MessageBox.Show("Cập nhật sinh viên thành công!");
                HienThiDSsinhvien(); // Làm mới danh sách sinh viên
             
            }
            else
            {
                MessageBox.Show("Cập nhật sinh viên thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa!");
                return;
            }

            // Khởi tạo sinh viên với mã cần xóa
            SinhVien_DTO SV = new SinhVien_DTO();
            SV.MaSV1 = txtMaSV.Text;

            // Gọi lớp BUS để xóa sinh viên
            if (SinhVien_BUS.XoaSV(SV) == false)
            {
                MessageBox.Show("Xóa sinh viên thất bại!");
            }
            else
            {
                txtMaSV.Text = "";
                txtTenSV.Text = "";
                cboLop.Text = "";
                txtQueQuan.Text = "";
                cboKhoahoc.Text = "";
                cboKhoa.Text = "";
                cboHedt.Text = "";

                // Đặt lại giá trị mặc định cho các RadioButton
                radNam.Checked = true; // Đặt Nam là giá trị mặc định

                // Đặt lại giá trị mặc định cho DateTimePicker
                dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày hiện tại

                // Đặt focus vào TextBox MaSV để người dùng có thể bắt đầu nhập lại từ đây
                txtMaSV.Focus();

                MessageBox.Show("Xóa sinh viên thành công!");
                HienThiDSsinhvien(); // Làm mới danh sách sinh viên
            }
        }


        // Lưu thông tin sinh vien vừa chỉnh sửa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "" || txtTenSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã sinh viên có độ dài chuỗi hợp lệ hay không
            if (txtMaSV.Text.Length > 9)
            {
                MessageBox.Show("Mã sinh viên tối đa 9 ký tự!");
                return;
            }
            // Kiểm tra mã sinh viên có bị trùng không
            if (SinhVien_BUS.TimSinhVienTheoMa(txtMaSV.Text) != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }

            // Lấy thông tin sinh viên từ người dùng
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.MaSV1 = txtMaSV.Text;
            sv.TenSV1 = txtTenSV.Text;
            if (radNam.Checked == true)
            {
                sv.GioiTinh1 = "Nam";
            }
            else
            {
                sv.GioiTinh1 = "Nữ";
            }
            DateTime ngaySinh;
            if (DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh))
            {
                sv.NgaySinh1 = ngaySinh.Date; // Lấy ngày tháng năm, không lấy giờ phút giây
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return; // Thoát khỏi phương thức nếu ngày sinh không hợp lệ
            }

            sv.QueQuan1 = txtQueQuan.Text;
            sv.MaLop1 = cboLop.Text;
            sv.MaKhoa1 = cboKhoa.Text;
            sv.MaHeDT1 = cboHedt.Text;
            sv.MaKhoaHoc1 = cboKhoahoc.Text;
            // Gọi lớp BUS để thêm sinh viên mới

            if (SinhVien_BUS.ThemSV(sv))
            {
                MessageBox.Show("Thêm sinh viên thành công!");
                HienThiDSsinhvien(); // Làm mới danh sách sinh viên
                btnLuu.Enabled = false;
                btnHuy.Visible = false;
                btnMoi.Visible = false;
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thất bại!");
            }
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            radMasv.Checked = true;
            radNam.Checked = true;

            HienThiComboBox();
            HienThiDSsinhvien();
        }

        private void HienThiComboBox()
        {
            List<Lop_DTO> lstThongtin = Lop_BUS.LayDSlop();
            cboLop.DataSource = lstThongtin;
            cboLop.DisplayMember = "TenLop1";
            cboLop.ValueMember = "MaLop1";

            List<Khoa_DTO> lstKhoa = Khoa_BUS.LayDSkhoa();
            cboKhoa.DataSource = lstKhoa;
            cboKhoa.DisplayMember = "TenKhoa1";
            cboKhoa.ValueMember = "MaKhoa1";

            List<HeDT_DTO> lstHeDT = HeDT_BUS.LayDShedt();
            cboHedt.DataSource = lstHeDT;
            cboHedt.DisplayMember = "TenHeDT1";
            cboHedt.ValueMember = "MaHeDT1";

            List<KhoaHoc_DTO> lstKhoaHoc = KhoaHoc_BUS.LayDSkhoahoc();
            cboKhoahoc.DataSource = lstKhoaHoc;
            cboKhoahoc.DisplayMember = "TenKhoaHoc1";
            cboKhoahoc.ValueMember = "MaKhoaHoc1";

        }
            private void HienThiDSsinhvien()
        {
            List<SinhVien_DTO> lstSinhvien = SinhVien_BUS.LayDSsinhvien();
            dataGridView1.DataSource = lstSinhvien;

            dataGridView1.Columns["MaSV1"].HeaderText = "Mã sinh viên";
            dataGridView1.Columns["MaSV1"].Width = 110;

            dataGridView1.Columns["TenSV1"].HeaderText = "Họ tên";
            dataGridView1.Columns["TenSV1"].Width = 110;

            dataGridView1.Columns["MaLop1"].HeaderText = "Lớp";
            dataGridView1.Columns["MaLop1"].Width = 60;

            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView1.Columns["GioiTinh1"].Width = 60;

            dataGridView1.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["NgaySinh1"].Width = 90;

            dataGridView1.Columns["QueQuan1"].HeaderText = "Quê quán";
            dataGridView1.Columns["QueQuan1"].Width = 70;

            dataGridView1.Columns["MaKhoa1"].HeaderText = "Khoa";
            dataGridView1.Columns["MaKhoa1"].Width = 70;

            dataGridView1.Columns["MaHeDT1"].HeaderText = "Hệ ĐT";
            dataGridView1.Columns["MaHeDT1"].Width = 60;

            dataGridView1.Columns["MaKhoaHoc1"].HeaderText = "Khóa học";
            dataGridView1.Columns["MaKhoaHoc1"].Width = 100;

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }
            moi.Enabled = true;

            string timKiem = txtTim.Text;

            if (radMasv.Checked)
            {
                // Tìm theo mã sinh viên
                SinhVien_DTO sv = SinhVien_BUS.TimSinhVienTheoMa(timKiem);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }

                // Hiển thị kết quả tìm được trong DataGridView
                dataGridView1.DataSource = new List<SinhVien_DTO> { sv };
            }
            else
            {
                // Tìm theo tên sinh viên
                List<SinhVien_DTO> lstsv = SinhVien_BUS.TimSinhVienTheoTen(timKiem);

                dataGridView1.DataSource = lstsv;

            }
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridView1.SelectedRows[0];
            txtMaSV.Text = r.Cells["MaSV1"].Value.ToString();
            txtTenSV.Text = r.Cells["TenSV1"].Value.ToString();
            cboLop.SelectedValue = r.Cells["MaLop1"].Value;
            dtpNgaySinh.Text = r.Cells["NgaySinh1"].Value.ToString();
            if (r.Cells["GioiTinh1"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtQueQuan.Text = r.Cells["QueQuan1"].Value.ToString();
            cboKhoa.SelectedValue = r.Cells["MaKhoa1"].Value;
            cboHedt.SelectedValue = r.Cells["MaHeDT1"].Value;
            cboKhoahoc.SelectedValue = r.Cells["MaKhoaHoc1"].Value;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cboLop.Text = "";
            txtQueQuan.Text = "";
            cboKhoahoc.Text = "";
            cboKhoa.Text = "";
            cboHedt.Text = "";

            // Đặt lại giá trị mặc định cho các RadioButton
            radNam.Checked = true; // Đặt Nam là giá trị mặc định

            // Đặt lại giá trị mặc định cho DateTimePicker
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày hiện tại

            // Đặt focus vào TextBox MaSV để người dùng có thể bắt đầu nhập lại từ đây
            txtMaSV.Focus();

            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = false;
            btnLuu.Visible = true;
            HienThiDSsinhvien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cboLop.Text = "";
            txtQueQuan.Text = "";
            cboKhoahoc.Text = "";
            cboKhoa.Text = "";
            cboHedt.Text = "";

            // Đặt lại giá trị mặc định cho các RadioButton
            radNam.Checked = true; // Đặt Nam là giá trị mặc định

            // Đặt lại giá trị mặc định cho DateTimePicker
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày hiện tại

            // Đặt focus vào TextBox MaSV để người dùng có thể bắt đầu nhập lại từ đây
            txtMaSV.Focus();

            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Visible = true;
            btnThoat.Visible = true;
            btnLuu.Enabled = false;
            btnMoi.Visible = false;
            btnHuy.Visible = false;
            HienThiDSsinhvien();
        }

        private void moi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            radMasv.Checked = true;
            HienThiDSsinhvien();
        }
    }
}
