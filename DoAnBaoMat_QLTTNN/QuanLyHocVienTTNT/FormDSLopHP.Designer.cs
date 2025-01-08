namespace QuanLyHocVienTTNT
{
    partial class FormDSLopHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSLopHP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DsLop = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhaiGiang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(383, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH SÁCH LỚP HỌC PHẦN";
            // 
            // dgv_DsLop
            // 
            this.dgv_DsLop.AllowUserToAddRows = false;
            this.dgv_DsLop.AllowUserToDeleteRows = false;
            this.dgv_DsLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DsLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DsLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DsLop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DsLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DsLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenGV,
            this.TenKhoa,
            this.TenLop,
            this.SiSo,
            this.LichHoc,
            this.NgayKhaiGiang,
            this.KetThuc,
            this.HocPhi});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DsLop.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DsLop.Location = new System.Drawing.Point(12, 114);
            this.dgv_DsLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DsLop.MultiSelect = false;
            this.dgv_DsLop.Name = "dgv_DsLop";
            this.dgv_DsLop.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DsLop.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_DsLop.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_DsLop.RowTemplate.Height = 28;
            this.dgv_DsLop.Size = new System.Drawing.Size(1061, 260);
            this.dgv_DsLop.TabIndex = 12;
            this.dgv_DsLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsLop_CellClick);
            this.dgv_DsLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsLop_CellDoubleClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(582, 398);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(150, 40);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "  Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(389, 398);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(150, 40);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "  Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm lớp HP";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_TimKiem.Location = new System.Drawing.Point(158, 73);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(215, 32);
            this.txt_TimKiem.TabIndex = 28;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLopHP";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.MaLop.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khóa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLopHP";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sỉ Số";
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            // 
            // LichHoc
            // 
            this.LichHoc.DataPropertyName = "LichHoc";
            this.LichHoc.HeaderText = "Lịch Học";
            this.LichHoc.Name = "LichHoc";
            this.LichHoc.ReadOnly = true;
            // 
            // NgayKhaiGiang
            // 
            this.NgayKhaiGiang.DataPropertyName = "NgayKhaiGiang";
            this.NgayKhaiGiang.HeaderText = "Khai Giảng";
            this.NgayKhaiGiang.Name = "NgayKhaiGiang";
            this.NgayKhaiGiang.ReadOnly = true;
            // 
            // KetThuc
            // 
            this.KetThuc.DataPropertyName = "NgayKT";
            this.KetThuc.HeaderText = "Kết Thúc";
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.ReadOnly = true;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học Phí";
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.ReadOnly = true;
            // 
            // FormDSLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DsLop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSLopHP";
            this.Text = "FormDSLopHP";
            this.Load += new System.EventHandler(this.FormDSLopHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DsLop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhaiGiang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
    }
}