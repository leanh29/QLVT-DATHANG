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
    public partial class formDDH : Form
    {
        int vitri = 0;
        string maCN = "";
        string maNV = "";
        Boolean flag = true;
        Boolean flag1 = true;
        public formDDH()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formDDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            
            DS.EnforceConstraints = false;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;

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
            foreach (DataGridViewRow row in gvCTDDH.Rows)
            {
                row.ReadOnly = true;
            }
        }

        private void mANVLabel_Click(object sender, EventArgs e)
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
                // TODO: This line of code loads data into the 'dS.DSNhanVien' table. You can move, or remove it, as needed.
                this.vattuTableAdapter.Fill(this.DS.Vattu);

                this.khoTableAdapter.Fill(this.DS.Kho);
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

                // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                //DS.EnforceConstraints = false;
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
            }
        }

        private void mANVTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbHOTEN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = cmbHOTEN.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            bdsDDH.AddNew();
            //txtmaCN.Text = maCN;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            //btnGhi.Enabled = btnUndo.Enabled = true;
            //txtmaCN.Enabled = false;
            gcDatHang.Enabled = false;
            flag = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = false;
            panelControl1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMADDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã số đơn dặt hàng không được để trống!");
                txtMADDH.Focus();
                return;
            }
            if (tpNGAY.Text ==null)
            {
                MessageBox.Show("Ngày không được bỏ trống");
                tpNGAY.Focus();
                return;
            }
            if (txtNCC.Text.Trim() == "")
            {
                MessageBox.Show("Nhà cung cấp không được để trống!");
                txtNCC.Focus();
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã Nhân viên không được để trống!");
                txtMaNV.Focus();
                return;
            }
            if (flag == true)
            {
                try
                {
                    String str = "dbo.SP_CHECKTRUNGDDH";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = str;
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.NChar).Value = txtMADDH.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.NChar).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        MessageBox.Show("Mã nhân viên bị trùng");
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsDDH.EndEdit();
                            bdsDDH.ResetCurrentItem();
                            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.datHangTableAdapter.Update(this.DS.DatHang);
                            MessageBox.Show("Ghi đơn đặt hàng thành công");
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi đơn đặt hàng" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Lỗi kiểm tra đơn đặt hàng.\n" + e2.Message, "", MessageBoxButtons.OK);
                }

            }
            else
            {
                try
                {
                    bdsDDH.EndEdit();
                    bdsDDH.ResetCurrentItem();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);
                    MessageBox.Show("Ghi đơn đặt hàng thành công");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi đơn đặt hàng" + ex.Message, "", MessageBoxButtons.OK);
                }
            }  
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("đơn đặt hàng đã có chi tiết, không thể xóa"); 
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này? ", "Xác nhận", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    try
                    {
                        bdsDDH.RemoveCurrent();
                        this.datHangTableAdapter.Update(this.DS.DatHang);
                        MessageBox.Show("Xóa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa đơn đặt hàng" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDDH.CancelEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.khoTableAdapter.Fill(this.DS.Kho);
            
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

            
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.datHangTableAdapter.Fill(this.DS.DatHang);
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bdsCTDDH.AddNew();
            vitri = bdsCTDDH.Position;
            string vt = vitri.ToString();
            gvCTDDH.Rows[vitri].ReadOnly = false;
            flag1 = true;

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsCTDDH.RemoveCurrent();
            this.cTDDHTableAdapter.Update(this.DS.CTDDH);
            MessageBox.Show("Xóa thành công");
        }

        private void cTDDHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mANVLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void ghiVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                vitri = bdsCTDDH.Position;
                if (gvCTDDH.Rows[vitri].Cells[1].Value == DBNull.Value)
                {
                    MessageBox.Show("Vật tư không được để trống");
                    return;
                }
                if (gvCTDDH.Rows[vitri].Cells[2].Value == DBNull.Value)
                {
                    MessageBox.Show("Số lượng vật tư không được để trống");
                    return;
                }
            }
             try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Update(this.DS.CTDDH);
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
            vitri = bdsCTDDH.Position;
            gvCTDDH.Rows[vitri].ReadOnly = false;
            flag1 = false;
        }
    }
}
