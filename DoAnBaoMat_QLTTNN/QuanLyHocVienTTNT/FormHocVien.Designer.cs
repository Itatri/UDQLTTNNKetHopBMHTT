namespace QuanLyHocVienTTNT
{
    partial class FormHocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocVien));
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHocVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHV,
            this.HOTENHV,
            this.GIOITINH,
            this.DIACHI,
            this.EMAIL,
            this.SDT});
            this.dgvHocVien.Location = new System.Drawing.Point(9, 162);
            this.dgvHocVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHocVien.Name = "dgvHocVien";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvHocVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocVien.RowTemplate.Height = 28;
            this.dgvHocVien.Size = new System.Drawing.Size(782, 271);
            this.dgvHocVien.TabIndex = 0;
            this.dgvHocVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellClick);
            this.dgvHocVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVien_CellDoubleClick);
            this.dgvHocVien.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHocVien_CellMouseDown);
            // 
            // MAHV
            // 
            this.MAHV.DataPropertyName = "MAHV";
            this.MAHV.HeaderText = "Mã học viên";
            this.MAHV.Name = "MAHV";
            this.MAHV.ReadOnly = true;
            // 
            // HOTENHV
            // 
            this.HOTENHV.DataPropertyName = "HOTENHV";
            this.HOTENHV.HeaderText = "Tên học viên";
            this.HOTENHV.Name = "HOTENHV";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(170, 67);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(170, 26);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(170, 20);
            this.cboLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(170, 28);
            this.cboLop.TabIndex = 6;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Tên HV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xem ds học viên";
            // 
            // cboLoc
            // 
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(421, 21);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(215, 28);
            this.cboLoc.TabIndex = 9;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(382, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lọc";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.cboLoc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnThemHV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.cboLop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(38, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(723, 104);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiLai.Location = new System.Drawing.Point(640, 20);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(79, 25);
            this.btnTaiLai.TabIndex = 39;
            this.btnTaiLai.Text = "Tải lại ";
            this.btnTaiLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(20, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 0;
            // 
            // btnThemHV
            // 
            this.btnThemHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHV.ForeColor = System.Drawing.Color.Black;
            this.btnThemHV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHV.Image")));
            this.btnThemHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHV.Location = new System.Drawing.Point(421, 59);
            this.btnThemHV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(214, 32);
            this.btnThemHV.TabIndex = 1;
            this.btnThemHV.Text = " Thêm 1 học viên mới";
            this.btnThemHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(276, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // FormHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvHocVien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHocVien";
            this.Text = "Danh sách học viên";
            this.Load += new System.EventHandler(this.FormHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiLai;
    }
}