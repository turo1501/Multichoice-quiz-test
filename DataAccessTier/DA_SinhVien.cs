using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using DataTransferObject;

namespace DataAccessTier
{
    public class DA_SinhVien : ConnectDB
    {
        private string mSSV, lop;
        private DataTable dt;
        private TimKiemSinhVien thongTin;

        public DA_SinhVien(string mSSV, string lop)
        {
            this.mSSV = mSSV;
            this.lop = lop;
        }

        public DA_SinhVien(string mSSV)
        {
            this.mSSV = mSSV;
        }

        public DA_SinhVien(TimKiemSinhVien thongTin)
        {
            this.thongTin = thongTin;
        }

        public DA_SinhVien(DataTable dt)
        {
            this.dt = dt;
        }

        public DA_SinhVien() { }

        public bool trueLogin()
        {
            OleDbCommand cmd =
                new OleDbCommand("Select * From SinhVien Where MSSV = @MSSV And Lop = @Lop", connect);
            cmd.Parameters.AddWithValue("@MSSV", mSSV);
            cmd.Parameters.AddWithValue("@Lop", lop);
            return getTable(cmd).Rows.Count == 1;
        }

        public DataTable getThongTin()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT SinhVien.HoDem, SinhVien.Ten, Lop.TenLop FROM Lop INNER JOIN SinhVien ON Lop.MaLop = SinhVien.Lop Where MSSV = @MSSV", connect);
            cmd.Parameters.AddWithValue("@MSSV", mSSV);
            return getTable(cmd);
        }

        public DataTable getAllSinhVien()
        {
            return getTable(new OleDbCommand("Select * From SinhVien", connect));
        }

        public DataTable getSinhVien_cauTruc()
        {
            return getTable(new OleDbCommand("Select * From SinhVien Where 1 = 2", connect));
        }

        public DataTable getSinhVien_thep_Lop()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From SinhVien Where Lop = @Lop", connect);
            cmd.Parameters.AddWithValue("@Lop", lop);
            return getTable(cmd);
        }

        public DataTable getSinhVien_theo_Ma()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From SinhVien Where MSSV = @MSSV", connect);
            cmd.Parameters.AddWithValue("@MSSV", mSSV);
            return getTable(cmd);
        }

        public int updateSinhVien()
        {
            return updateTable(new OleDbCommand("Select * From SinhVien Where 1 = 2", connect), dt);
        }

        public DataTable timKiem()
        {
            StringBuilder condition = new StringBuilder();
            if (!thongTin.MSSV.Equals(""))
            {
                if (thongTin.MSSV[0].Equals('\"') && thongTin.MSSV[thongTin.MSSV.Length - 1].Equals('\"'))
                {
                    thongTin.MSSV = thongTin.MSSV.Substring(1, thongTin.MSSV.Length - 2);
                    condition.Append("MSSV = @MSSV");
                }
                else condition.Append("(MSSV Like '%' + @MSSV Or MSSV Like '%' + @MSSV + '%' Or MSSV Like @MSSV + '%')");
            }
            if (!thongTin.HoDem.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                if (thongTin.HoDem[0].Equals('\"') && thongTin.HoDem[thongTin.HoDem.Length - 1].Equals('\"'))
                {
                    thongTin.HoDem = thongTin.HoDem.Substring(1, thongTin.HoDem.Length - 2);
                    condition.Append("HoDem = @HoDem");
                }
                else condition.Append("(HoDem Like '%' + @HoDem Or HoDem Like '%' + @HoDem + '%' Or HoDem Like @HoDem + '%')");
            }
            if (!thongTin.Ten.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                if (thongTin.Ten[0].Equals('\"') && thongTin.Ten[thongTin.Ten.Length - 1].Equals('\"'))
                {
                    thongTin.Ten = thongTin.Ten.Substring(1, thongTin.Ten.Length - 2);
                    condition.Append("Ten = @Ten");
                }
                else condition.Append("(Ten Like '%' + @Ten Or Ten Like '%' + @Ten + '%' Or Ten Like @Ten + '%')");
            }
            if (!thongTin.MaLop.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("Lop = @Lop");
            }
            if (thongTin.NgaySinh != new DateTime())
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("NgaySinh = @NgaySinh");
            }
            if (thongTin.GioiTinh != 0)
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("GioiTinh = @GioiTinh");
            }
            if (!thongTin.DiaChi.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("(DiaChi Like '%' + @DiaChi Or DiaChi Like '%' + @DiaChi + '%' Or DiaChi Like @DiaChi + '%')");
            }
            OleDbCommand cmd = new OleDbCommand("Select * From SinhVien Where " + condition, connect);
            if(condition.ToString().Contains("@MSSV"))
                cmd.Parameters.AddWithValue("@MSSV", thongTin.MSSV);
            if (condition.ToString().Contains("@HoDem"))
                cmd.Parameters.AddWithValue("@HoDem", thongTin.HoDem);
            if (condition.ToString().Contains("@Ten"))
                cmd.Parameters.AddWithValue("@Ten", thongTin.Ten);
            if (condition.ToString().Contains("@Lop"))
                cmd.Parameters.AddWithValue("@Lop", thongTin.MaLop);
            if (condition.ToString().Contains("@NgaySinh"))
                cmd.Parameters.AddWithValue("@NgaySinh", thongTin.NgaySinh);
            if (condition.ToString().Contains("@GioiTinh"))
                cmd.Parameters.AddWithValue("@GioiTinh", thongTin.GioiTinh == 1 ? true : false);
            cmd.Parameters.AddWithValue("@DiaChi", thongTin.DiaChi);
            return getTable(cmd);
        }
    }
}
