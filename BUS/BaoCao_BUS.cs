﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCao_BUS
    {
        public object LayDSBaoCao()
        {
            return BaoCao_DAO.LayDSBaoCao();
        }
    }
}
