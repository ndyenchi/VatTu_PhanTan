
namespace CSDLPT
{
    partial class FormVatTu
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
            System.Windows.Forms.Label tENHHLabel;
            System.Windows.Forms.Label sO_LUONG_TONLabel;
            System.Windows.Forms.Label dVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
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
            this.panelEdit = new DevExpress.XtraEditors.PanelControl();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.btnShowLoaiHH = new System.Windows.Forms.Button();
            this.txtTenLHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.NumericUpDown();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG_TON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterVatTu = new CSDLPT.DSTableAdapters.HANG_HOATableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            mAHHLabel = new System.Windows.Forms.Label();
            tENHHLabel = new System.Windows.Forms.Label();
            sO_LUONG_TONLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHHLabel
            // 
            mAHHLabel.AutoSize = true;
            mAHHLabel.Location = new System.Drawing.Point(82, 64);
            mAHHLabel.Name = "mAHHLabel";
            mAHHLabel.Size = new System.Drawing.Size(60, 19);
            mAHHLabel.TabIndex = 0;
            mAHHLabel.Text = "MAHH:";
            // 
            // tENHHLabel
            // 
            tENHHLabel.AutoSize = true;
            tENHHLabel.Location = new System.Drawing.Point(75, 109);
            tENHHLabel.Name = "tENHHLabel";
            tENHHLabel.Size = new System.Drawing.Size(67, 19);
            tENHHLabel.TabIndex = 2;
            tENHHLabel.Text = "TENHH:";
            // 
            // sO_LUONG_TONLabel
            // 
            sO_LUONG_TONLabel.AutoSize = true;
            sO_LUONG_TONLabel.Location = new System.Drawing.Point(10, 243);
            sO_LUONG_TONLabel.Name = "sO_LUONG_TONLabel";
            sO_LUONG_TONLabel.Size = new System.Drawing.Size(132, 19);
            sO_LUONG_TONLabel.TabIndex = 8;
            sO_LUONG_TONLabel.Text = "SO LUONG TON:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(96, 154);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(46, 19);
            dVTLabel.TabIndex = 12;
            dVTLabel.Text = "DVT:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1100, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 636);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 602);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(dVTLabel);
            this.panelEdit.Controls.Add(this.txtDVT);
            this.panelEdit.Controls.Add(this.btnShowLoaiHH);
            this.panelEdit.Controls.Add(this.txtTenLHH);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(sO_LUONG_TONLabel);
            this.panelEdit.Controls.Add(this.txtSL);
            this.panelEdit.Controls.Add(tENHHLabel);
            this.panelEdit.Controls.Add(this.txtTenHH);
            this.panelEdit.Controls.Add(mAHHLabel);
            this.panelEdit.Controls.Add(this.txtMaHH);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdit.Location = new System.Drawing.Point(0, 34);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(450, 602);
            this.panelEdit.TabIndex = 4;
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(148, 151);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(217, 27);
            this.txtDVT.TabIndex = 13;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "HANG_HOA";
            this.bdsVatTu.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShowLoaiHH
            // 
            this.btnShowLoaiHH.Location = new System.Drawing.Point(385, 200);
            this.btnShowLoaiHH.Name = "btnShowLoaiHH";
            this.btnShowLoaiHH.Size = new System.Drawing.Size(45, 29);
            this.btnShowLoaiHH.TabIndex = 12;
            this.btnShowLoaiHH.Text = "...";
            this.btnShowLoaiHH.UseVisualStyleBackColor = true;
            this.btnShowLoaiHH.Click += new System.EventHandler(this.btnShowLoaiHH_Click);
            // 
            // txtTenLHH
            // 
            this.txtTenLHH.Location = new System.Drawing.Point(149, 200);
            this.txtTenLHH.Name = "txtTenLHH";
            this.txtTenLHH.Size = new System.Drawing.Size(216, 27);
            this.txtTenLHH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Loại Hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsVatTu, "SO_LUONG_TON", true));
            this.txtSL.Location = new System.Drawing.Point(148, 243);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(217, 27);
            this.txtSL.TabIndex = 9;
            this.txtSL.ValueChanged += new System.EventHandler(this.sO_LUONG_TONNumericUpDown_ValueChanged);
            // 
            // txtTenHH
            // 
            this.txtTenHH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENHH", true));
            this.txtTenHH.Location = new System.Drawing.Point(148, 106);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(217, 27);
            this.txtTenHH.TabIndex = 3;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "MAHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(148, 61);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(217, 27);
            this.txtMaHH.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcVatTu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(450, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(650, 602);
            this.panelControl2.TabIndex = 5;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Location = new System.Drawing.Point(6, 6);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(685, 394);
            this.gcVatTu.TabIndex = 0;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTENHH,
            this.colDVT,
            this.colMALHH,
            this.colSO_LUONG_TON});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
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
            // colTENHH
            // 
            this.colTENHH.FieldName = "TENHH";
            this.colTENHH.MinWidth = 30;
            this.colTENHH.Name = "colTENHH";
            this.colTENHH.Visible = true;
            this.colTENHH.VisibleIndex = 1;
            this.colTENHH.Width = 112;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 30;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 112;
            // 
            // colMALHH
            // 
            this.colMALHH.FieldName = "MALHH";
            this.colMALHH.MinWidth = 30;
            this.colMALHH.Name = "colMALHH";
            this.colMALHH.Visible = true;
            this.colMALHH.VisibleIndex = 3;
            this.colMALHH.Width = 112;
            // 
            // colSO_LUONG_TON
            // 
            this.colSO_LUONG_TON.FieldName = "SO_LUONG_TON";
            this.colSO_LUONG_TON.MinWidth = 30;
            this.colSO_LUONG_TON.Name = "colSO_LUONG_TON";
            this.colSO_LUONG_TON.Visible = true;
            this.colSO_LUONG_TON.VisibleIndex = 4;
            this.colSO_LUONG_TON.Width = 112;
            // 
            // tableAdapterVatTu
            // 
            this.tableAdapterVatTu.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DDHTableAdapter = null;
            this.tableAdapterManager.CT_HOA_DONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = this.tableAdapterVatTu;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_HANG_HOATableAdapter = null;
            this.tableAdapterManager.NHA_CCTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DS ds;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelEdit;
        private DSTableAdapters.HANG_HOATableAdapter tableAdapterVatTu;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG_TON;
        private System.Windows.Forms.NumericUpDown txtSL;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Button btnShowLoaiHH;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenLHH;
        private System.Windows.Forms.TextBox txtDVT;
    }
}