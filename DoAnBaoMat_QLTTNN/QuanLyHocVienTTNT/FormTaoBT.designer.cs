namespace QuanLyHocVienTTNT
{
    partial class FormTaoBT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoBT));
            this.txtMaBT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemTD = new System.Windows.Forms.TextBox();
            this.btnTaoBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaBT
            // 
            this.txtMaBT.Enabled = false;
            this.txtMaBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBT.ForeColor = System.Drawing.Color.Black;
            this.txtMaBT.Location = new System.Drawing.Point(152, 124);
            this.txtMaBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBT.Name = "txtMaBT";
            this.txtMaBT.ReadOnly = true;
            this.txtMaBT.Size = new System.Drawing.Size(219, 32);
            this.txtMaBT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã bài tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Điểm tối đa";
            // 
            // txtDiemTD
            // 
            this.txtDiemTD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTD.Location = new System.Drawing.Point(152, 180);
            this.txtDiemTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiemTD.Name = "txtDiemTD";
            this.txtDiemTD.Size = new System.Drawing.Size(219, 32);
            this.txtDiemTD.TabIndex = 10;
            this.txtDiemTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemTD_KeyPress);
            // 
            // btnTaoBT
            // 
            this.btnTaoBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBT.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoBT.Image")));
            this.btnTaoBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoBT.Location = new System.Drawing.Point(164, 238);
            this.btnTaoBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoBT.Name = "btnTaoBT";
            this.btnTaoBT.Size = new System.Drawing.Size(165, 40);
            this.btnTaoBT.TabIndex = 14;
            this.btnTaoBT.Text = " Xác nhận";
            this.btnTaoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoBT.UseVisualStyleBackColor = true;
            this.btnTaoBT.Click += new System.EventHandler(this.btnTaoBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "TẠO BÀI TẬP MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã lớp";
            // 
            // cboMaLop
            // 
            this.cboMaLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(152, 79);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(219, 32);
            this.cboMaLop.TabIndex = 16;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormTaoBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoBT);
            this.Controls.Add(this.txtMaBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemTD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaoBT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo bài tập";
            this.Load += new System.EventHandler(this.FormTaoBT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemTD;
        private System.Windows.Forms.Button btnTaoBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}