
namespace CSDLPT
{
    partial class FormDatHang
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
            System.Windows.Forms.Label mADDHLabel;
            System.Windows.Forms.Label mANCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAY_LAPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelEdit = new DevExpress.XtraEditors.PanelControl();
            this.btnShowNhaCC = new System.Windows.Forms.Button();
            this.txtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ddhTableAdapter = new CSDLPT.DSTableAdapters.DONDHTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            mADDHLabel = new System.Windows.Forms.Label();
            mANCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAY_LAPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mADDHLabel
            // 
            mADDHLabel.AutoSize = true;
            mADDHLabel.Location = new System.Drawing.Point(57, 77);
            mADDHLabel.Name = "mADDHLabel";
            mADDHLabel.Size = new System.Drawing.Size(71, 19);
            mADDHLabel.TabIndex = 0;
            mADDHLabel.Text = "MADDH:";
            // 
            // mANCCLabel
            // 
            mANCCLabel.AutoSize = true;
            mANCCLabel.Location = new System.Drawing.Point(17, 129);
            mANCCLabel.Name = "mANCCLabel";
            mANCCLabel.Size = new System.Drawing.Size(111, 19);
            mANCCLabel.TabIndex = 2;
            mANCCLabel.Text = "Nhà cung cấp:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(69, 180);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MANV:";
            // 
            // nGAY_LAPLabel
            // 
            nGAY_LAPLabel.AutoSize = true;
            nGAY_LAPLabel.Location = new System.Drawing.Point(37, 238);
            nGAY_LAPLabel.Name = "nGAY_LAPLabel";
            nGAY_LAPLabel.Size = new System.Drawing.Size(91, 19);
            nGAY_LAPLabel.TabIndex = 6;
            nGAY_LAPLabel.Text = "NGAY LAP:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnPrint,
            this.btnOut,
            this.barButtonItem9,
            this.barButtonItem1,
            this.btnChiTiet});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChiTiet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In Danh Sách";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnOut
            // 
            this.btnOut.Caption = "Thoát";
            this.btnOut.Id = 7;
            this.btnOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.ImageOptions.Image")));
            this.btnOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOut.ImageOptions.LargeImage")));
            this.btnOut.Name = "btnOut";
            this.btnOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOut_ItemClick);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "Thêm Chi Tiết";
            this.btnChiTiet.Id = 10;
            this.btnChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChiTiet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.LargeImage")));
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTiet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1125, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 596);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1125, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1125, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm Vật tư";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnShowNhaCC);
            this.panelEdit.Controls.Add(nGAY_LAPLabel);
            this.panelEdit.Controls.Add(this.txtNgayLap);
            this.panelEdit.Controls.Add(mANVLabel);
            this.panelEdit.Controls.Add(this.txtMANV);
            this.panelEdit.Controls.Add(mANCCLabel);
            this.panelEdit.Controls.Add(this.txtNCC);
            this.panelEdit.Controls.Add(mADDHLabel);
            this.panelEdit.Controls.Add(this.txtMaDDH);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdit.Location = new System.Drawing.Point(0, 34);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(478, 562);
            this.panelEdit.TabIndex = 4;
            // 
            // btnShowNhaCC
            // 
            this.btnShowNhaCC.Location = new System.Drawing.Point(395, 129);
            this.btnShowNhaCC.Name = "btnShowNhaCC";
            this.btnShowNhaCC.Size = new System.Drawing.Size(46, 27);
            this.btnShowNhaCC.TabIndex = 8;
            this.btnShowNhaCC.Text = "...";
            this.btnShowNhaCC.UseVisualStyleBackColor = true;
            this.btnShowNhaCC.Click += new System.EventHandler(this.btnShowNhaCC_Click);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY_LAP", true));
            this.txtNgayLap.EditValue = null;
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(134, 235);
            this.txtNgayLap.MenuManager = this.barManager1;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Size = new System.Drawing.Size(226, 28);
            this.txtNgayLap.TabIndex = 7;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DONDH";
            this.bdsDDH.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(134, 177);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(226, 27);
            this.txtMANV.TabIndex = 5;
            // 
            // txtNCC
            // 
            this.txtNCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MANCC", true));
            this.txtNCC.Enabled = false;
            this.txtNCC.Location = new System.Drawing.Point(134, 129);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(226, 27);
            this.txtNCC.TabIndex = 3;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MADDH", true));
            this.txtMaDDH.Enabled = false;
            this.txtMaDDH.Location = new System.Drawing.Point(134, 74);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(226, 27);
            this.txtMaDDH.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcDDH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(478, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(647, 562);
            this.panelControl2.TabIndex = 5;
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.bdsDDH;
            this.gcDDH.Location = new System.Drawing.Point(6, 6);
            this.gcDDH.MainView = this.gridView1;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(643, 375);
            this.gcDDH.TabIndex = 0;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADDH,
            this.colMANCC,
            this.colMANV,
            this.colNGAY_LAP});
            this.gridView1.GridControl = this.gcDDH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMADDH
            // 
            this.colMADDH.FieldName = "MADDH";
            this.colMADDH.MinWidth = 30;
            this.colMADDH.Name = "colMADDH";
            this.colMADDH.Visible = true;
            this.colMADDH.VisibleIndex = 0;
            this.colMADDH.Width = 112;
            // 
            // colMANCC
            // 
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.MinWidth = 30;
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 1;
            this.colMANCC.Width = 112;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            this.colMANV.Width = 112;
            // 
            // colNGAY_LAP
            // 
            this.colNGAY_LAP.FieldName = "NGAY_LAP";
            this.colNGAY_LAP.MinWidth = 30;
            this.colNGAY_LAP.Name = "colNGAY_LAP";
            this.colNGAY_LAP.Visible = true;
            this.colNGAY_LAP.VisibleIndex = 3;
            this.colNGAY_LAP.Width = 112;
            // 
            // ddhTableAdapter
            // 
            this.ddhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DDHTableAdapter = null;
            this.tableAdapterManager.CT_HOA_DONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = this.ddhTableAdapter;
            this.tableAdapterManager.HANG_HOATableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_HANG_HOATableAdapter = null;
            this.tableAdapterManager.NHA_CCTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 596);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDatHang";
            this.Text = "FormDatHang";
            this.Load += new System.EventHandler(this.FormDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelEdit;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DS ds;
        private DSTableAdapters.DONDHTableAdapter ddhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_LAP;
        private System.Windows.Forms.Button btnShowNhaCC;
        private DevExpress.XtraEditors.DateEdit txtNgayLap;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtMaDDH;
        public System.Windows.Forms.TextBox txtNCC;
    }
}