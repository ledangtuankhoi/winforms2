namespace QuanLyTienLuong
{
    partial class frmtimluong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelACC = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnACCOUNT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbQLL_XemTruoc = new System.Windows.Forms.GroupBox();
            this.txtcoutacc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvluong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTienLuongDataSet2 = new QuanLyTienLuong.QuanLyTienLuongDataSet2();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsreach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbnv = new System.Windows.Forms.RadioButton();
            this.rdbMaLuong = new System.Windows.Forms.RadioButton();
            this.rdbphucap = new System.Windows.Forms.RadioButton();
            this.rdbthuong = new System.Windows.Forms.RadioButton();
            this.rdbngaycong = new System.Windows.Forms.RadioButton();
            this.rdbkhautru = new System.Windows.Forms.RadioButton();
            this.luongNhanVienTableAdapter = new QuanLyTienLuong.QuanLyTienLuongDataSet2TableAdapters.LuongNhanVienTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSreach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.luongNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luongNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bBacLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panelACC.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbQLL_XemTruoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienLuongDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBacLuongBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(125, 566);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelACC
            // 
            this.panelACC.Controls.Add(this.button2);
            this.panelACC.Controls.Add(this.button1);
            this.panelACC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelACC.Location = new System.Drawing.Point(0, 239);
            this.panelACC.Name = "panelACC";
            this.panelACC.Size = new System.Drawing.Size(125, 86);
            this.panelACC.TabIndex = 11;
            this.panelACC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelACC_Paint);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnACCOUNT.Size = new System.Drawing.Size(125, 44);
            this.btnACCOUNT.TabIndex = 10;
            this.btnACCOUNT.Text = "TÀI KHOẢN";
            this.btnACCOUNT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnACCOUNT.UseVisualStyleBackColor = true;
            this.btnACCOUNT.Click += new System.EventHandler(this.btnACCOUNT_Click_1);
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
            this.button4.Size = new System.Drawing.Size(125, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "BÁO BÁO";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button8.Size = new System.Drawing.Size(125, 44);
            this.button8.TabIndex = 5;
            this.button8.Text = "TÌM KIẾM";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "QUẢN KÝ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 63);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gbQLL_XemTruoc
            // 
            this.gbQLL_XemTruoc.Controls.Add(this.button6);
            this.gbQLL_XemTruoc.Controls.Add(this.btnThoat);
            this.gbQLL_XemTruoc.Controls.Add(this.button5);
            this.gbQLL_XemTruoc.Controls.Add(this.txtcoutacc);
            this.gbQLL_XemTruoc.Controls.Add(this.label7);
            this.gbQLL_XemTruoc.Controls.Add(this.dgvluong);
            this.gbQLL_XemTruoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbQLL_XemTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQLL_XemTruoc.Location = new System.Drawing.Point(125, 138);
            this.gbQLL_XemTruoc.Name = "gbQLL_XemTruoc";
            this.gbQLL_XemTruoc.Size = new System.Drawing.Size(859, 428);
            this.gbQLL_XemTruoc.TabIndex = 26;
            this.gbQLL_XemTruoc.TabStop = false;
            this.gbQLL_XemTruoc.Text = "Xem Trước";
            this.gbQLL_XemTruoc.Enter += new System.EventHandler(this.gbQLL_XemTruoc_Enter);
            // 
            // txtcoutacc
            // 
            this.txtcoutacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoutacc.Location = new System.Drawing.Point(747, 88);
            this.txtcoutacc.Name = "txtcoutacc";
            this.txtcoutacc.Size = new System.Drawing.Size(55, 35);
            this.txtcoutacc.TabIndex = 3;
            this.txtcoutacc.TextChanged += new System.EventHandler(this.txtcoutacc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(694, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "TỔNG NHÂN VIÊN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvluong
            // 
            this.dgvluong.AutoGenerateColumns = false;
            this.dgvluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvluong.DataSource = this.luongNhanVienBindingSource2;
            this.dgvluong.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvluong.GridColor = System.Drawing.Color.White;
            this.dgvluong.Location = new System.Drawing.Point(3, 17);
            this.dgvluong.Name = "dgvluong";
            this.dgvluong.Size = new System.Drawing.Size(666, 408);
            this.dgvluong.TabIndex = 1;
            this.dgvluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvluong_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLuong";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLuong";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaKhauTru";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaKhauTru";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNgayCong";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNgayCong";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaThuong";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaThuong";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaPhuCap";
            this.dataGridViewTextBoxColumn6.HeaderText = "MaPhuCap";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // luongNhanVienBindingSource2
            // 
            this.luongNhanVienBindingSource2.DataMember = "LuongNhanVien";
            this.luongNhanVienBindingSource2.DataSource = this.quanLyTienLuongDataSet2;
            // 
            // quanLyTienLuongDataSet2
            // 
            this.quanLyTienLuongDataSet2.DataSetName = "QuanLyTienLuongDataSet2";
            this.quanLyTienLuongDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(128, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 145);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnSreach);
            this.panel5.Controls.Add(this.txtsreach);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(850, 75);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rosewood Std Regular", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(433, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 41);
            this.label8.TabIndex = 27;
            this.label8.Text = "TIM KIEM";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtsreach
            // 
            this.txtsreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsreach.Location = new System.Drawing.Point(102, 30);
            this.txtsreach.Name = "txtsreach";
            this.txtsreach.Size = new System.Drawing.Size(177, 29);
            this.txtsreach.TabIndex = 1;
            this.txtsreach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbnv);
            this.panel4.Controls.Add(this.rdbMaLuong);
            this.panel4.Controls.Add(this.rdbphucap);
            this.panel4.Controls.Add(this.rdbthuong);
            this.panel4.Controls.Add(this.rdbngaycong);
            this.panel4.Controls.Add(this.rdbkhautru);
            this.panel4.Location = new System.Drawing.Point(3, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 47);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // rdbnv
            // 
            this.rdbnv.AutoSize = true;
            this.rdbnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnv.Location = new System.Drawing.Point(120, 16);
            this.rdbnv.Name = "rdbnv";
            this.rdbnv.Size = new System.Drawing.Size(113, 22);
            this.rdbnv.TabIndex = 6;
            this.rdbnv.TabStop = true;
            this.rdbnv.Text = "mã nhân viên";
            this.rdbnv.UseVisualStyleBackColor = true;
            this.rdbnv.CheckedChanged += new System.EventHandler(this.rdbnv_CheckedChanged);
            // 
            // rdbMaLuong
            // 
            this.rdbMaLuong.AutoSize = true;
            this.rdbMaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaLuong.Location = new System.Drawing.Point(3, 16);
            this.rdbMaLuong.Name = "rdbMaLuong";
            this.rdbMaLuong.Size = new System.Drawing.Size(87, 22);
            this.rdbMaLuong.TabIndex = 6;
            this.rdbMaLuong.TabStop = true;
            this.rdbMaLuong.Text = "mã lương";
            this.rdbMaLuong.UseVisualStyleBackColor = true;
            this.rdbMaLuong.CheckedChanged += new System.EventHandler(this.rdbMaLuong_CheckedChanged);
            // 
            // rdbphucap
            // 
            this.rdbphucap.AutoSize = true;
            this.rdbphucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbphucap.Location = new System.Drawing.Point(590, 16);
            this.rdbphucap.Name = "rdbphucap";
            this.rdbphucap.Size = new System.Drawing.Size(103, 22);
            this.rdbphucap.TabIndex = 6;
            this.rdbphucap.TabStop = true;
            this.rdbphucap.Text = "mã phụ cấp";
            this.rdbphucap.UseVisualStyleBackColor = true;
            this.rdbphucap.CheckedChanged += new System.EventHandler(this.rdbphucap_CheckedChanged);
            // 
            // rdbthuong
            // 
            this.rdbthuong.AutoSize = true;
            this.rdbthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbthuong.Location = new System.Drawing.Point(488, 16);
            this.rdbthuong.Name = "rdbthuong";
            this.rdbthuong.Size = new System.Drawing.Size(96, 22);
            this.rdbthuong.TabIndex = 6;
            this.rdbthuong.TabStop = true;
            this.rdbthuong.Text = "mã thưởng";
            this.rdbthuong.UseVisualStyleBackColor = true;
            this.rdbthuong.CheckedChanged += new System.EventHandler(this.rdbthuong_CheckedChanged);
            // 
            // rdbngaycong
            // 
            this.rdbngaycong.AutoSize = true;
            this.rdbngaycong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbngaycong.Location = new System.Drawing.Point(363, 16);
            this.rdbngaycong.Name = "rdbngaycong";
            this.rdbngaycong.Size = new System.Drawing.Size(119, 22);
            this.rdbngaycong.TabIndex = 6;
            this.rdbngaycong.TabStop = true;
            this.rdbngaycong.Text = "mã ngày công";
            this.rdbngaycong.UseVisualStyleBackColor = true;
            this.rdbngaycong.CheckedChanged += new System.EventHandler(this.rdbngaycong_CheckedChanged);
            // 
            // rdbkhautru
            // 
            this.rdbkhautru.AutoSize = true;
            this.rdbkhautru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbkhautru.Location = new System.Drawing.Point(249, 16);
            this.rdbkhautru.Name = "rdbkhautru";
            this.rdbkhautru.Size = new System.Drawing.Size(108, 22);
            this.rdbkhautru.TabIndex = 6;
            this.rdbkhautru.TabStop = true;
            this.rdbkhautru.Text = "mã khấu trừ ";
            this.rdbkhautru.UseVisualStyleBackColor = true;
            this.rdbkhautru.CheckedChanged += new System.EventHandler(this.rdbkhautru_CheckedChanged);
            // 
            // luongNhanVienTableAdapter
            // 
            this.luongNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.CausesValidation = false;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTienLuong.Properties.Resources.asdf;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(687, 303);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 57);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseCompatibleTextRendering = true;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button5
            // 
            this.button5.Image = global::QuanLyTienLuong.Properties.Resources.xoa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(687, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSreach
            // 
            this.btnSreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSreach.Image = global::QuanLyTienLuong.Properties.Resources.sreach;
            this.btnSreach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSreach.Location = new System.Drawing.Point(308, 33);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(88, 27);
            this.btnSreach.TabIndex = 2;
            this.btnSreach.Text = "tìm";
            this.btnSreach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // luongNhanVienBindingSource1
            // 
            this.luongNhanVienBindingSource1.DataMember = "LuongNhanVien";
            this.luongNhanVienBindingSource1.CurrentChanged += new System.EventHandler(this.luongNhanVienBindingSource1_CurrentChanged);
            // 
            // luongNhanVienBindingSource
            // 
            this.luongNhanVienBindingSource.DataMember = "LuongNhanVien";
            this.luongNhanVienBindingSource.CurrentChanged += new System.EventHandler(this.luongNhanVienBindingSource_CurrentChanged);
            // 
            // bBacLuongBindingSource
            // 
            this.bBacLuongBindingSource.DataMember = "bBacLuong";
            this.bBacLuongBindingSource.CurrentChanged += new System.EventHandler(this.bBacLuongBindingSource_CurrentChanged);
            // 
            // button6
            // 
            this.button6.Image = global::QuanLyTienLuong.Properties.Resources.in1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(687, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 51);
            this.button6.TabIndex = 23;
            this.button6.Text = "in";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmtimluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.gbQLL_XemTruoc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtimluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "timluong";
            this.Load += new System.EventHandler(this.frmtimluong_Load);
            this.panel1.ResumeLayout(false);
            this.panelACC.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbQLL_XemTruoc.ResumeLayout(false);
            this.gbQLL_XemTruoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienLuongDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBacLuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panelACC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnACCOUNT;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbQLL_XemTruoc;
        private System.Windows.Forms.TextBox txtcoutacc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhauTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhuCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource luongNhanVienBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource bBacLuongBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource luongNhanVienBindingSource;
        private System.Windows.Forms.TextBox txtsreach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbnv;
        private System.Windows.Forms.RadioButton rdbMaLuong;
        private System.Windows.Forms.RadioButton rdbphucap;
        private System.Windows.Forms.RadioButton rdbthuong;
        private System.Windows.Forms.RadioButton rdbngaycong;
        private System.Windows.Forms.RadioButton rdbkhautru;
        private System.Windows.Forms.Button btnSreach;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnThoat;
        private QuanLyTienLuongDataSet2 quanLyTienLuongDataSet2;
        private System.Windows.Forms.BindingSource luongNhanVienBindingSource2;
        private QuanLyTienLuongDataSet2TableAdapters.LuongNhanVienTableAdapter luongNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}