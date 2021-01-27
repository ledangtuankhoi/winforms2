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
    public partial class frmTaikhoan : Form
    {
       

        string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTAIKHAON = null;
        DataTable dtTAIKHOAN = null;
        bool Them;
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionstring);
                daTAIKHAON = new SqlDataAdapter("select * from user1", conn);
                dtTAIKHOAN = new DataTable();
                dtTAIKHOAN.Clear();
                daTAIKHAON.Fill(dtTAIKHOAN);
                dgvtaikhoan.DataSource = dtTAIKHOAN;

            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong table user1. loi roi");

            }
            txtcoutacc.Text = dtTAIKHOAN.Rows.Count.ToString();


        }

        public frmTaikhoan()
        {
            InitializeComponent();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbQLL_XemTruoc_Enter(object sender, EventArgs e)
        {

        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet.user1' table. You can move, or remove it, as needed.
            this.user1TableAdapter.Fill(this.quanLyTienLuongDataSet.user1);

            txttentaikhoan.Focus();
            
            LoadData();
            
            this.btnluu.Enabled = false;
            this.btnhuybo.Enabled = false;
            
            hideSubMenu();
            
            this.txttenDANGNHAP.Focus();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from user1 ", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("maquyen", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "maquyen";
            comboBox1.DisplayMember = "maquyen";
            comboBox1.DataSource = dt;

            conn.Close();
        }

        private void txtmanhanvien_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnACCOUNT_Click(object sender, EventArgs e)
        {
            showSubMenu(panelACC);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;


            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnthem.Enabled = true;


            this.btnxoa.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.txttentaikhoan.ResetText();
            this.txttenDANGNHAP.ResetText();
            this.txtmatkhau.ResetText();
            this.txtmaquyen.ResetText();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;
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
                    cmd.CommandText = System.String.Concat("INSERT INTO user1 values(" + "'" + this.txttentaikhoan.Text.ToString() + "','" + this.txttenDANGNHAP.Text.ToString() + "','" + this.txtmatkhau.Text.ToString() + "','" + this.txtmaquyen.Text.ToString()  + "')");
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
                int r = dgvtaikhoan.CurrentCell.RowIndex;
                string strTAIKHOAN = dgvtaikhoan.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("update user1 set tentaikhoan='" + this.txttentaikhoan.Text.ToString() + "',  Tendangnhap='" + this.txttenDANGNHAP.Text.ToString() + "' ,MatKhau='" + this.txtmatkhau.Text.ToString() + "' ,  maquyen='" + this.txtmaquyen.Text.ToString() + "'    Where txttentaikhoan='" + strTAIKHOAN + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
            conn.Close();




            this.btnluu.Enabled = false;
            this.btnhuybo.Enabled = false;
            this.btnxoa.Enabled = true;
            this.btnThoat.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnlammoi.Enabled = true;
            this.btnthem.Enabled = true;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.btnluu.Enabled = true;


            int r = dgvtaikhoan.CurrentCell.RowIndex;
            this.txttentaikhoan.Text = dgvtaikhoan.Rows[r].Cells[0].Value.ToString();
            this.txttenDANGNHAP.Text = dgvtaikhoan.Rows[r].Cells[1].Value.ToString();
            this.txtmatkhau.Text = dgvtaikhoan.Rows[r].Cells[2].Value.ToString();
            this.txtmaquyen.Text = dgvtaikhoan.Rows[r].Cells[3].Value.ToString();

            this.btnluu.Enabled = true;
            this.btnhuybo.Enabled = true;



            this.btnxoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnlammoi.Enabled = false;
            this.btnthem.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();



            try
            {
                SqlCommand cmd = new SqlCommand(); 
                cmd.Connection = conn; 
                cmd.CommandType = CommandType.Text;
                int r = dgvtaikhoan.CurrentCell.RowIndex;
                string strTAIKHOAN = dgvtaikhoan.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("ban có chắc là xóa " + strTAIKHOAN, "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    cmd.CommandText = System.String.Concat("Delete From user1 Where Tendangnhap='" + strTAIKHOAN + "'");
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

        private void btnlammoi_Click_1(object sender, EventArgs e)
        {
            LoadData();

            this.txttentaikhoan.ResetText();
            this.txttenDANGNHAP.ResetText();
            this.txtmatkhau.ResetText();
            this.txtmaquyen.ResetText();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnACCOUNT_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmbaocao frm = new frmbaocao();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            frmtimluong frm = new frmtimluong();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmqlLUONG frm = new frmqlLUONG();
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtcoutacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
