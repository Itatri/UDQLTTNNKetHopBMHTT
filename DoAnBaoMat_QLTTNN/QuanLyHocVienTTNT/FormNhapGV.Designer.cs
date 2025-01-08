namespace QuanLyHocVienTTNT
{
    partial class FormNhapGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapGV));
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(295, 296);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(219, 30);
            this.txt_MatKhau.TabIndex = 42;
            //this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(131, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mật Khẩu";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(295, 242);
            this.txt_TenTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(219, 30);
            this.txt_TenTK.TabIndex = 43;
            this.txt_TenTK.TextChanged += new System.EventHandler(this.txt_TenTK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(131, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tên tài khoản";
            // 
            // txt_TenGV
            // 
            this.txt_TenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenGV.Location = new System.Drawing.Point(295, 183);
            this.txt_TenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenGV.Name = "txt_TenGV";
            this.txt_TenGV.Size = new System.Drawing.Size(219, 30);
            this.txt_TenGV.TabIndex = 44;
            this.txt_TenGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenGV_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(129, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tên giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(131, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mã giảng viên";
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 150;
            // 
            // TenGV
            // 
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 250;
            // 
            // btn_Luu
            // 
            this.btn_Luu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Luu.FlatAppearance.BorderSize = 3;
            this.btn_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(295, 351);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(163, 50);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = " Xác nhận";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // MaGV
            // 
            this.MaGV.HeaderText = "Mã Giáo Viên";
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 150;
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Enabled = false;
            this.txt_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(295, 119);
            this.txt_MaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.ReadOnly = true;
            this.txt_MaGV.Size = new System.Drawing.Size(219, 30);
            this.txt_MaGV.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "THÊM GIÁO VIÊN MỚI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNhapGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(657, 423);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNhapGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm giáo viên";
            this.Load += new System.EventHandler(this.FormNhapGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}