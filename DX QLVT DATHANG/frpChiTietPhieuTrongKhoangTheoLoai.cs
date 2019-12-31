using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_QLVT_DATHANG
{
    public partial class frpChiTietPhieuTrongKhoangTheoLoai : Form
    {
        string nhom;
        string loai;
        int thangdau;
        int thangcuoi;
        public frpChiTietPhieuTrongKhoangTheoLoai()
        {
            InitializeComponent();
        }

        private void frpChiTietPhieuTrongKhoangTheoLoai_Load(object sender, EventArgs e)
        {
            //nhom = Program.mGroup;
            ////loai = "N";
            //thangdau = dtpFrom.Value.Month;
            //thangcuoi = dtpTo.Value.Month;

            //MessageBox.Show(nhom + loai + thangdau + thangcuoi);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nhom + loai + thangdau + thangcuoi);
            xrpChiTietPhieuTrongKhoangTheoLoai rpt = new xrpChiTietPhieuTrongKhoangTheoLoai(cmbLoaiPhieu.Text.Substring(0, 1), dtpFrom.Value.Month, dtpTo.Value.Month, Program.mGroup);

            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }
    }
}
