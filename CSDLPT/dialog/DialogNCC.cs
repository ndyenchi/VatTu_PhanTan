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
    public partial class DialogNCC : Form
    {
        public DialogNCC()
        {
            InitializeComponent();
        }

        private void nHA_CCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsncc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void DialogNCC_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.nccTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.NHA_CC' table. You can move, or remove it, as needed.
            this.nccTableAdapter.Fill(this.ds.NHA_CC);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Program.idNcc = int.Parse(((DataRowView)bdsncc[bdsncc.Position])["MANCC"].ToString());
            Program.formDatHang.txtNCC.Text = ((DataRowView)bdsncc[bdsncc.Position])["TENNCC"].ToString();
            this.Close();
            Program.formDatHang.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
