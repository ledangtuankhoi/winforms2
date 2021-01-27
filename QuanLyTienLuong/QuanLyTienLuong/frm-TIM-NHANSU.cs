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



            Panel panel3 = new Panel();
            ComboBox comboBox1 = new ComboBox();
            TextBox textBox2 = new TextBox();

            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(144, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(366, 29);
            textBox2.TabIndex = 1;

            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(3, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 28);
            comboBox1.TabIndex = 2;




            this.Controls.Add(panel3);
            panel3.BringToFront();
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox2);
            panel3.Location = new System.Drawing.Point(56, 72 + i);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(534, 64);
            panel3.TabIndex = 3;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Panel panel1 = new Panel();
            CreateMyPanel();
            button1.Location = new System.Drawing.Point(56, 72 + i);
        }
    }
}
