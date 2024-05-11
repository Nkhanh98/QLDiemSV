using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DangKy_BUS
    {
        public static bool DangKy(DangKy_DTO dk)
        {
            return DangKy_DAO.DangKy(dk);
        }
        public static List<DangKy_DTO> TimTaiKhoan(string ten)
        {
            return DangKy_DAO.TimTaiKhoan(ten);
        }
    }
}
