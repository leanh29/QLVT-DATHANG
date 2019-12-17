﻿using System;
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
    public partial class formPhieuNhap : Form
    {
        Boolean flag = true;
        public formPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.DSNhanVien' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            
            DS.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.dSNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNhanVienTableAdapter.Fill(this.DS.DSNhanVien);

            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DS.Kho);

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
        private void cmbHOTEN_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                txtMANV.Text = cmbHOTEN.SelectedValue.ToString();
            }
            catch (Exception){}
        }

        private void cmbKHO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
            catch (Exception) {}
        }
    }
}
