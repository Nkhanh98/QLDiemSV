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
    public class Lop_DAO
    {
        static SqlConnection con;

        public static List<Lop_DTO> LayDSlop()
        {
            string sTruyVan = "SELECT * FROM Lop";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Lop_DTO> lstLop = new List<DTO.Lop_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Lop_DTO lo = new Lop_DTO();
                lo.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                lo.TenLop1 = dt.Rows[i]["TenLop"].ToString();




                lstLop.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstLop;
        }
    }
}
