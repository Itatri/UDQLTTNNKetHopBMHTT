namespace QuanLyHocVienTTNT
{
    partial class PhanQuyen_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_schema = new System.Windows.Forms.Panel();
            this.cmb_table = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_roles_pk = new System.Windows.Forms.CheckBox();
            this.cb_user_pk = new System.Windows.Forms.CheckBox();
            this.cb_roles_fun = new System.Windows.Forms.CheckBox();
            this.cb_user_fun = new System.Windows.Forms.CheckBox();
            this.cb_roles_pro = new System.Windows.Forms.CheckBox();
            this.cb_user_pro = new System.Windows.Forms.CheckBox();
            this.cmb_package = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_function = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_procedure = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtg_grant_roles = new System.Windows.Forms.DataGridView();
            this.btn_Grant_Revoke_Role = new System.Windows.Forms.Button();
            this.cb_delete_ro = new System.Windows.Forms.CheckBox();
            this.cb_update_ro = new System.Windows.Forms.CheckBox();
            this.cb_insert_ro = new System.Windows.Forms.CheckBox();
            this.cb_select_ro = new System.Windows.Forms.CheckBox();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtg_grant = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dtg_roles = new System.Windows.Forms.DataGridView();
            this.cb_delete_us = new System.Windows.Forms.CheckBox();
            this.lb_table_user = new System.Windows.Forms.Label();
            this.cb_update_us = new System.Windows.Forms.CheckBox();
            this.cb_insert_us = new System.Windows.Forms.CheckBox();
            this.cmb_username = new System.Windows.Forms.ComboBox();
            this.cb_select_us = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_schema.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_grant_roles)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_grant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_roles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(420, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            // 
            // panel_schema
            // 
            this.panel_schema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_schema.Controls.Add(this.groupBox2);
            this.panel_schema.Controls.Add(this.groupBox1);
            this.panel_schema.Location = new System.Drawing.Point(12, 75);
            this.panel_schema.Name = "panel_schema";
            this.panel_schema.Size = new System.Drawing.Size(840, 232);
            this.panel_schema.TabIndex = 1;
            // 
            // cmb_table
            // 
            this.cmb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_table.FormattingEnabled = true;
            this.cmb_table.Location = new System.Drawing.Point(227, 30);
            this.cmb_table.Name = "cmb_table";
            this.cmb_table.Size = new System.Drawing.Size(215, 25);
            this.cmb_table.TabIndex = 15;
            this.cmb_table.SelectedIndexChanged += new System.EventHandler(this.cmb_table_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "DANH SÁCH BẢNG THAO TÁC";
            // 
            // cb_roles_pk
            // 
            this.cb_roles_pk.AutoSize = true;
            this.cb_roles_pk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roles_pk.ForeColor = System.Drawing.Color.Crimson;
            this.cb_roles_pk.Location = new System.Drawing.Point(568, 97);
            this.cb_roles_pk.Name = "cb_roles_pk";
            this.cb_roles_pk.Size = new System.Drawing.Size(109, 21);
            this.cb_roles_pk.TabIndex = 13;
            this.cb_roles_pk.Text = "Gán cho role";
            this.cb_roles_pk.UseVisualStyleBackColor = true;
            this.cb_roles_pk.Click += new System.EventHandler(this.cb_roles_pk_Click);
            // 
            // cb_user_pk
            // 
            this.cb_user_pk.AutoSize = true;
            this.cb_user_pk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user_pk.ForeColor = System.Drawing.Color.Crimson;
            this.cb_user_pk.Location = new System.Drawing.Point(568, 70);
            this.cb_user_pk.Name = "cb_user_pk";
            this.cb_user_pk.Size = new System.Drawing.Size(156, 21);
            this.cb_user_pk.TabIndex = 12;
            this.cb_user_pk.Text = "Gán cho người dùng";
            this.cb_user_pk.UseVisualStyleBackColor = true;
            this.cb_user_pk.Click += new System.EventHandler(this.cb_user_pk_Click);
            // 
            // cb_roles_fun
            // 
            this.cb_roles_fun.AutoSize = true;
            this.cb_roles_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roles_fun.ForeColor = System.Drawing.Color.Crimson;
            this.cb_roles_fun.Location = new System.Drawing.Point(276, 97);
            this.cb_roles_fun.Name = "cb_roles_fun";
            this.cb_roles_fun.Size = new System.Drawing.Size(109, 21);
            this.cb_roles_fun.TabIndex = 11;
            this.cb_roles_fun.Text = "Gán cho role";
            this.cb_roles_fun.UseVisualStyleBackColor = true;
            this.cb_roles_fun.CheckedChanged += new System.EventHandler(this.cb_roles_fun_CheckedChanged);
            // 
            // cb_user_fun
            // 
            this.cb_user_fun.AutoSize = true;
            this.cb_user_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user_fun.ForeColor = System.Drawing.Color.Crimson;
            this.cb_user_fun.Location = new System.Drawing.Point(276, 70);
            this.cb_user_fun.Name = "cb_user_fun";
            this.cb_user_fun.Size = new System.Drawing.Size(156, 21);
            this.cb_user_fun.TabIndex = 10;
            this.cb_user_fun.Text = "Gán cho người dùng";
            this.cb_user_fun.UseVisualStyleBackColor = true;
            this.cb_user_fun.Click += new System.EventHandler(this.cb_user_fun_Click);
            // 
            // cb_roles_pro
            // 
            this.cb_roles_pro.AutoSize = true;
            this.cb_roles_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roles_pro.ForeColor = System.Drawing.Color.Crimson;
            this.cb_roles_pro.Location = new System.Drawing.Point(19, 93);
            this.cb_roles_pro.Name = "cb_roles_pro";
            this.cb_roles_pro.Size = new System.Drawing.Size(109, 21);
            this.cb_roles_pro.TabIndex = 9;
            this.cb_roles_pro.Text = "Gán cho role";
            this.cb_roles_pro.UseVisualStyleBackColor = true;
            this.cb_roles_pro.Click += new System.EventHandler(this.cb_roles_pro_Click);
            // 
            // cb_user_pro
            // 
            this.cb_user_pro.AutoSize = true;
            this.cb_user_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user_pro.ForeColor = System.Drawing.Color.Crimson;
            this.cb_user_pro.Location = new System.Drawing.Point(19, 70);
            this.cb_user_pro.Name = "cb_user_pro";
            this.cb_user_pro.Size = new System.Drawing.Size(156, 21);
            this.cb_user_pro.TabIndex = 8;
            this.cb_user_pro.Text = "Gán cho người dùng";
            this.cb_user_pro.UseVisualStyleBackColor = true;
            this.cb_user_pro.Click += new System.EventHandler(this.cb_user_pro_Click);
            // 
            // cmb_package
            // 
            this.cmb_package.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_package.FormattingEnabled = true;
            this.cmb_package.Location = new System.Drawing.Point(568, 39);
            this.cmb_package.Name = "cmb_package";
            this.cmb_package.Size = new System.Drawing.Size(230, 25);
            this.cmb_package.TabIndex = 7;
            this.cmb_package.SelectedIndexChanged += new System.EventHandler(this.cmb_package_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(565, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Package";
            // 
            // cmb_function
            // 
            this.cmb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_function.FormattingEnabled = true;
            this.cmb_function.Location = new System.Drawing.Point(276, 39);
            this.cmb_function.Name = "cmb_function";
            this.cmb_function.Size = new System.Drawing.Size(215, 25);
            this.cmb_function.TabIndex = 5;
            this.cmb_function.SelectedIndexChanged += new System.EventHandler(this.cmb_function_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(273, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Function";
            // 
            // cmb_procedure
            // 
            this.cmb_procedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_procedure.FormattingEnabled = true;
            this.cmb_procedure.Location = new System.Drawing.Point(19, 39);
            this.cmb_procedure.Name = "cmb_procedure";
            this.cmb_procedure.Size = new System.Drawing.Size(215, 25);
            this.cmb_procedure.TabIndex = 3;
            this.cmb_procedure.SelectedIndexChanged += new System.EventHandler(this.cmb_procedure_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procedure";
            // 
            // cmb_user
            // 
            this.cmb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Location = new System.Drawing.Point(631, 31);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(167, 25);
            this.cmb_user.TabIndex = 1;
            this.cmb_user.SelectedIndexChanged += new System.EventHandler(this.cmb_user_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(459, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÀI KHOẢN CẤP QUYỀN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtg_grant_roles);
            this.panel1.Controls.Add(this.btn_Grant_Revoke_Role);
            this.panel1.Controls.Add(this.cb_delete_ro);
            this.panel1.Controls.Add(this.cb_update_ro);
            this.panel1.Controls.Add(this.cb_insert_ro);
            this.panel1.Controls.Add(this.cb_select_ro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_roles);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(858, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 673);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(158, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Grant";
            // 
            // dtg_grant_roles
            // 
            this.dtg_grant_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_grant_roles.Location = new System.Drawing.Point(3, 352);
            this.dtg_grant_roles.Name = "dtg_grant_roles";
            this.dtg_grant_roles.RowHeadersWidth = 51;
            this.dtg_grant_roles.RowTemplate.Height = 24;
            this.dtg_grant_roles.Size = new System.Drawing.Size(347, 318);
            this.dtg_grant_roles.TabIndex = 21;
            // 
            // btn_Grant_Revoke_Role
            // 
            this.btn_Grant_Revoke_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grant_Revoke_Role.Location = new System.Drawing.Point(94, 214);
            this.btn_Grant_Revoke_Role.Name = "btn_Grant_Revoke_Role";
            this.btn_Grant_Revoke_Role.Size = new System.Drawing.Size(180, 29);
            this.btn_Grant_Revoke_Role.TabIndex = 20;
            this.btn_Grant_Revoke_Role.Text = "CẤP QUYỀN";
            this.btn_Grant_Revoke_Role.UseVisualStyleBackColor = true;
            this.btn_Grant_Revoke_Role.Click += new System.EventHandler(this.btn_Grant_Revoke_Role_Click);
            // 
            // cb_delete_ro
            // 
            this.cb_delete_ro.AutoSize = true;
            this.cb_delete_ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_delete_ro.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_delete_ro.Location = new System.Drawing.Point(282, 81);
            this.cb_delete_ro.Name = "cb_delete_ro";
            this.cb_delete_ro.Size = new System.Drawing.Size(68, 21);
            this.cb_delete_ro.TabIndex = 19;
            this.cb_delete_ro.Text = "Delete";
            this.cb_delete_ro.UseVisualStyleBackColor = true;
            this.cb_delete_ro.Click += new System.EventHandler(this.cb_delete_ro_Click);
            // 
            // cb_update_ro
            // 
            this.cb_update_ro.AutoSize = true;
            this.cb_update_ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_update_ro.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_update_ro.Location = new System.Drawing.Point(185, 82);
            this.cb_update_ro.Name = "cb_update_ro";
            this.cb_update_ro.Size = new System.Drawing.Size(73, 21);
            this.cb_update_ro.TabIndex = 18;
            this.cb_update_ro.Text = "Update";
            this.cb_update_ro.UseVisualStyleBackColor = true;
            this.cb_update_ro.Click += new System.EventHandler(this.cb_update_ro_Click);
            // 
            // cb_insert_ro
            // 
            this.cb_insert_ro.AutoSize = true;
            this.cb_insert_ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_insert_ro.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_insert_ro.Location = new System.Drawing.Point(94, 84);
            this.cb_insert_ro.Name = "cb_insert_ro";
            this.cb_insert_ro.Size = new System.Drawing.Size(62, 21);
            this.cb_insert_ro.TabIndex = 17;
            this.cb_insert_ro.Text = "Insert";
            this.cb_insert_ro.UseVisualStyleBackColor = true;
            this.cb_insert_ro.Click += new System.EventHandler(this.cb_insert_ro_Click);
            // 
            // cb_select_ro
            // 
            this.cb_select_ro.AutoSize = true;
            this.cb_select_ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_select_ro.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_select_ro.Location = new System.Drawing.Point(8, 84);
            this.cb_select_ro.Name = "cb_select_ro";
            this.cb_select_ro.Size = new System.Drawing.Size(66, 21);
            this.cb_select_ro.TabIndex = 16;
            this.cb_select_ro.Text = "Select";
            this.cb_select_ro.UseVisualStyleBackColor = true;
            this.cb_select_ro.Click += new System.EventHandler(this.cb_select_ro_Click);
            // 
            // cmb_roles
            // 
            this.cmb_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.Location = new System.Drawing.Point(132, 11);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(218, 25);
            this.cmb_roles.TabIndex = 5;
            this.cmb_roles.SelectedIndexChanged += new System.EventHandler(this.cmb_roles_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(10, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Danh sách role";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtg_grant);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dtg_roles);
            this.panel2.Controls.Add(this.cb_delete_us);
            this.panel2.Controls.Add(this.lb_table_user);
            this.panel2.Controls.Add(this.cb_update_us);
            this.panel2.Controls.Add(this.cb_insert_us);
            this.panel2.Controls.Add(this.cmb_username);
            this.panel2.Controls.Add(this.cb_select_us);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 436);
            this.panel2.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(601, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Grant";
            // 
            // dtg_grant
            // 
            this.dtg_grant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_grant.Location = new System.Drawing.Point(444, 114);
            this.dtg_grant.Name = "dtg_grant";
            this.dtg_grant.RowHeadersWidth = 51;
            this.dtg_grant.RowTemplate.Height = 24;
            this.dtg_grant.Size = new System.Drawing.Size(384, 320);
            this.dtg_grant.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(241, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Role đang có";
            // 
            // dtg_roles
            // 
            this.dtg_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_roles.Location = new System.Drawing.Point(140, 114);
            this.dtg_roles.Name = "dtg_roles";
            this.dtg_roles.RowHeadersWidth = 51;
            this.dtg_roles.RowTemplate.Height = 24;
            this.dtg_roles.Size = new System.Drawing.Size(298, 322);
            this.dtg_roles.TabIndex = 27;
            // 
            // cb_delete_us
            // 
            this.cb_delete_us.AutoSize = true;
            this.cb_delete_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_delete_us.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_delete_us.Location = new System.Drawing.Point(38, 221);
            this.cb_delete_us.Name = "cb_delete_us";
            this.cb_delete_us.Size = new System.Drawing.Size(68, 21);
            this.cb_delete_us.TabIndex = 26;
            this.cb_delete_us.Text = "Delete";
            this.cb_delete_us.UseVisualStyleBackColor = true;
            this.cb_delete_us.Click += new System.EventHandler(this.cb_delete_us_Click);
            // 
            // lb_table_user
            // 
            this.lb_table_user.AutoSize = true;
            this.lb_table_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table_user.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_table_user.Location = new System.Drawing.Point(14, 54);
            this.lb_table_user.Name = "lb_table_user";
            this.lb_table_user.Size = new System.Drawing.Size(44, 17);
            this.lb_table_user.TabIndex = 23;
            this.lb_table_user.Text = "Table";
            // 
            // cb_update_us
            // 
            this.cb_update_us.AutoSize = true;
            this.cb_update_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_update_us.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_update_us.Location = new System.Drawing.Point(38, 176);
            this.cb_update_us.Name = "cb_update_us";
            this.cb_update_us.Size = new System.Drawing.Size(73, 21);
            this.cb_update_us.TabIndex = 25;
            this.cb_update_us.Text = "Update";
            this.cb_update_us.UseVisualStyleBackColor = true;
            this.cb_update_us.Click += new System.EventHandler(this.cb_update_us_Click);
            // 
            // cb_insert_us
            // 
            this.cb_insert_us.AutoSize = true;
            this.cb_insert_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_insert_us.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_insert_us.Location = new System.Drawing.Point(38, 132);
            this.cb_insert_us.Name = "cb_insert_us";
            this.cb_insert_us.Size = new System.Drawing.Size(62, 21);
            this.cb_insert_us.TabIndex = 24;
            this.cb_insert_us.Text = "Insert";
            this.cb_insert_us.UseVisualStyleBackColor = true;
            this.cb_insert_us.Click += new System.EventHandler(this.cb_insert_us_Click);
            // 
            // cmb_username
            // 
            this.cmb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_username.FormattingEnabled = true;
            this.cmb_username.Location = new System.Drawing.Point(140, 6);
            this.cmb_username.Name = "cmb_username";
            this.cmb_username.Size = new System.Drawing.Size(212, 25);
            this.cmb_username.TabIndex = 17;
            this.cmb_username.SelectedIndexChanged += new System.EventHandler(this.cmb_username_SelectedIndexChanged);
            // 
            // cb_select_us
            // 
            this.cb_select_us.AutoSize = true;
            this.cb_select_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_select_us.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_select_us.Location = new System.Drawing.Point(38, 89);
            this.cb_select_us.Name = "cb_select_us";
            this.cb_select_us.Size = new System.Drawing.Size(66, 21);
            this.cb_select_us.TabIndex = 23;
            this.cb_select_us.Text = "Select";
            this.cb_select_us.UseVisualStyleBackColor = true;
            this.cb_select_us.Click += new System.EventHandler(this.cb_select_us_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(14, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "NGƯỜI DÙNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_procedure);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_user_pro);
            this.groupBox1.Controls.Add(this.cb_roles_pk);
            this.groupBox1.Controls.Add(this.cb_roles_pro);
            this.groupBox1.Controls.Add(this.cb_user_pk);
            this.groupBox1.Controls.Add(this.cmb_function);
            this.groupBox1.Controls.Add(this.cmb_package);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_roles_fun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_user_fun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Quyền Thao Tác";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_table);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_user);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐỐI TƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Table";
            // 
            // PhanQuyen_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_schema);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "PhanQuyen_GUI";
            this.Text = "PhanQuyen_GUI";
            this.panel_schema.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_grant_roles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_grant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_roles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_schema;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_procedure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_package;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_function;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_roles_pk;
        private System.Windows.Forms.CheckBox cb_user_pk;
        private System.Windows.Forms.CheckBox cb_roles_fun;
        private System.Windows.Forms.CheckBox cb_user_fun;
        private System.Windows.Forms.CheckBox cb_roles_pro;
        private System.Windows.Forms.CheckBox cb_user_pro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_delete_ro;
        private System.Windows.Forms.CheckBox cb_update_ro;
        private System.Windows.Forms.CheckBox cb_insert_ro;
        private System.Windows.Forms.CheckBox cb_select_ro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtg_grant_roles;
        private System.Windows.Forms.Button btn_Grant_Revoke_Role;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_delete_us;
        private System.Windows.Forms.Label lb_table_user;
        private System.Windows.Forms.CheckBox cb_update_us;
        private System.Windows.Forms.CheckBox cb_insert_us;
        private System.Windows.Forms.ComboBox cmb_username;
        private System.Windows.Forms.CheckBox cb_select_us;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtg_grant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtg_roles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}