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
    public partial class DialogLoaiHangHoa : Form
    {
        public DialogLoaiHangHoa()
        {
            InitializeComponent();
        }

        private void lOAI_HANG_HOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLoaiHangHoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogLoaiHangHoa_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.loaiHangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOAI_HANG_HOA' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter.Fill(this.ds.LOAI_HANG_HOA);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.idlHH = int.Parse(((DataRowView)bdsLoaiHangHoa[bdsLoaiHangHoa.Position])["MALHH"].ToString());
            Program.formVatTu.txtTenLHH.Text = ((DataRowView)bdsLoaiHangHoa[bdsLoaiHangHoa.Position])["TENLHH"].ToString();
            this.Close();
            Program.formVatTu.Enabled = true;
        }
    }
}
