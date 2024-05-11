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
    public partial class FrmGiaoDien : Form
    {
        public FrmGiaoDien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        

        private void FrmGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.ShowDialog();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem di = new Diem();
            di.ShowDialog();
        }



        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.ShowDialog();
        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiemSinhVien tkdsv = new ThongKeDiemSinhVien();
            tkdsv.ShowDialog();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeSinhVien tksv = new ThongKeSinhVien();
            tksv.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaoTaiKhoan tk = new TaoTaiKhoan();
            tk.ShowDialog();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap DN = new DangNhap();
            DN.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao();
            bc.ShowDialog();
        }
    }
}
