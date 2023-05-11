using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
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
            else
            {
                String strLenh = "EXEC [dbo].[SaveKH] " + "N'" + txtTenKH.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text.Trim() + "','" + Program.maChiNhanh + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("lưu thành công", "", MessageBoxButtons.OK);
            }

            
        }
        private void update()
        {
            String message = validate();
            if (!message.Equals(""))
            {
                MessageBox.Show(message, "", MessageBoxButtons.OK);
                return;
            }
            else
            {
            String strLenh = "EXEC [dbo].[UpdateKH] " + "'" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + Program.maChiNhanh + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.myReader.Close();
            Program.conn.Close();

            MessageBox.Show("Chỉnh sửa thành công", "", MessageBoxButtons.OK);
            }
        }

        public string validate()
        {
            string msg = "";
            if (txtTenKH.Text.Trim().Equals(""))
            {
                msg = "Tên khách hàng không được trống !";
                txtTenKH.Focus();
                return msg;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                msg = "Tên khách hàng không được trống !";
                txtTenKH.Focus();
                return msg;
            }
            var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            if (!r.IsMatch(txtSDT.Text))
             {
                msg = "so dien thoai khong dung dinh dang !";
                txtTenKH.Focus();
                return msg;
            }
            return msg;
        }

        private void disableBtn()
        {
            if (bdsKhachHang.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.tableAdapterKhachHang.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.KHACH_HANG' table. You can move, or remove it, as needed.
            this.tableAdapterKhachHang.Fill(this.ds.KHACH_HANG);
            
            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcKhachHang.Enabled = false;
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
            int id = int.Parse(((DataRowView)bdsKhachHang[bdsKhachHang.Position])["MAKH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKhachHang.RemoveCurrent();
                    this.tableAdapterKhachHang.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterKhachHang.Update(this.ds.KHACH_HANG);

                    String strLenh = "EXECUTE dbo.deleteKH " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == -1)
                    {
                        MessageBox.Show("Không thể xóa");
                        this.tableAdapterKhachHang.Fill(this.ds.KHACH_HANG);
                        bdsKhachHang.Position = bdsKhachHang.Find("MANV", id);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterKhachHang.Fill(this.ds.KHACH_HANG);
                    bdsKhachHang.Position = bdsKhachHang.Find("MANV", id);
                    return;
                }
            }
            bdsKhachHang.Position = bdsKhachHang.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhachHang.CancelEdit();
            if (btnThem.Enabled == false) bdsKhachHang.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcKhachHang.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tableAdapterKhachHang.Fill(this.ds.KHACH_HANG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload khách hàng \n" + ex.Message, "", MessageBoxButtons.OK);
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
            gcKhachHang.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Enabled = false;
            gcKhachHang.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
    }
}
