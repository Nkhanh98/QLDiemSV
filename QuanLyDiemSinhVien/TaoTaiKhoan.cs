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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }




//---------------------- Ẩn hiện chữ chìm trên khung--------------------------
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
                if (txtTaiKhoan.Text == "User name")
            {
                    txtTaiKhoan.Text = "";
                    txtTaiKhoan.ForeColor = Color.Black;
            }

        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "User name";
                txtTaiKhoan.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
        if (txtMatKhau.Text == "Password")
             {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
             }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                    {
                        txtMatKhau.Text = "Password";
                        txtMatKhau.ForeColor = Color.Silver;
                    }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGiaoDien gd = new FrmGiaoDien();
            gd.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            
            // Kiểm tra mã sinh viên có bị trùng không
            if (DangKy_BUS.TimTaiKhoan(txtTaiKhoan.Text) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");

                txtTaiKhoan.Text = "User name";
                txtTaiKhoan.ForeColor = Color.Silver;
                txtMatKhau.Text = "Password";
                txtMatKhau.ForeColor = Color.Silver;
                return;

            }

            // Lấy thông tin 
            DangKy_DTO di = new DangKy_DTO();
            di.TaiKhoan1 = txtTaiKhoan.Text;
            di.MatKhau1 = txtMatKhau.Text;
            di.MaQuyen1 = 2;


            // Gọi lớp BUS để thêm thông tin mới

            if (DangKy_BUS.DangKy(di))
            {
                MessageBox.Show("Đăng ký thành công!");

                txtTaiKhoan.Text = "User name";
                txtTaiKhoan.ForeColor = Color.Silver;
                txtMatKhau.Text = "Password";
                txtMatKhau.ForeColor = Color.Silver;

            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");

            }
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
