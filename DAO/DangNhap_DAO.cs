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
    public  class DangNhap_DAO
    {
        static SqlConnection con;
        public static DangNhap_DTO DangNhap(string TaiKhoan, string MatKhau)
        {
            string query = string.Format(@"select *from NguoiDung where TaiKhoan = N'{0}' and MatKhau = N'{1}' ", TaiKhoan, MatKhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DangNhap_DTO tk = new DangNhap_DTO();
            tk.TaiKhoan1 = dt.Rows[0]["TaiKhoan"].ToString();
            tk.MatKhau1 = dt.Rows[0]["MatKhau"].ToString();
            tk.MaQuyen1 = int.Parse(dt.Rows[0]["MaQuyen"].ToString());
            DataProvider.DongKetNoi(con);
            return tk;
        }
    }
}
