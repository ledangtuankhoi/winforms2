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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.quanLyTienLuongDataSet5 = new QuanLyTienLuong.QuanLyTienLuongDataSet5();
            this.thongTinNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinNhanVienTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienLuongDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyTienLuongDataSet5
            // 
            this.quanLyTienLuongDataSet5.DataSetName = "QuanLyTienLuongDataSet5";
            this.quanLyTienLuongDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinNhanVienBindingSource
            // 
            this.thongTinNhanVienBindingSource.DataMember = "ThongTinNhanVien";
            this.thongTinNhanVienBindingSource.DataSource = this.quanLyTienLuongDataSet5;
            // 
            // thongTinNhanVienTableAdapter
            // 
            this.thongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongTinNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienLuong.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1289, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_NHANSU_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_NHANSU_baocao";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frm_NHANSU_baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienLuongDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyTienLuongDataSet5 quanLyTienLuongDataSet5;
        private System.Windows.Forms.BindingSource thongTinNhanVienBindingSource;
        private QuanLyTienLuongDataSet5TableAdapters.ThongTinNhanVienTableAdapter thongTinNhanVienTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}