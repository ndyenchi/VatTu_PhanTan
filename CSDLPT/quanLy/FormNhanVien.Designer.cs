
namespace CSDLPT
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAY_SINHLabel;
            System.Windows.Forms.Label dIA_CHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label dA_CHUYENLabel;
            System.Windows.Forms.Label dA_XOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ds = new CSDLPT.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDA_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDA_XOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtXoa = new DevExpress.XtraEditors.CheckEdit();
            this.txtChuyen = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaCN = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtPhai = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new CSDLPT.DSTableAdapters.NHAN_VIENTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAY_SINHLabel = new System.Windows.Forms.Label();
            dIA_CHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            dA_CHUYENLabel = new System.Windows.Forms.Label();
            dA_XOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(50, 30);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(71, 75);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(38, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(64, 125);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(57, 174);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(52, 19);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAY_SINHLabel
            // 
            nGAY_SINHLabel.AutoSize = true;
            nGAY_SINHLabel.Location = new System.Drawing.Point(9, 228);
            nGAY_SINHLabel.Name = "nGAY_SINHLabel";
            nGAY_SINHLabel.Size = new System.Drawing.Size(100, 19);
            nGAY_SINHLabel.TabIndex = 8;
            nGAY_SINHLabel.Text = "NGAY SINH:";
            // 
            // dIA_CHILabel
            // 
            dIA_CHILabel.AutoSize = true;
            dIA_CHILabel.Location = new System.Drawing.Point(34, 278);
            dIA_CHILabel.Name = "dIA_CHILabel";
            dIA_CHILabel.Size = new System.Drawing.Size(75, 19);
            dIA_CHILabel.TabIndex = 10;
            dIA_CHILabel.Text = "DIA CHI:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(64, 332);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(45, 19);
            sDTLabel.TabIndex = 12;
            sDTLabel.Text = "SDT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(50, 378);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // dA_CHUYENLabel
            // 
            dA_CHUYENLabel.AutoSize = true;
            dA_CHUYENLabel.Location = new System.Drawing.Point(5, 423);
            dA_CHUYENLabel.Name = "dA_CHUYENLabel";
            dA_CHUYENLabel.Size = new System.Drawing.Size(104, 19);
            dA_CHUYENLabel.TabIndex = 16;
            dA_CHUYENLabel.Text = "DA CHUYEN:";
            // 
            // dA_XOALabel
            // 
            dA_XOALabel.AutoSize = true;
            dA_XOALabel.Location = new System.Drawing.Point(209, 423);
            dA_XOALabel.Name = "dA_XOALabel";
            dA_XOALabel.Size = new System.Drawing.Size(74, 19);
            dA_XOALabel.TabIndex = 18;
            dA_XOALabel.Text = "DA XOA:";
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
            this.barButtonItem9});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1672, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 702);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1672, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 668);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1672, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 668);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBox1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(9);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1672, 102);
            this.panelControl1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(688, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH";
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NHAN_VIEN";
            this.bdsNhanVien.DataSource = this.ds;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(9);
            this.gcNhanVien.Location = new System.Drawing.Point(413, 136);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.Margin = new System.Windows.Forms.Padding(9);
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1259, 566);
            this.gcNhanVien.TabIndex = 6;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNhanVien.Click += new System.EventHandler(this.nHAN_VIENGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAY_SINH,
            this.colDIA_CHI,
            this.colSDT,
            this.colMACN,
            this.colDA_CHUYEN,
            this.colDA_XOA});
            this.gridView1.DetailHeight = 1180;
            this.gridView1.FixedLineWidth = 6;
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 67;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 252;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 67;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 252;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 67;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 252;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 67;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 252;
            // 
            // colNGAY_SINH
            // 
            this.colNGAY_SINH.FieldName = "NGAY_SINH";
            this.colNGAY_SINH.MinWidth = 67;
            this.colNGAY_SINH.Name = "colNGAY_SINH";
            this.colNGAY_SINH.Visible = true;
            this.colNGAY_SINH.VisibleIndex = 4;
            this.colNGAY_SINH.Width = 252;
            // 
            // colDIA_CHI
            // 
            this.colDIA_CHI.FieldName = "DIA_CHI";
            this.colDIA_CHI.MinWidth = 67;
            this.colDIA_CHI.Name = "colDIA_CHI";
            this.colDIA_CHI.Visible = true;
            this.colDIA_CHI.VisibleIndex = 5;
            this.colDIA_CHI.Width = 252;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 67;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 6;
            this.colSDT.Width = 252;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 67;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 252;
            // 
            // colDA_CHUYEN
            // 
            this.colDA_CHUYEN.FieldName = "DA_CHUYEN";
            this.colDA_CHUYEN.MinWidth = 67;
            this.colDA_CHUYEN.Name = "colDA_CHUYEN";
            this.colDA_CHUYEN.Visible = true;
            this.colDA_CHUYEN.VisibleIndex = 8;
            this.colDA_CHUYEN.Width = 252;
            // 
            // colDA_XOA
            // 
            this.colDA_XOA.FieldName = "DA_XOA";
            this.colDA_XOA.MinWidth = 67;
            this.colDA_XOA.Name = "colDA_XOA";
            this.colDA_XOA.Visible = true;
            this.colDA_XOA.VisibleIndex = 9;
            this.colDA_XOA.Width = 252;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(dA_XOALabel);
            this.panelControl2.Controls.Add(this.txtXoa);
            this.panelControl2.Controls.Add(dA_CHUYENLabel);
            this.panelControl2.Controls.Add(this.txtChuyen);
            this.panelControl2.Controls.Add(mACNLabel);
            this.panelControl2.Controls.Add(this.txtMaCN);
            this.panelControl2.Controls.Add(sDTLabel);
            this.panelControl2.Controls.Add(this.txtSdt);
            this.panelControl2.Controls.Add(dIA_CHILabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(nGAY_SINHLabel);
            this.panelControl2.Controls.Add(this.txtNgaySinh);
            this.panelControl2.Controls.Add(pHAILabel);
            this.panelControl2.Controls.Add(this.txtPhai);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.txtHo);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txtMaNV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 136);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(413, 566);
            this.panelControl2.TabIndex = 17;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint_1);
            // 
            // txtXoa
            // 
            this.txtXoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "DA_XOA", true));
            this.txtXoa.Enabled = false;
            this.txtXoa.Location = new System.Drawing.Point(289, 420);
            this.txtXoa.MenuManager = this.barManager1;
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Properties.Caption = "";
            this.txtXoa.Size = new System.Drawing.Size(112, 29);
            this.txtXoa.TabIndex = 19;
            // 
            // txtChuyen
            // 
            this.txtChuyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "DA_CHUYEN", true));
            this.txtChuyen.Enabled = false;
            this.txtChuyen.Location = new System.Drawing.Point(115, 420);
            this.txtChuyen.MenuManager = this.barManager1;
            this.txtChuyen.Name = "txtChuyen";
            this.txtChuyen.Properties.Caption = "";
            this.txtChuyen.Size = new System.Drawing.Size(112, 29);
            this.txtChuyen.TabIndex = 17;
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MACN", true));
            this.txtMaCN.Enabled = false;
            this.txtMaCN.FormattingEnabled = true;
            this.txtMaCN.Location = new System.Drawing.Point(115, 378);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(286, 27);
            this.txtMaCN.TabIndex = 15;
            // 
            // txtSdt
            // 
            this.txtSdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "SDT", true));
            this.txtSdt.Location = new System.Drawing.Point(115, 329);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(286, 27);
            this.txtSdt.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIA_CHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(115, 275);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(286, 27);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAY_SINH", true));
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(115, 225);
            this.txtNgaySinh.MenuManager = this.barManager1;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(286, 28);
            this.txtNgaySinh.TabIndex = 9;
            // 
            // txtPhai
            // 
            this.txtPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "PHAI", true));
            this.txtPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPhai.FormattingEnabled = true;
            this.txtPhai.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.txtPhai.Location = new System.Drawing.Point(115, 171);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(286, 27);
            this.txtPhai.TabIndex = 7;
            this.txtPhai.SelectedIndexChanged += new System.EventHandler(this.txtPhai_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(115, 122);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(286, 27);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(115, 72);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(286, 27);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(115, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(286, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
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
            this.tableAdapterManager.NHAN_VIENTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1672, 702);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DS ds;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colDA_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDA_XOA;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit txtXoa;
        private DevExpress.XtraEditors.CheckEdit txtChuyen;
        private System.Windows.Forms.ComboBox txtMaCN;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiaChi;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private System.Windows.Forms.ComboBox txtPhai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaNV;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.NHAN_VIENTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}