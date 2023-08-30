using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class BL_Admin
    {
        private DA_Admin objDA_Admin;

        public BL_Admin(string id, string pass)
        {
            objDA_Admin = new DA_Admin(id, pass);
        }

        public BL_Admin(DataTable dt)
        {
            objDA_Admin = new DA_Admin(dt);
        }

        public DataTable getAdmin_theo_ID()
        {
            return objDA_Admin.getAdmin_theo_ID();
        }

        public bool trueLogin()
        {
            return objDA_Admin.trueLogin();
        }

        public int updateAdmin()
        {
            return objDA_Admin.updateAdmin();
        }
    }
}
