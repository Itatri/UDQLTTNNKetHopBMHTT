namespace QuanLyHocVienTTNT
{
    partial class FormDSDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSDiemDanh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_MaLopHP = new System.Windows.Forms.ComboBox();
            this.btn_DiemDanh = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_DSDiemDanh = new System.Windows.Forms.DataGridView();
            this.MaLopHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_TrangThaiDiemDanh = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_TimKIem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_MaLopHP
            // 
            this.cb_MaLopHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MaLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaLopHP.FormattingEnabled = true;
            this.cb_MaLopHP.Location = new System.Drawing.Point(173, 101);
            this.cb_MaLopHP.Name = "cb_MaLopHP";
            this.cb_MaLopHP.Size = new System.Drawing.Size(172, 33);
            this.cb_MaLopHP.TabIndex = 0;
            this.cb_MaLopHP.SelectedIndexChanged += new System.EventHandler(this.cb_MaLopHP_SelectedIndexChanged);
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_DiemDanh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("btn_DiemDanh.Image")));
            this.btn_DiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DiemDanh.Location = new System.Drawing.Point(363, 98);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Size = new System.Drawing.Size(215, 40);
            this.btn_DiemDanh.TabIndex = 1;
            this.btn_DiemDanh.Text = " Điểm danh";
            this.btn_DiemDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DiemDanh.UseVisualStyleBackColor = true;
            this.btn_DiemDanh.Click += new System.EventHandler(this.btn_DiemDanh_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(363, 171);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(114, 38);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = " Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv_DSDiemDanh
            // 
            this.dgv_DSDiemDanh.AllowUserToAddRows = false;
            this.dgv_DSDiemDanh.AllowUserToDeleteRows = false;
            this.dgv_DSDiemDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDiemDanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DSDiemDanh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DSDiemDanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSDiemDanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopHP,
            this.MaHV,
            this.HoTenHV,
            this.NgayVang});
            this.dgv_DSDiemDanh.Location = new System.Drawing.Point(28, 253);
            this.dgv_DSDiemDanh.Name = "dgv_DSDiemDanh";
            this.dgv_DSDiemDanh.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_DSDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DSDiemDanh.RowTemplate.Height = 24;
            this.dgv_DSDiemDanh.Size = new System.Drawing.Size(1032, 358);
            this.dgv_DSDiemDanh.TabIndex = 3;
            this.dgv_DSDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSDiemDanh_CellClick);
            this.dgv_DSDiemDanh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSDiemDanh_CellDoubleClick);
            // 
            // MaLopHP
            // 
            this.MaLopHP.DataPropertyName = "MALOPHP";
            this.MaLopHP.HeaderText = "Mã lớp HP";
            this.MaLopHP.Name = "MaLopHP";
            this.MaLopHP.ReadOnly = true;
            // 
            // MaHV
            // 
            this.MaHV.DataPropertyName = "MAHV";
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.Name = "MaHV";
            this.MaHV.ReadOnly = true;
            // 
            // HoTenHV
            // 
            this.HoTenHV.DataPropertyName = "HOTENHV";
            this.HoTenHV.HeaderText = "Tên HV";
            this.HoTenHV.Name = "HoTenHV";
            this.HoTenHV.ReadOnly = true;
            // 
            // NgayVang
            // 
            this.NgayVang.DataPropertyName = "NGAYVANG";
            this.NgayVang.HeaderText = "Ngày Vắng";
            this.NgayVang.Name = "NgayVang";
            this.NgayVang.ReadOnly = true;
            // 
            // cb_TrangThaiDiemDanh
            // 
            this.cb_TrangThaiDiemDanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TrangThaiDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TrangThaiDiemDanh.FormattingEnabled = true;
            this.cb_TrangThaiDiemDanh.Location = new System.Drawing.Point(173, 176);
            this.cb_TrangThaiDiemDanh.Name = "cb_TrangThaiDiemDanh";
            this.cb_TrangThaiDiemDanh.Size = new System.Drawing.Size(170, 33);
            this.cb_TrangThaiDiemDanh.TabIndex = 4;
            this.cb_TrangThaiDiemDanh.SelectedIndexChanged += new System.EventHandler(this.cb_TrangThaiDiemDanh_SelectedIndexChanged);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(819, 101);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(218, 32);
            this.txt_TimKiem.TabIndex = 5;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(876, 169);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(167, 40);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = " Tìm kiếm";
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(391, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐIỂM DANH HỌC VIÊN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp HP";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(33, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tình trạng";
            // 
            // dt_TimKIem
            // 
            this.dt_TimKIem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_TimKIem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_TimKIem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_TimKIem.Location = new System.Drawing.Point(660, 173);
            this.dt_TimKIem.Name = "dt_TimKIem";
            this.dt_TimKIem.Size = new System.Drawing.Size(200, 32);
            this.dt_TimKIem.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(656, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm theo tên HV";
            // 
            // FormDSDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 744);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_TimKIem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.cb_TrangThaiDiemDanh);
            this.Controls.Add(this.dgv_DSDiemDanh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_DiemDanh);
            this.Controls.Add(this.cb_MaLopHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSDiemDanh";
            this.Text = "FormDSDiemDanh";
            this.Load += new System.EventHandler(this.FormDSDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDiemDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_MaLopHP;
        private System.Windows.Forms.Button btn_DiemDanh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DSDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVang;
        private System.Windows.Forms.ComboBox cb_TrangThaiDiemDanh;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_TimKIem;
        private System.Windows.Forms.Label label4;
    }
}