﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Lop_BUS
    {
            public static List<Lop_DTO> LayDSlop()
            {
                return Lop_DAO.LayDSlop();
            }
       
    }
}
