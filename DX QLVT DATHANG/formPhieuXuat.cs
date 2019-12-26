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
    public partial class formPhieuXuat : Form
    {
        Boolean flag = true;
        int vitri = 0;
        Boolean flag1 = true;
        public formPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.DSNhanVien' table. You can move, or remove it, as needed.
            
            DS.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);
            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CongTy")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnSua.Enabled = false;
            }

            else cmbChiNhanh.Enabled = false;
            panelControl1.Enabled = false;
            //gcPN.Click = true;
            foreach (DataGridViewRow row in gvCTPX.Rows)
            {
                row.ReadOnly = true;
            }
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
                // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.DS.CTPX);
                // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            }
        }

        private void cmbHOTEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMANV.Text = cmbHOTEN.SelectedValue.ToString();
            }
            catch (Exception er) { }
        }

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
            catch(Exception ex){

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = true;
            bdsPX.AddNew();
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            gcPX.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsPX.EndEdit();
                bdsPX.ResetCurrentItem();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
                MessageBox.Show("Ghi đơn đặt hàng thành công");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn đặt hàng" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsCTPX.AddNew();
            vitri = bdsCTPX.Position;
            string vt = vitri.ToString();
            gvCTPX.Rows[vitri].ReadOnly = false;
            flag1 = true;
        }

        private void ghiVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                vitri = bdsCTPX.Position;
                if (gvCTPX.Rows[vitri].Cells[2].Value == DBNull.Value)
                {
                    MessageBox.Show("Vật tư không được để trống");
                    return;
                }
            }
            try
            {
                bdsCTPX.EndEdit();
                bdsCTPX.ResetCurrentItem();
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Update(this.DS.CTPX);
                MessageBox.Show("Ghi vật tư vào đơn đặt hàng thành công");
                //string s = cmbMAVT.
                return;
            }
            catch (Exception ee)
            {

                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Vật tư đã tồn tại trong đơn đặt hàng");
                    return;
                }
                MessageBox.Show("lỗi ghi vât tư" + ee.Message);
            }
        }
    }
}
