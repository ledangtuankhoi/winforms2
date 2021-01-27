using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTienLuong
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //public static void start()
        //{
        //    frmLogin flogin = new frmLogin();
        //    frmqlLUONG fluong = new frmqlLUONG();
        //    frmtimluong ftimluong = new frmtimluong();
        //    frmqlNHANSU fnhansu = new frmqlNHANSU();
        //}

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            //frmqlNHANSU frm = new frmqlNHANSU();
            //frm.ShowDialog();

            //frmqlLUONG frm2 = new frmqlLUONG();
            ////frm2.FormBorderStyle = FormBorderStyle.None;
            //frm2.ShowDialog();
            //start();
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();

            //frmtimluong frm = new frmtimluong();
            //frm.ShowDialog();

            //frmtimluong frm = new frmtimluong();
            //frm.ShowDialog();

            //frmbaocao frm = new frmbaocao();
            //frm.ShowDialog();

            //frmTaikhoan frm = new frmTaikhoan();
            //frm.ShowDialog();


            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();

            //    frmqlNHANSU frm = new frmqlNHANSU();
            //    frm.ShowDialog();
        }

    }
}
