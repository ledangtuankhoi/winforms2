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
    public partial class frm_taikhoan_luong : Form
    {


        string strConnectionstring = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTAIKHAON = null;
        DataTable dtTAIKHOAN = null;
        bool Them;


        public frm_taikhoan_luong()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionstring);
                daTAIKHAON = new SqlDataAdapter("select * from user1", conn);
                dtTAIKHOAN = new DataTable();
                dtTAIKHOAN.Clear();
                daTAIKHAON.Fill(dtTAIKHOAN);
                //dgvtaikhoan.DataSource = dtTAIKHOAN;

            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong table user1. loi roi");

            }
          


        }
        private void frm_taikhoan_luong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet.user1' table. You can move, or remove it, as needed.
            this.user1TableAdapter.Fill(this.quanLyTienLuongDataSet.user1);

            txttentaikhoan.Focus();

            LoadData();

            this.btnluu.Enabled = false;
            this.btnhuybo.Enabled = false;

          

            this.txttenDANGNHAP.Focus();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from user1 ", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("maquyen", typeof(string));
            dt.Load(reader);

            //comboBox1.ValueMember = "maquyen";
            //comboBox1.DisplayMember = "maquyen";
            //comboBox1.DataSource = dt;

            conn.Close();
        }


    }
}
