
namespace CSDLPT
{
    partial class DialogLoaiHangHoa
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lOAI_HANG_HOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLoaiHangHoa = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.loaiHangHoaTableAdapter = new CSDLPT.DSTableAdapters.LOAI_HANG_HOATableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_HANG_HOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lOAI_HANG_HOAGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 529);
            this.panelControl1.TabIndex = 0;
            // 
            // lOAI_HANG_HOAGridControl
            // 
            this.lOAI_HANG_HOAGridControl.DataSource = this.bdsLoaiHangHoa;
            gridLevelNode2.RelationName = "FK_CT_DDH_HANG_HOA";
            gridLevelNode3.RelationName = "FK_CT_HOA_DON_HANG_HOA";
            gridLevelNode4.RelationName = "FK_CT_PHIEU_NHAP_HANG_HOA";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4});
            gridLevelNode1.RelationName = "FK_HANG_HOA_LOAI_HANG_HOA";
            this.lOAI_HANG_HOAGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.lOAI_HANG_HOAGridControl.Location = new System.Drawing.Point(5, 5);
            this.lOAI_HANG_HOAGridControl.MainView = this.gridView1;
            this.lOAI_HANG_HOAGridControl.Name = "lOAI_HANG_HOAGridControl";
            this.lOAI_HANG_HOAGridControl.Size = new System.Drawing.Size(774, 425);
            this.lOAI_HANG_HOAGridControl.TabIndex = 0;
            this.lOAI_HANG_HOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLoaiHangHoa
            // 
            this.bdsLoaiHangHoa.DataMember = "LOAI_HANG_HOA";
            this.bdsLoaiHangHoa.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALHH,
            this.colTENLHH});
            this.gridView1.GridControl = this.lOAI_HANG_HOAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALHH
            // 
            this.colMALHH.FieldName = "MALHH";
            this.colMALHH.MinWidth = 30;
            this.colMALHH.Name = "colMALHH";
            this.colMALHH.Visible = true;
            this.colMALHH.VisibleIndex = 0;
            this.colMALHH.Width = 112;
            // 
            // colTENLHH
            // 
            this.colTENLHH.FieldName = "TENLHH";
            this.colTENLHH.MinWidth = 30;
            this.colTENLHH.Name = "colTENLHH";
            this.colTENLHH.Visible = true;
            this.colTENLHH.VisibleIndex = 1;
            this.colTENLHH.Width = 112;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnOk);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 450);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 79);
            this.panelControl2.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(335, 23);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 44);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // loaiHangHoaTableAdapter
            // 
            this.loaiHangHoaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOAI_HANG_HOATableAdapter = this.loaiHangHoaTableAdapter;
            this.tableAdapterManager.NHA_CCTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DialogLoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DialogLoaiHangHoa";
            this.Text = "DialogLoaiHangHoa";
            this.Load += new System.EventHandler(this.DialogLoaiHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_HANG_HOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnOk;
        private DS ds;
        private System.Windows.Forms.BindingSource bdsLoaiHangHoa;
        private DSTableAdapters.LOAI_HANG_HOATableAdapter loaiHangHoaTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAI_HANG_HOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLHH;
    }
}