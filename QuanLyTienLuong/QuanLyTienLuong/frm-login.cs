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


        private void getData(AutoCompleteStringCollection dataCollection)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
            string sql = "SELECT MaNgayCong  FROM ThongTinNhanVien";

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }

        private void btnuser_Click(object sender, EventArgs e)
        {


            //if ((this.txtTaiKhoan.Text == "123") && (this.txtMatKhau.Text == "123"))
            //{
            //    //frmMain frm = new frmMain();
            //    //frm.ShowDialog();
            //    //txtlogin.Text = txtTaiKhoan.Text;

            //    //dsuser.Tables["user"].
            //    btnLuong.Enabled = true;
            //    btnNhanSu.Enabled = true;

            //}

            //else
            //{
            //    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
            //    this.txtTaiKhoan.Focus();

            //}


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
           
            
            try 
	        {	        
		        conn.Open();
                string tk= txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "SELECT * FROM user1 where Tendangnhap = '" + tk + "' and MatKhau = '" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader data = cmd.ExecuteReader();


                //string sql2 = "SELECT maquyen FROM user1 where where Tendangnhap = '" + tk + "'  ";
                //SqlCommand cmd2 = new SqlCommand(sql2, conn);
                //SqlDataReader data2 = cmd.ExecuteReader();
                if (data.Read() == true)
	                {
                        txtlogin.Text = data[0].ToString();
                        string maquyen = data[3].ToString();
		                 
                        if (maquyen == "1")
                        {
                            piclogin.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\people1.png");

                            btnLuong.Enabled = true;
                            btnNhanSu.Enabled = false;
                            this.txtTaiKhoan.ResetText();
                            this.txtMatKhau.ResetText();
                            
                        }
                        if (maquyen == "2")
                        {
                            piclogin.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\Untitled-1.png");

                            btnLuong.Enabled = false;
                            btnNhanSu.Enabled = true;
                            this.txtTaiKhoan.ResetText();
                            this.txtMatKhau.ResetText();
                        }
                        if (maquyen == "0")
                        {
                            piclogin.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\admin-settings-male.png");

                            btnLuong.Enabled = true;
                            btnNhanSu.Enabled = true;
                            this.txtTaiKhoan.ResetText();
                            this.txtMatKhau.ResetText();
                        }


	                }
                else
	                {
                        MessageBox.Show("dang nhap khong thanh cong");
	                }
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);

	        }

            conn.Close();






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
            frm_MDI_nhansu frmnv = new frm_MDI_nhansu();
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
