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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnMoi.Enabled = false;
            btnMoi2.Visible = false; 
            radMaMH.Checked = true;

            HienThiDSmon();
        }

        private void HienThiDSmon()
        {
            List<MonHoc_DTO> lstMon = MonHoc_BUS.LayDSmonhoc();
            dataGridView8.DataSource = lstMon;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            btnMoi.Enabled = true;


            // Kiểm tra dữ liệu có bị bỏ trống
            if (radMaMH.Checked == true)
            {

                if (string.IsNullOrEmpty(txtTim.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã môn học cần xem!");
                    return;
                }
                // Tìm theo Mã môn học
                string timKiem = txtTim.Text;
                List<MonHoc_DTO> lstMamon = MonHoc_BUS.TimTheoMaMon(timKiem);

                dataGridView8.DataSource = lstMamon;
            }
            else
            {
                radMaMH.Enabled = false;
                if (string.IsNullOrEmpty(txtTim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên môn học cần xem!");
                    return;
                }

                // Tìm theo Tên môn học 

                string timKiem = txtTim.Text;
                List<MonHoc_DTO> lstTenmon = MonHoc_BUS.TimTheoTenMon(timKiem);

                dataGridView8.DataSource = lstTenmon;


            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            btnLoc.Enabled = true;
            btnMoi.Enabled = false;
            radTenMH.Enabled = true;
            radMaMH.Enabled = true;
            HienThiDSmon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa các giá trị trong TextBoxes
            txtTenMH.Text = "";
            txtMaMH.Text = "";
            txtSoTC.Text = "";
           


            txtMaMH.Focus();

            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = false;
            button8.Visible = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnMoi2.Visible = true;
            HienThiDSmon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }



            // Lấy thông tin 
            MonHoc_DTO di = new MonHoc_DTO();
            di.MaMH1 = txtMaMH.Text;
            di.TenMH1 = txtTenMH.Text;
            di.SoTrinh1 = Int32.Parse(txtSoTC.Text);

            // Gọi lớp BUS để cập nhật thông tin 
            if (MonHoc_BUS.CapNhatMon(di))
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiDSmon(); // Làm mới danh sách 

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Khởi tạo điểm với mã cần xóa
            MonHoc_DTO di = new MonHoc_DTO();
            di.MaMH1 = txtMaMH.Text;

            // Gọi lớp BUS để xóa sinh viên
            if (MonHoc_BUS.XoaMon(di) == false)
            {
                MessageBox.Show("Xóa thất bại!");
            }
            else
            {
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtSoTC.Text = "";
                


                txtMaMH.Focus();

                MessageBox.Show("Xóa thành công!");
                HienThiDSmon();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã sinh viên có độ dài chuỗi hợp lệ hay không
            if (txtMaMH.Text.Length > 6)
            {
                MessageBox.Show("Mã môn học tối đa 6 ký tự!");
                return;
            }
            // Kiểm tra mã sinh viên có bị trùng không
            if (MonHoc_BUS.TimTheoMaMon(txtMaMH.Text) != null)
            {
                MessageBox.Show("Mã môn học đã tồn tại!");
                return;
            }

            // Lấy thông tin 
            MonHoc_DTO di = new MonHoc_DTO();
            di.MaMH1 = txtMaMH.Text;
            di.TenMH1 = txtTenMH.Text;
            di.SoTrinh1 = Int32.Parse(txtSoTC.Text);
            

            // Gọi lớp BUS để thêm thông tin mới

            if (MonHoc_BUS.ThemMon(di))
            {
                MessageBox.Show("Thêm thành công!");
                HienThiDSmon(); // Làm mới danh sách
                btnLuu.Enabled = false;
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
                button8.Visible = true;
                btnMoi2.Visible = false;
                btnHuy.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thêm thất bại do mã sinh viên không tồn tại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa các giá trị trong TextBoxes
            txtTenMH.Text = "";
            txtMaMH.Text = "";
            txtSoTC.Text = "";
            


            txtMaMH.Focus();

            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Visible = true;
            button8.Visible = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnMoi2.Visible = false;
            HienThiDSmon();
        }

        private void btnMoi2_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtMaMH.Text = "";
            txtSoTC.Text = "";

            txtMaMH.Focus();
            HienThiDSmon();
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridView8.SelectedRows[0];
            txtMaMH.Text = r.Cells["MaMH"].Value.ToString();
            txtTenMH.Text = r.Cells["TenMH"].Value.ToString();
            txtSoTC.Text = r.Cells["SoTrinh"].Value.ToString();
            
        }
    }
}
