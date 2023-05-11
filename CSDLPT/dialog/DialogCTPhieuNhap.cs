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
    public partial class DialogCTPhieuNhap : Form
    {
        public DialogCTPhieuNhap()
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
                String strLenh = "insert into CT_PHIEU_NHAP(SOPN,MAHH, SO_LUONG, DON_GIA) values("+txtPhieuNhap.Text.Trim()+","+txtVatTu.Text.Trim()+","+txtSL.Value+","+txtDonGia.Text.Trim()+")";
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
                String strLenh = "update CT_PHIEU_NHAP set SO_LUONG="+txtSL.Value+", DON_GIA='"+txtDonGia.Text.Trim()+"' where SOPN="+txtPhieuNhap.Text.Trim()+" and MAHH="+txtVatTu.Text.Trim()+"";

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
            if (txtPhieuNhap.Text.Trim().Equals(""))
            {
                msg = "phiếu nhập không được trống !";
                txtPhieuNhap.Focus();
                return msg;
            }
            if (txtSL.Text.Trim().Equals(""))
            {
                msg = "SL không được trống !";
                txtSL.Focus();
                return msg;
            }
            if (txtDonGia.Text.Trim().Equals(""))
            {
                msg = "Đơn giá không được trống !";
                txtDonGia.Focus();
                return msg;
            }
            if (txtVatTu.Text.Trim().Equals(""))
            {
                msg = "hàng hóakhông được trống !";
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
            if (bdsCTPhieuNhap.Position < 0)
                btnXoa.Enabled = btnHieuChinh.Enabled = false;
            else
                btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }

        private void cT_PHIEU_NHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogCTPhieuNhap_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.ctPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'ds.HANG_HOA' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.ds.HANG_HOA);
            // TODO: This line of code loads data into the 'dS.CT_PHIEU_NHAP' table. You can move, or remove it, as needed.
            this.ctPhieuNhapTableAdapter.Fill(this.ds.CT_PHIEU_NHAP);
            bdsCTPhieuNhap.Filter = "SOPN = "+Program.idPhieuNhap+"";
            txtPhieuNhap.Text = Program.idPhieuNhap.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelEdit.Enabled = true;

            gcCTPhieuNhap.Enabled = false;
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
            int idphieuNhap = int.Parse(((DataRowView)bdsCTPhieuNhap[bdsCTPhieuNhap.Position])["SOPN"].ToString());
            int idVatTu = int.Parse(((DataRowView)bdsCTPhieuNhap[bdsCTPhieuNhap.Position])["MAHH"].ToString());
            if (MessageBox.Show("Bạn có thật sự muốn xóa", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTPhieuNhap.RemoveCurrent();
                    this.ctPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctPhieuNhapTableAdapter.Update(this.ds.CT_PHIEU_NHAP);

                    String strLenh = "delete CT_PHIEU_NHAP where SOPN="+ idphieuNhap + " and MAHH="+idVatTu+"";
                    Program.Execute(strLenh);
                    if (Program.kt == -1)
                    {
                        MessageBox.Show("Không thể xóa");
                        this.ctPhieuNhapTableAdapter.Fill(this.ds.CT_PHIEU_NHAP);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.ctPhieuNhapTableAdapter.Fill(this.ds.CT_PHIEU_NHAP);
                    return;
                }
            }
            bdsCTPhieuNhap.Position = bdsCTPhieuNhap.Position - 1;
            disableBtn();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPhieuNhap.CancelEdit();
            if (btnThem.Enabled == false) bdsCTPhieuNhap.Position = vitri;
            btnReload_ItemClick(sender, e);
            gcCTPhieuNhap.Enabled = true;
            panelEdit.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnOut.Enabled = btnReload.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ctPhieuNhapTableAdapter.Fill(this.ds.CT_PHIEU_NHAP);
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


        private void btnShowVatTu_Click(object sender, EventArgs e)
        {
            DialogVatTu dialog = new DialogVatTu();
            dialog.Show();
            this.Enabled = false;
        }

        private void btnShowPhieuNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void DialogCTPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
    }
}
