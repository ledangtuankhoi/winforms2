namespace QuanLyTienLuong
{
    partial class frmbaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LuongNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyTienLuong.DataSet1();
            this.LuongNhanVienTableAdapter = new QuanLyTienLuong.DataSet1TableAdapters.LuongNhanVienTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mENUCHINHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luongNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bBacLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnACCOUNT = new System.Windows.Forms.Button();
            this.panelACC = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LuongNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBacLuongBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelACC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LuongNhanVienBindingSource
            // 
            this.LuongNhanVienBindingSource.DataMember = "LuongNhanVien";
            this.LuongNhanVienBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LuongNhanVienTableAdapter
            // 
            this.LuongNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUCHINHToolStripMenuItem,
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.sETTINGToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(9, 9);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(247, 24);
            this.menuStrip2.TabIndex = 24;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mENUCHINHToolStripMenuItem
            // 
            this.mENUCHINHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đĂNGXUẤTToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.chuyểnTàiKhoảnToolStripMenuItem});
            this.mENUCHINHToolStripMenuItem.Name = "mENUCHINHToolStripMenuItem";
            this.mENUCHINHToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mENUCHINHToolStripMenuItem.Text = "MENU CHINH";
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // chuyểnTàiKhoảnToolStripMenuItem
            // 
            this.chuyểnTàiKhoảnToolStripMenuItem.Name = "chuyểnTàiKhoảnToolStripMenuItem";
            this.chuyểnTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chuyểnTàiKhoảnToolStripMenuItem.Text = "Chuyển tài khoản";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inPageToolStripMenuItem,
            this.exportFileToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // inPageToolStripMenuItem
            // 
            this.inPageToolStripMenuItem.Name = "inPageToolStripMenuItem";
            this.inPageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inPageToolStripMenuItem.Text = "In page";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exportFileToolStripMenuItem.Text = "Export file";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // sETTINGToolStripMenuItem
            // 
            this.sETTINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.sETTINGToolStripMenuItem.Name = "sETTINGToolStripMenuItem";
            this.sETTINGToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sETTINGToolStripMenuItem.Text = "SETTING";
            this.sETTINGToolStripMenuItem.Click += new System.EventHandler(this.sETTINGToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(131, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 43);
            this.panel3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chartreuse;
            this.label8.Location = new System.Drawing.Point(493, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "quản lý và báo cáo thông tin lương";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "LuongNhanVien";
            // 
            // luongNhanVienBindingSource1
            // 
            this.luongNhanVienBindingSource1.DataMember = "LuongNhanVien";
            // 
            // bBacLuongBindingSource
            // 
            this.bBacLuongBindingSource.DataMember = "bBacLuong";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LuongNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienLuong.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(660, 505);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnlammoi);
            this.panel5.Controls.Add(this.btnThoat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(675, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 523);
            this.panel5.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyTienLuong.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(28, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 51);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "THOAT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.CausesValidation = false;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Image = global::QuanLyTienLuong.Properties.Resources.refresh;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(29, 354);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(145, 57);
            this.btnlammoi.TabIndex = 27;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseCompatibleTextRendering = true;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.reportViewer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(131, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 523);
            this.panel4.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 63);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyTienLuong.Properties.Resources.qw;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 63);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(131, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "QUẢN KÝ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(0, 107);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(131, 44);
            this.button8.TabIndex = 5;
            this.button8.Text = "TÌM KIẾM";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(0, 151);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(131, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "BÁO BÁO";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnACCOUNT
            // 
            this.btnACCOUNT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnACCOUNT.FlatAppearance.BorderSize = 0;
            this.btnACCOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACCOUNT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnACCOUNT.Location = new System.Drawing.Point(0, 195);
            this.btnACCOUNT.Name = "btnACCOUNT";
            this.btnACCOUNT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnACCOUNT.Size = new System.Drawing.Size(131, 44);
            this.btnACCOUNT.TabIndex = 10;
            this.btnACCOUNT.Text = "TÀI KHOẢN";
            this.btnACCOUNT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACCOUNT.UseVisualStyleBackColor = true;
            this.btnACCOUNT.Click += new System.EventHandler(this.btnACCOUNT_Click);
            // 
            // panelACC
            // 
            this.panelACC.Controls.Add(this.button2);
            this.panelACC.Controls.Add(this.button1);
            this.panelACC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelACC.Location = new System.Drawing.Point(0, 239);
            this.panelACC.Name = "panelACC";
            this.panelACC.Size = new System.Drawing.Size(131, 86);
            this.panelACC.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "CHANGE PASS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 44);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "INFO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panelACC);
            this.panel1.Controls.Add(this.btnACCOUNT);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 566);
            this.panel1.TabIndex = 31;
            // 
            // frmbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbaocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuongNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBacLuongBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelACC.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource LuongNhanVienBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.LuongNhanVienTableAdapter LuongNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource luongNhanVienBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource bBacLuongBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mENUCHINHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sETTINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnACCOUNT;
        private System.Windows.Forms.Panel panelACC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}