namespace QuanLyDiemSinhVien
{
    partial class ThongKeSinhVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTKmoi1 = new System.Windows.Forms.Button();
            this.ctnXem1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTKkhoa = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTKmoi2 = new System.Windows.Forms.Button();
            this.btnXem2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTKlop = new System.Windows.Forms.ComboBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new QuanLyDiemSinhVien.QuanLyDiemDataSet();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.khoaTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.KhoaTableAdapter();
            this.lopTableAdapter = new QuanLyDiemSinhVien.QuanLyDiemDataSetTableAdapters.LopTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.btnTKmoi1);
            this.tabPage1.Controls.Add(this.ctnXem1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboTKkhoa);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin Sinh Viên Theo Khoa";
            // 
            // btnTKmoi1
            // 
            this.btnTKmoi1.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Moi;
            this.btnTKmoi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKmoi1.Location = new System.Drawing.Point(603, 4);
            this.btnTKmoi1.Name = "btnTKmoi1";
            this.btnTKmoi1.Size = new System.Drawing.Size(83, 43);
            this.btnTKmoi1.TabIndex = 10;
            this.btnTKmoi1.Text = "Mới";
            this.btnTKmoi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKmoi1.UseVisualStyleBackColor = true;
            this.btnTKmoi1.Click += new System.EventHandler(this.btnTKmoi1_Click);
            // 
            // ctnXem1
            // 
            this.ctnXem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctnXem1.Location = new System.Drawing.Point(483, 4);
            this.ctnXem1.Name = "ctnXem1";
            this.ctnXem1.Size = new System.Drawing.Size(102, 43);
            this.ctnXem1.TabIndex = 9;
            this.ctnXem1.Text = "Xem";
            this.ctnXem1.UseVisualStyleBackColor = false;
            this.ctnXem1.Click += new System.EventHandler(this.ctnXem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Khoa";
            // 
            // cboTKkhoa
            // 
            this.cboTKkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKkhoa.FormattingEnabled = true;
            this.cboTKkhoa.Location = new System.Drawing.Point(192, 12);
            this.cboTKkhoa.Name = "cboTKkhoa";
            this.cboTKkhoa.Size = new System.Drawing.Size(270, 28);
            this.cboTKkhoa.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 53);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1112, 466);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.Controls.Add(this.btnTKmoi2);
            this.tabPage2.Controls.Add(this.btnXem2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboTKlop);
            this.tabPage2.Controls.Add(this.dataGridView5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông Tin Sinh Viên Theo Lớp";
            // 
            // btnTKmoi2
            // 
            this.btnTKmoi2.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Moi;
            this.btnTKmoi2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKmoi2.Location = new System.Drawing.Point(609, 6);
            this.btnTKmoi2.Name = "btnTKmoi2";
            this.btnTKmoi2.Size = new System.Drawing.Size(84, 43);
            this.btnTKmoi2.TabIndex = 7;
            this.btnTKmoi2.Text = "Mới";
            this.btnTKmoi2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKmoi2.UseVisualStyleBackColor = true;
            this.btnTKmoi2.Click += new System.EventHandler(this.btnTKmoi2_Click);
            // 
            // btnXem2
            // 
            this.btnXem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem2.Location = new System.Drawing.Point(482, 6);
            this.btnXem2.Name = "btnXem2";
            this.btnXem2.Size = new System.Drawing.Size(102, 43);
            this.btnXem2.TabIndex = 6;
            this.btnXem2.Text = "Xem";
            this.btnXem2.UseVisualStyleBackColor = false;
            this.btnXem2.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp";
            // 
            // cboTKlop
            // 
            this.cboTKlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKlop.FormattingEnabled = true;
            this.cboTKlop.Location = new System.Drawing.Point(191, 14);
            this.cboTKlop.Name = "cboTKlop";
            this.cboTKlop.Size = new System.Drawing.Size(270, 28);
            this.cboTKlop.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(3, 55);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1112, 466);
            this.dataGridView5.TabIndex = 1;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.quanLyDiemDataSet;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(237, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "THỐNG KÊ THÔNG TIN SINH VIÊN";
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyDiemSinhVien.Properties.Resources.i_Thoat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(995, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKeSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.ThongKeSinhVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTKlop;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QuanLyDiemDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyDiemDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Button ctnXem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTKkhoa;
        private System.Windows.Forms.Button btnTKmoi1;
        private System.Windows.Forms.Button btnTKmoi2;
    }
}