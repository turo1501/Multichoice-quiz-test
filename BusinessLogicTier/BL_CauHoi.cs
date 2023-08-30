using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessTier;
using DataTransferObject;

namespace BusinessLogicTier
{
    public class BL_CauHoi
    {
        private DA_CauHoi objDA_CauHoi;

        public BL_CauHoi(int chuong)
        {
            objDA_CauHoi = new DA_CauHoi(chuong);
        }

        public BL_CauHoi(DataTable dt)
        {
            objDA_CauHoi = new DA_CauHoi(dt);
        }

        public BL_CauHoi(TimKiemCauHoi thongTin)
        {
            objDA_CauHoi = new DA_CauHoi(thongTin);
        }

        public BL_CauHoi(string maCauHoi)
        {
            objDA_CauHoi = new DA_CauHoi(maCauHoi);
        }

        public BL_CauHoi()
        {
            objDA_CauHoi = new DA_CauHoi();
        }

        public DataTable getCauHois()
        {
            return objDA_CauHoi.getCauHois();
        }

        public DataTable getCauHoi_cauTruc()
        {
            return objDA_CauHoi.getCauHoi_cauTruc();
        }

        public DataTable getCauHois_theoChuong()
        {
            return objDA_CauHoi.getCauHois_theoChuong();
        }

        public DataTable timKiem()
        {
            return objDA_CauHoi.timKiem();
        }

        public DataTable getCauHoi_theoMa()
        {
            return objDA_CauHoi.getCauHoi_theoMa();
        }

        public int updateCauHoi()
        {
            return objDA_CauHoi.updateCauHoi();
        }

        public DataTable getAllCauHoi()
        {
            return objDA_CauHoi.getAllCauHoi();
        }
    }
}
