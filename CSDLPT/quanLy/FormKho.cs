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
    public partial class DialogKho : Form
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

            String strLenh = "EXEC [dbo].[SaveKho] " + "'" + txtTenKho.Text + "','" + Program.maChiNhanh + "'";
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

            String strLenh = "EXEC [dbo].[UpdateKho] '" + txtMaKho + "',N'" + txtTenKho.Text + "','" + Program.maChiNhanh + "'";

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
            
            if (txtTenKho.Text.Trim().Equals(""))
            {
                msg = "Tên Kho không được trống !";
                txtTenKho.Focus();
                return msg;
            }
            return msg;
        }
        private void disableBtn()
        {
            if (bdsKho.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        public DialogKho()
        {
            InitializeComponent();
        }

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.ds.KHO);


            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcKho.Enabled = false;
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
            int id = int.Parse(((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa KHo này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.ds.KHO);

                    String strLenh = "EXECUTE dbo.deleteKho " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == 1)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                    else if (Program.kt == 1)
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa Kho \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.ds.KHO);
                    bdsKho.Position = bdsKho.Find("MAKHO", id);
                    return;
                }
            }
            bdsKho.Position = bdsKho.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            if (btnThem.Enabled == false) bdsKho.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcKho.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.ds.KHO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload Kho \n" + ex.Message, "", MessageBoxButtons.OK);
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

        private void btnSave_Click(object sender, EventArgs e)
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
            gcKho.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Enabled = false;
            gcKho.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
    }
}
