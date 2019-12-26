using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpVATTU : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpVATTU()
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_VATTUTableAdapter1.Fill(ds1.SP_RP_VATTU);
        }

    }
}
