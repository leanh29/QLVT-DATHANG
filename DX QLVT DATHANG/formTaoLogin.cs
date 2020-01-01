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
    public partial class formTaoLogin : Form
    {
        public formTaoLogin()
        {
            InitializeComponent();
            loadStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLogName.Text.Trim() == "")
            {
                MessageBox.Show("LoginName không được để trống", "", MessageBoxButtons.OK);
                txtLogName.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Pass không được để trống", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("UserName không được để trống", "", MessageBoxButtons.OK);
                txtUserName.Focus();
                return;
            }

            if (Program.mGroup == "CongTy")
            {
                TaoLogin();
            }
            if (Program.mGroup == "ChiNhanh")
            {
                if (txtRole.Text.Trim() == "ChiNhanh" || txtRole.Text.Trim() == "User")
                {
                    TaoLogin();
                }
                else
                {
                    MessageBox.Show("ROLE chỉ thuộc ChiNhanh or User.\n Mời bạn nhập lại!");
                }
            }
        }

        public void TaoLogin()
        {
            try
            {
                if (Program.KetNoi() == 0) return;

                string lenh = "EXEC SP_TAOLOGIN1 "
                    + "'" + txtLogName.Text + "',"
                    + "'" + txtPass.Text + "',"
                    + "'" + txtUserName.Text + "',"
                    + "'" + txtRole.Text + "'";
                
               
                SqlCommand sqlcmd1 = new SqlCommand(lenh, Program.conn);
                Program.dataReader = sqlcmd1.ExecuteReader();
                if (Program.dataReader.Read())
                {
                    string check = Program.dataReader.GetString(0);
                    if (check == "1")
                    {
                        MessageBox.Show("Mời kiểm tra lại!");
                        txtLogName.Focus();
                        txtPass.Focus();
                        txtUserName.Focus();
                        txtRole.Focus();
                        Program.dataReader.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tạo login thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo Login.\n" + ex.Message, "", MessageBoxButtons.OK);

            }
        }

        private void formTaoLogin_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "CongTy")
            {
                txtRole.Enabled = false;
            }
        }
        private void loadStatus()
        {

            txtRole.Text = Program.mGroup;
        }
    }
}
