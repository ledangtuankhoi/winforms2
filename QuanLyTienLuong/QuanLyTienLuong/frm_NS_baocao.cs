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
    public partial class frm_report_1_NHANSU : Form
    {
        public frm_report_1_NHANSU()
        {
            InitializeComponent();
        }

        private void frm_report_1_NHANSU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyTienLuongDataSet9.ThongTinNhanVien' table. You can move, or remove it, as needed.
            //this.ThongTinNhanVienTableAdapter.Fill(this.QuanLyTienLuongDataSet9.ThongTinNhanVien);
            // TODO: This line of code loads data into the 'QuanLyTienLuongDataSet6.DS_Nhanvien_theo_maNV' table. You can move, or remove it, as needed.
            //this.DS_Nhanvien_theo_maNVTableAdapter.Fill(this.QuanLyTienLuongDataSet7.DS_Nhanvien_theo_maNV);

            //this.DS_Nhanvien_theo_maNVTableAdapter.Fill(this.QuanLyTienLuongDataSet6.DS_Nhanvien_theo_maNV,textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.DS_Nhanvien_theo_maNVTableAdapter.Fill(this.QuanLyTienLuongDataSet6.DS_Nhanvien_theo_maNV,textBox1.Text);
            this.reportViewer1.RefreshReport();
        
        }
    }
}
