namespace QuanLyDiemSinhVien
{
    partial class Diem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.radMaSV = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtHocky = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new QuanLyDiemSinhVien.QuanLyDiemDataSet();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMaMH = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMoi2 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.monHocTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.MonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMH,
            this.HocKy,
            this.DiemLan1,
            this.DiemLan2});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1096, 323);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 8;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Điểm học kỳ";
            this.HocKy.MinimumWidth = 8;
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            // 
            // DiemLan1
            // 
            this.DiemLan1.DataPropertyName = "DiemLan1";
            this.DiemLan1.HeaderText = "Điểm lần 1";
            this.DiemLan1.MinimumWidth = 8;
            this.DiemLan1.Name = "DiemLan1";
            this.DiemLan1.ReadOnly = true;
            // 
            // DiemLan2
            // 
            this.DiemLan2.DataPropertyName = "DiemLan2";
            this.DiemLan2.HeaderText = "Điểm lần 2";
            this.DiemLan2.MinimumWidth = 8;
            this.DiemLan2.Name = "DiemLan2";
            this.DiemLan2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "CẬP NHẬT ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 348);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Loc2;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(441, 43);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(96, 45);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "LỌC";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.SystemColors.Control;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTim.Location = new System.Drawing.Point(158, 43);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(256, 45);
            this.txtTim.TabIndex = 2;
            // 
            // radMaSV
            // 
            this.radMaSV.AutoSize = true;
            this.radMaSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radMaSV.Location = new System.Drawing.Point(11, 25);
            this.radMaSV.Name = "radMaSV";
            this.radMaSV.Size = new System.Drawing.Size(128, 24);
            this.radMaSV.TabIndex = 0;
            this.radMaSV.TabStop = true;
            this.radMaSV.Text = "Mã Sinh Viên";
            this.radMaSV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(379, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm Lần 1";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(126, 37);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(235, 34);
            this.txtMaSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Môn Học";
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMoi.Image = global::QuanLyDiemSinhVien.Properties.Resources.reset_n;
            this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi.Location = new System.Drawing.Point(543, 43);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(135, 45);
            this.btnMoi.TabIndex = 4;
            this.btnMoi.Text = "LÀM MỚI";
            this.btnMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDiem2);
            this.groupBox3.Controls.Add(this.txtDiem1);
            this.groupBox3.Controls.Add(this.txtHocky);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboMaMH);
            this.groupBox3.Controls.Add(this.txtMaSV);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(197, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 155);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Điểm Sinh Viên";
            // 
            // txtDiem2
            // 
            this.txtDiem2.Location = new System.Drawing.Point(503, 102);
            this.txtDiem2.Multiline = true;
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(116, 33);
            this.txtDiem2.TabIndex = 13;
            this.txtDiem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiem1
            // 
            this.txtDiem1.Location = new System.Drawing.Point(503, 63);
            this.txtDiem1.Multiline = true;
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(116, 33);
            this.txtDiem1.TabIndex = 12;
            this.txtDiem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHocky
            // 
            this.txtHocky.Location = new System.Drawing.Point(503, 23);
            this.txtHocky.Multiline = true;
            this.txtHocky.Name = "txtHocky";
            this.txtHocky.Size = new System.Drawing.Size(116, 33);
            this.txtHocky.TabIndex = 11;
            this.txtHocky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(379, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm Học Kỳ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(379, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm lần 2";
            // 
            // cboMaMH
            // 
            this.cboMaMH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cboMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(126, 104);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(235, 28);
            this.cboMaMH.TabIndex = 7;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(8, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 51);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Image = global::QuanLyDiemSinhVien.Properties.Resources.update_n;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(8, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 51);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "CẬP NHẬT";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Image = global::QuanLyDiemSinhVien.Properties.Resources.add_n;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 254);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMaMH);
            this.groupBox2.Controls.Add(this.btnMoi);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.radMaSV);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(197, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 116);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // radMaMH
            // 
            this.radMaMH.AutoSize = true;
            this.radMaMH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radMaMH.Location = new System.Drawing.Point(11, 73);
            this.radMaMH.Name = "radMaMH";
            this.radMaMH.Size = new System.Drawing.Size(124, 24);
            this.radMaMH.TabIndex = 5;
            this.radMaMH.TabStop = true;
            this.radMaMH.Text = "Mã Môn Học";
            this.radMaMH.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMoi2);
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnLuu);
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(904, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 254);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnMoi2
            // 
            this.btnMoi2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMoi2.Image = global::QuanLyDiemSinhVien.Properties.Resources.reset_n;
            this.btnMoi2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi2.Location = new System.Drawing.Point(57, 173);
            this.btnMoi2.Name = "btnMoi2";
            this.btnMoi2.Size = new System.Drawing.Size(97, 53);
            this.btnMoi2.TabIndex = 3;
            this.btnMoi2.Text = "MỚI";
            this.btnMoi2.UseVisualStyleBackColor = true;
            this.btnMoi2.Click += new System.EventHandler(this.btnMoi2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.Image = global::QuanLyDiemSinhVien.Properties.Resources.exit_n;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(8, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 51);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.Image = global::QuanLyDiemSinhVien.Properties.Resources.cancel_n;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(8, 106);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 51);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu.Image = global::QuanLyDiemSinhVien.Properties.Resources.save_n;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(7, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 51);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 693);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Điểm";
            this.Load += new System.EventHandler(this.Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.RadioButton radMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.RadioButton radMaMH;
        private System.Windows.Forms.Label label6;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QuanLyDiemDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan2;
        private System.Windows.Forms.TextBox txtDiem2;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtHocky;
        private System.Windows.Forms.Button btnMoi2;
    }
}