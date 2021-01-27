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
    public partial class frm_TIM_NHANSU : Form
    {

        string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daThongTinNhanVien = null;
        DataTable dtThongTinNhanVien = null;
        bool Them;
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionstring);
                daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien", conn);
                dtThongTinNhanVien = new DataTable();
                dtThongTinNhanVien.Clear();
                daThongTinNhanVien.Fill(dtThongTinNhanVien);




                dgvNHANSU.DataSource = dtThongTinNhanVien;

            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong tableThongTinNhanVien. loi roi");

            }
            //txtcoutacc.Text = dtThongTinNhanVien.Rows.Count.ToString();


        }


        public frm_TIM_NHANSU()
        {
            InitializeComponent();
        }

        private void frm_TIM_NHANSU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet4.ThongTinNhanVien' table. You can move, or remove it, as needed.
            this.thongTinNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet4.ThongTinNhanVien);
            LoadData();

            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThongTinNhanVien", conn);
            //DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            //da.Fill(dt);
            //comboBox4.DataSource = ds.Tables[0];
            //comboBox4.DisplayMember = "ThongTinNhanVien";
            //comboBox4.ValueMember = "ThongTinNhanVien";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionstring);
            conn.Open();
            daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien", conn);
            dtThongTinNhanVien = new DataTable();
            dtThongTinNhanVien.Clear();
            daThongTinNhanVien.Fill(dtThongTinNhanVien);
            dgvNHANSU.DataSource = dtThongTinNhanVien;



            daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaNV  like '" + textBox1.Text + "%'", conn);
            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaThuong  like '" + textBox1.Text + "%'", conn);
            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaNV  like '" + textBox1.Text + "%'", conn);
            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaKhauTru  like '" + textBox1.Text + "%'", conn);
            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaNgayCong  like '" + textBox1.Text + "%'", conn);
            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaPhuCap  like '" + textBox1.Text + "%'", conn);

            //daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where MaLuong like '" + textBox1.Text + "%' or MaNV like '" + textBox1.Text + "%' or MaKhauTru like '" + textBox1.Text + "%' or MaNgayCong like '" + textBox1.Text + "%' or MaThuong like '" + textBox1.Text + "%'  or MaPhuCap like '" + textBox1.Text + "%'", conn);
            daThongTinNhanVien = new SqlDataAdapter("select * from ThongTinNhanVien where  MaNV like '" + textBox1.Text + "%' or MaNgayCong  like '" + textBox1.Text + "%' or HoTen like '" + textBox1.Text + "%' or Phongban like '" + textBox1.Text + "%' or Chucvu like '" + textBox1.Text + "%' or DiaChi like '" + textBox1.Text + "%' or SDT like '" + textBox1.Text + "%' or CMND like '" + textBox1.Text + "%' or NgaySinh like '" + textBox1.Text + "%' or Email like '" + textBox1.Text + "%' or GioiTinh like '" + textBox1.Text + "%' or BacLuong like '" + textBox1.Text + "%' or TroCap like '" + textBox1.Text + "%'"  , conn);


            //a = dgvNHANSU.Rows.Count;
            //a = dgvNHANSU.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //txtcoutacc.Text = a.ToString();

            dtThongTinNhanVien = new DataTable();
            daThongTinNhanVien.Fill(dtThongTinNhanVien);
            dgvNHANSU.DataSource = dtThongTinNhanVien;
            conn.Close();  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int i = 0;

        public void CreateMyPanel()
        {
            i = i + 50;

            Panel panel4 = new Panel();
           this.groupBox1.Controls.Add(panel4);

            

            ComboBox comboBox4 = new ComboBox();
            TextBox textBox4 = new TextBox();

            // 
            // textBox4
            // 
            textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox4.Location = new System.Drawing.Point(144, 20);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(366, 29);
            textBox4.TabIndex = 1;

            // 
            // comboBox4
            // 
            comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(3, 20);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(121, 28);
            comboBox4.TabIndex = 2;




            this.Controls.Add(panel4);
            panel4.BringToFront();
            panel4.Controls.Add(comboBox4);
            panel4.Controls.Add(textBox4);
            panel4.Location = new System.Drawing.Point(9, 130 + i);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(450, 64);
            panel4.TabIndex = 3;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Panel panel1 = new Panel();
            //CreateMyPanel();
            //button1.Location = new System.Drawing.Point(9, 121 + i);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
