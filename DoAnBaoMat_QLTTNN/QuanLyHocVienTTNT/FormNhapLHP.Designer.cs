namespace QuanLyHocVienTTNT
{
    partial class FormNhapLHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapLHP));
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_TenKhoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SiSoLop = new System.Windows.Forms.TextBox();
            this.txt_TenLopHP = new System.Windows.Forms.TextBox();
            this.cbo_GiaoVien = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_MaLopHPhan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayKG = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_HocPhiLHP = new System.Windows.Forms.TextBox();
            this.txt_LichHocLHP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(463, 476);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(170, 40);
            this.btn_Luu.TabIndex = 23;
            this.btn_Luu.Text = " Xác nhận";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "TẠO LỚP HỌC PHẦN MỚI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cbo_TenKhoa);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_SiSoLop);
            this.groupBox3.Controls.Add(this.txt_TenLopHP);
            this.groupBox3.Controls.Add(this.cbo_GiaoVien);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_MaLopHPhan);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(29, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(491, 296);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lớp học";
            // 
            // cbo_TenKhoa
            // 
            this.cbo_TenKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TenKhoa.FormattingEnabled = true;
            this.cbo_TenKhoa.Location = new System.Drawing.Point(192, 142);
            this.cbo_TenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_TenKhoa.Name = "cbo_TenKhoa";
            this.cbo_TenKhoa.Size = new System.Drawing.Size(280, 32);
            this.cbo_TenKhoa.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(22, 235);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(52, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Sỉ số";
            // 
            // txt_SiSoLop
            // 
            this.txt_SiSoLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SiSoLop.Location = new System.Drawing.Point(192, 235);
            this.txt_SiSoLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SiSoLop.Name = "txt_SiSoLop";
            this.txt_SiSoLop.Size = new System.Drawing.Size(280, 32);
            this.txt_SiSoLop.TabIndex = 4;
            this.txt_SiSoLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SiSoLop_KeyPress);
            // 
            // txt_TenLopHP
            // 
            this.txt_TenLopHP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLopHP.Location = new System.Drawing.Point(192, 188);
            this.txt_TenLopHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenLopHP.Name = "txt_TenLopHP";
            this.txt_TenLopHP.Size = new System.Drawing.Size(280, 32);
            this.txt_TenLopHP.TabIndex = 3;
            // 
            // cbo_GiaoVien
            // 
            this.cbo_GiaoVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_GiaoVien.FormattingEnabled = true;
            this.cbo_GiaoVien.Location = new System.Drawing.Point(192, 90);
            this.cbo_GiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_GiaoVien.Name = "cbo_GiaoVien";
            this.cbo_GiaoVien.Size = new System.Drawing.Size(280, 32);
            this.cbo_GiaoVien.TabIndex = 2;
            this.cbo_GiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbo_GiaoVien_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(17, 188);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(77, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(17, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên khóa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(17, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên giáo viên";
            // 
            // txt_MaLopHPhan
            // 
            this.txt_MaLopHPhan.Enabled = false;
            this.txt_MaLopHPhan.Location = new System.Drawing.Point(192, 43);
            this.txt_MaLopHPhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaLopHPhan.Name = "txt_MaLopHPhan";
            this.txt_MaLopHPhan.ReadOnly = true;
            this.txt_MaLopHPhan.Size = new System.Drawing.Size(280, 32);
            this.txt_MaLopHPhan.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumBlue;
            this.label15.Location = new System.Drawing.Point(17, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã lớp";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.dtp_NgayKT);
            this.groupBox4.Controls.Add(this.dtp_NgayKG);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txt_HocPhiLHP);
            this.groupBox4.Controls.Add(this.txt_LichHocLHP);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(551, 128);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(503, 296);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thời gian";
            // 
            // dtp_NgayKT
            // 
            this.dtp_NgayKT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKT.Location = new System.Drawing.Point(209, 140);
            this.dtp_NgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayKT.Name = "dtp_NgayKT";
            this.dtp_NgayKT.Size = new System.Drawing.Size(222, 32);
            this.dtp_NgayKT.TabIndex = 2;
            // 
            // dtp_NgayKG
            // 
            this.dtp_NgayKG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKG.Location = new System.Drawing.Point(209, 93);
            this.dtp_NgayKG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayKG.Name = "dtp_NgayKG";
            this.dtp_NgayKG.Size = new System.Drawing.Size(222, 32);
            this.dtp_NgayKG.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MediumBlue;
            this.label16.Location = new System.Drawing.Point(34, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Lịch học";
            // 
            // txt_HocPhiLHP
            // 
            this.txt_HocPhiLHP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HocPhiLHP.Location = new System.Drawing.Point(209, 186);
            this.txt_HocPhiLHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HocPhiLHP.Name = "txt_HocPhiLHP";
            this.txt_HocPhiLHP.Size = new System.Drawing.Size(222, 32);
            this.txt_HocPhiLHP.TabIndex = 1;
            this.txt_HocPhiLHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HocPhiLHP_KeyPress);
            // 
            // txt_LichHocLHP
            // 
            this.txt_LichHocLHP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LichHocLHP.Location = new System.Drawing.Point(209, 42);
            this.txt_LichHocLHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LichHocLHP.Name = "txt_LichHocLHP";
            this.txt_LichHocLHP.Size = new System.Drawing.Size(222, 32);
            this.txt_LichHocLHP.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MediumBlue;
            this.label17.Location = new System.Drawing.Point(34, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Học phí";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MediumBlue;
            this.label18.Location = new System.Drawing.Point(34, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Ngày khai giảng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MediumBlue;
            this.label19.Location = new System.Drawing.Point(34, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ngày kết thúc";
            // 
            // FormNhapLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 589);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNhapLHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo lớp học phần";
            this.Load += new System.EventHandler(this.FormNhapLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_TenKhoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SiSoLop;
        private System.Windows.Forms.TextBox txt_TenLopHP;
        private System.Windows.Forms.ComboBox cbo_GiaoVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_MaLopHPhan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtp_NgayKT;
        private System.Windows.Forms.DateTimePicker dtp_NgayKG;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_HocPhiLHP;
        private System.Windows.Forms.TextBox txt_LichHocLHP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}