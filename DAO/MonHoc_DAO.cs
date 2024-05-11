using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHoc_DAO
    {
        static SqlConnection con;
        public static List<MonHoc_DTO> LayDSmonhoc()
        {
            string sTruyVan = "SELECT * FROM MonHoc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<MonHoc_DTO> lstMonHoc = new List<DTO.MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO lo = new MonHoc_DTO();
                lo.MaMH1 = dt.Rows[i]["MaMH"].ToString();
                lo.TenMH1 = dt.Rows[i]["TenMH"].ToString();
                lo.SoTrinh1 = int.Parse(dt.Rows[i]["SoTrinh"].ToString());

                lstMonHoc.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstMonHoc;
        }

        // Tìm theo Mã môn học
        public static List<MonHoc_DTO> TimTheoMaMon(string mamon)
        {
            string sTruyVan = string.Format(@"select * from MonHoc where MaMH = N'{0}'", mamon);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMamon = new List<DTO.MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO lo = new MonHoc_DTO();
                var row = dt.Rows[i];
                lo.MaMH1 = dt.Rows[i]["MaMH"].ToString();
                lo.TenMH1 = dt.Rows[i]["TenMH"].ToString();
                lo.SoTrinh1 = int.Parse(dt.Rows[i]["SoTrinh"].ToString());


                lstMamon.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstMamon;

        }

        // Tìm theo tên môn học
        public static List<MonHoc_DTO> TimTheoTenMon(string ten)
        {
            string sTruyVan = string.Format(@"select * from MonHoc where TenMH like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstTenmon = new List<DTO.MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO lo = new MonHoc_DTO();
                var row = dt.Rows[i];
                lo.MaMH1 = dt.Rows[i]["MaMH"].ToString();
                lo.TenMH1 = dt.Rows[i]["TenMH"].ToString();
                lo.SoTrinh1 = int.Parse(dt.Rows[i]["SoTrinh"].ToString());


                lstTenmon.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstTenmon;

        }

        // --------------------------Thêm thông tin môn học--------------------------------------
        public static bool ThemMon(MonHoc_DTO mo)
        {
            // Tạo chuỗi truy vấn để thêm môn học vào cơ sở dữ liệu
            string sTruyVan = string.Format(@"insert into MonHoc values (N'{0}',N'{1}','{2}')", mo.MaMH1, mo.TenMH1, mo.SoTrinh1);

            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;

        }


        // --------------------------------Sửa thông tin----------------------------------
        public static bool CapNhatMon(MonHoc_DTO mo)
        {
            // Tạo chuỗi truy vấn để cập nhật thông tin trong cơ sở dữ liệu
            string sTruyVan = string.Format(@"UPDATE MonHoc 
                              SET TenMH = N'{0}', 
                                  SoTrinh =  '{1}'
                              WHERE MaMH = N'{2}'", mo.TenMH1, mo.SoTrinh1, mo.MaMH1);

            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;
        }

        // Kiểm tra mã môn học có trong dữ lịệu không trước khi xóa
        public static bool KiemTra(string ma)
        {
            string sTruyVan = string.Format("SELECT * FROM MonHoc WHERE MaMH = N'{0}'", ma);
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
        //-----------------------------Xóa--------------------------------------------------------------
        public static bool XoaMon(MonHoc_DTO mo)
        {
            // Tạo chuỗi truy vấn để xóa khỏi cơ sở dữ liệu
            
                string sTruyVan = string.Format("DELETE FROM MonHoc WHERE MaMH = N'{0}'", mo.MaMH1);

                con = DataProvider.MoKetNoi();
                bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return ketqua;
            
        }
    }
}
