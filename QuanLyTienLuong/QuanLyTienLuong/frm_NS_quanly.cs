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
using System.IO;


namespace QuanLyTienLuong
{
    public partial class frmqlNHANSU : Form
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

        //private void hideSubMenu()
        //{
        //    panelACC.Visible = false;

        //}

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelACC);
        }

        public frmqlNHANSU()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void frmqlNHANSU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet3.ThongTinNhanVien' table. You can move, or remove it, as needed.
            this.thongTinNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet3.ThongTinNhanVien);
            LoadData();
            txtmaNGAYCONG.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtmaNGAYCONG.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            txtmaNGAYCONG.AutoCompleteCustomSource = DataCollection;


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNHANSU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            Them = true;
            //this.txtmaluong.ResetText();
            //this.txtmakhautru.ResetText();
            //this.txtmangaycong.ResetText();
            //this.txtmathuong.ResetText();
            //this.txtMaPhuCap.ResetText();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            //this.btnThoat.Enabled = true;
            this.btnthem.Enabled = true;


            this.btnxoa.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            Them = false;
            this.btnluu.Enabled = true;


            int r = dgvNHANSU.CurrentCell.RowIndex;
            this.txtmaNV.Text = dgvNHANSU.Rows[r].Cells[0].Value.ToString();
            this.txtmaNGAYCONG.Text = dgvNHANSU.Rows[r].Cells[1].Value.ToString();
            this.txtHOTEN.Text = dgvNHANSU.Rows[r].Cells[2].Value.ToString();
            this.txtPHONGBAN.Text = dgvNHANSU.Rows[r].Cells[3].Value.ToString();
            this.txtCHUCVU.Text = dgvNHANSU.Rows[r].Cells[4].Value.ToString();
            this.txtDIACHI.Text = dgvNHANSU.Rows[r].Cells[5].Value.ToString();
            this.txtSDT.Text = dgvNHANSU.Rows[r].Cells[6].Value.ToString();
            this.txtCMND.Text = dgvNHANSU.Rows[r].Cells[7].Value.ToString();
            this.txtNGAYSINH.Text = dgvNHANSU.Rows[r].Cells[8].Value.ToString();
            this.txtEMAIL.Text = dgvNHANSU.Rows[r].Cells[9].Value.ToString();
            this.txtGIOITINH.Text = dgvNHANSU.Rows[r].Cells[10].Value.ToString();
            this.txtBACLUONG.Text = dgvNHANSU.Rows[r].Cells[11].Value.ToString();
            this.txtTROCAP.Text = dgvNHANSU.Rows[r].Cells[12].Value.ToString();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;


            this.txtmaNV.Enabled = false;

            this.btnxoa.Enabled = false;
            //this.btnThoat.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
            this.btnthem.Enabled = false;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnluu_Click(object sender, EventArgs e)
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
                    MessageBox.Show("LOI CMD!");
                    cmd.CommandText = System.String.Concat("INSERT INTO ThongTinNhanVien values(" + "'" + this.txtmaNV.Text.ToString() + "','" + this.txtmaNGAYCONG.Text.ToString() + "','" + this.txtHOTEN.Text.ToString() + "','" + this.txtPHONGBAN.Text.ToString() + "','" + this.txtCHUCVU.Text.ToString() + "','" + this.txtDIACHI.Text.ToString() + "','" + this.txtSDT.Text.ToString() + "','" + this.txtCMND.Text.ToString() + "','" + this.txtNGAYSINH.Text.ToString() + "','" + this.txtEMAIL.Text.ToString() + "','" + this.txtGIOITINH.Text.ToString() + "','" + this.txtBACLUONG.Text.ToString() + "','" + this.txtTROCAP.Text.ToString() + "')");
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn; 
                cmd.CommandType = CommandType.Text;
                int r = dgvNHANSU.CurrentCell.RowIndex;
                string strNHANSU = dgvNHANSU.Rows[r].Cells[0].Value.ToString();

                this.txtmaNV.Enabled = false;

                cmd.CommandText = System.String.Concat("update ThongTinNhanVien set MaNgayCong='" + this.txtmaNGAYCONG.Text.ToString() + "' , HoTen ='" + this.txtHOTEN.Text.ToString() + "' ,  Phongban ='" + this.txtPHONGBAN.Text.ToString() + "' ,  Chucvu ='" + this.txtCHUCVU.Text.ToString() + "', DiaChi ='" + this.txtDIACHI.Text.ToString() + "',    SDT ='" + this.txtSDT.Text.ToString() + "',  CMND ='" + this.txtCMND.Text.ToString() + "' , NgaySinh ='" + this.txtNGAYSINH.Text.ToString() + "' ,  Email ='" + this.txtEMAIL.Text.ToString() + "' ,  GioiTinh ='" + this.txtGIOITINH.Text.ToString() + "', BacLuong ='" + this.txtBACLUONG.Text.ToString() + "',TroCap='" + this.txtTROCAP.Text.ToString() + "' Where MaNV ='" + strNHANSU + "' ");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");

               

                //SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                //int r = dgvluong.CurrentCell.RowIndex;
                //string strLuong = dgvluong.Rows[r].Cells[0].Value.ToString();

                //cmd.CommandText = System.String.Concat("update LuongNhanVien set MaLuong='" + this.txtmaluong.Text.ToString() + "',  MaNV='" + this.txtmanhanvien.Text.ToString() + "' ,MaKhauTru='" + this.txtmakhautru.Text.ToString() + "' ,  MaNgayCong='" + this.txtmangaycong.Text.ToString() + "' ,  MaThuong='" + this.txtmathuong.Text.ToString() + "', MaPhuCap='" + this.txtMaPhuCap.Text.ToString() + "'    Where MaLuong='" + strLuong + "'");

                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();
                //LoadData();
                //MessageBox.Show("Đã sửa xong!");
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
            //this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.txtmaNV.ResetText();
            this.txtmaNGAYCONG.ResetText();
            this.txtHOTEN.ResetText();
            this.txtPHONGBAN.ResetText();
            this.txtCHUCVU.ResetText();
            this.txtDIACHI.ResetText();
            this.txtSDT.ResetText();
            this.txtCMND.ResetText();
            this.txtNGAYSINH.ResetText();
            this.txtEMAIL.ResetText();
            this.txtGIOITINH.ResetText();
            this.txtBACLUONG.ResetText();
            this.txtTROCAP.ResetText();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            this.btnxoa.Enabled = true;
            //this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                int r = dgvNHANSU.CurrentCell.RowIndex;
                string strLuong = dgvNHANSU.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("ban có chắc là xóa " + strLuong, "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    cmd.CommandText = System.String.Concat("Delete From ThongTinNhanVien Where MaNV='" + strLuong + "'");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtmaNV.ResetText();
            this.txtmaNGAYCONG.ResetText();
            this.txtHOTEN.ResetText();
            this.txtPHONGBAN.ResetText();
            this.txtCHUCVU.ResetText();
            this.txtDIACHI.ResetText();
            this.txtSDT.ResetText();
            this.txtCMND.ResetText();
            this.txtNGAYSINH.ResetText();
            this.txtEMAIL.ResetText();
            this.txtGIOITINH.ResetText();
            this.txtBACLUONG.ResetText();
            this.txtTROCAP.ResetText();
        }

        //private byte[] converImgToByte()
        //{
        //    FileStream fs;
        //    fs = new FileStream(txthinh.Text, FileMode.Open, FileAccess.Read);
        //    byte[] picbyte = new byte[fs.Length];
        //    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //    fs.Close();
        //    return picbyte;
        //}

        //private Image ByteToImg(string byteString)
        //{
        //    byte[] imgBytes = Convert.FromBase64String(byteString);
        //    MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
        //    ms.Write(imgBytes, 0, imgBytes.Length);
        //    Image image = Image.FromStream(ms, true);
        //    return image;
        //}

        private void button2_Click(object sender, EventArgs e)
        {

            //conn.Open(); 

            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            //openFile.FilterIndex = 1;
            //openFile.RestoreDirectory = true;
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    txthinh.Text = openFile.FileName;
            //}

            ////= Convert.ToBase64String(converImgToByte());

            //richTextBox2.Text = Convert.ToBase64String(converImgToByte());
            //richTextBox2.ToString();



            //textBox1.Text = richTextBox2.Text;
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //int r = dgvNHANSU.CurrentCell.RowIndex;
            //string strNHANSU = dgvNHANSU.Rows[r].Cells[0].Value.ToString();

            //this.txtmaNV.Enabled = false;

            //cmd.CommandText = System.String.Concat("update ThongTinNhanVien set hinh = '" + richTextBox2.Text + "' Where MaNV ='" + strNHANSU + "' ");

            //cmd.CommandType = CommandType.Text;
            //cmd.ExecuteNonQuery();
            //LoadData();
            //MessageBox.Show("Đã sửa xong!");


            //imageList1.Images.Add(ByteToImg(richTextBox2.Text));
            //imageList1.ImageSize = new Size(132, 132);
            //this.listView1.View = View.LargeIcon;
            //for (int counter = 0; counter < imageList1.Images.Count; counter++)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.ImageIndex = counter;
            //    this.listView1.Items.Add(item);
            //}
            //this.listView1.LargeImageList = imageList1;
        }

        private void dgvNHANSU_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
