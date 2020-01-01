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
    public partial class frpTinhHinhHoatDong1NV : Form
    {
        public frpTinhHinhHoatDong1NV()
        {
            InitializeComponent();
        }

        private void frmTinhHinhHoatDong1NV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSNhanVien' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
        }

        private void cmbHOTEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMANV.Text = cmbHOTEN.SelectedValue.ToString();
            }
            catch (Exception) { }
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
                DS.EnforceConstraints = false;
                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);


                //maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToInt16(txtMANV.Text)+ cmbLoaiPhieu.Text.Substring(0, 1) + String.Format("{0:yyyy/MM/dd}", dtpFrom) + String.Format("{0:yyyy/MM/dd}", dtpTo));
            MessageBox.Show(dtpFrom.Value.ToString("yyyy/MM/dd"));
            xrpTinhHinhHoatDong1NV rpt = new xrpTinhHinhHoatDong1NV(Convert.ToInt16(txtMANV.Text), cmbLoaiPhieu.Text.Substring(0, 1), dtpFrom.Value.ToString("yyyy/MM/dd"), dtpTo.Value.ToString("yyyy/MM/dd"));

            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }
    }
}
