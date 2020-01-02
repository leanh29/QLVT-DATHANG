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
    public partial class formVatTu : Form
    {
        Boolean flag = true;
        int slt = 0;
        public formVatTu()
        {
            InitializeComponent();
        }

        private void formVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);

            if (Program.mGroup == "CongTy")
            {
                btnThem.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnSua.Enabled = false;
            }
            panelControl1.Enabled = false;
            //txtSLT.Text = slt.ToString();
            //int Convert.ToInt32(txtSLT.Text) = 0;
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            bdsVatTu.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = btnUndo.Enabled=false;
            gcVatTu.Enabled = false;
            flag = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = false;
            flag = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsCTPN.Count > 0)
            {
                MessageBox.Show("Vật tư đã lập phiếu nhập, không thể xóa");
                return;
            }
            if(bdsCTPX.Count > 0 )
            {
                MessageBox.Show("Vật tư đã lập phiếu xuất, không thể xóa");
                return;
            }
            if(bdsCTDH.Count > 0)
            {
                MessageBox.Show("Vật tư đã lập phiếu đặt hàng, không thể xóa");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa vật tư này?", "Xác nhận", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    try
                    {
                        bdsVatTu.RemoveCurrent();
                        this.vattuTableAdapter.Update(this.DS.Vattu);
                        MessageBox.Show("Xóa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lôii xóa vật tư" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Fill(this.DS.Vattu);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vat tu không du?c d? tr?ng!");
                txtMAVT.Focus();
                return;
            }
            if (txtTENVT.Text.Trim() == "")
            {
                MessageBox.Show("Ten vat tu không du?c d? tr?ng!");
                txtTENVT.Focus();
                return;
            }
            if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("DVT không du?c d? tr?ng!");
                txtDVT.Focus();
                return;
            }
            if(flag == true)
            {
                try
                {
                    bdsVatTu.EndEdit();
                    //dong bo du lieu giua 2 khu vuc
                    bdsVatTu.ResetCurrentItem();
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                    MessageBox.Show("Ghi vat tu thành công!");
                    gcVatTu.Enabled = true;
                    panelControl1.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = btnUndo.Enabled = true;
                    return;
                }
                catch (Exception ee)
                {
                    if (ee.Message.Contains("duplicate"))
                    {
                        MessageBox.Show("Vật tư đã tồn tại ");
                        return;
                    }
                    MessageBox.Show("lỗi ghi vât tư" + ee.Message);
                }
            }
            else
            {
                try
                {
                    bdsVatTu.EndEdit();
                    //dong bo du lieu giua 2 khu vuc
                    bdsVatTu.ResetCurrentItem();
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                    MessageBox.Show("Ghi vat tu thành công!");
                    panelControl1.Enabled = false;
                    gcVatTu.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = btnUndo.Enabled = true;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi ghi vât tư" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
