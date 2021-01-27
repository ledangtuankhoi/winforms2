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
    public partial class frm_LUONG_baocao : Form
    {
        public frm_LUONG_baocao()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.LuongNhanVien' table. You can move, or remove it, as needed.
            this.LuongNhanVienTableAdapter.Fill(this.DataSet1.LuongNhanVien);

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void sETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.LuongNhanVienTableAdapter.Fill(this.DataSet1.LuongNhanVien);

            this.reportViewer1.RefreshReport();
            
        }

        private void btnACCOUNT_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frm_LUONG_taikhoan frm = new frm_LUONG_taikhoan();
            frm.ShowDialog();
        }
    }
}
