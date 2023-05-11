using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FormLogin : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();

        public FormLogin()
        {
            InitializeComponent();

        }
        private void lay_dspm(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCN";
            comboBox1.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kế nối về cơ sở dữ liệu gốc.\n Bạn xem lại Tên Server của Publisher, và tên CSDL", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chinhanh = comboBox1.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;
            
            if (username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống ", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = username;
            Program.password = password;

            if (Program.KetNoi() == 0)
                return;

            Program.mChinhanh = comboBox1.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu,\n bạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (Program.mChinhanh == 1) Program.maChiNhanh = "CN1";
            else Program.maChiNhanh = "CN2";

            Program.formMain.tSSL_MaNV.Text = "Mã NV: " + Program.username;
            Program.formMain.tSSL_ChiNhanh.Text = "Họ Tên: " + Program.mHoten;
            Program.formMain.tSSL_MatKhau.Text = "Nhóm: " + Program.mGroup;

            MessageBox.Show("Đăng nhập vào site " + Program.maChiNhanh, "", MessageBoxButtons.OK);
            enableAll();
            Program.formMain.barButtonItem1.Enabled = false;
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0)
                return;
            lay_dspm("SELECT * FROM V_DS_PHANMANH1");
            comboBox1.SelectedIndex = 1;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comboBox1.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void enableAll()
        {
            Program.formMain.barButtonItem2.Enabled = Program.formMain.barButtonItem3.Enabled = Program.formMain.barButtonItem21.Enabled = Program.formMain.barButtonItem20.Enabled =
            Program.formMain.barButtonItem17.Enabled = Program.formMain.barButtonItem13.Enabled = Program.formMain.barButtonItem12.Enabled = Program.formMain.barButtonItem4.Enabled =
            Program.formMain.barButtonItem16.Enabled = Program.formMain.barButtonItem15.Enabled = Program.formMain.barButtonItem9.Enabled = Program.formMain.barButtonItem8.Enabled = 
            Program.formMain.barButtonItem14.Enabled = Program.formMain.barButtonItem22.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
