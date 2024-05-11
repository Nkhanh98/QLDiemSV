using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Diem_BUS
    {
        public static List<Diem_DTO> LayDSdiem()
        {
            return Diem_DAO.LayDSdiem();
        }
        public static List<Diem_DTO> TimTheoMon(string mon)
        {
            return Diem_DAO.TimTheoMon(mon);
        }
        public static Diem_DTO TimTheoMa(string ma)
        {
            return Diem_DAO.TimTheoMa(ma);
        }
        public static bool ThemThongTinDiem(Diem_DTO di)
        {
            return Diem_DAO.ThemThongTinDiem(di);
        }
        public static bool CapNhatDiem(Diem_DTO di)
        {
            return Diem_DAO.CapNhatDiem(di);
        }
        public static bool XoaDiem(Diem_DTO di)
        {
            return Diem_DAO.XoaDiem(di);
        }
    }
}
