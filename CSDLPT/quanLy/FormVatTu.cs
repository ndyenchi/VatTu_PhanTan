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
    public partial class FormVatTu : Form
    {
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

            String strLenh = "EXEC [dbo].[SaveVatTu] " + "N'" + txtTenHH.Text + "',N'" + txtDVT.Text + "'," + Program.idlHH + "," + txtSL.Value + "";

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

            String strLenh = "EXEC [dbo].[UpdateVatTu] '"+ txtMaHH+ "',N'" + txtTenHH.Text + "',N'" + txtDVT + "','" + txtSL + "','" + Program.maChiNhanh + "'";

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
            if (txtTenHH.Text.Trim().Equals(""))
            {
                msg = "Tên hàng hóa không được trống !";
                txtTenHH.Focus();
                return msg;
            }
            return msg;
        }

        private void disableBtn()
        {
            if (bdsVatTu.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }

        public FormVatTu()
        {
            InitializeComponent();
        }

        private void hANG_HOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.tableAdapterVatTu.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.tableAdapterVatTu.Fill(this.ds.HANG_HOA);


            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }

        private void sO_LUONG_TONNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcVatTu.Enabled = false;
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
            gcVatTu.Enabled = true;
            panelControl2.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = int.Parse(((DataRowView)bdsVatTu[bdsVatTu.Position])["MAHH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsVatTu.RemoveCurrent();
                    this.tableAdapterVatTu.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterVatTu.Update(this.ds.HANG_HOA);

                    String strLenh = "EXECUTE dbo.deleteVatTu " + manv;
                    Program.Execute(strLenh);
                    if (Program.kt == -1)
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                    else    MessageBox.Show("Xóa thành công");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa hàng hóa \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterVatTu.Fill(this.ds.HANG_HOA);
                    bdsVatTu.Position = bdsVatTu.Find("MAHH", manv);
                    return;
                }
            }
            bdsVatTu.Position = bdsVatTu.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            if (btnThem.Enabled == false) bdsVatTu.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcVatTu.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tableAdapterVatTu.Fill(this.ds.HANG_HOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload hàng hóa \n" + ex.Message, "", MessageBoxButtons.OK);
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

        private void btnShowLoaiHH_Click(object sender, EventArgs e)
        {
            DialogLoaiHangHoa dialog = new DialogLoaiHangHoa();
            dialog.Show();
            this.Enabled = false;
        }
    }
}
