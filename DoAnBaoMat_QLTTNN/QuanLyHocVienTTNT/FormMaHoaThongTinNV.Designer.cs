namespace QuanLyHocVienTTNT
{
    partial class FormMaHoaThongTinNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonGenerateKeyRSA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_privatekey = new System.Windows.Forms.TextBox();
            this.labelTepRSA = new System.Windows.Forms.Label();
            this.buttonChonTepRSA = new System.Windows.Forms.Button();
            this.buttonGiaiMaRSA = new System.Windows.Forms.Button();
            this.buttonMaHoaRSA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_publickey = new System.Windows.Forms.TextBox();
            this.btnGiaiMaCS = new System.Windows.Forms.Button();
            this.btnMaHoaCS = new System.Windows.Forms.Button();
            this.numericKeyEncrypt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKeyMaHoa = new System.Windows.Forms.TextBox();
            this.labelMaHoaLaitxt = new System.Windows.Forms.Label();
            this.btnChonTepMaHoaLai = new System.Windows.Forms.Button();
            this.btnGiaiMaMaHoaLai = new System.Windows.Forms.Button();
            this.btnMaHoaMHLai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyMaHoaLai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyMaHoaLai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownKeyMaHoaLai = new System.Windows.Forms.NumericUpDown();
            this.TENTKNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdb_doixungCSDL = new System.Windows.Forms.RadioButton();
            this.rdb_doixungUD = new System.Windows.Forms.RadioButton();
            this.rdoRSAUD = new System.Windows.Forms.RadioButton();
            this.rdoRSACSDL = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuuKhoaLAI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyEncrypt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyMaHoaLai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENTKNV,
            this.MatKhau,
            this.Email,
            this.SDT});
            this.dgv.Location = new System.Drawing.Point(11, 475);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1373, 148);
            this.dgv.TabIndex = 139;
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTaiLai.ForeColor = System.Drawing.Color.Black;
            this.buttonTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiLai.Location = new System.Drawing.Point(1249, 417);
            this.buttonTaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(80, 34);
            this.buttonTaiLai.TabIndex = 125;
            this.buttonTaiLai.Text = "Tải lại ";
            this.buttonTaiLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTaiLai.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateKeyRSA
            // 
            this.buttonGenerateKeyRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGenerateKeyRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateKeyRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateKeyRSA.Location = new System.Drawing.Point(348, 192);
            this.buttonGenerateKeyRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateKeyRSA.Name = "buttonGenerateKeyRSA";
            this.buttonGenerateKeyRSA.Size = new System.Drawing.Size(63, 35);
            this.buttonGenerateKeyRSA.TabIndex = 124;
            this.buttonGenerateKeyRSA.Text = "Tạo Khóa";
            this.buttonGenerateKeyRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGenerateKeyRSA.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyRSA.Click += new System.EventHandler(this.buttonGenerateKeyRSA_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 123;
            this.label10.Text = "Khóa bí mật";
            // 
            // txt_privatekey
            // 
            this.txt_privatekey.Location = new System.Drawing.Point(8, 131);
            this.txt_privatekey.Multiline = true;
            this.txt_privatekey.Name = "txt_privatekey";
            this.txt_privatekey.Size = new System.Drawing.Size(518, 43);
            this.txt_privatekey.TabIndex = 122;
            // 
            // labelTepRSA
            // 
            this.labelTepRSA.AutoSize = true;
            this.labelTepRSA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTepRSA.ForeColor = System.Drawing.Color.Red;
            this.labelTepRSA.Location = new System.Drawing.Point(294, 244);
            this.labelTepRSA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTepRSA.Name = "labelTepRSA";
            this.labelTepRSA.Size = new System.Drawing.Size(72, 13);
            this.labelTepRSA.TabIndex = 121;
            this.labelTepRSA.Text = "document.txt";
            // 
            // buttonChonTepRSA
            // 
            this.buttonChonTepRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChonTepRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonChonTepRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChonTepRSA.Location = new System.Drawing.Point(144, 233);
            this.buttonChonTepRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChonTepRSA.Name = "buttonChonTepRSA";
            this.buttonChonTepRSA.Size = new System.Drawing.Size(113, 34);
            this.buttonChonTepRSA.TabIndex = 120;
            this.buttonChonTepRSA.Text = "Chọn tệp ";
            this.buttonChonTepRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChonTepRSA.UseVisualStyleBackColor = true;
            this.buttonChonTepRSA.Click += new System.EventHandler(this.buttonChonTepRSA_Click);
            // 
            // buttonGiaiMaRSA
            // 
            this.buttonGiaiMaRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonGiaiMaRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonGiaiMaRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGiaiMaRSA.Location = new System.Drawing.Point(246, 189);
            this.buttonGiaiMaRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGiaiMaRSA.Name = "buttonGiaiMaRSA";
            this.buttonGiaiMaRSA.Size = new System.Drawing.Size(98, 40);
            this.buttonGiaiMaRSA.TabIndex = 117;
            this.buttonGiaiMaRSA.Text = "Giải Mã";
            this.buttonGiaiMaRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGiaiMaRSA.UseVisualStyleBackColor = true;
            this.buttonGiaiMaRSA.Click += new System.EventHandler(this.buttonGiaiMaRSA_Click);
            // 
            // buttonMaHoaRSA
            // 
            this.buttonMaHoaRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonMaHoaRSA.ForeColor = System.Drawing.Color.Black;
            this.buttonMaHoaRSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaHoaRSA.Location = new System.Drawing.Point(144, 189);
            this.buttonMaHoaRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaHoaRSA.Name = "buttonMaHoaRSA";
            this.buttonMaHoaRSA.Size = new System.Drawing.Size(98, 40);
            this.buttonMaHoaRSA.TabIndex = 116;
            this.buttonMaHoaRSA.Text = "Mã Hóa ";
            this.buttonMaHoaRSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMaHoaRSA.UseVisualStyleBackColor = true;
            this.buttonMaHoaRSA.Click += new System.EventHandler(this.buttonMaHoaRSA_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "Khóa công cộng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 114;
            this.label7.Text = "Key";
            // 
            // txt_publickey
            // 
            this.txt_publickey.Location = new System.Drawing.Point(8, 54);
            this.txt_publickey.Multiline = true;
            this.txt_publickey.Name = "txt_publickey";
            this.txt_publickey.Size = new System.Drawing.Size(518, 43);
            this.txt_publickey.TabIndex = 113;
            // 
            // btnGiaiMaCS
            // 
            this.btnGiaiMaCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaiMaCS.ForeColor = System.Drawing.Color.Black;
            this.btnGiaiMaCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaiMaCS.Location = new System.Drawing.Point(141, 112);
            this.btnGiaiMaCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaiMaCS.Name = "btnGiaiMaCS";
            this.btnGiaiMaCS.Size = new System.Drawing.Size(98, 40);
            this.btnGiaiMaCS.TabIndex = 106;
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
            this.btnMaHoaCS.Location = new System.Drawing.Point(26, 112);
            this.btnMaHoaCS.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaHoaCS.Name = "btnMaHoaCS";
            this.btnMaHoaCS.Size = new System.Drawing.Size(98, 40);
            this.btnMaHoaCS.TabIndex = 105;
            this.btnMaHoaCS.Text = "Mã Hóa ";
            this.btnMaHoaCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaHoaCS.UseVisualStyleBackColor = true;
            this.btnMaHoaCS.Click += new System.EventHandler(this.btnMaHoaCS_Click);
            // 
            // numericKeyEncrypt
            // 
            this.numericKeyEncrypt.Location = new System.Drawing.Point(43, 28);
            this.numericKeyEncrypt.Name = "numericKeyEncrypt";
            this.numericKeyEncrypt.Size = new System.Drawing.Size(196, 20);
            this.numericKeyEncrypt.TabIndex = 103;
            this.numericKeyEncrypt.ValueChanged += new System.EventHandler(this.numericKeyEncrypt_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(537, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 27);
            this.label4.TabIndex = 99;
            this.label4.Text = "MÃ HÓA DỮ LIỆU NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_doixungUD);
            this.groupBox1.Controls.Add(this.rdb_doixungCSDL);
            this.groupBox1.Controls.Add(this.numericKeyEncrypt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMaHoaCS);
            this.groupBox1.Controls.Add(this.btnGiaiMaCS);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 376);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐỐI XỨNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rdoRSAUD);
            this.groupBox2.Controls.Add(this.rdoRSACSDL);
            this.groupBox2.Controls.Add(this.txt_privatekey);
            this.groupBox2.Controls.Add(this.txt_publickey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonMaHoaRSA);
            this.groupBox2.Controls.Add(this.buttonGiaiMaRSA);
            this.groupBox2.Controls.Add(this.buttonChonTepRSA);
            this.groupBox2.Controls.Add(this.labelTepRSA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.buttonGenerateKeyRSA);
            this.groupBox2.Location = new System.Drawing.Point(313, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 376);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BẤT ĐỐI XỨNG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnLuuKhoaLAI);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtKeyMaHoa);
            this.groupBox3.Controls.Add(this.numericUpDownKeyMaHoaLai);
            this.groupBox3.Controls.Add(this.labelMaHoaLaitxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnChonTepMaHoaLai);
            this.groupBox3.Controls.Add(this.textBoxPublicKeyMaHoaLai);
            this.groupBox3.Controls.Add(this.btnGiaiMaMaHoaLai);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnMaHoaMHLai);
            this.groupBox3.Controls.Add(this.textBoxPrivateKeyMaHoaLai);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(852, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 376);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LAI";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(34, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 16);
            this.label15.TabIndex = 154;
            this.label15.Text = "Mã hóa khóa (KEY)";
            // 
            // txtKeyMaHoa
            // 
            this.txtKeyMaHoa.Location = new System.Drawing.Point(37, 73);
            this.txtKeyMaHoa.Multiline = true;
            this.txtKeyMaHoa.Name = "txtKeyMaHoa";
            this.txtKeyMaHoa.Size = new System.Drawing.Size(460, 43);
            this.txtKeyMaHoa.TabIndex = 153;
            // 
            // labelMaHoaLaitxt
            // 
            this.labelMaHoaLaitxt.AutoSize = true;
            this.labelMaHoaLaitxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaHoaLaitxt.ForeColor = System.Drawing.Color.Red;
            this.labelMaHoaLaitxt.Location = new System.Drawing.Point(200, 322);
            this.labelMaHoaLaitxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaHoaLaitxt.Name = "labelMaHoaLaitxt";
            this.labelMaHoaLaitxt.Size = new System.Drawing.Size(72, 13);
            this.labelMaHoaLaitxt.TabIndex = 152;
            this.labelMaHoaLaitxt.Text = "document.txt";
            // 
            // btnChonTepMaHoaLai
            // 
            this.btnChonTepMaHoaLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonTepMaHoaLai.ForeColor = System.Drawing.Color.Black;
            this.btnChonTepMaHoaLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonTepMaHoaLai.Location = new System.Drawing.Point(37, 311);
            this.btnChonTepMaHoaLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonTepMaHoaLai.Name = "btnChonTepMaHoaLai";
            this.btnChonTepMaHoaLai.Size = new System.Drawing.Size(113, 34);
            this.btnChonTepMaHoaLai.TabIndex = 151;
            this.btnChonTepMaHoaLai.Text = "Chọn tệp ";
            this.btnChonTepMaHoaLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonTepMaHoaLai.UseVisualStyleBackColor = true;
            this.btnChonTepMaHoaLai.Click += new System.EventHandler(this.btnChonTepMaHoaLai_Click);
            // 
            // btnGiaiMaMaHoaLai
            // 
            this.btnGiaiMaMaHoaLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaiMaMaHoaLai.ForeColor = System.Drawing.Color.Black;
            this.btnGiaiMaMaHoaLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaiMaMaHoaLai.Location = new System.Drawing.Point(137, 265);
            this.btnGiaiMaMaHoaLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaiMaMaHoaLai.Name = "btnGiaiMaMaHoaLai";
            this.btnGiaiMaMaHoaLai.Size = new System.Drawing.Size(98, 40);
            this.btnGiaiMaMaHoaLai.TabIndex = 150;
            this.btnGiaiMaMaHoaLai.Text = "Giải Mã";
            this.btnGiaiMaMaHoaLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaiMaMaHoaLai.UseVisualStyleBackColor = true;
            this.btnGiaiMaMaHoaLai.Click += new System.EventHandler(this.btnGiaiMaMaHoaLai_Click);
            // 
            // btnMaHoaMHLai
            // 
            this.btnMaHoaMHLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMaHoaMHLai.ForeColor = System.Drawing.Color.Black;
            this.btnMaHoaMHLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaHoaMHLai.Location = new System.Drawing.Point(35, 265);
            this.btnMaHoaMHLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaHoaMHLai.Name = "btnMaHoaMHLai";
            this.btnMaHoaMHLai.Size = new System.Drawing.Size(98, 40);
            this.btnMaHoaMHLai.TabIndex = 149;
            this.btnMaHoaMHLai.Text = "Mã Hóa ";
            this.btnMaHoaMHLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaHoaMHLai.UseVisualStyleBackColor = true;
            this.btnMaHoaMHLai.Click += new System.EventHandler(this.btnMaHoaMHLai_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(32, 195);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 148;
            this.label12.Text = "Khóa bí mật";
            // 
            // textBoxPrivateKeyMaHoaLai
            // 
            this.textBoxPrivateKeyMaHoaLai.Location = new System.Drawing.Point(35, 214);
            this.textBoxPrivateKeyMaHoaLai.Multiline = true;
            this.textBoxPrivateKeyMaHoaLai.Name = "textBoxPrivateKeyMaHoaLai";
            this.textBoxPrivateKeyMaHoaLai.Size = new System.Drawing.Size(462, 43);
            this.textBoxPrivateKeyMaHoaLai.TabIndex = 147;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(32, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Khóa công cộng";
            // 
            // textBoxPublicKeyMaHoaLai
            // 
            this.textBoxPublicKeyMaHoaLai.Location = new System.Drawing.Point(35, 150);
            this.textBoxPublicKeyMaHoaLai.Multiline = true;
            this.textBoxPublicKeyMaHoaLai.Name = "textBoxPublicKeyMaHoaLai";
            this.textBoxPublicKeyMaHoaLai.Size = new System.Drawing.Size(462, 43);
            this.textBoxPublicKeyMaHoaLai.TabIndex = 145;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(5, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 144;
            this.label11.Text = "Key";
            // 
            // numericUpDownKeyMaHoaLai
            // 
            this.numericUpDownKeyMaHoaLai.Location = new System.Drawing.Point(37, 28);
            this.numericUpDownKeyMaHoaLai.Name = "numericUpDownKeyMaHoaLai";
            this.numericUpDownKeyMaHoaLai.Size = new System.Drawing.Size(146, 20);
            this.numericUpDownKeyMaHoaLai.TabIndex = 143;
            // 
            // TENTKNV
            // 
            this.TENTKNV.DataPropertyName = "TENTKNV";
            this.TENTKNV.HeaderText = "Tài khoản nhân viên";
            this.TENTKNV.MinimumWidth = 6;
            this.TENTKNV.Name = "TENTKNV";
            this.TENTKNV.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // rdb_doixungCSDL
            // 
            this.rdb_doixungCSDL.AutoSize = true;
            this.rdb_doixungCSDL.Location = new System.Drawing.Point(27, 90);
            this.rdb_doixungCSDL.Name = "rdb_doixungCSDL";
            this.rdb_doixungCSDL.Size = new System.Drawing.Size(53, 17);
            this.rdb_doixungCSDL.TabIndex = 117;
            this.rdb_doixungCSDL.TabStop = true;
            this.rdb_doixungCSDL.Text = "CSDL";
            this.rdb_doixungCSDL.UseVisualStyleBackColor = true;
            // 
            // rdb_doixungUD
            // 
            this.rdb_doixungUD.AutoSize = true;
            this.rdb_doixungUD.Location = new System.Drawing.Point(141, 90);
            this.rdb_doixungUD.Name = "rdb_doixungUD";
            this.rdb_doixungUD.Size = new System.Drawing.Size(72, 17);
            this.rdb_doixungUD.TabIndex = 118;
            this.rdb_doixungUD.TabStop = true;
            this.rdb_doixungUD.Text = "Ứng dụng";
            this.rdb_doixungUD.UseVisualStyleBackColor = true;
            // 
            // rdoRSAUD
            // 
            this.rdoRSAUD.AutoSize = true;
            this.rdoRSAUD.Location = new System.Drawing.Point(67, 192);
            this.rdoRSAUD.Name = "rdoRSAUD";
            this.rdoRSAUD.Size = new System.Drawing.Size(72, 17);
            this.rdoRSAUD.TabIndex = 126;
            this.rdoRSAUD.TabStop = true;
            this.rdoRSAUD.Text = "Ứng dụng";
            this.rdoRSAUD.UseVisualStyleBackColor = true;
            // 
            // rdoRSACSDL
            // 
            this.rdoRSACSDL.AutoSize = true;
            this.rdoRSACSDL.Location = new System.Drawing.Point(8, 192);
            this.rdoRSACSDL.Name = "rdoRSACSDL";
            this.rdoRSACSDL.Size = new System.Drawing.Size(53, 17);
            this.rdoRSACSDL.TabIndex = 125;
            this.rdoRSACSDL.TabStop = true;
            this.rdoRSACSDL.Text = "CSDL";
            this.rdoRSACSDL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 35);
            this.button1.TabIndex = 127;
            this.button1.Text = "Lưu Khóa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuuKhoaLAI
            // 
            this.btnLuuKhoaLAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuKhoaLAI.ForeColor = System.Drawing.Color.Black;
            this.btnLuuKhoaLAI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuKhoaLAI.Location = new System.Drawing.Point(239, 268);
            this.btnLuuKhoaLAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuKhoaLAI.Name = "btnLuuKhoaLAI";
            this.btnLuuKhoaLAI.Size = new System.Drawing.Size(63, 35);
            this.btnLuuKhoaLAI.TabIndex = 155;
            this.btnLuuKhoaLAI.Text = "Lưu Khóa";
            this.btnLuuKhoaLAI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuKhoaLAI.UseVisualStyleBackColor = true;
            this.btnLuuKhoaLAI.Click += new System.EventHandler(this.btnLuuKhoaLAI_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(416, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 28);
            this.button2.TabIndex = 156;
            this.button2.Text = "Làm mới";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMaHoaThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.label4);
            this.Name = "FormMaHoaThongTinNV";
            this.Text = "FormMaHoaThongTinNV";
            this.Load += new System.EventHandler(this.FormMaHoaThongTinNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyEncrypt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyMaHoaLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonGenerateKeyRSA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_privatekey;
        private System.Windows.Forms.Label labelTepRSA;
        private System.Windows.Forms.Button buttonChonTepRSA;
        private System.Windows.Forms.Button buttonGiaiMaRSA;
        private System.Windows.Forms.Button buttonMaHoaRSA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_publickey;
        private System.Windows.Forms.Button btnGiaiMaCS;
        private System.Windows.Forms.Button btnMaHoaCS;
        private System.Windows.Forms.NumericUpDown numericKeyEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTKNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKeyMaHoa;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyMaHoaLai;
        private System.Windows.Forms.Label labelMaHoaLaitxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChonTepMaHoaLai;
        private System.Windows.Forms.TextBox textBoxPublicKeyMaHoaLai;
        private System.Windows.Forms.Button btnGiaiMaMaHoaLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMaHoaMHLai;
        private System.Windows.Forms.TextBox textBoxPrivateKeyMaHoaLai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdb_doixungUD;
        private System.Windows.Forms.RadioButton rdb_doixungCSDL;
        private System.Windows.Forms.RadioButton rdoRSAUD;
        private System.Windows.Forms.RadioButton rdoRSACSDL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLuuKhoaLAI;
        private System.Windows.Forms.Button button2;
    }
}