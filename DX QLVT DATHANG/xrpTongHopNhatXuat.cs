using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpTongHopNhatXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpTongHopNhatXuat( string begin, string end, string nhom)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_TongHopNhapXuatTableAdapter.Fill(ds1.SP_RP_TongHopNhapXuat, begin, end, nhom);
        }

    }
}
