using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SinhVien_BUS
    {
        public static List<SinhVien_DTO> LayDSsinhvien()
        {
            return SinhVien_DAO.LayDSsinhvien();
        }
        public static bool ThemSV(SinhVien_DTO sv)
        {
            return SinhVien_DAO.ThemSV(sv); 
        }
        public static bool CapNhatSV(SinhVien_DTO sv)
        {
            return SinhVien_DAO.CapNhatSV(sv);
        }
        public static bool XoaSV(SinhVien_DTO sv)
        {
            return SinhVien_DAO.XoaSV(sv);
        }
        public static SinhVien_DTO TimSinhVienTheoMa(string ma)
        {
            return SinhVien_DAO.TimSinhVienTheoMa(ma);
        }

        public static List<SinhVien_DTO> TimSinhVienTheoTen(string ten)
        {
            return SinhVien_DAO.TimSinhVienTheoTen(ten);
        }

        public static List<SinhVien_DTO> TimSinhVienTheoKhoa(string khoa)
        {
            return SinhVien_DAO.TimSinhVienTheoKhoa(khoa);
        }

        public static List<SinhVien_DTO> TimSinhVienTheoLop(string lop)
        {
            return SinhVien_DAO.TimSinhVienTheoLop(lop);
        }
    }
}
