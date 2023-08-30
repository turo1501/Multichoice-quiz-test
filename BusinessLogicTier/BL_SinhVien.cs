using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessTier;
using DataTransferObject;

namespace BusinessLogicTier
{
    public class BL_SinhVien
    {
        private DA_SinhVien objDA_SinhVien;

        public BL_SinhVien(string mSSV, string lop)
        {
            objDA_SinhVien = new DA_SinhVien(mSSV, lop);
        }

        public BL_SinhVien(string mSSV)
        {
            objDA_SinhVien = new DA_SinhVien(mSSV);
        }

        public BL_SinhVien(DataTable dt)
        {
            objDA_SinhVien = new DA_SinhVien(dt);
        }

        public BL_SinhVien(TimKiemSinhVien thongTin)
        {
            objDA_SinhVien = new DA_SinhVien(thongTin);
        }

        public BL_SinhVien()
        {
            objDA_SinhVien = new DA_SinhVien();
        }

        public bool trueLogin()
        {
            return objDA_SinhVien.trueLogin();
        }

        public DataTable getThongTin()
        {
            return objDA_SinhVien.getThongTin();
        }

        public DataTable getAllSinhVien()
        {
            return objDA_SinhVien.getAllSinhVien();
        }

        public DataTable getSinhVien_cauTruc()
        {
            return objDA_SinhVien.getSinhVien_cauTruc();
        }

        public DataTable getSinhVien_theo_Lop()
        {
            return objDA_SinhVien.getSinhVien_thep_Lop();
        }

        public DataTable getSinhVien_theo_Ma()
        {
            return objDA_SinhVien.getSinhVien_theo_Ma();
        }

        public int updateSinhVien()
        {
            return objDA_SinhVien.updateSinhVien();
        }

        public DataTable timKiem()
        {
            return objDA_SinhVien.timKiem();
        }
    }
}
