using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace DataAccessTier
{
    public class DA_Chuong : ConnectDB
    {
        private DataTable dt;
        private int maChuong;

        public DA_Chuong(DataTable dt)
        {
            this.dt = dt;
        }

        public DA_Chuong(int maChuong)
        {
            this.maChuong = maChuong;
        }

        public DA_Chuong() { }

        public DataTable getAllChuong()
        {
            return getTable(new OleDbCommand("Select * From Chuong", connect));
        }

        public DataTable getChuong_cauTruc()
        {
            return getTable(new OleDbCommand("Select * From Chuong Where 1 = 2", connect));
        }

        public int updateChuong()
        {
            return updateTable(new OleDbCommand("Select * From Chuong Where 1 = 2", connect), dt);
        }

        public DataTable getChuong_theo_maChuong()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Chuong Where MaChuong = @MaChuong", connect);
            cmd.Parameters.AddWithValue("@MaChuong", maChuong);
            return getTable(cmd);
        }
    }
}
