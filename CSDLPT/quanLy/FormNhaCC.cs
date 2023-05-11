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
    public partial class FormNhaCC : Form
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

            String strLenh = "INSERT INTO NHA_CC(TENNCC, DIA_CHI, SDT)  VALUES(' " + txtTen.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text.Trim() + "')";

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

            String strLenh = "UPDATE NHA_CC SET TENNCC= '" + txtTen + "',DIA_CHI='" + txtDiaChi + "', SDT='" + txtSDT + "' WHERE MANCC='" + txtMaNCC + "'";
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

            if (txtTen.Text.Trim().Equals(""))
            {
                msg = "Tên nhà cung cấp không được trống !";
                txtTen.Focus();
                return msg;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                msg = "Dịa chỉ không được trống !";
                txtTen.Focus();
                return msg;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                msg = "SDT không được trống !";
                txtTen.Focus();
                return msg;
                return msg;
            }
            return msg;
        }
        private void disableBtn()
        {
            if (bdsNhaCC.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        public FormNhaCC()
        {
            InitializeComponent();
        }

        private void nHA_CCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhaCC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.nhaCCTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nhaCCTableAdapter.Fill(this.ds.NHA_CC);


            panelEdit.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcNhaCC.Enabled = false;
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
            int id = int.Parse(((DataRowView)bdsNhaCC[bdsNhaCC.Position])["MAKHO"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa KHo này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNhaCC.RemoveCurrent();
                    this.nhaCCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhaCCTableAdapter.Update(this.ds.NHA_CC);

                    String strLenh = "EXECUTE dbo.deleteNhaCC " + id;
                    Program.Execute(strLenh);
                    if (Program.kt == 1)
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công");
                    }
                    else if (Program.kt == 1)
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa Kho \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhaCCTableAdapter.Fill(this.ds.NHA_CC);
                    bdsNhaCC.Position = bdsNhaCC.Find("MANCC", id);
                    return;
                }
            }
            bdsNhaCC.Position = bdsNhaCC.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhaCC.CancelEdit();
            if (btnThem.Enabled == false) bdsNhaCC.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcNhaCC.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhaCCTableAdapter.Fill(this.ds.NHA_CC);
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
            gcNhaCC.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Enabled = false;
            gcNhaCC.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
    }
}
