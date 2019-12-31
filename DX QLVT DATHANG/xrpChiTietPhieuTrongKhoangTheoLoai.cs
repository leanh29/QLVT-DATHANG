using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpChiTietPhieuTrongKhoangTheoLoai : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpChiTietPhieuTrongKhoangTheoLoai (string loai, int thangdau, int thangcuoi, string nhom)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_ChiTietPhieuTrongKhoangTheoLoaiTableAdapter.Fill(ds1.SP_RP_ChiTietPhieuTrongKhoangTheoLoai, loai, thangdau, thangcuoi, nhom);
        }

    }
}
