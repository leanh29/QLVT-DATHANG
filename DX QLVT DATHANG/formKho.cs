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
    public partial class formKho : Form
    {
        string maCN = "";
        Boolean flag = true;
        public formKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void khoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
           
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            
           
            maCN = ((DataRowView)bdsKHO[0])["MACN"].ToString();
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
            txtMACN.ReadOnly = true;
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
                // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DS.Kho);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKHO.AddNew();
            panelControl1.Enabled = true;
            txtMACN.Text = maCN;
            flag = true;
            txtMACN.ReadOnly = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKHO.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống");
                txtMAKHO.Focus();
                return;
            }
            if (txtTENKHO.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống");
                txtTENKHO.Focus();
                return;
            }
            if (flag == true)
            {
                try
                {
                    String str = "dbo.SP_CHECKTRUNGKHO";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = str;
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.NChar).Value = txtMAKHO.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.NChar).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        MessageBox.Show("Mã kho bị trùng");
                        txtMAKHO.Focus();
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsKHO.EndEdit();
                            //dong bo du lieu giua 2 khu vuc
                            bdsKHO.ResetCurrentItem();
                            this.khoTableAdapter.Update(this.DS.Kho);
                            MessageBox.Show("Ghi nhân viên thành công!");
                            //gcNhanVien.Enabled = true;
                            panelControl1.Enabled = false;
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled =  true;
                            return;
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("duplicate"))
                            {
                                MessageBox.Show("Tên kho đã tồn tại");
                                return;
                            }
                            MessageBox.Show("Lỗi ghi kho" + ex.Message, "", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Lỗi kiểm tra kho.\n" + e2.Message, "", MessageBoxButtons.OK);
                }

                
            }
            else
            {
                try
                {
                    bdsKHO.EndEdit();
                    //dong bo du lieu giua 2 khu vuc
                    bdsKHO.ResetCurrentItem();
                    this.khoTableAdapter.Update(this.DS.Kho);
                    MessageBox.Show("Ghi nhân viên thành công!");
                    //gcNhanVien.Enabled = true;
                    panelControl1.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Kho đã được lập phiếu nhập, không thể xóa");
                    return;
            }
            if (bdsDDH.Count > 0)
            {
                MessageBox.Show("Kho đã được lập đơn đặt hàng, không thể xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này? ", "Xác nhận", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    try
                    {
                        bdsKHO.RemoveCurrent();
                        this.khoTableAdapter.Update(this.DS.Kho);
                        MessageBox.Show(" Xóa thành công");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("lỗi\n" + er.Message);
                    }
                }
            }
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            flag = false;
            txtMAKHO.ReadOnly = true;
        }
    }
}
