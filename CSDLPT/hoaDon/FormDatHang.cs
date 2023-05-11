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
    public partial class FormDatHang : Form
    {
        public FormDatHang()
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
            String strLenh = "insert into DONDH(MANCC, MANV, NGAY_LAP) values("+Program.idNcc+","+Program.username+",'"+txtNgayLap.Text+"')";
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
            int id = int.Parse(((DataRowView)bdsDDH[bdsDDH.Position])["MADDH"].ToString());

            String strLenh = "update DONDH set MANCC="+Program.idNcc+" where MADDH="+ id + "";

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

            if (txtNCC.Text.Trim().Equals(""))
            {
                msg = "Nhà cung cap không được trống !";
                txtNCC.Focus();
                return msg;
            }
            return msg;
        }
        private void disableBtn()
        {
            if (bdsDDH.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        public void loadInfo()
        {
            txtMANV.Text = Program.username;
            txtNgayLap.Text = DateTime.Now.ToString();

        }
        private void dONDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.ddhTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.DONDH' table. You can move, or remove it, as needed.
            this.ddhTableAdapter.Fill(this.ds.DONDH);

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            panelEdit.Enabled = false;

            loadInfo();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcDDH.Enabled = false;
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
            panelControl2.Enabled = gcDDH.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = int.Parse(((DataRowView)bdsDDH[bdsDDH.Position])["MADDH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDDH.RemoveCurrent();
                    this.ddhTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ddhTableAdapter.Update(this.ds.DONDH);

                    String strLenh = "EXECUTE dbo.deleteDdh " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == 1)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else if (Program.kt == -1)
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.ddhTableAdapter.Fill(this.ds.DONDH);
                    bdsDDH.Position = bdsDDH.Find("MADDH", id);
                    return;
                }
            }
            bdsDDH.Position = bdsDDH.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDDH.CancelEdit();
            if (btnThem.Enabled == false) bdsDDH.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcDDH.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ddhTableAdapter.Fill(this.ds.DONDH);
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

        private void btnChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            Program.idDDH= int.Parse(((DataRowView)bdsDDH[bdsDDH.Position])["MADDH"].ToString());
            DIalogChiTietDDH dialog = new DIalogChiTietDDH();
            dialog.Show();
            Program.formMain.Enabled = false;
        }

        private void btnShowNhaCC_Click(object sender, EventArgs e)
        {
            DialogNCC dialog = new DialogNCC();
            dialog.Show();
            this.Enabled = false;
        }
    }
}
