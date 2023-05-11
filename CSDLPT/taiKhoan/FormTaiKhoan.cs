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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void nHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.dS.NHAN_VIEN);
            
            if (Program.mGroup == "CONGTY")
            {
                cbbQuyen.Items.Add("CONGTY");
                cbbQuyen.SelectedIndex = 0;
                cbbQuyen.Enabled = false;
                cbbChiNhanh.Enabled = true;
            }
            else
            {
                cbbChiNhanh.Enabled = false;
                cbbQuyen.Items.Add("CHINHANH");
                cbbQuyen.Items.Add("USER");
                cbbQuyen.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "", MessageBoxButtons.OK);
                txtUser.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            string hoten = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["HO"].ToString().Trim()+ ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TEN"].ToString().Trim();

            if (hoten.Trim() == "")
            {
                MessageBox.Show("vui long chon nhan vien", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            

            Program.mChinhanh = cbbChiNhanh.SelectedIndex;
            if (Program.KetNoi() == 0) return;

            String strLenh = "EXECUTE dbo.SP_TAOTAIKHOAN N'" + txtUser.Text + "', N'" + txtPass.Text + "', N'" + txtPass + "', N'" + cbbQuyen.SelectedItem + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            MessageBox.Show("Tạo tài khoản thành công " + Program.mlogin, " ", MessageBoxButtons.OK);

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            Program.myReader.Close();
            Program.conn.Close();

            Program.formMain.tSSL_MaNV.Text = "Mã nhân viên: " + Program.username;
            Program.formMain.tSSL_MatKhau.Text = "Họ tên: " + Program.mHoten;
            Program.formMain.tSSL_ChiNhanh.Text = "Nhóm: " + Program.mGroup;
            txtId.Text = hoten;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
