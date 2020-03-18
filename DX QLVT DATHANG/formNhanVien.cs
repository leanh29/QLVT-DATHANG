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
    public partial class formNhanVien : Form
    {
        int vitri = 0;
        string maCN = "";
        Boolean flag = true;
        Boolean kt = true;
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
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

            this.sP_DSCNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSCNTableAdapter.Fill(this.DS.SP_DSCN);


            maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            cmbChiNhanh.Enabled = false;
            if (Program.mGroup == "CongTy")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnSua.Enabled = false;
            }
            if (Program.mGroup == "User" || Program.mGroup == "ChiNhanh")
            {
                btnChuyenCN.Enabled = false;
            }
            
            groupControl1.Enabled = false;
            panelControl1.Enabled = false;
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
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            txtmaCN.Enabled = false;
            gcNhanVien.Enabled = false;
            flag = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            flag = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
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

            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã Nhân viên không được để trống!");
                txtMANV.Focus();
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
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.Int).Value = txtMANV.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
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
                            txtTTX.Text = "0";
                            bdsNV.EndEdit();
                            //dong bo du lieu giua 2 khu vuc
                            bdsNV.ResetCurrentItem();
                            this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                            MessageBox.Show("Ghi nhân viên thành công!");
                            gcNhanVien.Enabled = true;
                            groupControl1.Enabled = false;
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled =  true;
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
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = true;
            if(txtTTX.Text.Trim() == "1")
            {
                MessageBox.Show("Nhân viên đã chuyển chi nhánh", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (bdsDH.Count > 0 || bdsPN.Count > 0 || bdsPX.Count > 0)
                {
                    // Nhân viên này dã l?p phi?u
                    MessageBox.Show("Nhân viên dã lập phiếu", "", MessageBoxButtons.OK);
                    txtMANV.Enabled = false;
                    gcNhanVien.Enabled = false;
                    groupControl1.Enabled = true;
                    txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtLuong.Enabled = txtNS.Enabled = txtmaCN.Enabled = false;
                    kt = true;
                }
                else
                {
                    // txtMaNV.Focus();

                    MessageBox.Show("Nhân viên chua lập phiếu", "", MessageBoxButtons.OK);
                    label1.Enabled = false;
                    gcNhanVien.Enabled = false;
                    groupControl1.Enabled = true;
                    txtMaNVMoi.Enabled = txtMANV.Enabled = false;
                    txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtLuong.Enabled = txtNS.Enabled = txtmaCN.Enabled = false;
                    kt = false;
                }
            }
            //if (bdsDH.Count > 0 || bdsPN.Count > 0 || bdsPX.Count > 0)
            //{
            //    // Nhân viên này dã l?p phi?u
            //    MessageBox.Show("Nhân viên dã lập phiếu", "", MessageBoxButtons.OK);
            //    txtMANV.Enabled = false;
            //    gcNhanVien.Enabled = false;
            //    groupControl1.Enabled = true;
            //    txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtLuong.Enabled = txtNS.Enabled = txtmaCN.Enabled = false;
            //    kt = true;
            //}
            //else
            //{
            //    // txtMaNV.Focus();

            //    MessageBox.Show("Nhân viên chua lập phiếu", "", MessageBoxButtons.OK);
            //    label1.Enabled = false;
            //    gcNhanVien.Enabled = false;
            //    groupControl1.Enabled = true;
            //    txtMaNVMoi.Enabled = txtMANV.Enabled = false;
            //    txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtLuong.Enabled = txtNS.Enabled = txtmaCN.Enabled = false;
            //    kt = false;
            //}

        }
        private void XoaNhanVienCoTKLogin(string manv)
        {
            if (Program.KetNoi() == 0) return;
            string lenh = "EXEC XOA_LOGIN " + manv;
            SqlCommand sqlcmd = new SqlCommand(lenh, Program.conn);
            Program.dataReader = sqlcmd.ExecuteReader();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChuyen_Click_1(object sender, EventArgs e)
        {
            string manv = txtMANV.Text.Trim();
            //string macnmoi = cmbCNMoi.Text.ToString();
            if (kt == true)
            {
                int manvcu = Convert.ToInt16(txtMANV.Text);
                string hocu = txtHo.Text;
                string tencu = txtTen.Text;
                string diachicu = txtDiaChi.Text;
                string luongcu = txtLuong.Text;
                string nscu = txtNS.Text;

                String mamoi = txtMaNVMoi.Text;
                if (mamoi == "")
                {
                    MessageBox.Show("Mã NV mới không dc để trống");
                    return;
                }
                else
                {
                    if (Program.KetNoi() == 0) return;

                    String str = "dbo.SP_CHECKTRUNGNV";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = str;
                    int mm = Convert.ToInt16(mamoi);
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.Int).Value = mm;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
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

                            //String macnmoi = txtCNMoi.Text;
                            if (Program.KetNoi() == 0) return;

                            MessageBox.Show(mamoi + ",'" + hocu + "','" + tencu
                                + "',N'" + diachicu + "','" + nscu + "','" + luongcu + "','" + cmbCNMoi.SelectedValue.ToString() + "'," + manvcu);

                            String sql = "SP_CHUYENCHINHANHCHONHANVIEN " + mamoi + ",'" + hocu + "','" + tencu
                                + "',N'" + diachicu + "','" + nscu + "','" + luongcu + "','" + cmbCNMoi.SelectedValue.ToString() + "'," + manvcu;
                            SqlCommand sqlcmd1 = new SqlCommand(sql, Program.conn);
                            sqlcmd1.ExecuteNonQuery();

                            bdsNV.EndEdit();
                            bdsNV.ResetCurrentItem();
                            this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                            XoaNhanVienCoTKLogin(manv);

                            MessageBox.Show("Chuyển thành công!", "", MessageBoxButtons.OK);
                            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                            gcNhanVien.Enabled = true;
                            return;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Chuy?n thành công!", "", MessageBoxButtons.OK);
                            MessageBox.Show("Lỗi chuyển chi nhánh" + ex.Message, "", MessageBoxButtons.OK);
                        }

                    }
                }
            }
            else
            {

                try
                {

                    int mnv = Convert.ToInt16(txtMANV.Text.Trim());
                    // String macnmoi = txtCNMoi.Text;
                    if (Program.KetNoi() == 0) return;
                    try
                    {
                        String lenh = "EXEC SP_DOIMACHINHANHCUANHANVIEN " + mnv + ",'" + cmbCNMoi.SelectedValue.ToString() + "'";
                        SqlCommand sql = new SqlCommand(lenh, Program.conn);
                        sql.ExecuteNonQuery();
                        bdsNV.EndEdit();
                        //dong bo du lieu giua 2 khu vuc
                        bdsNV.ResetCurrentItem();
                        this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                        XoaNhanVienCoTKLogin(manv);
                        MessageBox.Show("Chuyển chi nhánh thành công!");
                        gcNhanVien.Enabled = true;
                        return;
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Lỗi chạy sql" + e1.Message, "", MessageBoxButtons.OK);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển chi nhánh" + ex.Message, "", MessageBoxButtons.OK);
                }

            }
        }
    }
}
