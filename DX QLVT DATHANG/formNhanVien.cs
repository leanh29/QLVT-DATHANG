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
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr; // doi phan manh moi
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.bdsPX.Connection.ConnectionString = Program.connstr;
            this.bdsPX.Fill(this.DS.PhieuXuat);

            maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CongTy") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;
            //if (bdsNV.Count = 0) btnXoa.Enabled = false;
            groupControl1.Enabled = false;
           
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

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                this.bdsPX.Connection.ConnectionString = Program.connstr;
                this.bdsPX.Fill(this.DS.PhieuXuat);

                maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;//so thu tu cua mau tin do trong ds
            groupControl1.Enabled = true;
            bdsNV.AddNew();
            txtmaCN.Text = maCN;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            txtmaCN.Enabled = false;
            gcNhanVien.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsNV.EndEdit();
                //dong bo du lieu giua 2 khu vuc
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
            }
            catch(Exception ex){
                MessageBox.Show("Lỗi ghi nhân viên" + ex.Message, "", MessageBoxButtons.OK);
            }
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này? ","Xác nhận", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

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
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên Nhân viên không được để trống!");
                txtTen.Focus();
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ Nhân viên không được để trống!");
                txtDiaChi.Focus();
            }
            if (txtLuong.Text.Trim() == "")
            {

                txtLuong.Text= "0";
                
            }
            if (Convert.ToInt32(txtLuong.Text) <= 0)
            {
                MessageBox.Show("");
                txtLuong.Focus();
            }
            if (Convert.ToInt32(txtLuong.Text) < 4000000)
            {
                MessageBox.Show("Lương phải lớn hơn hoặc bàng 4000000");
                txtLuong.Focus();
            }
            if (bdsNV.Find("MANV",txtMaNV.Text)>0)
            {
                 MessageBox.Show("Mã Nhân viên bị trùng");
                //txtLuong.Focus();
            }
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("PRIMARY")){
                    MessageBox.Show("Mã nhân viên bị trùng");
                    txtMaNV.Focus();
                }
               
                //bdsNV.Find("maNV",)
                else
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    MessageBox.Show("Lỗi ghi nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

       

      
    }
}
