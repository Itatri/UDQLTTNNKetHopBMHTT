namespace QuanLyHocVienTTNT
{
    partial class FormKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhuyenMai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Xoa = new System.Windows.Forms.Button();
            this.BT_Them = new System.Windows.Forms.Button();
            this.Dvg_GiamGia = new System.Windows.Forms.DataGridView();
            this.BT_TimKiem = new System.Windows.Forms.Button();
            this.TB_MKM = new System.Windows.Forms.TextBox();
            this.LB_MaKM = new System.Windows.Forms.Label();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHVNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_GiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH KHUYẾN MÃI";
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("BT_Xoa.Image")));
            this.BT_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Xoa.Location = new System.Drawing.Point(597, 328);
            this.BT_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(109, 44);
            this.BT_Xoa.TabIndex = 9;
            this.BT_Xoa.Text = " Xóa";
            this.BT_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // BT_Them
            // 
            this.BT_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Them.Image = ((System.Drawing.Image)(resources.GetObject("BT_Them.Image")));
            this.BT_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Them.Location = new System.Drawing.Point(424, 328);
            this.BT_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Them.Name = "BT_Them";
            this.BT_Them.Size = new System.Drawing.Size(131, 44);
            this.BT_Them.TabIndex = 10;
            this.BT_Them.Text = " Thêm";
            this.BT_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Them.UseVisualStyleBackColor = true;
            this.BT_Them.Click += new System.EventHandler(this.BT_Them_Click);
            // 
            // Dvg_GiamGia
            // 
            this.Dvg_GiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_GiamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvg_GiamGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dvg_GiamGia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dvg_GiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvg_GiamGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dvg_GiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_GiamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.SoHVNhom,
            this.SoTienGiam});
            this.Dvg_GiamGia.Location = new System.Drawing.Point(60, 118);
            this.Dvg_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dvg_GiamGia.Name = "Dvg_GiamGia";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.Dvg_GiamGia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvg_GiamGia.RowTemplate.Height = 28;
            this.Dvg_GiamGia.Size = new System.Drawing.Size(987, 194);
            this.Dvg_GiamGia.TabIndex = 3;
            this.Dvg_GiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_GiamGia_CellClick);
            this.Dvg_GiamGia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_GiamGia_CellDoubleClick);
            // 
            // BT_TimKiem
            // 
            this.BT_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_TimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("BT_TimKiem.Image")));
            this.BT_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_TimKiem.Location = new System.Drawing.Point(791, 59);
            this.BT_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_TimKiem.Name = "BT_TimKiem";
            this.BT_TimKiem.Size = new System.Drawing.Size(162, 38);
            this.BT_TimKiem.TabIndex = 13;
            this.BT_TimKiem.Text = " Tìm kiếm";
            this.BT_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_TimKiem.UseVisualStyleBackColor = true;
            this.BT_TimKiem.Click += new System.EventHandler(this.BT_TimKiem_Click);
            // 
            // TB_MKM
            // 
            this.TB_MKM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_MKM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MKM.Location = new System.Drawing.Point(363, 65);
            this.TB_MKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_MKM.Name = "TB_MKM";
            this.TB_MKM.Size = new System.Drawing.Size(399, 32);
            this.TB_MKM.TabIndex = 12;
            // 
            // LB_MaKM
            // 
            this.LB_MaKM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_MaKM.AutoSize = true;
            this.LB_MaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaKM.ForeColor = System.Drawing.Color.MediumBlue;
            this.LB_MaKM.Location = new System.Drawing.Point(185, 66);
            this.LB_MaKM.Name = "LB_MaKM";
            this.LB_MaKM.Size = new System.Drawing.Size(145, 25);
            this.LB_MaKM.TabIndex = 11;
            this.LB_MaKM.Text = "Mã khuyến mãi";
            this.LB_MaKM.Click += new System.EventHandler(this.LB_MaKM_Click);
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.HeaderText = "Mã Khuyến Mãi";
            this.MaKM.Name = "MaKM";
            // 
            // SoHVNhom
            // 
            this.SoHVNhom.DataPropertyName = "SoHVNhom";
            this.SoHVNhom.HeaderText = "Số Học Viên Nhóm";
            this.SoHVNhom.Name = "SoHVNhom";
            // 
            // SoTienGiam
            // 
            this.SoTienGiam.DataPropertyName = "SoTienGiam";
            dataGridViewCellStyle2.NullValue = null;
            this.SoTienGiam.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoTienGiam.HeaderText = "Số Tiền Giảm";
            this.SoTienGiam.Name = "SoTienGiam";
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 744);
            this.Controls.Add(this.BT_TimKiem);
            this.Controls.Add(this.TB_MKM);
            this.Controls.Add(this.LB_MaKM);
            this.Controls.Add(this.Dvg_GiamGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.BT_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhuyenMai";
            this.Text = "FormKhuyenMai";
            this.Load += new System.EventHandler(this.FormKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_GiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Xoa;
        private System.Windows.Forms.Button BT_Them;
        private System.Windows.Forms.DataGridView Dvg_GiamGia;
        private System.Windows.Forms.Button BT_TimKiem;
        private System.Windows.Forms.TextBox TB_MKM;
        private System.Windows.Forms.Label LB_MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHVNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienGiam;
    }
}