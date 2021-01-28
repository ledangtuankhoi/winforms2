namespace QuanLyTienLuong
{
    partial class frm_NHANSU_baocao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dstheomaNVTableAdapter = new QuanLyTienLuong.dstheomaNVTableAdapters.dstheomaNVTableAdapter();
            this.dstheomaNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstheomaNV = new QuanLyTienLuong.dstheomaNV();
            this.QuanLyTienLuongDataSet5 = new QuanLyTienLuong.QuanLyTienLuongDataSet5();
            this.ThongTinNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongTinNhanVienTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dstheomaNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstheomaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "dstheomaNV";
            reportDataSource2.Value = this.dstheomaNVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienLuong.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1289, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "báo cáo theo điều kiện";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(479, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 31);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "TÌM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DisplayMember = "DIEU KIEN";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MaNV",
            "MaNgayCong",
            "HoTen",
            "Phongban",
            "Chucvu",
            "DiaChi",
            "SDT",
            "CMND",
            "NgaySinh",
            "Email",
            "GioiTinh",
            "BacLuong",
            "TroCap",
            "hinh"});
            this.comboBox1.Location = new System.Drawing.Point(263, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // dstheomaNVTableAdapter
            // 
            this.dstheomaNVTableAdapter.ClearBeforeFill = true;
            // 
            // dstheomaNVBindingSource
            // 
            this.dstheomaNVBindingSource.DataMember = "dstheomaNV";
            this.dstheomaNVBindingSource.DataSource = this.dstheomaNV;
            // 
            // dstheomaNV
            // 
            this.dstheomaNV.DataSetName = "dstheomaNV";
            this.dstheomaNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuanLyTienLuongDataSet5
            // 
            this.QuanLyTienLuongDataSet5.DataSetName = "QuanLyTienLuongDataSet5";
            this.QuanLyTienLuongDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongTinNhanVienBindingSource
            // 
            this.ThongTinNhanVienBindingSource.DataMember = "ThongTinNhanVien";
            this.ThongTinNhanVienBindingSource.DataSource = this.QuanLyTienLuongDataSet5;
            // 
            // ThongTinNhanVienTableAdapter
            // 
            this.ThongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frm_NHANSU_baocao
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 566);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_NHANSU_baocao";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frm_NHANSU_baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dstheomaNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstheomaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTienLuongDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private dstheomaNVTableAdapters.dstheomaNVTableAdapter dstheomaNVTableAdapter;
        private System.Windows.Forms.BindingSource dstheomaNVBindingSource;
        private dstheomaNV dstheomaNV;
        private System.Windows.Forms.BindingSource ThongTinNhanVienBindingSource;
        private QuanLyTienLuongDataSet5 QuanLyTienLuongDataSet5;
        private QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter ThongTinNhanVienTableAdapter;
    }
}