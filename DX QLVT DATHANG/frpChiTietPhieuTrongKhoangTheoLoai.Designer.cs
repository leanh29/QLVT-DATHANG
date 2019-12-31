namespace DX_QLVT_DATHANG
{
    partial class frpChiTietPhieuTrongKhoangTheoLoai
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(50, 36);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(50, 78);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(50, 124);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiPhieu.TabIndex = 2;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(50, 169);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(100, 25);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "button1";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // frpChiTietPhieuTrongKhoangTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "frpChiTietPhieuTrongKhoangTheoLoai";
            this.Text = "frpChiTietPhieuTrongKhoangTheoLoai";
            this.Load += new System.EventHandler(this.frpChiTietPhieuTrongKhoangTheoLoai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private System.Windows.Forms.Button btnPre;
    }
}