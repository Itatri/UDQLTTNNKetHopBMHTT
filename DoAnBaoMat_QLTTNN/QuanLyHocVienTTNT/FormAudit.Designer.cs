namespace QuanLyHocVienTTNT
{
    partial class FormAudit
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
            this.cbo_User = new System.Windows.Forms.ComboBox();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_User
            // 
            this.cbo_User.FormattingEnabled = true;
            this.cbo_User.Location = new System.Drawing.Point(70, 46);
            this.cbo_User.Name = "cbo_User";
            this.cbo_User.Size = new System.Drawing.Size(201, 21);
            this.cbo_User.TabIndex = 0;
            this.cbo_User.SelectedIndexChanged += new System.EventHandler(this.cbo_User_SelectedIndexChanged);
            // 
            // dgvAudit
            // 
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(12, 92);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.Size = new System.Drawing.Size(776, 174);
            this.dgvAudit.TabIndex = 1;
            this.dgvAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAudit_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(294, 44);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(109, 23);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(77, 272);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(711, 20);
            this.txtSql.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(441, 313);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(347, 94);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User:";
            // 
            // FormAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgvAudit);
            this.Controls.Add(this.cbo_User);
            this.Name = "FormAudit";
            this.Text = "FormAudit";
            this.Load += new System.EventHandler(this.FormAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_User;
        private System.Windows.Forms.DataGridView dgvAudit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}