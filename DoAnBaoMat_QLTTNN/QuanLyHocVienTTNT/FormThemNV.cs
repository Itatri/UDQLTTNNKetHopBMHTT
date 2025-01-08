using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormThemNV : Form
    {
        public FormThemNV()
        {
            InitializeComponent();
            EncryptFun = new EncryptCeaser();
        }

        private static OracleConnection conn;
        private static Database db = new Database();
        private static EncryptCeaser EncryptFun;
        DataTable dt;

        bool KTDuLieuRong()
        {
            if (txtMatKhau.Text.Length != 0 && txtSDT.Text.Length != 0 && txtEmail.Text.Length != 0 && txtTenTKNV.Text.Length != 0)
                return true;
            else
                return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KTDuLieuRong())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string insertGVQuery = @"
            INSERT INTO DuLieu.NHANVIEN (TENTKNV, MATKHAU, EMAIL, SDT) 
            VALUES (:maGV, :tenGV, :tentkgv, :matkhau)";

                // lấy giá trị và thêm
                OracleParameter[] parameters = {
            new OracleParameter(":TENTKNV", txtTenTKNV.Text),
            new OracleParameter(":MATKHAU", txtMatKhau.Text),
            new OracleParameter(":EMAIL", txtEmail.Text),
            new OracleParameter(":SDT", txtSDT.Text)
        };

                int result = Database.ExecuteNonQuery(insertGVQuery, parameters);
                if (result != 1)
                {
                    MessageBox.Show("Thêm tài khoản nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    // Tạo tài khoản người dùng Oracle
                    string createUserQuery = $@"
                    CREATE USER {txtTenTKNV.Text} IDENTIFIED BY {txtMatKhau.Text}";

                    int createUserResult = Database.ExecuteNonQuery(createUserQuery);
                    if (createUserResult == 0)
                    {
                        MessageBox.Show("Không thể tạo tài khoản người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Gán quyền ROLE
                    string grantRoleQuery = $@"GRANT ROLENV TO {txtTenTKNV.Text}";

                    int grantRoleResult = Database.ExecuteNonQuery(grantRoleQuery);
                    if (grantRoleResult == 0) // Kiểm tra xem có lỗi khi gán quyền không
                    {
                        MessageBox.Show("Không thể gán quyền cho người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OracleException ex)
                {
                    // Xử lý các lỗi đặc biệt khi tạo tài khoản người dùng hoặc gán quyền
                    string errorMessage = "Lỗi khi tạo tài khoản hoặc gán quyền: ";
                    switch (ex.Number)
                    {
                        case 1031: // ORA-01031: insufficient privileges
                            errorMessage += "Tài khoản hiện tại không có quyền tạo user hoặc gán role.";
                            break;
                        case 1920: // ORA-01920: user name conflicts with another user or role name
                            errorMessage += "Tên tài khoản đã tồn tại hoặc xung đột.";
                            break;
                        case 65096: // ORA-65096: invalid common user or role name
                            errorMessage += "Tên người dùng không hợp lệ. Tên phải bắt đầu bằng chữ cái và không chứa ký tự đặc biệt.";
                            break;
                        default:
                            errorMessage += ex.Message;
                            break;
                    }
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Đóng form sau khi thành công
                this.Dispose();
            }
            catch (OracleException ex)
            {
                string message = "Lỗi thêm nhân viên mới: ";
                switch (ex.Number)
                {
                    case 1: // Unique constraint violated
                        message += "Tên tài khoản đã tồn tại!";
                        break;
                    default:
                        message += ex.Message;
                        break;
                }
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
