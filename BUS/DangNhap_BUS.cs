using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static DangNhap_DTO DangNhap(string TaiKhoan, string MatKhau)
        {
            return DangNhap_DAO.DangNhap(TaiKhoan, MatKhau);
        }
    }
}
