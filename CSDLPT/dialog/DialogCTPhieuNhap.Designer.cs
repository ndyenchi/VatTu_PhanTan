
namespace CSDLPT
{
    partial class DialogCTPhieuNhap
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
            System.Windows.Forms.Label mAHHLabel;
            System.Windows.Forms.Label sOPNLabel;
            System.Windows.Forms.Label sO_LUONGLabel;
            System.Windows.Forms.Label dON_GIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCTPhieuNhap));
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.panelEdit = new DevExpress.XtraEditors.PanelControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.bdsCTPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.txtSL = new System.Windows.Forms.NumericUpDown();
            this.txtPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtVatTu = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcCTPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctPhieuNhapTableAdapter = new CSDLPT.DSTableAdapters.CT_PHIEU_NHAPTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bdsHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new CSDLPT.DSTableAdapters.HANG_HOATableAdapter();
            this.hANG_HOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG_TON = new DevExpress.XtraGrid.Columns.GridColumn();
            mAHHLabel = new System.Windows.Forms.Label();
            sOPNLabel = new System.Windows.Forms.Label();
            sO_LUONGLabel = new System.Windows.Forms.Label();
            dON_GIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANG_HOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(61, 21);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(60, 19);
            mAHHLabel.TabIndex = 0;
            mAHHLabel.Text = "MAHH:";
            // 
            // sOPNLabel
            // 
            sOPNLabel.AutoSize = true;
            sOPNLabel.Location = new System.Drawing.Point(65, 54);
            sOPNLabel.Name = "sOPNLabel";
            sOPNLabel.Size = new System.Drawing.Size(56, 19);
            sOPNLabel.TabIndex = 2;
            sOPNLabel.Text = "SOPN:";
            // 
            // sO_LUONGLabel
            // 
            sO_LUONGLabel.AutoSize = true;
            sO_LUONGLabel.Location = new System.Drawing.Point(26, 87);
            sO_LUONGLabel.Name = "sO_LUONGLabel";
            sO_LUONGLabel.Size = new System.Drawing.Size(94, 19);
            sO_LUONGLabel.TabIndex = 4;
            sO_LUONGLabel.Text = "SO LUONG:";
            // 
            // dON_GIALabel
            // 
            dON_GIALabel.AutoSize = true;
            dON_GIALabel.Location = new System.Drawing.Point(38, 133);
            dON_GIALabel.Name = "dON_GIALabel";
            dON_GIALabel.Size = new System.Drawing.Size(82, 19);
            dON_GIALabel.TabIndex = 6;
            dON_GIALabel.Text = "DON GIA:";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1088, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1088, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1088, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
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
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "Thêm Chi Tiết";
            this.btnChiTiet.Id = 10;
            this.btnChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChiTiet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.LargeImage")));
            this.btnChiTiet.Name = "btnChiTiet";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.panelControl1);
            this.panelEdit.Controls.Add(dON_GIALabel);
            this.panelEdit.Controls.Add(this.txtDonGia);
            this.panelEdit.Controls.Add(sO_LUONGLabel);
            this.panelEdit.Controls.Add(this.txtSL);
            this.panelEdit.Controls.Add(sOPNLabel);
            this.panelEdit.Controls.Add(this.txtPhieuNhap);
            this.panelEdit.Controls.Add(mAHHLabel);
            this.panelEdit.Controls.Add(this.txtVatTu);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdit.Location = new System.Drawing.Point(0, 34);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(489, 566);
            this.panelEdit.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuNhap, "DON_GIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(126, 130);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(175, 27);
            this.txtDonGia.TabIndex = 7;
            // 
            // bdsCTPhieuNhap
            // 
            this.bdsCTPhieuNhap.DataMember = "CT_PHIEU_NHAP";
            this.bdsCTPhieuNhap.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPhieuNhap, "SO_LUONG", true));
            this.txtSL.Location = new System.Drawing.Point(126, 87);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(176, 27);
            this.txtSL.TabIndex = 5;
            // 
            // txtPhieuNhap
            // 
            this.txtPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuNhap, "SOPN", true));
            this.txtPhieuNhap.Enabled = false;
            this.txtPhieuNhap.Location = new System.Drawing.Point(127, 51);
            this.txtPhieuNhap.Name = "txtPhieuNhap";
            this.txtPhieuNhap.Size = new System.Drawing.Size(175, 27);
            this.txtPhieuNhap.TabIndex = 3;
            // 
            // txtVatTu
            // 
            this.txtVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPhieuNhap, "MAHH", true));
            this.txtVatTu.Location = new System.Drawing.Point(127, 18);
            this.txtVatTu.Name = "txtVatTu";
            this.txtVatTu.Size = new System.Drawing.Size(175, 27);
            this.txtVatTu.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcCTPhieuNhap);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(489, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(599, 566);
            this.panelControl2.TabIndex = 5;
            // 
            // gcCTPhieuNhap
            // 
            this.gcCTPhieuNhap.DataSource = this.bdsCTPhieuNhap;
            this.gcCTPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.gcCTPhieuNhap.MainView = this.gridView1;
            this.gcCTPhieuNhap.MenuManager = this.barManager1;
            this.gcCTPhieuNhap.Name = "gcCTPhieuNhap";
            this.gcCTPhieuNhap.Size = new System.Drawing.Size(743, 422);
            this.gcCTPhieuNhap.TabIndex = 0;
            this.gcCTPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colSOPN,
            this.colSO_LUONG,
            this.colDON_GIA});
            this.gridView1.GridControl = this.gcCTPhieuNhap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAHH
            // 
            this.colMAHH.FieldName = "MAHH";
            this.colMAHH.MinWidth = 30;
            this.colMAHH.Name = "colMAHH";
            this.colMAHH.Visible = true;
            this.colMAHH.VisibleIndex = 0;
            this.colMAHH.Width = 112;
            // 
            // colSOPN
            // 
            this.colSOPN.FieldName = "SOPN";
            this.colSOPN.MinWidth = 30;
            this.colSOPN.Name = "colSOPN";
            this.colSOPN.Visible = true;
            this.colSOPN.VisibleIndex = 1;
            this.colSOPN.Width = 112;
            // 
            // colSO_LUONG
            // 
            this.colSO_LUONG.FieldName = "SO_LUONG";
            this.colSO_LUONG.MinWidth = 30;
            this.colSO_LUONG.Name = "colSO_LUONG";
            this.colSO_LUONG.Visible = true;
            this.colSO_LUONG.VisibleIndex = 2;
            this.colSO_LUONG.Width = 112;
            // 
            // colDON_GIA
            // 
            this.colDON_GIA.FieldName = "DON_GIA";
            this.colDON_GIA.MinWidth = 30;
            this.colDON_GIA.Name = "colDON_GIA";
            this.colDON_GIA.Visible = true;
            this.colDON_GIA.VisibleIndex = 3;
            this.colDON_GIA.Width = 112;
            // 
            // ctPhieuNhapTableAdapter
            // 
            this.ctPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DDHTableAdapter = null;
            this.tableAdapterManager.CT_HOA_DONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEU_NHAPTableAdapter = this.ctPhieuNhapTableAdapter;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.hANG_HOAGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 249);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(485, 315);
            this.panelControl1.TabIndex = 8;
            // 
            // bdsHangHoa
            // 
            this.bdsHangHoa.DataMember = "HANG_HOA";
            this.bdsHangHoa.DataSource = this.ds;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // hANG_HOAGridControl
            // 
            this.hANG_HOAGridControl.DataSource = this.bdsHangHoa;
            this.hANG_HOAGridControl.Location = new System.Drawing.Point(3, 5);
            this.hANG_HOAGridControl.MainView = this.gridView2;
            this.hANG_HOAGridControl.MenuManager = this.barManager1;
            this.hANG_HOAGridControl.Name = "hANG_HOAGridControl";
            this.hANG_HOAGridControl.Size = new System.Drawing.Size(477, 290);
            this.hANG_HOAGridControl.TabIndex = 0;
            this.hANG_HOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH1,
            this.colTENHH,
            this.colSO_LUONG_TON});
            this.gridView2.GridControl = this.hANG_HOAGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMAHH1
            // 
            this.colMAHH1.FieldName = "MAHH";
            this.colMAHH1.MinWidth = 30;
            this.colMAHH1.Name = "colMAHH1";
            this.colMAHH1.Visible = true;
            this.colMAHH1.VisibleIndex = 0;
            this.colMAHH1.Width = 112;
            // 
            // colTENHH
            // 
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.MinWidth = 30;
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 1;
            this.colTENHH.Width = 112;
            // 
            // colSO_LUONG_TON
            // 
            this.colSO_LUONG_TON.FieldName = "SO_LUONG_TON";
            this.colSO_LUONG_TON.MinWidth = 30;
            this.colSO_LUONG_TON.Name = "colSO_LUONG_TON";
            this.colSO_LUONG_TON.Visible = true;
            this.colSO_LUONG_TON.VisibleIndex = 2;
            this.colSO_LUONG_TON.Width = 112;
            // 
            // DialogCTPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 600);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DialogCTPhieuNhap";
            this.Text = "DialogCTPhieuNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogCTPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.DialogCTPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANG_HOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnChiTiet;
        private System.Windows.Forms.BindingSource bdsCTPhieuNhap;
        private DS ds;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelEdit;
        private DSTableAdapters.CT_PHIEU_NHAPTableAdapter ctPhieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcCTPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPN;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_GIA;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.NumericUpDown txtSL;
        private System.Windows.Forms.TextBox txtPhieuNhap;
        private System.Windows.Forms.TextBox txtVatTu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsHangHoa;
        private DSTableAdapters.HANG_HOATableAdapter hangHoaTableAdapter;
        private DevExpress.XtraGrid.GridControl hANG_HOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG_TON;
    }
}