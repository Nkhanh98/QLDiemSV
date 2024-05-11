using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHoc_BUS
    {
        public static List<MonHoc_DTO> LayDSmonhoc()
        {
            return MonHoc_DAO.LayDSmonhoc();
        }

        public static List<MonHoc_DTO> TimTheoMaMon(string mamon)
        {
            return MonHoc_DAO.TimTheoMaMon(mamon);
        }

        public static List<MonHoc_DTO> TimTheoTenMon(string ten)
        {
            return MonHoc_DAO.TimTheoTenMon(ten);
        }

        public static bool ThemMon(MonHoc_DTO mo)
        {
            return MonHoc_DAO.ThemMon(mo);
        }
        public static bool CapNhatMon(MonHoc_DTO mo)
        {
            return MonHoc_DAO.CapNhatMon(mo);
        }
        public static bool XoaMon(MonHoc_DTO mo)
        {
            return MonHoc_DAO.XoaMon(mo);
        }
    }
}
