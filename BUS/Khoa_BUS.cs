using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Khoa_BUS
    {
        public static List<Khoa_DTO> LayDSkhoa()
        {
            return Khoa_DAO.LayDSkhoa();
        }
    }
}
