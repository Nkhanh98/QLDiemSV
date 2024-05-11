using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DangKy_DAO
    {
        static SqlConnection con;
        public static bool DangKy(DangKy_DTO dk)
        {
            // Tạo chuỗi truy vấn để thêm môn học vào cơ sở dữ liệu
            string sTruyVan = string.Format(@"insert into NguoiDung values (N'{0}',N'{1}','{2}')", dk.TaiKhoan1, dk.MatKhau1, dk.MaQuyen1);

            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;
        }

        //Tìm tài khoản theo tên
        public static List<DangKy_DTO> TimTaiKhoan(string ten)
        {
            string sTruyVan = string.Format(@"select * from NguoiDung where TaiKhoan like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DangKy_DTO> lstTaikhoan = new List<DTO.DangKy_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DangKy_DTO sv = new DangKy_DTO();
                sv.TaiKhoan1 = dt.Rows[i]["TaiKhoan"].ToString();
                sv.MatKhau1 = dt.Rows[i]["MatKhau"].ToString();



                lstTaikhoan.Add(sv);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstTaikhoan;

        }
    }
}

