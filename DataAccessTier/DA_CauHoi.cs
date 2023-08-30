using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using DataTransferObject;

namespace DataAccessTier
{
    public class DA_CauHoi : ConnectDB
    {
        private int chuong;
        private DataTable dt;
        private TimKiemCauHoi thongTin;
        private string maCauHoi;

        public DA_CauHoi(int chuong)
        {
            this.chuong = chuong;
        }

        public DA_CauHoi(DataTable dt)
        {
            this.dt = dt;
        }

        public DA_CauHoi(TimKiemCauHoi thongTin)
        {
            this.thongTin = thongTin;
        }

        public DA_CauHoi(string maCauHoi)
        {
            this.maCauHoi = maCauHoi;
        }

        public DA_CauHoi() { }

        public DataTable getCauHois()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From CauHoi Where Chuong <= @Chuong", connect);
            cmd.Parameters.AddWithValue("@Chuong", chuong);
            return getTable(cmd);
        }

        public DataTable getCauHoi_cauTruc()
        {
            return getTable(new OleDbCommand("Select * From CauHoi Where 1 = 2", connect));
        }
        //Download source code tại Sharecode.vn
        public DataTable getCauHois_theoChuong()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From CauHoi Where Chuong = @Chuong", connect);
            cmd.Parameters.AddWithValue("@Chuong", chuong);
            return getTable(cmd);
        }

        public DataTable timKiem()
        {
            StringBuilder condition = new StringBuilder();
            if (!thongTin.KeyCauHoi.Equals(""))
            {
                if (thongTin.KeyCauHoi[0].Equals('\"') && thongTin.KeyCauHoi[thongTin.KeyCauHoi.Length - 1].Equals('\"'))
                {
                    thongTin.KeyCauHoi = thongTin.KeyCauHoi.Substring(1, thongTin.KeyCauHoi.Length - 2);
                    condition.Append("CauHoi = @keyCauHoi");
                }
                else condition.Append("(CauHoi Like '%' + @keyCauHoi Or CauHoi Like '%' + @keyCauHoi + '%' Or CauHoi Like @keyCauHoi + '%')");
            }
            if (!thongTin.KeyDapAn.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                if (thongTin.DapAn.Equals(""))
                {
                    condition.Append("(");
                    bool type = thongTin.KeyDapAn[0].Equals('\"') && thongTin.KeyDapAn[thongTin.KeyDapAn.Length - 1].Equals('\"');
                    if (type) thongTin.KeyDapAn = thongTin.KeyDapAn.Substring(1, thongTin.KeyDapAn.Length - 2);
                    for (char c = 'A'; c <= 'D'; c++)
                    {
                        if (type) condition.Append("(" + c + " = @keyDapAn And DapAn = '" + c + "')");
                        else condition.Append("((" + c + " Like '%' + @keyDapAn Or " + c + " Like '%' + @keyDapAn + '%' Or " +
                            c + " Like @keyDapAn + '%') And DapAn = '" + c + "')");
                        if (!c.Equals('D')) condition.Append(" Or ");
                        else condition.Append(")");
                    }
                }
                else
                {
                    if (thongTin.KeyDapAn[0].Equals('\"') && thongTin.KeyDapAn[thongTin.KeyDapAn.Length - 1].Equals('\"'))
                    {
                        thongTin.KeyDapAn = thongTin.KeyDapAn.Substring(1, thongTin.KeyDapAn.Length - 2);
                        condition.Append("(" + thongTin.KeyDapAn + " = @keyDapAn And DapAn = @dapAn)");
                    }
                    else condition.Append("((" + thongTin.DapAn + " Like '%' + @keyDapAn Or " + thongTin.DapAn +
                        " Like '%' + @keyDapAn + '%' Or " + thongTin.DapAn + " Like @keyDapAn + '%') And DapAn = @dapAn)");
                }
            }
            else if (!thongTin.DapAn.Equals(""))
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("DapAn = @dapAn");
            }
            if (thongTin.MaChuong != 0)
            {
                if (!condition.ToString().Equals("")) condition.Append(" And ");
                condition.Append("Chuong = @chuong");
            }
            OleDbCommand cmd = new OleDbCommand("Select * From CauHoi Where " + condition, connect);
            if (condition.ToString().Contains("@keyCauHoi")) cmd.Parameters.AddWithValue("@keyCauHoi", thongTin.KeyCauHoi);
            if (condition.ToString().Contains("@keyDapAn"))
            {
                cmd.Parameters.AddWithValue("@keyDapAn", thongTin.KeyDapAn);
                if (!thongTin.DapAn.Equals("")) cmd.Parameters.AddWithValue("@dapAn", thongTin.DapAn);
            }
            else if (condition.ToString().Contains("@dapAn")) cmd.Parameters.AddWithValue("@dapAn", thongTin.DapAn);
            cmd.Parameters.AddWithValue("@chuong", thongTin.MaChuong);
            return getTable(cmd);
        }

        public DataTable getCauHoi_theoMa()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From CauHoi Where MaCauHoi = @MaCauHoi", connect);
            cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
            return getTable(cmd);
        }
        //Download source code tại Sharecode.vn
        public int updateCauHoi()
        {
            return updateTable(new OleDbCommand("Select * From CauHoi Where 1 = 2", connect), dt);
        }

        public DataTable getAllCauHoi()
        {
            return getTable(new OleDbCommand("Select * From CauHoi", connect));
        }
    }
}
