using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpNV : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpNV()
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_NVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_RP_NVTableAdapter1.Fill(ds1.SP_RP_NV);

        }

    }
}
