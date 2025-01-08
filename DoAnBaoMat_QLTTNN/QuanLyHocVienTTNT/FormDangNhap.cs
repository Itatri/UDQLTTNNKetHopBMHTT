using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using QuanLyHocVienTTNT;
using CrystalDecisions.CrystalReports.Engine;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyHocVienTTNT
{
    public partial class FormDangNhap : Form
    {
        Database db = new Database();
        public FormDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btn_DangNhap;
        }
        bool Check_Textbox(string user, string pass)
        {
            if (user == "")
            {
                MessageBox.Show("Chưa điền tài khoản");
                txt_username.Focus();
                return false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Chưa điền mật khẩu");
                txt_password.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txt_username.Text.Trim();
            string matkhau = txt_password.Text.Trim();

            // Kiểm tra thông tin nhập vào
            if (Check_Textbox(tentk, matkhau))
            {
                // Thiết lập thông tin kết nối
                Database.Set_Database(tentk, matkhau);

                // Kết nối đến cơ sở dữ liệu
                if (Database.Connect())
                {
                    try
                    {

                        // Lấy kết nối từ lớp Database
                        using (OracleConnection connection = Database.Get_Connect())
                        {
                            // Kiểm tra role của người dùng
                            string role = GetUserRole(connection, tentk);

                            switch (role)
                            {
                                case "DBA":
                                    FormChinh.loaitk = "Nhân viên";
                                    FormChinh.tentk = tentk; // Sử dụng tên tài khoản đã nhập
                                    MessageBox.Show("Đăng nhập thành công! Xin chào Admin 💟", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                case "ROLENV":
                                    FormChinh.loaitk = "Nhân viên";
                                    FormChinh.tentk = tentk; // Sử dụng tên tài khoản đã nhập
                                    MessageBox.Show("Đăng nhập thành công! Xin chào bạn 💟", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                case "ROLEGV":
                                    FormChinh.loaitk = "Giáo viên";
                                    FormChinh.magv = tentk; // Giả sử mã giáo viên là tên tài khoản
                                    MessageBox.Show("Đăng nhập thành công!\nXin chào thầy/cô " + tentk + " 🥰\nChúc thầy/cô một ngày tốt lành 💕", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                default:
                                    MessageBox.Show("Bạn không có quyền truy cập.");
                                    return; // Thoát khỏi phương thức nếu không có quyền
                            }

                            // Mở form chính
                            this.Hide();
                            FormChinh frmChinh = new FormChinh();
                            frmChinh.ShowDialog();
                            this.Close();
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu!");
                }
            }
        }



        private void link_DoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Mở ra nếu chạy Audit
            //Database.Set_Database("localhost", "1521", "orcl", "", "");
            //if (Database.ConnectSys())
            //{
            //    new FormAudit().Show();
            //}
        }

        private void btn_ThoatDN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private string GetUserRole(OracleConnection connection, string username)
        {
            string role = null;
            string query = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = " + "'" + txt_username.Text + "'";

            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                try
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi lấy vai trò: " + ex.Message);
                }
            }

            return role;
        }
        void Check_Status(string user)
        {
            string status = Database.Get_Status(user);

            if (status.Equals("LOCKED") || status.Equals("LOCKED(TIMED)"))
            {
                MessageBox.Show("Tài khoản bị khóa");
            }
            else if (status.Equals("EXPIRED(GRACE)"))
            {
                MessageBox.Show("Tài khoản sắp hết hạn");
            }
            else if (status.Equals("EXPIRED & LOCKED(TIMED)"))
            {
                MessageBox.Show("Tài khoản bị khóa do hết hạn");
            }
            else if (status.Equals("EXPIRED"))
            {
                MessageBox.Show("Tài khoản hết hạn");
            }
            else if (status.Equals(" "))
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!\nXem lại thông tin đăng nhập: UserName, PassWord");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Mở ra nếu chạy phân quyền
            //Database.Set_Database("localhost", "1521", "orcl", "", "");
            //if (Database.ConnectSys())
            //{
            //    new PhanQuyen_GUI().Show();
            //}
        }
    }
}
