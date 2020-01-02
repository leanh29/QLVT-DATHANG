namespace DX_QLVT_DATHANG
{
    partial class formVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnsuanot = new DevExpress.XtraBars.BarButtonItem();
            this.ghi = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new DX_QLVT_DATHANG.DS();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new DX_QLVT_DATHANG.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new DX_QLVT_DATHANG.DSTableAdapters.TableAdapterManager();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMAVT = new System.Windows.Forms.TextBox();
            this.txtTENVT = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new DX_QLVT_DATHANG.DSTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new DX_QLVT_DATHANG.DSTableAdapters.CTPNTableAdapter();
            this.bdsCTDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new DX_QLVT_DATHANG.DSTableAdapters.CTDDHTableAdapter();
            this.txtSLT = new System.Windows.Forms.NumericUpDown();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(154, 32);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "MAVT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(154, 59);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(42, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "TENVT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(154, 86);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(30, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(154, 113);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(80, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnsuanot,
            this.ghi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnIn,
            this.btnThoat,
            this.btnSua,
            this.btnGhi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 3;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhi.Glyph")));
            this.btnGhi.Id = 12;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 11;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 7;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 8;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 9;
            this.btnIn.Name = "btnIn";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 10;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 348);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 348);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnsuanot
            // 
            this.btnsuanot.Caption = "Ghi";
            this.btnsuanot.Glyph = ((System.Drawing.Image)(resources.GetObject("btnsuanot.Glyph")));
            this.btnsuanot.Id = 4;
            this.btnsuanot.Name = "btnsuanot";
            // 
            // ghi
            // 
            this.ghi.Caption = "Ghi";
            this.ghi.Glyph = ((System.Drawing.Image)(resources.GetObject("ghi.Glyph")));
            this.ghi.Id = 5;
            this.ghi.Name = "ghi";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DX_QLVT_DATHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Location = new System.Drawing.Point(0, 40);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(884, 157);
            this.gcVatTu.TabIndex = 9;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSLT);
            this.panelControl1.Controls.Add(mAVTLabel);
            this.panelControl1.Controls.Add(this.txtMAVT);
            this.panelControl1.Controls.Add(tENVTLabel);
            this.panelControl1.Controls.Add(this.txtTENVT);
            this.panelControl1.Controls.Add(dVTLabel);
            this.panelControl1.Controls.Add(this.txtDVT);
            this.panelControl1.Controls.Add(sOLUONGTONLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 197);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 191);
            this.panelControl1.TabIndex = 10;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(240, 29);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(361, 21);
            this.txtMAVT.TabIndex = 1;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(240, 56);
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Size = new System.Drawing.Size(361, 21);
            this.txtTENVT.TabIndex = 3;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(240, 83);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(361, 21);
            this.txtDVT.TabIndex = 5;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDH
            // 
            this.bdsCTDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDH.DataSource = this.bdsVatTu;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // txtSLT
            // 
            this.txtSLT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsVatTu, "SOLUONGTON", true));
            this.txtSLT.Location = new System.Drawing.Point(240, 113);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(120, 21);
            this.txtSLT.TabIndex = 8;
            // 
            // formVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formVatTu";
            this.Text = "formVatTu";
            this.Load += new System.EventHandler(this.formVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnsuanot;
        private DevExpress.XtraBars.BarButtonItem ghi;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DS DS;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtMAVT;
        private System.Windows.Forms.TextBox txtTENVT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.NumericUpDown txtSLT;
    }
}