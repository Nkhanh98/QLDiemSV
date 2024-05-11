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
    public class KhoaHoc_DAO
    {
        static SqlConnection con;

        public static List<KhoaHoc_DTO> LayDSkhoahoc()
        {
            string sTruyVan = "SELECT * FROM KhoaHoc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<KhoaHoc_DTO> lstKhoaHoc = new List<DTO.KhoaHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoaHoc_DTO lo = new KhoaHoc_DTO();
                lo.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();
                lo.TenKhoaHoc1 = dt.Rows[i]["TenKhoaHoc"].ToString();




                lstKhoaHoc.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstKhoaHoc;
        }
    }
}
