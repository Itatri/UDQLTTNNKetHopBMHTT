namespace QuanLyHocVienTTNT
{
    partial class FormMaHoaThongTinGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKeyMaHoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonGenerateKeyRSA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_privatekey = new System.Windows.Forms.TextBox();
            this.labelTepRSA = new System.Windows.Forms.Label();
            this.buttonChonTepRSA = new System.Windows.Forms.Button();
            this.checkBoxUngDungRSA = new System.Windows.Forms.CheckBox();
            this.checkBoxCSDLRSA = new System.Windows.Forms.CheckBox();
            this.buttonGiaiMaRSA = new System.Windows.Forms.Button();
            this.buttonMaHoaRSA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_publickey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDongYCS = new System.Windows.Forms.Button();
            this.labelTepCS = new System.Windows.Forms.Label();
            this.btnImportFileCS = new System.Windows.Forms.Button();
            this.checkBoxUngDungCeaser = new System.Windows.Forms.CheckBox();
            this.checkBoxCSDLCeaser = new System.Windows.Forms.CheckBox();
            this.btnGiaiMaCS = new System.Windows.Forms.Button();
            this.btnMaHoaCS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericKeyEncrypt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_GiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownKeyMaHoaLai = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyMaHoaLai = new System.Windows.Forms.TextBox();
            this.textBoxPrivateKeyMaHoaLai = new System.Windows.Forms.TextBox();
            this.btnGiaiMaMaHoaLai = new System.Windows.Forms.Button();
            this.btnMaHoaMHLai = new System.Windows.Forms.Button();
            this.labelMaHoaLaitxt = new System.Windows.Forms.Label();
            this.btnChonTepMaHoaLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyMaHoaLai)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(1052, 95);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 97;
            this.label15.Text = "Encrypt Key ";
            // 
            // txtKeyMaHoa
            // 
            this.txtKeyMaHoa.Location = new System.Drawing.Point(1055, 115);
            this.txtKeyMaHoa.Multiline = true;
            this.txtKeyMaHoa.Name = "txtKeyMaHoa";
            this.txtKeyMaHoa.Size = new System.Drawing.Size(242, 43);
            this.txtKeyMaHoa.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(847, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "Mã hóa lai ";
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaiLai.ForeColor = System.Drawing.Color.Black;
            this.buttonTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiLai.Location = new System.Drawing.Point(1246, 416);
            this.buttonTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(80, 34);
            this.buttonTaiLai.TabIndex = 84;
            this.buttonTaiLai.Text = "Tải lại ";
            this.buttonTaiLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTaiLai.UseVisualStyleBackColor = true;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click_1);
            // 
            // buttonGenerateKeyRSA
            // 
            this.buttonGenerateKeyRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGenerateKeyRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateKeyRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateKeyRSA.Location = new System.Drawing.Point(758, 260);
            this.buttonGenerateKeyRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateKeyRSA.Name = "buttonGenerateKeyRSA";
            this.buttonGenerateKeyRSA.Size = new System.Drawing.Size(63, 35);
            this.buttonGenerateKeyRSA.TabIndex = 83;
            this.buttonGenerateKeyRSA.Text = "Tạo Khóa";
            this.buttonGenerateKeyRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGenerateKeyRSA.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyRSA.Click += new System.EventHandler(this.buttonGenerateKeyRSA_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(351, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 82;
            this.label10.Text = "Private Key ";
            // 
            // txt_privatekey
            // 
            this.txt_privatekey.Location = new System.Drawing.Point(354, 209);
            this.txt_privatekey.Multiline = true;
            this.txt_privatekey.Name = "txt_privatekey";
            this.txt_privatekey.Size = new System.Drawing.Size(468, 43);
            this.txt_privatekey.TabIndex = 81;
            // 
            // labelTepRSA
            // 
            this.labelTepRSA.AutoSize = true;
            this.labelTepRSA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTepRSA.ForeColor = System.Drawing.Color.Red;
            this.labelTepRSA.Location = new System.Drawing.Point(410, 388);
            this.labelTepRSA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTepRSA.Name = "labelTepRSA";
            this.labelTepRSA.Size = new System.Drawing.Size(72, 13);
            this.labelTepRSA.TabIndex = 80;
            this.labelTepRSA.Text = "document.txt";
            // 
            // buttonChonTepRSA
            // 
            this.buttonChonTepRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChonTepRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonChonTepRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChonTepRSA.Location = new System.Drawing.Point(499, 378);
            this.buttonChonTepRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChonTepRSA.Name = "buttonChonTepRSA";
            this.buttonChonTepRSA.Size = new System.Drawing.Size(113, 34);
            this.buttonChonTepRSA.TabIndex = 79;
            this.buttonChonTepRSA.Text = "Chọn tệp ";
            this.buttonChonTepRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChonTepRSA.UseVisualStyleBackColor = true;
            // 
            // checkBoxUngDungRSA
            // 
            this.checkBoxUngDungRSA.AutoSize = true;
            this.checkBoxUngDungRSA.Location = new System.Drawing.Point(535, 265);
            this.checkBoxUngDungRSA.Name = "checkBoxUngDungRSA";
            this.checkBoxUngDungRSA.Size = new System.Drawing.Size(138, 17);
            this.checkBoxUngDungRSA.TabIndex = 78;
            this.checkBoxUngDungRSA.Text = "Mã hóa mức Ứng dụng ";
            this.checkBoxUngDungRSA.UseVisualStyleBackColor = true;
            this.checkBoxUngDungRSA.CheckedChanged += new System.EventHandler(this.checkBoxUngDungRSA_CheckedChanged_1);
            // 
            // checkBoxCSDLRSA
            // 
            this.checkBoxCSDLRSA.AutoSize = true;
            this.checkBoxCSDLRSA.Location = new System.Drawing.Point(387, 265);
            this.checkBoxCSDLRSA.Name = "checkBoxCSDLRSA";
            this.checkBoxCSDLRSA.Size = new System.Drawing.Size(119, 17);
            this.checkBoxCSDLRSA.TabIndex = 77;
            this.checkBoxCSDLRSA.Text = "Mã hóa mức CSDL ";
            this.checkBoxCSDLRSA.UseVisualStyleBackColor = true;
            this.checkBoxCSDLRSA.CheckedChanged += new System.EventHandler(this.checkBoxCSDLRSA_CheckedChanged_1);
            // 
            // buttonGiaiMaRSA
            // 
            this.buttonGiaiMaRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGiaiMaRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonGiaiMaRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGiaiMaRSA.Location = new System.Drawing.Point(632, 304);
            this.buttonGiaiMaRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGiaiMaRSA.Name = "buttonGiaiMaRSA";
            this.buttonGiaiMaRSA.Size = new System.Drawing.Size(98, 40);
            this.buttonGiaiMaRSA.TabIndex = 76;
            this.buttonGiaiMaRSA.Text = "Giải Mã";
            this.buttonGiaiMaRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGiaiMaRSA.UseVisualStyleBackColor = true;
            this.buttonGiaiMaRSA.Click += new System.EventHandler(this.buttonGiaiMaRSA_Click_1);
            // 
            // buttonMaHoaRSA
            // 
            this.buttonMaHoaRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMaHoaRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonMaHoaRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaHoaRSA.Location = new System.Drawing.Point(428, 304);
            this.buttonMaHoaRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaHoaRSA.Name = "buttonMaHoaRSA";
            this.buttonMaHoaRSA.Size = new System.Drawing.Size(98, 40);
            this.buttonMaHoaRSA.TabIndex = 75;
            this.buttonMaHoaRSA.Text = "Mã Hóa ";
            this.buttonMaHoaRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMaHoaRSA.UseVisualStyleBackColor = true;
            this.buttonMaHoaRSA.Click += new System.EventHandler(this.buttonMaHoaRSA_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(351, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Public Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Key";
            // 
            // txt_publickey
            // 
            this.txt_publickey.Location = new System.Drawing.Point(354, 138);
            this.txt_publickey.Multiline = true;
            this.txt_publickey.Name = "txt_publickey";
            this.txt_publickey.Size = new System.Drawing.Size(468, 43);
            this.txt_publickey.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(351, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Mã hóa RSA";
            // 
            // btnDongYCS
            // 
            this.btnDongYCS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDongYCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongYCS.ForeColor = System.Drawing.Color.White;
            this.btnDongYCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongYCS.Location = new System.Drawing.Point(219, 219);
            this.btnDongYCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongYCS.Name = "btnDongYCS";
            this.btnDongYCS.Size = new System.Drawing.Size(80, 42);
            this.btnDongYCS.TabIndex = 70;
            this.btnDongYCS.Text = "Giải mã ";
            this.btnDongYCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDongYCS.UseVisualStyleBackColor = false;
            this.btnDongYCS.Click += new System.EventHandler(this.btnDongYCS_Click);
            // 
            // labelTepCS
            // 
            this.labelTepCS.AutoSize = true;
            this.labelTepCS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTepCS.ForeColor = System.Drawing.Color.Red;
            this.labelTepCS.Location = new System.Drawing.Point(8, 238);
            this.labelTepCS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTepCS.Name = "labelTepCS";
            this.labelTepCS.Size = new System.Drawing.Size(72, 13);
            this.labelTepCS.TabIndex = 69;
            this.labelTepCS.Text = "document.txt";
            // 
            // btnImportFileCS
            // 
            this.btnImportFileCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImportFileCS.ForeColor = System.Drawing.Color.Black;
            this.btnImportFileCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportFileCS.Location = new System.Drawing.Point(106, 223);
            this.btnImportFileCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportFileCS.Name = "btnImportFileCS";
            this.btnImportFileCS.Size = new System.Drawing.Size(87, 34);
            this.btnImportFileCS.TabIndex = 68;
            this.btnImportFileCS.Text = "Chọn tệp ";
            this.btnImportFileCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFileCS.UseVisualStyleBackColor = true;
            this.btnImportFileCS.Click += new System.EventHandler(this.btnImportFileCS_Click);
            // 
            // checkBoxUngDungCeaser
            // 
            this.checkBoxUngDungCeaser.AutoSize = true;
            this.checkBoxUngDungCeaser.Location = new System.Drawing.Point(175, 139);
            this.checkBoxUngDungCeaser.Name = "checkBoxUngDungCeaser";
            this.checkBoxUngDungCeaser.Size = new System.Drawing.Size(138, 17);
            this.checkBoxUngDungCeaser.TabIndex = 66;
            this.checkBoxUngDungCeaser.Text = "Mã hóa mức Ứng dụng ";
            this.checkBoxUngDungCeaser.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSDLCeaser
            // 
            this.checkBoxCSDLCeaser.AutoSize = true;
            this.checkBoxCSDLCeaser.Location = new System.Drawing.Point(62, 138);
            this.checkBoxCSDLCeaser.Name = "checkBoxCSDLCeaser";
            this.checkBoxCSDLCeaser.Size = new System.Drawing.Size(119, 17);
            this.checkBoxCSDLCeaser.TabIndex = 65;
            this.checkBoxCSDLCeaser.Text = "Mã hóa mức CSDL ";
            this.checkBoxCSDLCeaser.UseVisualStyleBackColor = true;
            // 
            // btnGiaiMaCS
            // 
            this.btnGiaiMaCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaiMaCS.ForeColor = System.Drawing.Color.Black;
            this.btnGiaiMaCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaiMaCS.Location = new System.Drawing.Point(175, 168);
            this.btnGiaiMaCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaiMaCS.Name = "btnGiaiMaCS";
            this.btnGiaiMaCS.Size = new System.Drawing.Size(98, 40);
            this.btnGiaiMaCS.TabIndex = 64;
            this.btnGiaiMaCS.Text = "Giải Mã";
            this.btnGiaiMaCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaiMaCS.UseVisualStyleBackColor = true;
            this.btnGiaiMaCS.Click += new System.EventHandler(this.btnGiaiMaCS_Click);
            // 
            // btnMaHoaCS
            // 
            this.btnMaHoaCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMaHoaCS.ForeColor = System.Drawing.Color.Black;
            this.btnMaHoaCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaHoaCS.Location = new System.Drawing.Point(25, 171);
            this.btnMaHoaCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaHoaCS.Name = "btnMaHoaCS";
            this.btnMaHoaCS.Size = new System.Drawing.Size(98, 40);
            this.btnMaHoaCS.TabIndex = 63;
            this.btnMaHoaCS.Text = "Mã Hóa ";
            this.btnMaHoaCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaHoaCS.UseVisualStyleBackColor = true;
            this.btnMaHoaCS.Click += new System.EventHandler(this.btnMaHoaCS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Mã hóa Ceaser Cipher";
            // 
            // numericKeyEncrypt
            // 
            this.numericKeyEncrypt.Location = new System.Drawing.Point(10, 138);
            this.numericKeyEncrypt.Name = "numericKeyEncrypt";
            this.numericKeyEncrypt.Size = new System.Drawing.Size(37, 20);
            this.numericKeyEncrypt.TabIndex = 61;
            this.numericKeyEncrypt.ValueChanged += new System.EventHandler(this.numericKeyEncrypt_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(846, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Mã Hóa Tên Giáo Viên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(351, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mã hóa mật khẩu giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã hóa tài khoản giáo viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(530, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 27);
            this.label4.TabIndex = 57;
            this.label4.Text = "MÃ HÓA DỮ LIỆU GIÁO VIÊN ";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.TenTKGV,
            this.MatKhau});
            this.dgv_GiaoVien.Location = new System.Drawing.Point(8, 474);
            this.dgv_GiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_GiaoVien.Name = "dgv_GiaoVien";
            this.dgv_GiaoVien.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_GiaoVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_GiaoVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_GiaoVien.RowTemplate.Height = 28;
            this.dgv_GiaoVien.Size = new System.Drawing.Size(1365, 148);
            this.dgv_GiaoVien.TabIndex = 98;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            // 
            // TenTKGV
            // 
            this.TenTKGV.DataPropertyName = "TenTKGV";
            this.TenTKGV.HeaderText = "Tên tài khoản";
            this.TenTKGV.MinimumWidth = 6;
            this.TenTKGV.Name = "TenTKGV";
            this.TenTKGV.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(862, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Key";
            // 
            // numericUpDownKeyMaHoaLai
            // 
            this.numericUpDownKeyMaHoaLai.Location = new System.Drawing.Point(865, 140);
            this.numericUpDownKeyMaHoaLai.Name = "numericUpDownKeyMaHoaLai";
            this.numericUpDownKeyMaHoaLai.Size = new System.Drawing.Size(146, 20);
            this.numericUpDownKeyMaHoaLai.TabIndex = 86;
            this.numericUpDownKeyMaHoaLai.ValueChanged += new System.EventHandler(this.numericUpDownKeyMaHoaLai_ValueChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(862, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 89;
            this.label13.Text = "Public Key";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(862, 236);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 91;
            this.label12.Text = "Private Key ";
            // 
            // textBoxPublicKeyMaHoaLai
            // 
            this.textBoxPublicKeyMaHoaLai.Location = new System.Drawing.Point(865, 191);
            this.textBoxPublicKeyMaHoaLai.Multiline = true;
            this.textBoxPublicKeyMaHoaLai.Name = "textBoxPublicKeyMaHoaLai";
            this.textBoxPublicKeyMaHoaLai.Size = new System.Drawing.Size(462, 43);
            this.textBoxPublicKeyMaHoaLai.TabIndex = 88;
            // 
            // textBoxPrivateKeyMaHoaLai
            // 
            this.textBoxPrivateKeyMaHoaLai.Location = new System.Drawing.Point(865, 255);
            this.textBoxPrivateKeyMaHoaLai.Multiline = true;
            this.textBoxPrivateKeyMaHoaLai.Name = "textBoxPrivateKeyMaHoaLai";
            this.textBoxPrivateKeyMaHoaLai.Size = new System.Drawing.Size(462, 43);
            this.textBoxPrivateKeyMaHoaLai.TabIndex = 90;
            // 
            // btnGiaiMaMaHoaLai
            // 
            this.btnGiaiMaMaHoaLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaiMaMaHoaLai.ForeColor = System.Drawing.Color.Black;
            this.btnGiaiMaMaHoaLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaiMaMaHoaLai.Location = new System.Drawing.Point(1160, 306);
            this.btnGiaiMaMaHoaLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaiMaMaHoaLai.Name = "btnGiaiMaMaHoaLai";
            this.btnGiaiMaMaHoaLai.Size = new System.Drawing.Size(98, 40);
            this.btnGiaiMaMaHoaLai.TabIndex = 93;
            this.btnGiaiMaMaHoaLai.Text = "Giải Mã";
            this.btnGiaiMaMaHoaLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaiMaMaHoaLai.UseVisualStyleBackColor = true;
            this.btnGiaiMaMaHoaLai.Click += new System.EventHandler(this.btnGiaiMaMaHoaLai_Click_1);
            // 
            // btnMaHoaMHLai
            // 
            this.btnMaHoaMHLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMaHoaMHLai.ForeColor = System.Drawing.Color.Black;
            this.btnMaHoaMHLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaHoaMHLai.Location = new System.Drawing.Point(925, 306);
            this.btnMaHoaMHLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaHoaMHLai.Name = "btnMaHoaMHLai";
            this.btnMaHoaMHLai.Size = new System.Drawing.Size(98, 40);
            this.btnMaHoaMHLai.TabIndex = 92;
            this.btnMaHoaMHLai.Text = "Mã Hóa ";
            this.btnMaHoaMHLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaHoaMHLai.UseVisualStyleBackColor = true;
            this.btnMaHoaMHLai.Click += new System.EventHandler(this.btnMaHoaMHLai_Click_1);
            // 
            // labelMaHoaLaitxt
            // 
            this.labelMaHoaLaitxt.AutoSize = true;
            this.labelMaHoaLaitxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaHoaLaitxt.ForeColor = System.Drawing.Color.Red;
            this.labelMaHoaLaitxt.Location = new System.Drawing.Point(983, 388);
            this.labelMaHoaLaitxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaHoaLaitxt.Name = "labelMaHoaLaitxt";
            this.labelMaHoaLaitxt.Size = new System.Drawing.Size(72, 13);
            this.labelMaHoaLaitxt.TabIndex = 95;
            this.labelMaHoaLaitxt.Text = "document.txt";
            // 
            // btnChonTepMaHoaLai
            // 
            this.btnChonTepMaHoaLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonTepMaHoaLai.ForeColor = System.Drawing.Color.Black;
            this.btnChonTepMaHoaLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonTepMaHoaLai.Location = new System.Drawing.Point(1084, 378);
            this.btnChonTepMaHoaLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonTepMaHoaLai.Name = "btnChonTepMaHoaLai";
            this.btnChonTepMaHoaLai.Size = new System.Drawing.Size(113, 34);
            this.btnChonTepMaHoaLai.TabIndex = 94;
            this.btnChonTepMaHoaLai.Text = "Chọn tệp ";
            this.btnChonTepMaHoaLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonTepMaHoaLai.UseVisualStyleBackColor = true;
            // 
            // FormMaHoaThongTinGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 631);
            this.Controls.Add(this.dgv_GiaoVien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtKeyMaHoa);
            this.Controls.Add(this.labelMaHoaLaitxt);
            this.Controls.Add(this.btnChonTepMaHoaLai);
            this.Controls.Add(this.btnGiaiMaMaHoaLai);
            this.Controls.Add(this.btnMaHoaMHLai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPrivateKeyMaHoaLai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxPublicKeyMaHoaLai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownKeyMaHoaLai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonGenerateKeyRSA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_privatekey);
            this.Controls.Add(this.labelTepRSA);
            this.Controls.Add(this.buttonChonTepRSA);
            this.Controls.Add(this.checkBoxUngDungRSA);
            this.Controls.Add(this.checkBoxCSDLRSA);
            this.Controls.Add(this.buttonGiaiMaRSA);
            this.Controls.Add(this.buttonMaHoaRSA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_publickey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDongYCS);
            this.Controls.Add(this.labelTepCS);
            this.Controls.Add(this.btnImportFileCS);
            this.Controls.Add(this.checkBoxUngDungCeaser);
            this.Controls.Add(this.checkBoxCSDLCeaser);
            this.Controls.Add(this.btnGiaiMaCS);
            this.Controls.Add(this.btnMaHoaCS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericKeyEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMaHoaThongTinGV";
            this.Text = "FormMaHoaThongTinGV";
            this.Load += new System.EventHandler(this.FormMaHoaThongTinGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyMaHoaLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKeyMaHoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonGenerateKeyRSA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_privatekey;
        private System.Windows.Forms.Label labelTepRSA;
        private System.Windows.Forms.Button buttonChonTepRSA;
        private System.Windows.Forms.CheckBox checkBoxUngDungRSA;
        private System.Windows.Forms.CheckBox checkBoxCSDLRSA;
        private System.Windows.Forms.Button buttonGiaiMaRSA;
        private System.Windows.Forms.Button buttonMaHoaRSA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_publickey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDongYCS;
        private System.Windows.Forms.Label labelTepCS;
        private System.Windows.Forms.Button btnImportFileCS;
        private System.Windows.Forms.CheckBox checkBoxUngDungCeaser;
        private System.Windows.Forms.CheckBox checkBoxCSDLCeaser;
        private System.Windows.Forms.Button btnGiaiMaCS;
        private System.Windows.Forms.Button btnMaHoaCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericKeyEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyMaHoaLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPublicKeyMaHoaLai;
        private System.Windows.Forms.TextBox textBoxPrivateKeyMaHoaLai;
        private System.Windows.Forms.Button btnGiaiMaMaHoaLai;
        private System.Windows.Forms.Button btnMaHoaMHLai;
        private System.Windows.Forms.Label labelMaHoaLaitxt;
        private System.Windows.Forms.Button btnChonTepMaHoaLai;
    }
}