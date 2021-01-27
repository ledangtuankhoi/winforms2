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
            // TODO: This line of code loads data into the 'quanLyTienLuongDataSet5.ThongTinNhanVien' table. You can move, or remove it, as needed.
            this.thongTinNhanVienTableAdapter.Fill(this.quanLyTienLuongDataSet5.ThongTinNhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
