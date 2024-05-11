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
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
           
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnMoi.Enabled = false;
            btnMoi2.Visible = false;
            radMaSV.Checked = true;
            

            HienThiComboBox();
            HienThiDSdiem();
        }

        private void HienThiComboBox()
        {

            List<MonHoc_DTO> lstMon = MonHoc_BUS.LayDSmonhoc();
            cboMaMH.DataSource = lstMon;
            cboMaMH.DisplayMember = "MaMH1";
            cboMaMH.ValueMember = "MaMH1";
        }

        private void HienThiDSdiem()
        {
            List<Diem_DTO> lstDiem = Diem_BUS.LayDSdiem();
            dataGridView3.DataSource = lstDiem;
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
                List<Diem_DTO> lstdiem = Diem_BUS.TimTheoMon(timKiem);

                dataGridView3.DataSource = lstdiem;
            }
            else
            {
                radMaMH.Enabled = false;
                if (string.IsNullOrEmpty(txtTim.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên cần xem!");
                    return;
                }

                // Tìm theo Mã sinh viên

                string timKiem = txtTim.Text;
                Diem_DTO di = Diem_BUS.TimTheoMa(timKiem);

                if (di == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }

                // Hiển thị kết quả tìm được trong DataGridView
                dataGridView3.DataSource = new List<Diem_DTO> { di };


            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            btnLoc.Enabled = true;
            btnMoi.Enabled = false;
            radMaSV.Enabled = true;
            radMaMH.Enabled=true;
            HienThiDSdiem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa các giá trị trong TextBoxes
            txtMaSV.Text = "";
            cboMaMH.Text = "CNPM";
            txtHocky.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
            txtTim.Text = "";

            
            txtMaSV.Focus();

            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = false;
            btnThoat.Visible = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnMoi2.Visible = true;
            HienThiDSdiem();
        }

        //-------------------------- Cập nhật ----------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "" || txtHocky.Text == "" || txtDiem1.Text == "" || txtDiem2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
           

            // Lấy thông tin 
            Diem_DTO di = new Diem_DTO();
            di.MaSV = txtMaSV.Text;
            di.MaMH = cboMaMH.Text;
            di.HocKy = Int32.Parse(txtHocky.Text);
            di.DiemLan1 = Int32.Parse(txtDiem1.Text);
            di.DiemLan2 = Int32.Parse(txtDiem2.Text);

            // Gọi lớp BUS để cập nhật thông tin 
            if (Diem_BUS.CapNhatDiem(di))
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiDSdiem(); // Làm mới danh sách 

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
         // -------------------Xóa------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa!");
                return;
            }

            // Khởi tạo điểm với mã cần xóa
            Diem_DTO di = new Diem_DTO();
            di.MaSV = txtMaSV.Text;

            // Gọi lớp BUS để xóa sinh viên
            if (Diem_BUS.XoaDiem(di) == false)
            {
                MessageBox.Show("Xóa thất bại!");
            }
            else
            {
                txtMaSV.Text = "";
                txtHocky.Text = "";
                txtDiem1.Text = "";
                txtDiem2.Text = "";
                cboMaMH.Text = "CNPM";
               
                
                txtMaSV.Focus();

                MessageBox.Show("Xóa thành công!");
                HienThiDSdiem(); 
            }
        }

        //---------------- Thêm---------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaSV.Text == "" || txtHocky.Text == "" || txtDiem1.Text == "" || txtDiem2.Text == "")
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
            if (Diem_BUS.TimTheoMa(txtMaSV.Text) != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }

            // Lấy thông tin 
            Diem_DTO di = new Diem_DTO();
            di.MaSV = txtMaSV.Text;
            di.MaMH = cboMaMH.Text;
            di.HocKy = Int32.Parse(txtHocky.Text);
            di.DiemLan1 = Int32.Parse(txtDiem1.Text);
            di.DiemLan2 = Int32.Parse(txtDiem2.Text);

            // Gọi lớp BUS để thêm thông tin điểm mới

            if (Diem_BUS.ThemThongTinDiem(di))
            {
                MessageBox.Show("Thêm thành công!");
                HienThiDSdiem(); // Làm mới danh sách
                btnLuu.Enabled = false;
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
                btnThoat.Visible = true;    
                btnMoi2.Visible = false;
                btnHuy.Enabled =false;
            }
            else
            {
                MessageBox.Show("Thêm thất bại do mã sinh viên không tồn tại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa các giá trị trong TextBoxes
            txtMaSV.Text = "";
            cboMaMH.Text = "CNPM";
            txtHocky.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
            txtTim.Text = "";


            txtMaSV.Focus();

            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Visible = true;
            btnThoat.Visible = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnMoi2.Visible = false;
            HienThiDSdiem();
        }

        private void btnMoi2_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            cboMaMH.Text = "CNPM";
            txtHocky.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";



            txtMaSV.Focus();

            HienThiDSdiem();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridView3.SelectedRows[0];
            txtMaSV.Text = r.Cells["MaSV"].Value.ToString();
            cboMaMH.SelectedValue = r.Cells["MaMH"].Value;
            txtHocky.Text = r.Cells["HocKy"].Value.ToString();
            txtDiem1.Text = r.Cells["DiemLan1"].Value.ToString();
            txtDiem2.Text = r.Cells["DiemLan2"].Value.ToString();
        }
    }
}
