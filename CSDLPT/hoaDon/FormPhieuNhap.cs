using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        int vitri = 0;
        string button = "";

        private void save()
        {

            String message = validate();
            if (!message.Equals(""))
            {
                MessageBox.Show(message, "", MessageBoxButtons.OK);
                return;
            }

            String strLenh = "INSERT INTO PHIEU_NHAP(MANV, MADDH,MaKHo) VALUES ("+txtMaNV.Text + ","+txtMADDH.Text+","+Program.idKho+")";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("lưu thành công", "", MessageBoxButtons.OK);
        }
        private void update()
        {

            String message = validate();
            if (!message.Equals(""))
            {
                MessageBox.Show(message, "", MessageBoxButtons.OK);
                return;
            }

            String strLenh = "Update PHIEU_NHAP set MADDH="+txtMADDH.Text+" , MaKHO="+Program.idKho+" where SOPN="+txtSoPN.Text+"";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Chỉnh sửa thành công", "", MessageBoxButtons.OK);
        }
        public string validate()
        {
            string msg = "";

            if (txtKho.Text.Trim().Equals(""))
            {
                msg = "Kho không được trống !";
                txtKho.Focus();
                return msg;
            }
            if(txtMADDH.Text.Trim().Equals(""))
            {
                msg = "đơn đặt hàng không được trống !";
                txtMADDH.Focus();
                return msg;
            }
            return msg;
        }
        private void disableBtn()
        {
            if (bdsPhieuNhap.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        public void loadInfo()
        {
            txtMaNV.Text = Program.username;
            txtNgay.Text = DateTime.Now.ToString();
            txtKho.Text = Program.idKho.ToString();
        }
        private void pHIEU_NHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {

            ds.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.PHIEU_NHAP' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.ds.PHIEU_NHAP);
            button = "add";
            loadInfo();
        }

        private void btnShowDDH_Click(object sender, EventArgs e)
        {
            DialogDDH dialog = new DialogDDH();
            dialog.Show();
            this.Enabled = false;
        }

        private void btnShowKho_Click(object sender, EventArgs e)
        {
            FrameKho dialog = new FrameKho(Program.formPhieuNhap);
            dialog.Show();
            this.Enabled = false;
        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.idPhieuNhap  = int.Parse(((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["SOPN"].ToString());

            DialogCTPhieuNhap dialog = new DialogCTPhieuNhap();
            dialog.Show();
            this.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcPhieuNhap.Enabled = false;
            button = "add";

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "edit";

            panelEdit.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (button.Equals("add"))
            {
                save();
            }
            else
            {
                update();
            }
            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = int.Parse(((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["SOPN"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsPhieuNhap.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.ds.PHIEU_NHAP);

                    String strLenh = "EXECUTE dbo.deletePhieuNhap " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == 1)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else if (Program.kt == 1)
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.ds.PHIEU_NHAP);
                    bdsPhieuNhap.Position = bdsPhieuNhap.Find("SOPN", id);
                    return;
                }
            }
            bdsPhieuNhap.Position = bdsPhieuNhap.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.CancelEdit();
            if (btnThem.Enabled == false) bdsPhieuNhap.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcPhieuNhap.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuNhapTableAdapter.Fill(this.ds.PHIEU_NHAP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
