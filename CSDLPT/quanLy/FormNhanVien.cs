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
    public partial class FormNhanVien : Form
    {
        
        int vitri = 0;
        string button = "";
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "edit";

            panelControl2.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (button.Equals("add"))
            {
                save();
            }
            else
            {
                update();
            }
            panelControl2.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void nHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.ds.NHAN_VIEN);
            bdsNhanVien.Filter = "DA_XOA = 0";


            panelControl2.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled  = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
           
        }

        private void nHAN_VIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void dA_XOALabel_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void disableBtn()
        {
            if (bdsNhanVien.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }

        public string validate()
        {
            string msg = "";
            if (txtMaNV.Text.Trim().Equals(""))
            {
                msg = "Mã nhân viên không được trống !";
                txtMaNV.Focus();
                return msg;
            }
            if (txtHo.Text.Trim().Equals(""))
            {
                msg = "Họ nhân viên không được trống !";
                txtHo.Focus();
                return msg;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                msg = "Họ nhân viên không được trống !";
                txtTen.Focus();
                return msg;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                msg = "Địa chỉ không được trống !";
                txtDiaChi.Focus();
                return msg;
            }
            if (txtSdt.Text.Trim().Equals(""))
            {
                msg = "Số điện thoại không được trống !";
                txtSdt.Focus();
                return msg;
            }
            return msg;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = true;

            gcNhanVien.Enabled = false;
            button = "add";

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = false ;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            
        }

        private void panelControl2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            { 
                try
                {
                    bdsNhanVien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.ds.NHAN_VIEN);

                    String strLenh = "EXECUTE dbo.deleteNV " + manv;
                    Program.Execute(strLenh);
                    if (Program.kt == 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.ds.NHAN_VIEN);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            bdsNhanVien.Position = bdsNhanVien.Position - 1;
            disableBtn();
        }
        private void refreshTXT()
        {
            txtChuyen.EditValue = 0;
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            txtNgaySinh.DateTime = DateTime.Now;
            txtTen.Text = "";
            txtXoa.EditValue = false;
            txtHo.Text = "";
            txtSdt.Text = "";
        }

        private void txtPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            panelControl2.Enabled = false;
            gcNhanVien.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelControl2.Enabled = false;
            gcNhanVien.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            
        }
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
                String strLenh = "EXEC SP_SaveNV '" + txtHo.Text + "','" + txtTen.Text + "',N'" + txtPhai.Text + "','" + txtNgaySinh.Text + "','" + txtSdt.Text + "','" + txtDiaChi.Text + "','" +
                Program.maChiNhanh + "'";

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
                String strLenh = "EXEC [dbo].[UpdateNV] " + txtMaNV.Text + ",N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" + txtPhai.Text + "','" + txtNgaySinh.Text + "','" + txtSdt.Text + "','" + txtDiaChi.Text + "','" +
                Program.maChiNhanh + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.myReader.Close();
                Program.conn.Close();

                MessageBox.Show("Chỉnh sửa thành công", "", MessageBoxButtons.OK);
            }

            
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            if (btnThem.Enabled == false) bdsNhanVien.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcNhanVien.Enabled = true;
            panelControl2.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.ds.NHAN_VIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
