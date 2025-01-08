namespace QuanLyHocVienTTNT
{
    partial class FormUpdateKM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateKM));
            this.BT_CapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_SLHV = new System.Windows.Forms.TextBox();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_CapNhat
            // 
            this.BT_CapNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("BT_CapNhat.Image")));
            this.BT_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_CapNhat.Location = new System.Drawing.Point(363, 307);
            this.BT_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_CapNhat.Name = "BT_CapNhat";
            this.BT_CapNhat.Size = new System.Drawing.Size(167, 40);
            this.BT_CapNhat.TabIndex = 8;
            this.BT_CapNhat.Text = " Cập nhật";
            this.BT_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_CapNhat.UseVisualStyleBackColor = true;
            this.BT_CapNhat.Click += new System.EventHandler(this.BT_CapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 33);
            this.label1.TabIndex = 38;
            this.label1.Text = "CẬP NHẬT THÔNG TIN KHUYẾN MÃI";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_GiamGia);
            this.groupBox2.Controls.Add(this.txt_SLHV);
            this.groupBox2.Controls.Add(this.txt_MaKM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(130, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(632, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung khuyến mãi";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiamGia.ForeColor = System.Drawing.Color.Black;
            this.txt_GiamGia.Location = new System.Drawing.Point(283, 139);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(284, 32);
            this.txt_GiamGia.TabIndex = 1;
            // 
            // txt_SLHV
            // 
            this.txt_SLHV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLHV.ForeColor = System.Drawing.Color.Black;
            this.txt_SLHV.Location = new System.Drawing.Point(283, 90);
            this.txt_SLHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SLHV.Name = "txt_SLHV";
            this.txt_SLHV.Size = new System.Drawing.Size(284, 32);
            this.txt_SLHV.TabIndex = 1;
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Enabled = false;
            this.txt_MaKM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKM.ForeColor = System.Drawing.Color.Black;
            this.txt_MaKM.Location = new System.Drawing.Point(283, 44);
            this.txt_MaKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.ReadOnly = true;
            this.txt_MaKM.Size = new System.Drawing.Size(284, 32);
            this.txt_MaKM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giảm Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(60, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khuyến mãi";
            // 
            // FormUpdateKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_CapNhat);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin khuyến mãi";
            this.Load += new System.EventHandler(this.FormUpdateKM_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_CapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.TextBox txt_SLHV;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}