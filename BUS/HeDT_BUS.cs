using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HeDT_BUS
    {
        public static List<HeDT_DTO> LayDShedt()
        {
            return HeDT_DAO.LayDShedt();
        }
    }
}
