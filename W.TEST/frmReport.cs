using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using CrystalDecisions.CrystalReports.Engine;

namespace W.TEST
{
    public partial class frmReport : Office2007Form
    {
        private dsReport ds;
        private int type;

        public frmReport(dsReport ds, int type)
        {
            InitializeComponent();
            this.ds = ds;
            this.type = type;
            //1: DS câu hỏi
            //2: 1 câu hỏi
            //3: DS sinh viên
            //4: 1 sinh viên
        }

        private void frmReport_CauHoi_Load(object sender, EventArgs e)
        {
            ReportClass r = null;
            switch (type)
            {
                case 1: r = new crpt_DSCauHoi(); break;
                case 2: r = new crpt_CauHoi(); break;
                case 3: r = new crpt_DSSinhVien(); break;
                default: r = new crpt_SinhVien(); break;
            }
            r.SetDataSource(ds);
            cRV.ReportSource = r;
        }
    }
}