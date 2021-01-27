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
    public partial class frm_test : Form
    {
        public frm_test()
        {
            InitializeComponent();
        }
        int i = 0;

        public void CreateMyPanel()
        {
            i = i + 50;
            


            Panel panel3 = new Panel();
            ComboBox comboBox1 = new ComboBox();
            TextBox textBox2 = new TextBox();

            // 
            // textBox2
            // 
             textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             textBox2.Location = new System.Drawing.Point(144, 20);
             textBox2.Name = "textBox2";
             textBox2.Size = new System.Drawing.Size(366, 29);
             textBox2.TabIndex = 1;
            
            // 
            // comboBox1
            // 
             comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             comboBox1.FormattingEnabled = true;
             comboBox1.Location = new System.Drawing.Point(3, 20);
             comboBox1.Name = "comboBox1";
             comboBox1.Size = new System.Drawing.Size(121, 28);
             comboBox1.TabIndex = 2;
             

            

             this.Controls.Add(panel3);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox2);
            panel3.Location = new System.Drawing.Point(56, 72 + i);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(534, 64);
            panel3.TabIndex = 3;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMyPanel();
        }
    }
}
