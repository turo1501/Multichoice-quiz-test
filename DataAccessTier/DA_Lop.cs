using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace DataAccessTier
{
    public class DA_Lop : ConnectDB
    {
        private string maLop;
        private DataTable dt;

        public DA_Lop(string maLop)
        {
            this.maLop = maLop;
        }

        public DA_Lop(DataTable dt)
        {
            this.dt = dt;
        }

        public DA_Lop() { }

        public DataTable getAllLop()
        {
            return getTable(new OleDbCommand("Select * From Lop", connect));
        }

        public DataTable getLop_cauTruc()
        {
            return getTable(new OleDbCommand("Select * From Lop Where 1 = 2", connect));
        }

        public DataTable getLop_theo_Ma()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Lop Where MaLop = @MaLop", connect);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            return getTable(cmd);
        }

        public int updateLop()
        {
            return updateTable(new OleDbCommand("Select * From Lop Where 1 = 2", connect), dt);
        }
    }
}
