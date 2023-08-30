using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace DataAccessTier
{
    public class ConnectDB
    {
        protected OleDbConnection connect =
            new OleDbConnection("Provider = Microsoft.Jet.OleDb.4.0; Data Source = database/db.mdb");

        protected DataTable getTable(OleDbCommand cmd)
        {
            DataTable dt = new DataTable();
            new OleDbDataAdapter(cmd).Fill(dt);
            return dt;
        }

        protected int updateTable(OleDbCommand cmd, DataTable dt)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            new OleDbCommandBuilder(da);
            return da.Update(dt);
        }
    }
}
