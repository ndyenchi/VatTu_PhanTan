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
    public partial class FrameKho : Form
    {
        Form form;
        public FrameKho(Form a)
        {
            InitializeComponent();
            this.form = a;
        }

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void FrameKho_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.ds.KHO);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Program.idKho = int.Parse(((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString());
            this.Close();
            
            this.form.Enabled = true;
           
        }
    }
}
