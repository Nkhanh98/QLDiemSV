using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Collections;
using System.Drawing;
using System.Linq.Expressions;

namespace DAO
{

    public class SinhVien_DAO
    {
        static SqlConnection con;

        public static List<SinhVien_DTO> LayDSsinhvien()
        {
            string sTruyVan = "SELECT * FROM SinhVien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<SinhVien_DTO> lstSinhVien = new List<DTO.SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.MaSV1 = dt.Rows[i]["MaSV"].ToString();
                sv.TenSV1 = dt.Rows[i]["TenSV"].ToString();
                sv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                sv.QueQuan1 = dt.Rows[i]["QueQuan"].ToString();
                sv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                sv.MaKhoa1 = dt.Rows[i]["MaKhoa"].ToString();
                sv.MaHeDT1 = dt.Rows[i]["MaHeDT"].ToString();
                sv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();

                lstSinhVien.Add(sv);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstSinhVien;
        }
        public static bool ThemSV(SinhVien_DTO sv)
        {
            // Tạo chuỗi truy vấn để thêm sinh viên vào cơ sở dữ liệu
            string sTruyVan = string.Format(@"insert into SinhVien values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
                , sv.MaSV1,sv.TenSV1,sv.GioiTinh1,sv.NgaySinh1.Year+"-"+sv.NgaySinh1.Month+"-"+sv.NgaySinh1.Day,sv.QueQuan1,sv.MaLop1,sv.MaKhoa1,sv.MaHeDT1,sv.MaKhoaHoc1);
            // Mở kết nối đến cơ sở dữ liệu
            con = DataProvider.MoKetNoi();
                bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return ketqua;

        }

        public static bool CapNhatSV(SinhVien_DTO sv)
        {
            // Tạo chuỗi truy vấn để cập nhật thông tin của sinh viên trong cơ sở dữ liệu
            string sTruyVan = string.Format(@"UPDATE SinhVien 
                              SET TenSV = N'{0}', 
                                  GioiTinh =  N'{1}',
                                  NgaySinh =  N'{2}',
                                  QueQuan =  N'{3}',
                                    MaLop = N'{4}',
                                    MaKhoa = N'{5}',
                                    MaHeDT = N'{6}',
                                    MaKhoaHoc = N'{7}' 
                              WHERE MaSV = N'{8}'",
                 sv.TenSV1, sv.GioiTinh1, sv.NgaySinh1.Year + "-" + sv.NgaySinh1.Month + "-" + sv.NgaySinh1.Day, sv.QueQuan1, sv.MaLop1, sv.MaKhoa1, sv.MaHeDT1, sv.MaKhoaHoc1, sv.MaSV1);

            // Mở kết nối đến cơ sở dữ liệu
            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;
        }

        // Kiểm tra mã sinh viên có trong dữ lịệu không trước khi xóa

        public static bool KiemTra(string ma)
        {
            string sTruyVan = string.Format("SELECT * FROM SinhVien WHERE MaSV = N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable ketqua = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);

            // Kiểm tra số hàng trong bảng kết quả
            if (ketqua.Rows.Count > 0)
            {
                return true; // Trả về true nếu có ít nhất một hàng được trả về
            }
            return false; // Trả về false nếu không có hàng nào được trả về
        }

        public static bool XoaSV(SinhVien_DTO sv)
        {
            // Tạo chuỗi truy vấn để xóa sinh viên khỏi cơ sở dữ liệu
            bool kiemtra = KiemTra(sv.MaSV1);
            if(kiemtra == false)
            {
                return false;
            }
            else
            {
                string sTruyVan = string.Format("DELETE FROM SinhVien WHERE MaSV = N'{0}'", sv.MaSV1);

                // Mở kết nối đến cơ sở dữ liệu
                con = DataProvider.MoKetNoi();
                bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return ketqua;
            }
        }

        //Tìm sinh viên theo mã
        public static SinhVien_DTO TimSinhVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaSV = N'{0}'",ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.MaSV1 = dt.Rows[0]["MaSV"].ToString();
                sv.TenSV1 = dt.Rows[0]["TenSV"].ToString();
                sv.GioiTinh1 = dt.Rows[0]["GioiTinh"].ToString();
                sv.NgaySinh1 = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                sv.QueQuan1 = dt.Rows[0]["QueQuan"].ToString();
                sv.MaLop1 = dt.Rows[0]["MaLop"].ToString();
                sv.MaKhoa1 = dt.Rows[0]["MaKhoa"].ToString();
                sv.MaHeDT1 = dt.Rows[0]["MaHeDT"].ToString();
                sv.MaKhoaHoc1 = dt.Rows[0]["MaKhoaHoc"].ToString();

            DataProvider.DongKetNoi(con);
            return sv;
        }

        //Tìm sinh viên theo tên
        public static List<SinhVien_DTO> TimSinhVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where TenSV like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<DTO.SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.MaSV1 = dt.Rows[i]["MaSV"].ToString();
                sv.TenSV1 = dt.Rows[i]["TenSV"].ToString();
                sv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                sv.QueQuan1 = dt.Rows[i]["QueQuan"].ToString();
                sv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                sv.MaKhoa1 = dt.Rows[i]["MaKhoa"].ToString();
                sv.MaHeDT1 = dt.Rows[i]["MaHeDT"].ToString();
                sv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();


                lstSinhVien.Add(sv);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstSinhVien;

        }

        //Tìm sinh viên theo khoa
        public static List<SinhVien_DTO> TimSinhVienTheoKhoa(string khoa)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaKhoa = N'{0}'", khoa);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<DTO.SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.MaSV1 = dt.Rows[i]["MaSV"].ToString();
                sv.TenSV1 = dt.Rows[i]["TenSV"].ToString();
                sv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                sv.QueQuan1 = dt.Rows[i]["QueQuan"].ToString();
                sv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                sv.MaKhoa1 = dt.Rows[i]["MaKhoa"].ToString();
                sv.MaHeDT1 = dt.Rows[i]["MaHeDT"].ToString();
                sv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();


                lstSinhVien.Add(sv);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstSinhVien;

        }

        //Tìm sinh viên theo lớp
        public static List<SinhVien_DTO> TimSinhVienTheoLop(string lop)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaLop = N'{0}'", lop);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<DTO.SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.MaSV1 = dt.Rows[i]["MaSV"].ToString();
                sv.TenSV1 = dt.Rows[i]["TenSV"].ToString();
                sv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                sv.QueQuan1 = dt.Rows[i]["QueQuan"].ToString();
                sv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                sv.MaKhoa1 = dt.Rows[i]["MaKhoa"].ToString();
                sv.MaHeDT1 = dt.Rows[i]["MaHeDT"].ToString();
                sv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();


                lstSinhVien.Add(sv);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstSinhVien;

        }
    }
}   

