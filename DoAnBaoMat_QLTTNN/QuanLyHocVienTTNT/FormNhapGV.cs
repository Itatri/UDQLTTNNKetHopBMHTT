using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormNhapGV : Form
    {
        public FormNhapGV()
        {
            InitializeComponent();
        }

        private void FormNhapGV_Load(object sender, EventArgs e)
        {
            try
            {
                // Câu truy vấn lấy mã giáo viên mới nhất
                string query = @"
                    SELECT MAGV 
                    FROM (
                        SELECT MAGV 
                        FROM DuLieu.GIAOVIEN 
                        WHERE MAGV LIKE 'GV%' 
                        ORDER BY MAGV DESC
                    ) 
                    WHERE ROWNUM = 1";

                // Tự động sinh mã giáo viên mới
                txt_MaGV.Text = Function.TaoMa("GV", query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã GV: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nhập đủ thông tin
                if (string.IsNullOrWhiteSpace(txt_TenGV.Text) ||
                    string.IsNullOrWhiteSpace(txt_TenTK.Text) ||
                    string.IsNullOrWhiteSpace(txt_MatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh thêm giáo viên vào bảng GIAOVIEN
                string insertGVQuery = @"
            INSERT INTO DuLieu.GIAOVIEN (MAGV, TENGV, TENTKGV, MATKHAU) 
            VALUES (:maGV, :tenGV, :tentkgv, :matkhau)";

                // Thêm giáo viên
                OracleParameter[] parameters = {
            new OracleParameter(":maGV", txt_MaGV.Text),
            new OracleParameter(":tenGV", txt_TenGV.Text),
            new OracleParameter(":tentkgv", txt_TenTK.Text),
            new OracleParameter(":matkhau", txt_MatKhau.Text)
        };

                int result = Database.ExecuteNonQuery(insertGVQuery, parameters);
                if (result != 1)
                {
                    MessageBox.Show("Thêm giáo viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo tài khoản người dùng Oracle
                try
                {
                    // Tạo tài khoản người dùng Oracle
                    string createUserQuery = $@"
                    CREATE USER {txt_TenTK.Text} IDENTIFIED BY {txt_MatKhau.Text}";

                    int createUserResult = Database.ExecuteNonQuery(createUserQuery);
                    if (createUserResult == 0) // Kiểm tra xem có lỗi khi tạo tài khoản không
                    {
                        MessageBox.Show("Không thể tạo tài khoản người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Gán quyền GIAO_VIEN_ROLE cho người dùng
                    string grantRoleQuery = $@"GRANT ROLEGV TO {txt_TenTK.Text}";

                    int grantRoleResult = Database.ExecuteNonQuery(grantRoleQuery);
                    if (grantRoleResult == 0) // Kiểm tra xem có lỗi khi gán quyền không
                    {
                        MessageBox.Show("Không thể gán quyền cho người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Tài khoản đã được tạo và gán quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string message = "Lỗi thêm giáo viên: ";
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




        // Giữ nguyên các phương thức validation
        private void txt_TenGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txt_TenGV, "Không nhập kí tự số!");
                e.Handled = true;
            }
            else
                errorProvider1.Clear();
        }

        private void txt_TenTK_TextChanged(object sender, EventArgs e)
        {
            if (!Function.checkAccount(txt_TenTK.Text))
            {
                errorProvider1.SetError(txt_TenTK,
                    "Tên tài khoản phải từ 6 kí tự trở lên và nhỏ hơn 24 kí tự!");
            }
            else
                errorProvider1.Clear();
        }

        //private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        //{
        //    if (!Function.checkPass(txt_MatKhau.Text))
        //    {
        //        errorProvider1.SetError(txt_MatKhau,
        //            "Mật khẩu phải từ 8 kí tự trở lên, 1 kí tự hoa, 1 kí tự số và 1 kí tự đặc biệt!");
        //    }
        //    else
        //        errorProvider1.Clear();
        //}
    }
}
