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
    public partial class formrpVATU : Form
    {
        public formrpVATU()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            xrpVATTU rpt = new xrpVATTU();
            //rpt.lblTieuDe.Text = ‘DANH SÁCH PHIẾU ‘ + cmbLoai.Text.ToUpper() + ‘ NHÂN VIÊN LẬP TRONG NĂM ‘ & cmbNam.Text;
            //rpt.lblHoTen.Text = cmbHoten.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }
    }
}
