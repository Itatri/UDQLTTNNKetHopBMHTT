namespace QuanLyHocVienTTNT
{
    partial class FormTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.ngayKT = new System.Windows.Forms.DateTimePicker();
            this.ngayBD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLuaChon = new System.Windows.Forms.ComboBox();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // HOTENHV
            // 
            this.HOTENHV.DataPropertyName = "HOTENHV";
            this.HOTENHV.HeaderText = "Họ tên";
            this.HOTENHV.Name = "HOTENHV";
            this.HOTENHV.ReadOnly = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Black;
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(379, 123);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(146, 40);
            this.btnTraCuu.TabIndex = 48;
            this.btnTraCuu.Text = " Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // ngayKT
            // 
            this.ngayKT.Enabled = false;
            this.ngayKT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayKT.Location = new System.Drawing.Point(571, 76);
            this.ngayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayKT.Name = "ngayKT";
            this.ngayKT.Size = new System.Drawing.Size(231, 32);
            this.ngayKT.TabIndex = 47;
            // 
            // ngayBD
            // 
            this.ngayBD.Enabled = false;
            this.ngayBD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayBD.Location = new System.Drawing.Point(571, 32);
            this.ngayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Size = new System.Drawing.Size(231, 32);
            this.ngayBD.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(462, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(462, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Lựa chọn";
            // 
            // MAHV
            // 
            this.MAHV.DataPropertyName = "MAHV";
            this.MAHV.HeaderText = "Mã học viên";
            this.MAHV.Name = "MAHV";
            this.MAHV.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(418, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "TRA CỨU THÔNG TIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(27, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã lớp";
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLuaChon.FormattingEnabled = true;
            this.cboLuaChon.Location = new System.Drawing.Point(147, 82);
            this.cboLuaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(282, 32);
            this.cboLuaChon.TabIndex = 41;
            this.cboLuaChon.SelectedIndexChanged += new System.EventHandler(this.cboLuaChon_SelectedIndexChanged);
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Controls.Add(this.ngayKT);
            this.groupBox2.Controls.Add(this.ngayBD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboLop);
            this.groupBox2.Controls.Add(this.cboLuaChon);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(116, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(868, 172);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(147, 34);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(282, 32);
            this.cboLop.TabIndex = 40;
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTraCuu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTraCuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHV,
            this.HOTENHV,
            this.GIOITINH,
            this.SDT});
            this.dgvTraCuu.Location = new System.Drawing.Point(27, 299);
            this.dgvTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTraCuu.Name = "dgvTraCuu";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTraCuu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraCuu.RowTemplate.Height = 28;
            this.dgvTraCuu.Size = new System.Drawing.Size(1032, 281);
            this.dgvTraCuu.TabIndex = 42;
            // 
            // FormTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 735);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTraCuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTraCuu";
            this.Text = "FormTraCuu";
            this.Load += new System.EventHandler(this.FormTraCuu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENHV;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DateTimePicker ngayKT;
        private System.Windows.Forms.DateTimePicker ngayBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLuaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DataGridView dgvTraCuu;
    }
}