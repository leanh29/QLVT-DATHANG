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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(121, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(121, 77);
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
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(121, 123);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiPhieu.TabIndex = 2;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(121, 168);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(100, 25);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "PREVIEW";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẮT ĐẦU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "KẾT THÚC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOẠI PHIẾU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frpChiTietPhieuTrongKhoangTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "frpChiTietPhieuTrongKhoangTheoLoai";
            this.Text = "frpChiTietPhieuTrongKhoangTheoLoai";
            this.Load += new System.EventHandler(this.frpChiTietPhieuTrongKhoangTheoLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}