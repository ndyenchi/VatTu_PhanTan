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
    public partial class DIalogChiTietDDH : Form
    {
        public DIalogChiTietDDH()
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

            String strLenh = "";
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
            if (bdsCTDDH.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
        private void cT_DDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DIalogChiTietDDH_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.ctDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANG_HOATableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'ds.HANG_HOA' table. You can move, or remove it, as needed.
            this.hANG_HOATableAdapter.Fill(this.ds.HANG_HOA);
            
            this.ctDDHTableAdapter.Fill(this.ds.CT_DDH);
            bdsCTDDH.Filter = "MADDH = "+ Program.idDDH+"";
            txtMaDDH.Text = Program.idDDH.ToString() ;
            

        }

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowVatTu_Click(object sender, EventArgs e)
        {
            DialogVatTu dialog = new DialogVatTu();
            dialog.Show();
            Program.formMain.Enabled = false;
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcctddh.Enabled = false;
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
            int idddh = int.Parse(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MADDH"].ToString());
            int idhh = int.Parse(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAHH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTDDH.RemoveCurrent();
                    this.ctDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctDDHTableAdapter.Update(this.ds.CT_DDH);

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
                    this.ctDDHTableAdapter.Fill(this.ds.CT_DDH);
                    bdsCTDDH.Position = bdsCTDDH.Find("MADDH", idddh);
                    return;
                }
            }
            bdsCTDDH.Position = bdsCTDDH.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTDDH.CancelEdit();
            if (btnThem.Enabled == false) bdsCTDDH.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcctddh.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ctDDHTableAdapter.Fill(this.ds.CT_DDH);
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

        private void DIalogChiTietDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
