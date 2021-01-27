namespace QuanLyTienLuong
{
    partial class frm_report_1_NHANSU
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
            this.ThongTinNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyTienLuongDataSet5 = new QuanLyTienLuong.QuanLyTienLuongDataSet5();
            this.DS_Nhanvien_theo_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyTienLuongDataSet8 = new QuanLyTienLuong.QuanLyTienLuongDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongTinNhanVienTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter();
            this.QuanLyTienLuongDataSet6 = new QuanLyTienLuong.QuanLyTienLuongDataSet6();
            this.DS_Nhanvien_theo_maNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Nhanvien_theo_maNVTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet6TableAdapters.DS_Nhanvien_theo_maNVTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DS_Nhanvien_theo_ALLTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet8TableAdapters.DS_Nhanvien_theo_ALLTableAdapter();
            this.DataSet1 = new QuanLyTienLuong.DataSet1();
            this.LuongNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LuongNhanVienTableAdapter = new QuanLyTienLuong.DataSet1TableAdapters.LuongNhanVienTableAdapter();
            this.QuanLyTienLuongDataSet9 = new QuanLyTienLuong.QuanLyTienLuongDataSet9();
            this.DataSet3 = new QuanLyTienLuong.DataSet3();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Nhanvien_theo_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Nhanvien_theo_maNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongTinNhanVienBindingSource
            // 
            this.ThongTinNhanVienBindingSource.DataMember = "ThongTinNhanVien";
            this.ThongTinNhanVienBindingSource.DataSource = this.QuanLyTienLuongDataSet5;
            // 
            // QuanLyTienLuongDataSet5
            // 
            this.QuanLyTienLuongDataSet5.DataSetName = "QuanLyTienLuongDataSet5";
            this.QuanLyTienLuongDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DS_Nhanvien_theo_ALLBindingSource
            // 
            this.DS_Nhanvien_theo_ALLBindingSource.DataMember = "DS_Nhanvien_theo_ALL";
            this.DS_Nhanvien_theo_ALLBindingSource.DataSource = this.QuanLyTienLuongDataSet8;
            // 
            // QuanLyTienLuongDataSet8
            // 
            this.QuanLyTienLuongDataSet8.DataSetName = "QuanLyTienLuongDataSet8";
            this.QuanLyTienLuongDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongTinNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienLuong.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1190, 479);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ThongTinNhanVienTableAdapter
            // 
            this.ThongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyTienLuongDataSet6
            // 
            this.QuanLyTienLuongDataSet6.DataSetName = "QuanLyTienLuongDataSet6";
            this.QuanLyTienLuongDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DS_Nhanvien_theo_maNVBindingSource
            // 
            this.DS_Nhanvien_theo_maNVBindingSource.DataMember = "DS_Nhanvien_theo_maNV";
            this.DS_Nhanvien_theo_maNVBindingSource.DataSource = this.QuanLyTienLuongDataSet6;
            // 
            // DS_Nhanvien_theo_maNVTableAdapter
            // 
            this.DS_Nhanvien_theo_maNVTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DS_Nhanvien_theo_ALLTableAdapter
            // 
            this.DS_Nhanvien_theo_ALLTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LuongNhanVienBindingSource
            // 
            this.LuongNhanVienBindingSource.DataMember = "LuongNhanVien";
            this.LuongNhanVienBindingSource.DataSource = this.DataSet1;
            // 
            // LuongNhanVienTableAdapter
            // 
            this.LuongNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyTienLuongDataSet9
            // 
            this.QuanLyTienLuongDataSet9.DataSetName = "QuanLyTienLuongDataSet9";
            this.QuanLyTienLuongDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_report_1_NHANSU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_report_1_NHANSU";
            this.Text = "frm_report_1_NHANSU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_report_1_NHANSU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Nhanvien_theo_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Nhanvien_theo_maNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongTinNhanVienBindingSource;
        private QuanLyTienLuongDataSet5 QuanLyTienLuongDataSet5;
        private QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter ThongTinNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource DS_Nhanvien_theo_maNVBindingSource;
        private QuanLyTienLuongDataSet6 QuanLyTienLuongDataSet6;
        private QuanLyTienLuongDataSet6TableAdapters.DS_Nhanvien_theo_maNVTableAdapter DS_Nhanvien_theo_maNVTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource DS_Nhanvien_theo_ALLBindingSource;
        private QuanLyTienLuongDataSet8 QuanLyTienLuongDataSet8;
        private QuanLyTienLuongDataSet8TableAdapters.DS_Nhanvien_theo_ALLTableAdapter DS_Nhanvien_theo_ALLTableAdapter;
        private System.Windows.Forms.BindingSource LuongNhanVienBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.LuongNhanVienTableAdapter LuongNhanVienTableAdapter;
        private QuanLyTienLuongDataSet9 QuanLyTienLuongDataSet9;
        private DataSet3 DataSet3;
    }
}