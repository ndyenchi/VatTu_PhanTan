using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT
{
    static class Program
    {
        
        // form
        public static FormMain formMain;
        public static FormLogin formLogin;
        public static FormNhanVien formNhanVien;
        public static FormVatTu formVatTu;
        public static FormKhachHang formKhachHang;
        public static FormNhaCC formNhaCC;
        public static FormTaiKhoan formTaiKhoan;
        public static FormPhieuNhap formPhieuNhap;
        public static FormPhieuXuat formPhieuXuat;
        public static FormDatHang formDatHang;
        public static DialogKho formKho;
        public static Form1 form1;

        //dialog
        public static FrameKho dialogKho;
        public static DialogKhachHang dialogKhachHang;
        public static DialogVatTu DialogVatTu;
        public static DialogLoaiHangHoa dialogLoaiHangHoa;
        public static DIalogChiTietDDH  DIalogChiTietDDH;
        public static DialogNCC  dialogNCC;
        public static DialogCTHoaDon  dialogCTHoaDon;
        public static DialogDDH  dialogDDH;
        public static DialogCTPhieuNhap  dialogCTPhieuNhap;
        public static DialogPhieuNhap  DialogPhieuNhap;


        // id
        public static int idKH = 0;
        public static int idKho = 0;
        public static int idlHH = 0;
        public static int idHoaDon = 0;
        public static int idDDH = 0;
        public static int idCTDDH = 0;
        public static int idVatTu = 0;
        public static int idNcc = 0;
        public static int idPhieuNhap = 0;


        public static string name = "";

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-1KENKLS;Initial Catalog=QLVT;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";
        public static String remotelogin = "sa";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static String maChiNhanh = "";
        public static SqlCommand sqlcmd = new SqlCommand();

        public static int kt;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập



        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();

            try
            {
                Console.WriteLine(Program.servername);
                Console.WriteLine(Program.database);
                Console.WriteLine(Program.mlogin);
                Console.WriteLine(Program.password);



                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }


        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int ExecuteScalar(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //Chỉ dùng cho cơ sở dữ liệu lớn

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                kt = (int)sqlcmd.ExecuteScalar();
                return 1;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        internal static void ExecSqlNonQuery(string strLenh)
        {
            throw new NotImplementedException();
        }

        public static int Execute(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //Chỉ dùng cho cơ sở dữ liệu lớn

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                kt = 0;
                return 1;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);

        }
    }
}
