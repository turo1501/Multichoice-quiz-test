using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace DataAccessTier
{
    public class DA_Admin : ConnectDB
    {
        private string id, pass;
        private DataTable dt;

        public DA_Admin(string id, string pass)
        {
            this.id = id;
            this.pass = pass;
        }

        public DA_Admin(DataTable dt)
        {
            this.dt = dt;
        }

        public DataTable getAdmin_theo_ID()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Login Where ID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", id);
            return getTable(cmd);
        }

        public bool trueLogin()
        {
            OleDbCommand cmd =
                new OleDbCommand("Select * From Login Where ID = @ID And Pass = @Password", connect);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ID", pass);
            return getTable(cmd).Rows.Count > 0;
        }

        public int updateAdmin()
        {
            return updateTable(new OleDbCommand("Select * From Login Where 1 = 2", connect), dt);
        }
    }
}
