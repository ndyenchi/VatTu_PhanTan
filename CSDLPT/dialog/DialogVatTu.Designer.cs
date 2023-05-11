
namespace CSDLPT
{
    partial class DialogVatTu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.hANG_HOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG_TON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hangHoaTableAdapter = new CSDLPT.DSTableAdapters.HANG_HOATableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hANG_HOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 421);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1130, 126);
            this.panelControl1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(540, 27);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 36);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.hANG_HOAGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1130, 421);
            this.panelControl2.TabIndex = 1;
            // 
            // hANG_HOAGridControl
            // 
            this.hANG_HOAGridControl.DataSource = this.bdsHangHoa;
            this.hANG_HOAGridControl.Location = new System.Drawing.Point(5, 5);
            this.hANG_HOAGridControl.MainView = this.gridView1;
            this.hANG_HOAGridControl.Name = "hANG_HOAGridControl";
            this.hANG_HOAGridControl.Size = new System.Drawing.Size(1104, 416);
            this.hANG_HOAGridControl.TabIndex = 0;
            this.hANG_HOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.hANG_HOAGridControl.Click += new System.EventHandler(this.hANG_HOAGridControl_Click);
            // 
            // bdsHangHoa
            // 
            this.bdsHangHoa.DataMember = "HANG_HOA";
            this.bdsHangHoa.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHH,
            this.colTENHH,
            this.colDVT,
            this.colMALHH,
            this.colSO_LUONG_TON});
            this.gridView1.GridControl = this.hANG_HOAGridControl;
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
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_DDHTableAdapter = null;
            this.tableAdapterManager.CT_HOA_DONTableAdapter = null;
            this.tableAdapterManager.CT_PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HANG_HOATableAdapter = this.hangHoaTableAdapter;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_HANG_HOATableAdapter = null;
            this.tableAdapterManager.NHA_CCTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DialogVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 547);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DialogVatTu";
            this.Text = "DialogVatTu";
            this.Load += new System.EventHandler(this.DialogVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hANG_HOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnOk;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DS ds;
        private System.Windows.Forms.BindingSource bdsHangHoa;
        private DSTableAdapters.HANG_HOATableAdapter hangHoaTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hANG_HOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHH;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG_TON;
    }
}