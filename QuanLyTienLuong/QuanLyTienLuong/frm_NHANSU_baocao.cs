using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTienLuong
{
    public partial class frm_NHANSU_baocao : Form
    {
        public frm_NHANSU_baocao()
        {
            InitializeComponent();
        }



        private void frm_NHANSU_baocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dstheomaNV.dstheomaNV' table. You can move, or remove it, as needed.
            //this.dstheomaNVTableAdapter.Fill(this.dstheomaNV.dstheomaNV);
            // TODO: This line of code loads data into the 'QuanLyTienLuongDataSet5.ThongTinNhanVien' table. You can move, or remove it, as needed.
            //this.ThongTinNhanVienTableAdapter.Fill(this.QuanLyTienLuongDataSet5.ThongTinNhanVien);
            // TODO: This line of code loads data into the 'dstheomaNV.dstheomaNV' table. You can move, or remove it, as needed.
            //this.dstheomaNVTableAdapter.Fill(this.dstheomaNV.dstheomaNV);
            // TODO: This line of code loads data into the 'QuanLyTienLuongDataSet10.dstheomaNV' table. You can move, or remove it, as needed.
            //this.dstheomaNVTableAdapter.Fill(this.QuanLyTienLuongDataSet10.dstheomaNV);
            // TODO: This line of code loads data into the 'QuanLyTienLuongDataSet11.dstheomaNCONG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dstheomaNV.dstheomaNV' table. You can move, or remove it, as needed.
            //this.dstheomanvtableadapter.fill(this.dstheomanv._dstheomanv, "*");
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet5.ThongTinNhanVien' table. You can move, or remove it, as needed.
            //this.thongTinNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet5.ThongTinNhanVien);
            // TODO: This line of code loads data into the 'dstheomaNV.dstheomaNV' table. You can move, or remove it, as needed.
            comboBox1.DisplayMember = "DIEU KIEN";
            comboBox1.ValueMember = "Gender";
            //comboBox1.SelectedIndex = 1;
            comboBox1.SelectedItem = "MaNV";

            this.reportViewer1.RefreshReport();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (comboBox1.SelectedItem.ToString() == "MaNV")
                {
                    //this.dstheomaNCONGTableAdapter.Fill(this.QuanLyTienLuongDataSet11.dstheomaNCONG, comboBox1.SelectedItem.ToString(), textBox1.Text);

                    this.dstheomaNVTableAdapter.Fill(this.dstheomaNV._dstheomaNV, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                if (true)
                {
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("khong ton tai gia tri");
            }
            

        }
    }
}
