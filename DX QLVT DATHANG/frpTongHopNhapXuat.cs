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
    public partial class frpTongHopNhapXuat : Form
    {
        public frpTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpFrom.Value.ToString("yyyy/MM/dd"));

            xrpTongHopNhatXuat rpt = new xrpTongHopNhatXuat(dtpFrom.Value.ToString("yyyy/MM/dd"), dtpTo.Value.ToString("yyyy/MM/dd"),Program.mGroup);
            rpt.lblTieuDe.Text = "TỔNG HỢP NHẬP XUẤT TỪ " +dtpFrom.Value.ToString("yyyy/MM/dd") + " ĐẾN "+dtpTo.Value.ToString("yyyy/MM/dd");
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }
    }
}
