namespace DX_QLVT_DATHANG
{
    partial class frpTinhHinhHoatDong1NV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.DS = new DX_QLVT_DATHANG.DS();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.dSNhanVienTableAdapter = new DX_QLVT_DATHANG.DSTableAdapters.DSNhanVienTableAdapter();
            this.tableAdapterManager = new DX_QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.cmbHOTEN = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Items.AddRange(new object[] {
            "Nhập",
            "Xuất",
            "Đặt Hàng"});
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(204, 197);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiPhieu.TabIndex = 7;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy/MM/dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(204, 151);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(204, 109);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(204, 34);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(121, 21);
            this.cmbChiNhanh.TabIndex = 9;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNhanVien";
            this.bdsDSNV.DataSource = this.DS;
            // 
            // dSNhanVienTableAdapter
            // 
            this.dSNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cmbHOTEN
            // 
            this.cmbHOTEN.DataSource = this.bdsDSNV;
            this.cmbHOTEN.DisplayMember = "HOTEN";
            this.cmbHOTEN.FormattingEnabled = true;
            this.cmbHOTEN.Location = new System.Drawing.Point(204, 71);
            this.cmbHOTEN.Name = "cmbHOTEN";
            this.cmbHOTEN.Size = new System.Drawing.Size(300, 21);
            this.cmbHOTEN.TabIndex = 10;
            this.cmbHOTEN.ValueMember = "MANV";
            this.cmbHOTEN.SelectedIndexChanged += new System.EventHandler(this.cmbHOTEN_SelectedIndexChanged);
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(592, 71);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "LOẠI PHIẾU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "KẾT THÚC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "BẮT ĐẦU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "MÃ NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "HỌ TÊN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "CHI NHÁNH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "PREVIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frpTinhHinhHoatDong1NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.cmbHOTEN);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "frpTinhHinhHoatDong1NV";
            this.Text = "frmTinhHinhHoatDong1NV";
            this.Load += new System.EventHandler(this.frmTinhHinhHoatDong1NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DSTableAdapters.DSNhanVienTableAdapter dSNhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHOTEN;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}