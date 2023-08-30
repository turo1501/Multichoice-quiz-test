using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class BL_Lop
    {
        private DA_Lop objDA_Lop;

        public BL_Lop(string maLop)
        {
            objDA_Lop = new DA_Lop(maLop);
        }

        public BL_Lop(DataTable dt)
        {
            objDA_Lop = new DA_Lop(dt);
        }

        public BL_Lop()
        {
            objDA_Lop = new DA_Lop();
        }

        public DataTable getAllLop()
        {
            return objDA_Lop.getAllLop();
        }

        public DataTable getLop_cauTruc()
        {
            return objDA_Lop.getLop_cauTruc();
        }

        public DataTable getLop_theo_Ma()
        {
            return objDA_Lop.getLop_theo_Ma();
        }

        public int updateLop()
        {
            return objDA_Lop.updateLop();
        }
    }
}
