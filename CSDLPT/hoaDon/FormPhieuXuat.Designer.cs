
namespace CSDLPT
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.Label nGAY_LAPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuat));
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
            this.bdsCtHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.bdsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.panelHoaDon = new DevExpress.XtraEditors.PanelControl();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_LAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCTHoaDon = new DevExpress.XtraEditors.PanelControl();
            this.hoaDonTableAdapter = new CSDLPT.DSTableAdapters.HOA_DONTableAdapter();
            this.ctHoaDonTableAdapter = new CSDLPT.DSTableAdapters.CT_HOA_DONTableAdapter();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.panelEdit = new DevExpress.XtraEditors.PanelControl();
            this.btnShowKho = new System.Windows.Forms.Button();
            this.btnShowKH = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenKho = new System.Windows.Forms.TextBox();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.panelNhap = new DevExpress.XtraEditors.PanelControl();
            nGAY_LAPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAHDLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHoaDon)).BeginInit();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHoaDon)).BeginInit();
            this.panelCTHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhap)).BeginInit();
            this.panelNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // nGAY_LAPLabel
            // 
            nGAY_LAPLabel.AutoSize = true;
            nGAY_LAPLabel.Location = new System.Drawing.Point(20, 143);
            nGAY_LAPLabel.Name = "nGAY_LAPLabel";
            nGAY_LAPLabel.Size = new System.Drawing.Size(91, 19);
            nGAY_LAPLabel.TabIndex = 4;
            nGAY_LAPLabel.Text = "NGAY LAP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(53, 233);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(58, 19);
            mAKHLabel.TabIndex = 6;
            mAKHLabel.Text = "MAKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(52, 188);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 2;
            mANVLabel.Text = "MANV:";
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(51, 92);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(60, 19);
            mAHDLabel.TabIndex = 0;
            mAHDLabel.Text = "MAHD:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(41, 283);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(70, 19);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
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
            this.btnChiTiet.Caption = "Chi Tiết";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1479, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 643);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1479, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1479, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 609);
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
            // bdsCtHoaDon
            // 
            this.bdsCtHoaDon.DataMember = "CT_HOA_DON";
            this.bdsCtHoaDon.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoaDon
            // 
            this.bdsHoaDon.DataMember = "HOA_DON";
            this.bdsHoaDon.DataSource = this.ds;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DDHTableAdapter = null;
            this.tableAdapterManager.CT_HOA_DONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
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
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.gcHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDon.Location = new System.Drawing.Point(2, 2);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(945, 605);
            this.panelHoaDon.TabIndex = 1;
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.DataSource = this.bdsHoaDon;
            this.gcHoaDon.Location = new System.Drawing.Point(41, 6);
            this.gcHoaDon.MainView = this.gridView2;
            this.gcHoaDon.MenuManager = this.barManager1;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(743, 490);
            this.gcHoaDon.TabIndex = 0;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colNGAY_LAP,
            this.colMANV,
            this.colMAKH1,
            this.colMAKHO});
            this.gridView2.GridControl = this.gcHoaDon;
            this.gridView2.Name = "gridView2";
            // 
            // colMAHD
            // 
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.MinWidth = 30;
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            this.colMAHD.Width = 112;
            // 
            // colNGAY_LAP
            // 
            this.colNGAY_LAP.FieldName = "NGAY_LAP";
            this.colNGAY_LAP.MinWidth = 30;
            this.colNGAY_LAP.Name = "colNGAY_LAP";
            this.colNGAY_LAP.Visible = true;
            this.colNGAY_LAP.VisibleIndex = 1;
            this.colNGAY_LAP.Width = 112;
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
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 30;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 3;
            this.colMAKH1.Width = 112;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 30;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 112;
            // 
            // panelCTHoaDon
            // 
            this.panelCTHoaDon.Controls.Add(this.panelHoaDon);
            this.panelCTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCTHoaDon.Location = new System.Drawing.Point(530, 34);
            this.panelCTHoaDon.Name = "panelCTHoaDon";
            this.panelCTHoaDon.Size = new System.Drawing.Size(949, 609);
            this.panelCTHoaDon.TabIndex = 14;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ctHoaDonTableAdapter
            // 
            this.ctHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1479, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 643);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1479, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 643);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1479, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 643);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnShowKho);
            this.panelEdit.Controls.Add(this.btnShowKH);
            this.panelEdit.Controls.Add(this.txtMaNV);
            this.panelEdit.Controls.Add(this.txtMaHD);
            this.panelEdit.Controls.Add(mAKHOLabel);
            this.panelEdit.Controls.Add(mAHDLabel);
            this.panelEdit.Controls.Add(this.txtTenKho);
            this.panelEdit.Controls.Add(mANVLabel);
            this.panelEdit.Controls.Add(mAKHLabel);
            this.panelEdit.Controls.Add(this.txtNgay);
            this.panelEdit.Controls.Add(this.txtTenKH);
            this.panelEdit.Controls.Add(nGAY_LAPLabel);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdit.Location = new System.Drawing.Point(2, 2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(526, 605);
            this.panelEdit.TabIndex = 0;
            this.panelEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // btnShowKho
            // 
            this.btnShowKho.Location = new System.Drawing.Point(355, 278);
            this.btnShowKho.Name = "btnShowKho";
            this.btnShowKho.Size = new System.Drawing.Size(50, 35);
            this.btnShowKho.TabIndex = 13;
            this.btnShowKho.Text = "...";
            this.btnShowKho.UseVisualStyleBackColor = true;
            this.btnShowKho.Click += new System.EventHandler(this.btnShowKho_Click);
            // 
            // btnShowKH
            // 
            this.btnShowKH.Location = new System.Drawing.Point(355, 225);
            this.btnShowKH.Name = "btnShowKH";
            this.btnShowKH.Size = new System.Drawing.Size(50, 34);
            this.btnShowKH.TabIndex = 12;
            this.btnShowKH.Text = "...";
            this.btnShowKH.UseVisualStyleBackColor = true;
            this.btnShowKH.Click += new System.EventHandler(this.btnShowKH_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(117, 185);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(192, 27);
            this.txtMaNV.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAHD", true));
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(117, 89);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(192, 27);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtTenKho
            // 
            this.txtTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAKHO", true));
            this.txtTenKho.Enabled = false;
            this.txtTenKho.Location = new System.Drawing.Point(117, 280);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(192, 27);
            this.txtTenKho.TabIndex = 9;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoaDon, "NGAY_LAP", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(117, 140);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(192, 28);
            this.txtNgay.TabIndex = 5;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoaDon, "MAKH", true));
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(117, 230);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 27);
            this.txtTenKH.TabIndex = 7;
            // 
            // panelNhap
            // 
            this.panelNhap.Controls.Add(this.panelEdit);
            this.panelNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhap.Location = new System.Drawing.Point(0, 34);
            this.panelNhap.Name = "panelNhap";
            this.panelNhap.Size = new System.Drawing.Size(530, 609);
            this.panelNhap.TabIndex = 13;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 643);
            this.Controls.Add(this.panelCTHoaDon);
            this.Controls.Add(this.panelNhap);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormPhieuXuat";
            this.Text = "FormPhieuXuat";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHoaDon)).EndInit();
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHoaDon)).EndInit();
            this.panelCTHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhap)).EndInit();
            this.panelNhap.ResumeLayout(false);
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
        private DS ds;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelCTHoaDon;
        private DevExpress.XtraEditors.PanelControl panelHoaDon;
        private System.Windows.Forms.BindingSource bdsHoaDon;
        private DSTableAdapters.HOA_DONTableAdapter hoaDonTableAdapter;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_LAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.BindingSource bdsCtHoaDon;
        private DSTableAdapters.CT_HOA_DONTableAdapter ctHoaDonTableAdapter;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private DevExpress.XtraEditors.PanelControl panelNhap;
        private DevExpress.XtraEditors.PanelControl panelEdit;
        private System.Windows.Forms.Button btnShowKho;
        private System.Windows.Forms.Button btnShowKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        public System.Windows.Forms.TextBox txtTenKho;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        public System.Windows.Forms.TextBox txtTenKH;
    }
}