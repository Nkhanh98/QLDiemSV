using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien_DTO
    {
        private string MaSV;
        private string TenSV;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string QueQuan;

        private string MaLop;
        private string MaHeDT;
        private string MaKhoa;
        private string MaKhoaHoc;

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string MaHeDT1 { get => MaHeDT; set => MaHeDT = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string MaKhoaHoc1 { get => MaKhoaHoc; set => MaKhoaHoc = value; }
    }
}
