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
    public class HeDT_DAO
    {
        static SqlConnection con;

        public static List<HeDT_DTO> LayDShedt()
        {
            string sTruyVan = "SELECT * FROM HeDT";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HeDT_DTO> lstHeDT = new List<DTO.HeDT_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HeDT_DTO lo = new HeDT_DTO();
                lo.MaHeDT1 = dt.Rows[i]["MaHeDT"].ToString();
                lo.TenHeDT1 = dt.Rows[i]["TenHeDT"].ToString();




                lstHeDT.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstHeDT;
        }
    }
}
