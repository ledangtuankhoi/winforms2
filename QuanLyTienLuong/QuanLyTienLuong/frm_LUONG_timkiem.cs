﻿using System;
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
    public partial class frmtimluong : Form
    {
        string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daLuongNhanVien = null;
        DataTable dtLuongNhanVien = null;
        int a;
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
            a = dgvluong.Rows.Count;
            txtcoutacc.Text = a.ToString();


        }


        public frmtimluong()
        {
            InitializeComponent();
            hideSubMenu();
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
                subMenu.Visible =false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelACC);
        }

        private void btnACCOUNT_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmqlLUONG frm = new frmqlLUONG();
            frm.ShowDialog();
        }

        private void btnACCOUNT_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelACC);
            this.Close();
            frm_LUONG_taikhoan frm = new frm_LUONG_taikhoan();
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmtimluong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet2.LuongNhanVien' table. You can move, or remove it, as needed.
            this.luongNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet2.LuongNhanVien);
            LoadData();
            txtsreach.Focus();
            rdbMaLuong.Checked = false;
            rdbnv.Checked = false;
            rdbkhautru.Checked = false;
            rdbngaycong.Checked = false;
            rdbthuong.Checked = false;
            rdbphucap.Checked = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionstring);
            conn.Open();
            daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien", conn);
            dtLuongNhanVien = new DataTable();
            dtLuongNhanVien.Clear();
            daLuongNhanVien.Fill(dtLuongNhanVien);
            dgvluong.DataSource = dtLuongNhanVien;



            daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaLuong  like '" + txtsreach.Text + "%'", conn);
            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaThuong  like '" + txtsreach.Text + "%'", conn);
            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaNV  like '" + txtsreach.Text + "%'", conn);
            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaKhauTru  like '" + txtsreach.Text + "%'", conn);
            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaNgayCong  like '" + txtsreach.Text + "%'", conn);
            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaPhuCap  like '" + txtsreach.Text + "%'", conn);

            daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaLuong like '" + txtsreach.Text + "%' or MaNV like '" + txtsreach.Text + "%' or MaKhauTru like '" + txtsreach.Text + "%' or MaNgayCong like '" + txtsreach.Text + "%' or MaThuong like '" + txtsreach.Text + "%'  or MaPhuCap like '" + txtsreach.Text + "%'", conn);


            //a = dgvluong.Rows.Count;
            a = dgvluong.Rows.GetRowCount(DataGridViewElementStates.Selected);
            txtcoutacc.Text = a.ToString();

            dtLuongNhanVien = new DataTable();
            daLuongNhanVien.Fill(dtLuongNhanVien);
            dgvluong.DataSource = dtLuongNhanVien;
            conn.Close();  


        }

        private void btnSreach_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionstring);
            conn.Open();
            
            dtLuongNhanVien = new DataTable();
            dtLuongNhanVien.Clear();
            daLuongNhanVien.Fill(dtLuongNhanVien);
            dgvluong.DataSource = dtLuongNhanVien;

            if (rdbMaLuong.Checked == true)
            {
                daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaLuong  like '" + txtsreach.Text + "%'", conn);

            }

            //daLuongNhanVien = new SqlDataAdapter("select * from LuongNhanVien where MaLuong  like '" + txtsreach.Text + "%'", conn);
   

            dtLuongNhanVien = new DataTable();
            daLuongNhanVien.Fill(dtLuongNhanVien);
            dgvluong.DataSource = dtLuongNhanVien;
            conn.Close();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rdbMaLuong.Checked = false;
            rdbnv.Checked = false;
            rdbkhautru.Checked = false;
            rdbngaycong.Checked = false;
            rdbthuong.Checked = false;
            rdbphucap.Checked = false;

            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            DialogResult traloi;
            traloi = MessageBox.Show("hay luu du lieu truoc khi thoat", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_LUONG_baocao frm = new frm_LUONG_baocao();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelACC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbMaLuong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gbQLL_XemTruoc_Enter(object sender, EventArgs e)
        {

        }

        private void txtcoutacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luongNhanVienBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbkhautru_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbnv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbphucap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbthuong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbngaycong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void luongNhanVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bBacLuongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
