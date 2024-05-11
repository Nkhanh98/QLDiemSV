namespace QuanLyDiemSinhVien
{
    partial class ThongKeDiemSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new QuanLyDiemSinhVien.QuanLyDiemDataSet();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.LopTableAdapter();
            this.monHocTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.MonHocTableAdapter();
            this.khoaTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.KhoaTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radTKDmaSV = new System.Windows.Forms.RadioButton();
            this.radTKDmaMH = new System.Windows.Forms.RadioButton();
            this.txtTKDmasv = new System.Windows.Forms.TextBox();
            this.btnTKDmoi1 = new System.Windows.Forms.Button();
            this.btnTKDxem1 = new System.Windows.Forms.Button();
            this.cboTKDmonhoc = new System.Windows.Forms.ComboBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.quanLyDiemDataSet;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(217, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "THỐNG KÊ ĐIỂM SINH VIÊN";
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.radTKDmaSV);
            this.tabPage4.Controls.Add(this.radTKDmaMH);
            this.tabPage4.Controls.Add(this.txtTKDmasv);
            this.tabPage4.Controls.Add(this.btnTKDmoi1);
            this.tabPage4.Controls.Add(this.btnTKDxem1);
            this.tabPage4.Controls.Add(this.cboTKDmonhoc);
            this.tabPage4.Controls.Add(this.dataGridView7);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(923, 549);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Danh Sách";
            // 
            // radTKDmaSV
            // 
            this.radTKDmaSV.AutoSize = true;
            this.radTKDmaSV.Location = new System.Drawing.Point(311, 7);
            this.radTKDmaSV.Name = "radTKDmaSV";
            this.radTKDmaSV.Size = new System.Drawing.Size(128, 24);
            this.radTKDmaSV.TabIndex = 14;
            this.radTKDmaSV.TabStop = true;
            this.radTKDmaSV.Text = "Mã Sinh Viên";
            this.radTKDmaSV.UseVisualStyleBackColor = true;
            // 
            // radTKDmaMH
            // 
            this.radTKDmaMH.AutoSize = true;
            this.radTKDmaMH.Location = new System.Drawing.Point(7, 7);
            this.radTKDmaMH.Name = "radTKDmaMH";
            this.radTKDmaMH.Size = new System.Drawing.Size(124, 24);
            this.radTKDmaMH.TabIndex = 13;
            this.radTKDmaMH.TabStop = true;
            this.radTKDmaMH.Text = "Mã Môn Học";
            this.radTKDmaMH.UseVisualStyleBackColor = true;
            // 
            // txtTKDmasv
            // 
            this.txtTKDmasv.Location = new System.Drawing.Point(445, 3);
            this.txtTKDmasv.Multiline = true;
            this.txtTKDmasv.Name = "txtTKDmasv";
            this.txtTKDmasv.Size = new System.Drawing.Size(229, 28);
            this.txtTKDmasv.TabIndex = 12;
            // 
            // btnTKDmoi1
            // 
            this.btnTKDmoi1.Location = new System.Drawing.Point(818, 3);
            this.btnTKDmoi1.Name = "btnTKDmoi1";
            this.btnTKDmoi1.Size = new System.Drawing.Size(99, 35);
            this.btnTKDmoi1.TabIndex = 11;
            this.btnTKDmoi1.Text = "Mới";
            this.btnTKDmoi1.UseVisualStyleBackColor = true;
            this.btnTKDmoi1.Click += new System.EventHandler(this.btnTKDmoi1_Click);
            // 
            // btnTKDxem1
            // 
            this.btnTKDxem1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTKDxem1.Location = new System.Drawing.Point(713, 3);
            this.btnTKDxem1.Name = "btnTKDxem1";
            this.btnTKDxem1.Size = new System.Drawing.Size(99, 35);
            this.btnTKDxem1.TabIndex = 9;
            this.btnTKDxem1.Text = "Xem";
            this.btnTKDxem1.UseVisualStyleBackColor = false;
            this.btnTKDxem1.Click += new System.EventHandler(this.btnTKDxem1_Click);
            // 
            // cboTKDmonhoc
            // 
            this.cboTKDmonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKDmonhoc.FormattingEnabled = true;
            this.cboTKDmonhoc.Location = new System.Drawing.Point(137, 3);
            this.cboTKDmonhoc.Name = "cboTKDmonhoc";
            this.cboTKDmonhoc.Size = new System.Drawing.Size(168, 28);
            this.cboTKDmonhoc.TabIndex = 7;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMH,
            this.HocKy,
            this.DiemLan1,
            this.DiemLan2});
            this.dataGridView7.Location = new System.Drawing.Point(3, 41);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView7.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView7.RowTemplate.Height = 28;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(914, 474);
            this.dataGridView7.TabIndex = 3;
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
            this.HocKy.HeaderText = "Học kỳ";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Thoat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(809, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ThongKeDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKeDiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.ThongKeDiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyDiemDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QuanLyDiemDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLyDiemDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTKDxem1;
        private System.Windows.Forms.ComboBox cboTKDmonhoc;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnTKDmoi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLan2;
        private System.Windows.Forms.TextBox txtTKDmasv;
        private System.Windows.Forms.RadioButton radTKDmaSV;
        private System.Windows.Forms.RadioButton radTKDmaMH;
    }
}