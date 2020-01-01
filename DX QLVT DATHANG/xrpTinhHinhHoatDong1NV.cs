using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DX_QLVT_DATHANG
{
    public partial class xrpTinhHinhHoatDong1NV : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpTinhHinhHoatDong1NV(int manv, string loai, string thangdau, string thangcuoi)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_RP_TinhHinhHoatDong1NhanVienTableAdapter.Fill(ds1.SP_RP_TinhHinhHoatDong1NhanVien, manv, loai, thangdau, thangcuoi);
        }

    }
}
