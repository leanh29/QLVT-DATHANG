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
    public partial class formrpNV : Form
    {
        public formrpNV()
        {
            InitializeComponent();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();

            }
            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Loi ket noi chi nhanh moi", "", MessageBoxButtons.OK);
            }
            else
            {
                
                this.sP_RP_NVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_RP_NVTableAdapter.Fill(this.DS.SP_RP_NV);
            }
            
        }

        private void formrpNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SP_RP_NV' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.sP_RP_NVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_RP_NVTableAdapter.Fill(this.DS.SP_RP_NV);
            // TODO: This line of code loads data into the 'dS.SP_RP_NHANVIEN' table. You can move, or remove it, as needed.
            
            
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            xrpNV rpt = new xrpNV();
            
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }
    }
}
