using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DX_QLVT_DATHANG
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            loadStatus();
        }

        // kiem tra form da duoc mo chua
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                formDangNhap f = new formDangNhap ();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                formNhanVien f = new formNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void loadStatus()
        {
            ssMaNV.Text = "Mã Nhân Viên: " + Program.username + " ||  ";
            ssHoTen.Text = "Họ Tên: " + Program.mHoten + " ||  ";
            ssNhom.Text = "Nhóm: " + Program.mGroup + " ||  ";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDDH));
            if (frm != null) frm.Activate();
            else
            {
                formDDH f = new formDDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formVatTu));
            if (frm != null) frm.Activate();
            else
            {
                formVatTu f = new formVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuNhap f = new formPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKho));
            if (frm != null) frm.Activate();
            else
            {
                formKho f = new formKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuXuat f = new formPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xrpVATTU rpt = new xrpVATTU();
        //rpt.lblTieuDe.Text = ‘DANH SÁCH PHIẾU ‘ + cmbLoai.Text.ToUpper() + ‘ NHÂN VIÊN LẬP TRONG NĂM ‘ & cmbNam.Text;
        //rpt.lblHoTen.Text = cmbHoten.Text;
        ReportPrintTool print= new ReportPrintTool(rpt);
        
        print.ShowPreviewDialog();

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formrpNV));
            if (frm != null) frm.Activate();
            else
            {
                formrpNV f = new formrpNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpChiTietPhieuTrongKhoangTheoLoai));
            if (frm != null) frm.Activate();
            else
            {
                frpChiTietPhieuTrongKhoangTheoLoai f = new frpChiTietPhieuTrongKhoangTheoLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xrpDonDatHangChuaCoPhieuNhap rpt = new xrpDonDatHangChuaCoPhieuNhap(Program.mGroup);
            
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpTinhHinhHoatDong1NV));
            if (frm != null) frm.Activate();
            else
            {
                frpTinhHinhHoatDong1NV f = new frpTinhHinhHoatDong1NV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpTongHopNhapXuat));
            if (frm != null) frm.Activate();
            else
            {
                frpTongHopNhapXuat f = new frpTongHopNhapXuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
