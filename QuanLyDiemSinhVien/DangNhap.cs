using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            //kiểm tra xem chuỗi có rỗng không
            if (string.IsNullOrEmpty(taikhoan) && string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập vào tài khoản và mật khẩu !", "Thông báo");
                return;
            }
            // Thực hiện quá trình đăng nhập và kiểm tra kết quả
            DangNhap_DTO tk = new DangNhap_DTO();
            tk = DangNhap_BUS.DangNhap(taikhoan, matkhau);

            if (tk == null)
            {
                MessageBox.Show("Sai thông tin, vui lòng nhập lại", "Thông báo");
                this.txtTaiKhoan.Focus();
                return; 
                
            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo");
            }

            // Nếu đăng nhập thành công, kiểm tra quyền 

            if (tk.MaQuyen1 == 1) // 1 là  admin, 2 là khách
            {
                FrmGiaoDien GD = new FrmGiaoDien();
                this.Hide();
                GD.ShowDialog();
            }
            else
            {
                FrmKhach KH = new FrmKhach();
                this.Hide();
                KH.ShowDialog();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        // Ẩn hiện chữ chìm trên khung
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
    }
}
