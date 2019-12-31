using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpDonDatHangChuaCoPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpDonDatHangChuaCoPhieuNhap(string nhom)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_DonDatHangChuaCoPhieuNhapTableAdapter1.Fill(ds1.SP_RP_DonDatHangChuaCoPhieuNhap, nhom);
        }

    }
}
