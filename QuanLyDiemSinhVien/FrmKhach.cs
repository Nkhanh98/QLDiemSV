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
    public partial class FrmKhach : Form
    {
        public FrmKhach()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap DN = new DangNhap();
            DN.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }
    }
}
