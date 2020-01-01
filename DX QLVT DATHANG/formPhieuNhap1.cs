using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_QLVT_DATHANG
{
    public partial class formPhieuNhap1 : Form
    {
        Boolean flag = true;
        int vitri = 0;
        Boolean flag1 = true;
        public formPhieuNhap1()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formPhieuNhap1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'DS.DSNhanVien' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
           
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            //this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.khoTableAdapter.Fill(this.DS.Kho);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.

            
            // TODO: This line of code loads data into the 'DS.DSNhanVien' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
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
            foreach (DataGridViewRow row in gvCTPN.Rows)
            {
                row.ReadOnly = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'DS.DSNhanVien' table. You can move, or remove it, as needed.
                //this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.khoTableAdapter.Fill(this.DS.Kho);

                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);
                // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.DS.CTPN);
                // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            bdsPN.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            gcPN.Enabled = false;
            flag = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                MessageBox.Show("Ghi đơn đặt hàng thành công");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn đặt hàng" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cmbHOTEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMANV.Text = cmbHOTEN.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsCTPN.AddNew();
            vitri = bdsCTPN.Position;
            string vt = vitri.ToString();
            gvCTPN.Rows[vitri].ReadOnly = false;
            flag1 = true;
        }

        private void ghiVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(gvCTPN.Rows[vitri].Cells[1].Value.ToString());
            if (flag1 == true)
            {
                vitri = bdsCTPN.Position;
                if (gvCTPN.Rows[vitri].Cells[1].Value == DBNull.Value)
                {
                    MessageBox.Show("Vật tư không được để trống");
                    return;
                }
            }
            if (flag1 == true)
            {
                vitri = bdsCTPN.Position;
                if (gvCTPN.Rows[vitri].Cells[2].Value == DBNull.Value)
                {
                    MessageBox.Show("Số lượng không được để trống");
                    return;
                }
            }
            try
            {
                String str = "dbo.SP_DS_VatTuTheoDDH";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = str;
                Program.sqlcmd.Parameters.Add("@maddh", SqlDbType.Char).Value = cmbMADDH.Text;
                Program.sqlcmd.Parameters.Add("@vt", SqlDbType.Char).Value = gvCTPN.Rows[vitri].Cells[1].Value.ToString();
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
                if (ret == "1")
                {
                    MessageBox.Show("Vật tư chưa được đặt hàng trước");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kiểm tra vật tư " + ex.Message);
            }
            try
            {
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Update(this.DS.CTPN);
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

        private void sửaVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsCTPN.Position;
            gvCTPN.Rows[vitri].ReadOnly = false;
            flag1 = false;
        }
    }
}
