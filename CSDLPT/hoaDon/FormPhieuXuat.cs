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
    public partial class FormPhieuXuat : Form
    {

        List<int> listVatTu = new List<int>();
        string button = "";
        int vitri = 0;
        int idHoaDon = 0;

        public string validate()
        {
            string msg = "";
            if (txtTenKH.Text.Trim().Equals(""))
            {
                msg = "Tên khách hàng không được trống !";
                txtTenKH.Focus();
                return msg;
            }
            if (Program.idKho.Equals(""))
            {
                msg = "Tên kho không được trống !";
                txtTenKH.Focus();
                return msg;
            }
            return msg;
        }
        private void save()
        {
            String message = validate();
            if (!message.Equals(""))
            {
                MessageBox.Show(message, "", MessageBoxButtons.OK);
                return;
            }
            String strLenh = "INSERT INTO HOA_DON(manv,makh, makho)  VALUES(" + txtMaNV.Text + ", " + Program.idKH + ", " + Program.idKho + ")";

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
            if (Program.idKho == 0)
            {
                Program.idKho = int.Parse(((DataRowView)bdsHoaDon[bdsHoaDon.Position])["MAKHO"].ToString());
            }
            if (Program.idKH == 0)
            {
                Program.idKH = int.Parse(((DataRowView)bdsHoaDon[bdsHoaDon.Position])["MAKH"].ToString());
            }
            String strLenh = "UPDATE HOA_DON SET MAKH=" + Program.idKH + ", MAKHO=" + Program.idKho + " WHERE MAHD=" + txtMaHD.Text + "";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Chỉnh sửa thành công", "", MessageBoxButtons.OK);
        }
        private void disableBtn()
        {
            if (bdsHoaDon.Position < 0)
            {
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            }
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        

        public FormPhieuXuat()
        {
            InitializeComponent();
            disableBtn();
        }

        private void hOA_DONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //   this.hOA_DONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void hOA_DONBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //    this.hOA_DONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.CT_HOA_DON' table. You can move, or remove it, as needed.
            this.ctHoaDonTableAdapter.Fill(this.ds.CT_HOA_DON);
            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.ds.HOA_DON);
            // TODO: This line of code loads data into the 'dS.HANG_HOA' table. You can move, or remove it, as needed.
            //   this.hANG_HOATableAdapter.Fill(this.dS.HANG_HOA);

            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

            txtTenKH.Text = Program.name;
            txtMaNV.Text = Program.username;
            txtNgay.Text = DateTime.Now.ToString();

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void btnShowKH_Click(object sender, EventArgs e)
        {
            DialogKhachHang dialogKhachHang = new DialogKhachHang();
            dialogKhachHang.Show();
            Program.formPhieuXuat.Enabled = false;

        }

        private void btnShowKho_Click(object sender, EventArgs e)
        {

            FrameKho dialog = new FrameKho(Program.formPhieuXuat);
            dialog.Show();
            Program.formPhieuXuat.Enabled = false;


        }

        private void addVatTu_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcHoaDon.Enabled = false;

            button = "add";

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "edit";

            panelEdit.Enabled = panelNhap.Enabled = true;

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
            panelHoaDon.Enabled = gcHoaDon.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = int.Parse(((DataRowView)bdsHoaDon[bdsHoaDon.Position])["MAHD"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa hóa đơn này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsHoaDon.RemoveCurrent();
                    this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hoaDonTableAdapter.Update(this.ds.HOA_DON);

                    String strLenh = "EXECUTE dbo.deleteHoaDon " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == 1)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công");
                    }
                    else if (Program.kt == -1)
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa hóa đơn \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.hoaDonTableAdapter.Fill(this.ds.HOA_DON);
                    bdsHoaDon.Position = bdsHoaDon.Find("MAHD", id);
                    return;
                }
            }
            bdsHoaDon.Position = bdsHoaDon.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHoaDon.CancelEdit();
            if (btnThem.Enabled == false) bdsHoaDon.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcHoaDon.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.hoaDonTableAdapter.Fill(this.ds.HOA_DON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
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

        private void btnDeleteVatTu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((DataRowView)bdsCtHoaDon[bdsCtHoaDon.Position])["MAHD"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết hóa đơn này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCtHoaDon.RemoveCurrent();
                    this.ctHoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctHoaDonTableAdapter.Update(this.ds.CT_HOA_DON);

                    String strLenh = "EXECUTE dbo.deleteKho " + id;
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
                    MessageBox.Show("Lỗi \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.ctHoaDonTableAdapter.Fill(this.ds.CT_HOA_DON);
                    return;
                }
            }
            bdsCtHoaDon.Position = bdsCtHoaDon.Position - 1;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            Program.idHoaDon = int.Parse(((DataRowView)bdsHoaDon[bdsHoaDon.Position])["MAHD"].ToString());

            DialogVatTu dialog = new DialogVatTu();
            dialog.Show();
            this.Enabled = false;

        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            // delete ct hoa đơn

            try
            {
                bdsCtHoaDon.RemoveCurrent();
                this.ctHoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctHoaDonTableAdapter.Update(this.ds.CT_HOA_DON);

                String strLenh = "DELETE FROM CT_HOA_DON WHERE CT_HOA_DON.MAhd=@idHD and CT_HOA_DON.MAHH=@idhh";
                Program.Execute(strLenh);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n" + ex.Message, "", MessageBoxButtons.OK);
                this.ctHoaDonTableAdapter.Fill(this.ds.CT_HOA_DON);
                return;
            }
        }

        private void btnReloadVT_Click(object sender, EventArgs e)
        {
            try
            {
                this.hoaDonTableAdapter.Fill(this.ds.HOA_DON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogCTHoaDon dialog = new DialogCTHoaDon();
            dialog.Show();
            Program.formMain.Enabled = false;
        }
    }
}
