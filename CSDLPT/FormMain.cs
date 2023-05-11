using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            disableAll();
        }

        private void disableAll()
        {
            barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem21.Enabled = barButtonItem20.Enabled =
            barButtonItem17.Enabled = barButtonItem13.Enabled = barButtonItem12.Enabled = barButtonItem4.Enabled =
            barButtonItem16.Enabled = barButtonItem15.Enabled = barButtonItem9.Enabled = barButtonItem8.Enabled =
            barButtonItem14.Enabled = barButtonItem22.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLogin));
            if (frm != null) frm.Activate();
            else
            {
                Program.formLogin = new FormLogin();
                Program.formLogin.MdiParent = this;
                Program.formLogin.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTaiKhoan = new FormTaiKhoan();
                Program.formTaiKhoan.MdiParent = this;
                Program.formTaiKhoan.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Program.form1 = new Form1();
         //   Program.form1.MdiParent = this;
            Program.form1.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Program.formVatTu = new FormVatTu();
                Program.formVatTu.MdiParent = this;
                Program.formVatTu.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKhachHang = new FormKhachHang();
                Program.formKhachHang.MdiParent = this;
                Program.formKhachHang.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(DialogKho));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKho = new DialogKho();
                Program.formKho.MdiParent = this;
                Program.formKho.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhaCC));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhaCC = new FormNhaCC();
                Program.formNhaCC.MdiParent = this;
                Program.formNhaCC.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuNhap = new FormPhieuNhap();
                Program.formPhieuNhap.MdiParent = this;
                Program.formPhieuNhap.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhieuXuat = new FormPhieuXuat();
                Program.formPhieuXuat.MdiParent = this;
                Program.formPhieuXuat.Show();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDatHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDatHang = new FormDatHang();
                Program.formDatHang.MdiParent = this;
                Program.formDatHang.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(DialogKho));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(FormVatTu));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(FormPhieuNhap));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(FormPhieuXuat));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(FormDatHang));
            if (frm != null) frm.Close();

            frm = this.CheckExists(typeof(FormTaiKhoan));
            if (frm != null) frm.Close();

            disableAll();
            barButtonItem1.Enabled = true;
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDDH rp = new ReportDDH();
            ReportPrintTool rpt = new ReportPrintTool(rp);
            rp.ShowPreviewDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
