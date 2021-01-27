using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTienLuong
{
    public partial class frmLogin : Form
    {
        ////private SqlConnection conn;
        ////private SqlCommand commnd;
        ////private SqlDataAdapter da;
        //string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        //SqlConnection conn = null;
        //SqlDataAdapter dauser = null;
        //DataTable dtuser = null;
        ///// <summary>
        ///// //
        ///// </summary>
        //DataSet dsuser = new DataSet();
        ////string name = txtTaiKhoan
        ////string pass = txtTaiKhoan.Text;
        //string url;
        //int a;

        
            //frmLogin flogin = new frmLogin();
            //frmqlLUONG fluong = new frmqlLUONG();
            //frmtimluong ftimluong = new frmtimluong();
            //frmqlNHANSU fnhansu = new frmqlNHANSU();



        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnuser_Click(object sender, EventArgs e)
        {


            if ((this.txtTaiKhoan.Text == "123") && (this.txtMatKhau.Text == "123"))
            {
                //frmMain frm = new frmMain();
                //frm.ShowDialog();
                //txtlogin.Text = txtTaiKhoan.Text;

                //dsuser.Tables["user"].
                btnLuong.Enabled = true;
                btnNhanSu.Enabled = true;

            }

            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                this.txtTaiKhoan.Focus();

            }
            //////////////////////////////////////////////
            //Boolean check = false;
            //int i = 0;
            //for (; i < dtuser.Rows.Count; i++)
            //{
            //    if (dsuser.Tables["user"].Rows[i]["Tendangnhap"].ToString() == txtTaiKhoan.Text && dsuser.Tables["user"].Rows[i]["MatKhau"].ToString() == txtMatKhau.Text)
            //    {
            //        //BienTC.MaPhanQuyen = dsuser.Tables["user"].Rows[i]["MaPQ"].ToString();
            //        check = true;
            //        i = dsuser.Tables["user"].Rows.Count;
            //    }
            //}
            //if (check == false)
            //{
            //    MessageBox.Show("Bạn Nhập Sai Tên Tài Khoản hoặc Pass", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //   //////////////////////////
            //    txtlogin.Text = dsuser.Tables["user"].Rows[i]["tentaikhoan"].ToString();
            //    if (Int32.Parse(dsuser.Tables["user"].Rows[i]["maquyen"].ToString()) == 1)
            //    {
            //        btnNhanSu.Enabled = false;
            //    }
            //    else
            //    {
            //        btnLuong.Enabled = false;
            //    }
            //}


            ////SqlConnection conn = null;
            //string sqlSelect = "Select * from user where Tendangnhap = '" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'";
            ////conn.Open();
            //SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read() == true)
            //{
            //    //this.Hide();
            //    //Form main = new Frm_Main();
            //    //main.Show();
            //    MessageBox.Show("sssssssssss", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    MessageBox.Show("Ban dang nhap khong thanh cong !");
            //    //txtTaiKhoan.Text = "";
            //    //txtMatKhau.Text = "";
            //    //txtTaiKhoan.Focus();
            //}


           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
           //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM user1 WHERE Tendangnhap='" + txtTaiKhoan.Text + "' AND MatKhau='" + txtMatKhau.Text + "'", con);
           // /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
           // DataTable dt = new DataTable(); //this is creating a virtual table  
           // sda.Fill(dt);
           // if (dt.Rows[1][1].ToString() == "1")
           // {
           //     /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
           //     this.Hide();
           //     //new home().Show();
           //     btnLuong.Enabled = true;
           //     btnNhanSu.Enabled = true;
           // }
           // else
           //     MessageBox.Show("Invalid username or password");            //SqlConnection con = new SqlConnection();  
            //con.ConnectionString = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";  
            //con.Open();  
            //string userid = txtTaiKhoan.Text;  
            //string password = txtMatKhau.Text;
            //SqlCommand cmd = new SqlCommand("select Tendangnhap,MatKhau from login where Tendangnhap='" + txtTaiKhoan.Text + "'and MatKhau='" + txtMatKhau.Text + "'", con);  
            //SqlDataAdapter da = new SqlDataAdapter(cmd);  
            //DataTable dt = new DataTable();  
            //da.Fill(dt);  
            //if (dt.Rows.Count >= 0)  
            //{  
            //    MessageBox.Show("Login sucess Welcome to Homepage http://krishnasinghprogramming.nlogspot.com");  
            //    System.Diagnostics.Process.Start("http://krishnasinghprogramming.blogspot.com");  
            //}  
            //else  
            //{  
            //    MessageBox.Show("Invalid Login please check username and password");  
            //}  
            //con.Close();  

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                    Application.Exit();
        }

        private void piclogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.btnThoat.Enabled = true;
            DialogResult traloi;
            traloi = MessageBox.Show("hay luu du lieu truoc khi thoat", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //textBox1.Text = dsuser.Tables["user"].Rows.Count.ToString();
            btnLuong.Enabled = false;
            btnNhanSu.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            frmqlNHANSU frmnv = new frmqlNHANSU();
            frmnv.ShowDialog();
            this.Hide();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            frmqlLUONG frmluong = new frmqlLUONG();
            frmluong.ShowDialog();
            //fluong.ShowDialog();
            //this.Hide();
        }
    }
}
