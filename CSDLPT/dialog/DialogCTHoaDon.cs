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
    public partial class DialogCTHoaDon : Form
    {
        public DialogCTHoaDon()
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

            String strLenh = "execute [dbo].[SaveCTHoaDon] "+txtMaHD.Text+", "+txtVatTu.Text+","+txtSL.Value+","+txtDonGia.Text+"";
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

            String strLenh = "";

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

            if (txtVatTu.Text.Trim().Equals(""))
            {
                msg = "hàng hóa không được trống !";
                txtVatTu.Focus();
                return msg;
            }
            for (int i = 0; i < gridView2.Columns.Count; i++)
            {
                msg = "hàng hóa không tồn tại !";
                String id = ((DataRowView)bdsHangHoa[bdsHangHoa.Position])["MAHH"].ToString();
                if (txtVatTu.Text.Equals(id))
                {
                    msg = "";
                    return msg;
                }
            }
            return msg;
        }
        private void disableBtn()
        {
            if (bdsCTHD.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        private void cT_HOA_DONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTHD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogCTHoaDon_Load(object sender, EventArgs e)
        {

            ds.EnforceConstraints = false;
            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'ds.HANG_HOA' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.ds.HANG_HOA);
            // TODO: This line of code loads data into the 'dS.CT_HOA_DON' table. You can move, or remove it, as needed.
            this.cthdTableAdapter.Fill(this.ds.CT_HOA_DON);
            button = "add";
        }

        private void btnShowVatTu_Click(object sender, EventArgs e)
        {
            DialogVatTu dialog = new DialogVatTu();
            dialog.Show();
            this.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gccthd.Enabled = false;
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
            int idddh = int.Parse(((DataRowView)bdsCTHD[bdsCTHD.Position])["MADDH"].ToString());
            int idhh = int.Parse(((DataRowView)bdsCTHD[bdsCTHD.Position])["MAHH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTHD.RemoveCurrent();
                    this.cthdTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cthdTableAdapter.Update(this.ds.CT_HOA_DON);

                    String strLenh = "EXECUTE dbo.deleteKho " + idddh;
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
                    this.cthdTableAdapter.Fill(this.ds.CT_HOA_DON);
                    bdsCTHD.Position = bdsCTHD.Find("MAHH", idhh);
                    return;
                }
            }
            bdsCTHD.Position = bdsCTHD.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTHD.CancelEdit();
            if (btnThem.Enabled == false) bdsCTHD.Position = vitri;
            btnReload_ItemClick(sender, e);
            gccthd.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cthdTableAdapter.Fill(this.ds.CT_HOA_DON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload Don đặt hàng \n" + ex.Message, "", MessageBoxButtons.OK);
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

        private void DialogCTHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
    }
}
