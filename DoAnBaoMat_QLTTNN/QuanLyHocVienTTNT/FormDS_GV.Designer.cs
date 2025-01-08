namespace QuanLyHocVienTTNT
{
    partial class FormDS_GV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDS_GV));
            this.dgv_GiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GiaoVien
            // 
            this.dgv_GiaoVien.AllowUserToAddRows = false;
            this.dgv_GiaoVien.AllowUserToDeleteRows = false;
            this.dgv_GiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_GiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiaoVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_GiaoVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_GiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.TenTKGV,
            this.MatKhau});
            this.dgv_GiaoVien.Location = new System.Drawing.Point(12, 142);
            this.dgv_GiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_GiaoVien.Name = "dgv_GiaoVien";
            this.dgv_GiaoVien.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_GiaoVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_GiaoVien.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_GiaoVien.RowTemplate.Height = 28;
            this.dgv_GiaoVien.Size = new System.Drawing.Size(1060, 182);
            this.dgv_GiaoVien.TabIndex = 22;
            this.dgv_GiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaoVien_CellClick);
            this.dgv_GiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaoVien_CellDoubleClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            // 
            // TenTKGV
            // 
            this.TenTKGV.DataPropertyName = "TenTKGV";
            this.TenTKGV.HeaderText = "Tên tài khoản";
            this.TenTKGV.Name = "TenTKGV";
            this.TenTKGV.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Them.FlatAppearance.BorderSize = 3;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(412, 355);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(150, 40);
            this.btn_Them.TabIndex = 25;
            this.btn_Them.Text = "  Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Xoa.FlatAppearance.BorderSize = 3;
            this.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(578, 355);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 40);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "  Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(426, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.MediumBlue;
            this.txt_TimKiem.Location = new System.Drawing.Point(130, 101);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(215, 32);
            this.txt_TimKiem.TabIndex = 26;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm GV";
            // 
            // FormDS_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dgv_GiaoVien);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDS_GV";
            this.Text = "FormDS_GV";
            this.Load += new System.EventHandler(this.FormDS_GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GiaoVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
    }
}