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
    public partial class DialogDDH : Form
    {
        public DialogDDH()
        {
            InitializeComponent();
        }

        private void dONDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dONDHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void DialogDDH_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.dONDHTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS.DONDH' table. You can move, or remove it, as needed.
            this.dONDHTableAdapter.Fill(this.dS.DONDH);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Program.idDDH = int.Parse(((DataRowView)dONDHBindingSource[dONDHBindingSource.Position])["MADDH"].ToString());
            Program.formPhieuNhap.txtMADDH.Text = ((DataRowView)dONDHBindingSource[dONDHBindingSource.Position])["MADDH"].ToString();
            this.Close();
            Program.formPhieuNhap.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
