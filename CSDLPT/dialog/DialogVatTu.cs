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
    public partial class DialogVatTu : Form
    {

        public DialogVatTu()
        {
            InitializeComponent();
        }

        private void hANG_HOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHangHoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogVatTu_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.HANG_HOA' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.ds.HANG_HOA);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Program.idVatTu = int.Parse(((DataRowView)bdsHangHoa[bdsHangHoa.Position])["MAHH"].ToString());
                this.Close();
                Program.formMain.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("có loi "+ex.Message,"", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void hANG_HOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHangHoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void hANG_HOAGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
