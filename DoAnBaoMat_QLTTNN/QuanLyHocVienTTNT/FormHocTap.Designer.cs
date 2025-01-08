namespace QuanLyHocVienTTNT
{
    partial class FormHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocTap));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocTap = new System.Windows.Forms.DataGridView();
            this.MABT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTOIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOPHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTao = new System.Windows.Forms.Button();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocTap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐIỂM";
            // 
            // dgvHocTap
            // 
            this.dgvHocTap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocTap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocTap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHocTap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocTap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABT,
            this.MAHV,
            this.HOTENHV,
            this.DIEM,
            this.DIEMTOIDA,
            this.MALOPHP});
            this.dgvHocTap.Location = new System.Drawing.Point(23, 157);
            this.dgvHocTap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHocTap.Name = "dgvHocTap";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvHocTap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocTap.RowTemplate.Height = 28;
            this.dgvHocTap.Size = new System.Drawing.Size(767, 284);
            this.dgvHocTap.TabIndex = 2;
            this.dgvHocTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocTap_CellClick);
            this.dgvHocTap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocTap_CellDoubleClick);
            // 
            // MABT
            // 
            this.MABT.DataPropertyName = "MABT";
            this.MABT.HeaderText = "Mã Bài Tập";
            this.MABT.Name = "MABT";
            this.MABT.ReadOnly = true;
            // 
            // MAHV
            // 
            this.MAHV.DataPropertyName = "MAHV";
            this.MAHV.HeaderText = "Mã Học Viên";
            this.MAHV.Name = "MAHV";
            this.MAHV.ReadOnly = true;
            // 
            // HOTENHV
            // 
            this.HOTENHV.DataPropertyName = "HOTENHV";
            this.HOTENHV.HeaderText = "Tên Học Viên";
            this.HOTENHV.Name = "HOTENHV";
            this.HOTENHV.ReadOnly = true;
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm";
            this.DIEM.Name = "DIEM";
            // 
            // DIEMTOIDA
            // 
            this.DIEMTOIDA.DataPropertyName = "DIEMTOIDA";
            this.DIEMTOIDA.HeaderText = "Điểm Tối Đa";
            this.DIEMTOIDA.Name = "DIEMTOIDA";
            // 
            // MALOPHP
            // 
            this.MALOPHP.DataPropertyName = "MALOPHP";
            this.MALOPHP.HeaderText = "Mã Lớp";
            this.MALOPHP.Name = "MALOPHP";
            this.MALOPHP.ReadOnly = true;
            // 
            // btnTao
            // 
            this.btnTao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(643, 83);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(147, 32);
            this.btnTao.TabIndex = 3;
            this.btnTao.Text = " Tạo bài tập";
            this.btnTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cboMaLop
            // 
            this.cboMaLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(110, 63);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(144, 28);
            this.cboMaLop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(302, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn";
            // 
            // cboLoc
            // 
            this.cboLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(353, 21);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(165, 28);
            this.cboLoc.TabIndex = 6;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(234, 58);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(134, 25);
            this.btn_TimKiem.TabIndex = 46;
            this.btn_TimKiem.Text = " Tìm kiếm";
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.cboLoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(34, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(605, 97);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // FormHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dgvHocTap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHocTap";
            this.Text = "FormHocTap";
            this.Load += new System.EventHandler(this.FormHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocTap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocTap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTOIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOPHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}