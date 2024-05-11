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
    public partial class ThongKeDiemSinhVien : Form
    {
        public ThongKeDiemSinhVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ThongKeDiemSinhVien_Load(object sender, EventArgs e)
        {
            if(radTKDmaMH.Checked = true)
            btnTKDmoi1.Enabled = false;
            HienThiComboBox();
            HienThiDSsinhvien1();
        }

        private void HienThiComboBox()
        {
        
            List<MonHoc_DTO> lstMon = MonHoc_BUS.LayDSmonhoc();
            cboTKDmonhoc.DataSource = lstMon;
            cboTKDmonhoc.DisplayMember = "MaMH1";
            cboTKDmonhoc.ValueMember = "MaMH1";
        }

            private void HienThiDSsinhvien1()
        {
            List<Diem_DTO> lstDiem = Diem_BUS.LayDSdiem();
            dataGridView7.DataSource = lstDiem;
        }

        private void btnTKDxem1_Click(object sender, EventArgs e)
        {
            btnTKDmoi1.Enabled = true;
            btnTKDxem1.Enabled = false;
            
            // Kiểm tra dữ liệu có bị bỏ trống
            if (radTKDmaMH.Checked == true)
            {
                txtTKDmasv.Enabled = false;
                radTKDmaSV.Enabled=false;
                
                if (string.IsNullOrEmpty(cboTKDmonhoc.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã môn học cần xem!");
                    return;
                }
                // Tìm theo Mã môn học
                string timKiem = cboTKDmonhoc.Text;
                List<Diem_DTO> lstdiem = Diem_BUS.TimTheoMon(timKiem);

                dataGridView7.DataSource = lstdiem;
            }
            else 
            {
                radTKDmaMH.Enabled = false;
                txtTKDmasv.Enabled =false;
                if (string.IsNullOrEmpty(txtTKDmasv.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên cần xem!");
                    return;
                }

                // Tìm theo Mã sinh viên

                string timKiem = txtTKDmasv.Text;
                Diem_DTO di = Diem_BUS.TimTheoMa(timKiem);

                if (di == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }

                // Hiển thị kết quả tìm được trong DataGridView
                dataGridView7.DataSource = new List<Diem_DTO> { di };


            }
        }

        private void btnTKDmoi1_Click(object sender, EventArgs e)
        {
            txtTKDmasv.Text = "";
            btnTKDmoi1.Enabled = false;
            txtTKDmasv.Enabled=true;
            btnTKDxem1 .Enabled = true;
            radTKDmaSV.Enabled=true;
            radTKDmaMH .Enabled=true;
            HienThiDSsinhvien1();
        }
    }
}
