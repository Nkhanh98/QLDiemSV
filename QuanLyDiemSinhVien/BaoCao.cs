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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent(); 
            object  lstSinhvien = new BaoCao_BUS().LayDSBaoCao();
            dataGridView1.DataSource = lstSinhvien;
            this.Size = new Size(810,600);
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Lấy tọa độ của trang in 
            var page = e.MarginBounds;

            // Xác định vị trí của hình in 1 
            int headX = page.Width / 2 - (page.Width / 2) / 2 - 150;
            int headY = page.Top;

            e.Graphics.DrawImage(header, headX, headY);



            // Xác định vị trí của hình in 2 
            int dsX = page.Width / 2 - (page.Width / 2) / 2 - 140;
            int dsY = headY + header.Height + 25;

            e.Graphics.DrawImage(ds, dsX, dsY);


            // Xác định vị trí của hình in 3
            int footX = page.Width / 2 - (page.Width / 2) / 2 - 200;
            int footY = dsY + ds.Height + 50;

            e.Graphics.DrawImage(footer, footX, footY);

        }

        private Bitmap header;
        private Bitmap ds;
        private Bitmap footer;
        public void TaoPDF()
        {
            button1.Hide();

            header = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(header, new Rectangle(0, 0, panel1.Width, panel1.Height));

           

            // Tạo biến đễ lưu giá trị cũ về chiều cao của datagridview
            int Height = dataGridView1.Height;

            // Cập nhật lại giá trị chiều cao mới  nó sẽ bằng: số dòng * chiều cao mỗi dòng * 2 ( con số 2 để in ra đẹp)
            dataGridView1.Height = dataGridView1.Rows.Count * dataGridView1.RowTemplate.Height + dataGridView1.RowTemplate.Height;
            ds = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(ds, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            // Cập nhật lại giá trị chiều cao
            dataGridView1.Height = Height;

            footer  = new Bitmap(panel2.Width, panel2.Height);
            panel2.DrawToBitmap(footer , new Rectangle(0, 0, panel2.Width, panel2.Height));

            button1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaoPDF();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
