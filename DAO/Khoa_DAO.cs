using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Khoa_DAO
    {
        static SqlConnection con;

        public static List<Khoa_DTO> LayDSkhoa()
        {
            string sTruyVan = "SELECT * FROM Khoa";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Khoa_DTO> lstKhoa = new List<DTO.Khoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Khoa_DTO lo = new Khoa_DTO();
                lo.MaKhoa1 = dt.Rows[i]["MaKhoa"].ToString();
                lo.TenKhoa1 = dt.Rows[i]["TenKhoa"].ToString();




                lstKhoa.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstKhoa;
        }
    }
}
