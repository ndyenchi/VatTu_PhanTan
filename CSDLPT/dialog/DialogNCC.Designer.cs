
namespace CSDLPT
{
    partial class DialogNCC
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
            this.nHA_CCGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsncc = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new CSDLPT.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new System.Windows.Forms.Button();
            this.nccTableAdapter = new CSDLPT.DSTableAdapters.NHA_CCTableAdapter();
            this.tableAdapterManager = new CSDLPT.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_CCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nHA_CCGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 550);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // nHA_CCGridControl
            // 
            this.nHA_CCGridControl.DataSource = this.bdsncc;
            this.nHA_CCGridControl.Location = new System.Drawing.Point(12, 12);
            this.nHA_CCGridControl.MainView = this.gridView1;
            this.nHA_CCGridControl.Name = "nHA_CCGridControl";
            this.nHA_CCGridControl.Size = new System.Drawing.Size(776, 390);
            this.nHA_CCGridControl.TabIndex = 0;
            this.nHA_CCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsncc
            // 
            this.bdsncc.DataMember = "NHA_CC";
            this.bdsncc.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DS";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANCC,
            this.colTENNCC,
            this.colDIA_CHI,
            this.colSDT});
            this.gridView1.GridControl = this.nHA_CCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANCC
            // 
            this.colMANCC.FieldName = "MANCC";
            this.colMANCC.MinWidth = 30;
            this.colMANCC.Name = "colMANCC";
            this.colMANCC.Visible = true;
            this.colMANCC.VisibleIndex = 0;
            this.colMANCC.Width = 112;
            // 
            // colTENNCC
            // 
            this.colTENNCC.FieldName = "TENNCC";
            this.colTENNCC.MinWidth = 30;
            this.colTENNCC.Name = "colTENNCC";
            this.colTENNCC.Visible = true;
            this.colTENNCC.VisibleIndex = 1;
            this.colTENNCC.Width = 112;
            // 
            // colDIA_CHI
            // 
            this.colDIA_CHI.FieldName = "DIA_CHI";
            this.colDIA_CHI.MinWidth = 30;
            this.colDIA_CHI.Name = "colDIA_CHI";
            this.colDIA_CHI.Visible = true;
            this.colDIA_CHI.VisibleIndex = 2;
            this.colDIA_CHI.Width = 112;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 30;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 112;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnOK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 450);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(359, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nccTableAdapter
            // 
            this.nccTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHA_CCTableAdapter = this.nccTableAdapter;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_NHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DialogNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "DialogNCC";
            this.Text = "FormNCC";
            this.Load += new System.EventHandler(this.DialogNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHA_CCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DS ds;
        private System.Windows.Forms.BindingSource bdsncc;
        private DSTableAdapters.NHA_CCTableAdapter nccTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHA_CCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private System.Windows.Forms.Button btnOK;
    }
}