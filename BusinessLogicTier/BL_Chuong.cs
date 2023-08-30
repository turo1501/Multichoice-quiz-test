using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class BL_Chuong
    {
        private DA_Chuong objDA_Chuong;

        public BL_Chuong(DataTable dt)
        {
            objDA_Chuong = new DA_Chuong(dt);
        }

        public BL_Chuong(int maChuong)
        {
            objDA_Chuong = new DA_Chuong(maChuong);
        }

        public BL_Chuong()
        {
            objDA_Chuong = new DA_Chuong();
        }

        public DataTable getAllChuong()
        {
            return objDA_Chuong.getAllChuong();
        }
        //Download source code tại Sharecode.vn
        public DataTable getChuong_cauTruc()
        {
            return objDA_Chuong.getChuong_cauTruc();
        }

        public int updateChuong()
        {
            return objDA_Chuong.updateChuong();
        }

        public DataTable getChuong_theo_maChuong()
        {
            return objDA_Chuong.getChuong_theo_maChuong();
        }
    }
}
