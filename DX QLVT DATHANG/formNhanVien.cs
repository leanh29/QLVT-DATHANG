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
    public partial class formNhanVien : Form
    {
        int vitri = 0;
        string maCN = "";
        Boolean flag = true;
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr; // doi phan manh moi
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;


            maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
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
            groupControl1.Enabled = false;
            //if (bdsNV.Count = 0) btnXoa.Enabled = false;
            //groupControl1.Enabled = false;


        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void nhanVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr; // doi phan manh moi
                // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;

                //maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vitri = bdsNV.Position;//so thu tu cua mau tin do trong ds
            groupControl1.Enabled = true;
            bdsNV.AddNew();
            txtmaCN.Text = maCN;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = false;
            txtmaCN.Enabled = false;
            gcNhanVien.Enabled = false;
            flag = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = false;
            flag = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bo sung khi dang sua thi close
            Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maNV = 0;
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu nhập, không thể xóa");
                return;
            }
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu đặt, không thể xóa");
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu xuất, không thể xóa");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này? ", "Xác nhận", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    try
                    {
                        bdsNV.RemoveCurrent();
                        this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                        MessageBox.Show("Xóa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã Nhân viên không được để trống!");
                txtMaNV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ Nhân viên không được để trống!");
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên Nhân viên không được để trống!");
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ Nhân viên không được để trống!");
                txtDiaChi.Focus();
                return;
            }
            if (txtLuong.Text.Trim() == "")
            {

                txtLuong.Text = "0";

            }
            if (Convert.ToInt32(txtLuong.Text) <= 0)
            {
                MessageBox.Show("Lương phải lớn hơn 0");
                txtLuong.Focus();
                return;
            }
            if (Convert.ToInt32(txtLuong.Text) < 4000000)
            {
                MessageBox.Show("Lương phải lớn hơn hoặc bằng 4000000");
                txtLuong.Focus();
                return;
            }
            if (flag == true)
            {
                try
                {
                        String str = "dbo.SP_CHECKTRUNGNV";
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.sqlcmd.CommandText = str;
                        Program.sqlcmd.Parameters.Add("@X", SqlDbType.Int).Value = txtMaNV.Text;
                        Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                        Program.sqlcmd.ExecuteNonQuery();
                        String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
                        if (ret == "1")
                        {
                            MessageBox.Show("Mã nhân viên bị trùng");
                            return;
                        }
                        else {
                            try
                            {
                                bdsNV.EndEdit();
                                //dong bo du lieu giua 2 khu vuc
                                bdsNV.ResetCurrentItem();
                                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                                MessageBox.Show("Ghi nhân viên thành công!");
                                gcNhanVien.Enabled = true;
                                groupControl1.Enabled = false;
                                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = true;
                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi ghi nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                            }
                        }
                    }
                catch (Exception e2)
                {
                    MessageBox.Show("Lỗi kiểm tra nhân viên.\n" + e2.Message, "", MessageBoxButtons.OK);
                }
               
                
                //if (bdsNV.Find("MANV", txtMaNV.Text) > 0)
                //{
                //    MessageBox.Show("Mã Nhân viên bị trùng");
                //    return;
                //    //txtLuong.Focus();
                //}
                //else
                //{
                //    try
                //    {
                //        bdsNV.EndEdit();
                //        bdsNV.ResetCurrentItem();
                //        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                //        this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                //        MessageBox.Show("Ghi nhân viên thành công");
                //        gcNhanVien.Enabled = true;
                //        return;
                //    }
                //    catch (Exception ex)
                //    {
                //        if (ex.Message.Contains("PRIMARY"))
                //        {
                //            MessageBox.Show("Mã nhân viên bị trùng");
                //            txtMaNV.Focus();
                //            return;
                //        }

                //        //bdsNV.Find("maNV",)
                //        else
                //        {
                //            bdsNV.EndEdit();
                //            bdsNV.ResetCurrentItem();
                //            MessageBox.Show("Lỗi ghi nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                //            return;
                //        }
                //    }
                //}
            }
            else
            {
                try
                {
                    bdsNV.EndEdit();
                    //dong bo du lieu giua 2 khu vuc
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Ghi nhân viên thành công!");
                    groupControl1.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnIn.Enabled = true;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            
            
        }

        private void txtmaCN_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
