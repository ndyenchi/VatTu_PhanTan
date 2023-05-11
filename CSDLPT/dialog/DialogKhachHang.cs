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
    public partial class DialogKhachHang : Form
    {
        public DialogKhachHang()
        {
            InitializeComponent();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogKhachHang_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.KHACH_HANG' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.ds.KHACH_HANG);


        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Program.idKH = int.Parse(((DataRowView)bdsKhachHang[bdsKhachHang.Position])["MAKH"].ToString());
            Program.formPhieuXuat.txtTenKH.Text = ((DataRowView)bdsKhachHang[bdsKhachHang.Position])["TENKH"].ToString();
            this.Close();
            Program.formPhieuXuat.Enabled = true;

        }
    }
}
