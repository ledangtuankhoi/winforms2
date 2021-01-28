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
    public partial class frmqlLUONG : Form
    {
       

      

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daLuongNhanVien = null;
        DataTable dtLuongNhanVien = null;
        bool Them;

        public string setmaquyen, getmaquyen;



        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionstring);
                daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien", conn);
                dtLuongNhanVien = new DataTable();
                dtLuongNhanVien.Clear();
                daLuongNhanVien.Fill(dtLuongNhanVien);
                dgvluong.DataSource = dtLuongNhanVien;

            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong tableLuongNhanVien. loi roi");

            }
            txtcoutacc.Text = dtLuongNhanVien.Rows.Count.ToString();


        }

        private void hideSubMenu()
        {
            panelACC.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelACC);
        }


        public frmqlLUONG()
        {
            InitializeComponent();
        }


        private void getData(AutoCompleteStringCollection dataCollection, string sql_cot, string sql_bang)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
            string sql = "SELECT " + sql_cot + "  FROM " + sql_bang + "";

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


        private void frmqlLUONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet1.LuongNhanVien' table. You can move, or remove it, as needed.
            this.luongNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet1.LuongNhanVien);
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet1.LuongNhanVien' table. You can move, or remove it, as needed.
            //this.luongNhanVienTableAdapter1.Fill(this.quanLyTienLuongDataSet1.LuongNhanVien);
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet.LuongNhanVien' table. You can move, or remove it, as needed.
           // this.luongNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet.LuongNhanVien);
            LoadData();


            getmaquyen = setmaquyen;

            if (getmaquyen == "1")
            {
                pictureBox1.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\people1.png");

                //btnLuong.Enabled = true;
                //btnNhanSu.Enabled = false;
                //btntaikhoab.Enabled = false;



            }
            if (getmaquyen == "2")
            {
                pictureBox1.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\Untitled-1.png");

                //btnLuong.Enabled = false;
                //btnNhanSu.Enabled = true;
                //btntaikhoab.Enabled = false;


            }
            if (getmaquyen == "0")
            {
                pictureBox1.Image = Image.FromFile(@"H:\TuanKhoi\Dai_Hoc\KT_winforms\img\forms\admin-settings-male.png");

                //btnLuong.Enabled = true;
                //btnNhanSu.Enabled = true;
                //btntaikhoab.Enabled = true;

            }



            this.btnluu.Enabled = false;
            this.btnhuybo.Enabled = false;
            hideSubMenu();
            this.txtmaluong.Focus();

           /// goi y cho textbox
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();

            txtmakhautru.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmakhautru.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            getData(DataCollection, "MaKhauTru", "LuongNhanVien");
            txtmakhautru.AutoCompleteCustomSource = DataCollection;

            txtmanhanvien.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmanhanvien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, "MaNV", "LuongNhanVien");
            txtmanhanvien.AutoCompleteCustomSource = DataCollection;

            txtmangaycong.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmangaycong.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, "MaNgayCong", "LuongNhanVien");
            txtmangaycong.AutoCompleteCustomSource = DataCollection;

            txtmathuong.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmathuong.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, "MaThuong", "LuongNhanVien");
            txtmathuong.AutoCompleteCustomSource = DataCollection;

            txtMaPhuCap.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaPhuCap.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, "MaPhuCap", "LuongNhanVien");
            txtMaPhuCap.AutoCompleteCustomSource = DataCollection;

         

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gbQLL_XemTruoc_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            frmtimluong frm = new frmtimluong();
            frm.ShowDialog();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            Them = true;
            //this.txtmaluong.ResetText();
            //this.txtmakhautru.ResetText();
            //this.txtmangaycong.ResetText();
            //this.txtmathuong.ResetText();
            //this.txtMaPhuCap.ResetText();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnthem.Enabled = true;


            this.btnxoa.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
        }

        private void btnhuybo_Click_1(object sender, EventArgs e)
        {
            this.txtmaluong.ResetText();
            this.txtmakhautru.ResetText();
            this.txtmangaycong.ResetText();
            this.txtmathuong.ResetText();
            this.txtMaPhuCap.ResetText();
            this.txtmanhanvien.ResetText();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {

            // Mở kết nối 
            conn.Open();
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("INSERT INTO LuongNhanVien values(" + "'" + this.txtmaluong.Text.ToString() + "','" + this.txtmanhanvien.Text.ToString() + "','" + this.txtmakhautru.Text.ToString() + "','" + this.txtmangaycong.Text.ToString() + "','" + this.txtmathuong.Text.ToString() + "','" + this.txtMaPhuCap.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                int r = dgvluong.CurrentCell.RowIndex;
                string strLuong = dgvluong.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("update LuongNhanVien set MaLuong='" + this.txtmaluong.Text.ToString() + "',  MaNV='" + this.txtmanhanvien.Text.ToString() + "' ,MaKhauTru='" + this.txtmakhautru.Text.ToString() + "' ,  MaNgayCong='" + this.txtmangaycong.Text.ToString() + "' ,  MaThuong='" + this.txtmathuong.Text.ToString() + "', MaPhuCap='" + this.txtMaPhuCap.Text.ToString() + "'    Where MaLuong='" + strLuong + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
            conn.Close();

            //this.txtmaluong.ResetText();
            //this.txtmakhautru.ResetText();
            //this.txtmangaycong.ResetText();
            //this.txtmathuong.ResetText();
            //this.txtMaPhuCap.ResetText();
            //this.txtmanhanvien.ResetText();

            this.btnluu.Enabled = false;
            this.btnhuybo.Enabled = false;
            this.btnxoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;

        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {


            Them = false;
            this.btnluu.Enabled = true;


            int r = dgvluong.CurrentCell.RowIndex;
            this.txtmaluong.Text = dgvluong.Rows[r].Cells[0].Value.ToString();
            this.txtmanhanvien.Text = dgvluong.Rows[r].Cells[1].Value.ToString();
            this.txtmakhautru.Text = dgvluong.Rows[r].Cells[2].Value.ToString();
            this.txtmangaycong.Text = dgvluong.Rows[r].Cells[3].Value.ToString();
            this.txtmathuong.Text = dgvluong.Rows[r].Cells[4].Value.ToString();
            this.txtMaPhuCap.Text = dgvluong.Rows[r].Cells[5].Value.ToString();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;



            this.btnxoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
            this.btnthem.Enabled = false;

        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            conn.Open();



            try
            {
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                int r = dgvluong.CurrentCell.RowIndex;
                string strLuong = dgvluong.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("ban có chắc là xóa " + strLuong, "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    cmd.CommandText = System.String.Concat("Delete From LuongNhanVien Where MaLuong='" + strLuong + "'"); 
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            conn.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
                traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    //Application.Exit();
                    this.Close();
                }
                    
        }

        private void btnACCOUNT_Click(object sender, EventArgs e)
        {
            showSubMenu(panelACC);
            showSubMenu(panelACC);
            this.Close();
            frmTaikhoan frm = new frmTaikhoan();
            frm.ShowDialog();

        }

        private void gbQLL_XemTruoc_Enter_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không123?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthoat_Click_2(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmbaocao frm = new frmbaocao();
            frm.ShowDialog();
        }

        private void dgvluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
