using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormUpdateGV : Form
    {
        private readonly string maGV;
        private DataTable dt;

        public FormUpdateGV(string maGV)
        {
            this.maGV = maGV;
            InitializeComponent();
        }

        private void HienThiThongTinGV()
        {
            try
            {
                string chuoitruyvan = "SELECT * FROM DuLieu.GIAOVIEN WHERE MAGV = :maGV";

                OracleParameter[] parameters = {
                    new OracleParameter(":maGV", OracleDbType.Varchar2) { Value = maGV }
                };

                dt = Database.GetDataTable(chuoitruyvan, parameters); // Sử dụng lớp Database

                if (dt.Rows.Count > 0)
                {
                    txt_MaGV.Text = dt.Rows[0]["MAGV"]?.ToString();
                    txt_TenGV.Text = dt.Rows[0]["TENGV"]?.ToString();
                    txt_TenTK.Text = dt.Rows[0]["TENTKGV"]?.ToString();
                    txt_MatKhau.Text = dt.Rows[0]["MATKHAU"]?.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin giáo viên!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUpdateGV_Load(object sender, EventArgs e)
        {
            HienThiThongTinGV();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || string.IsNullOrWhiteSpace(txt_TenTK.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu và tên tài khoản!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật mật khẩu trong bảng GIAOVIEN (không thay đổi tên giáo viên hoặc tài khoản)
                string updateQuery = @"UPDATE DuLieu.GIAOVIEN 
                       SET MATKHAU = :matKhau
                       WHERE TENTKGV = :tenTK";

                OracleParameter[] updateParams = {
            new OracleParameter(":matKhau", OracleDbType.Varchar2) { Value = txt_MatKhau.Text },
            new OracleParameter(":tenTK", OracleDbType.Varchar2) { Value = txt_TenTK.Text.Trim() }
        };

                int rowsAffected = Database.ExecuteNonQuery(updateQuery, updateParams);

                if (rowsAffected > 0)
                {
                    // Cập nhật mật khẩu tài khoản Oracle và làm mật khẩu hết hạn
                    // Thực thi câu lệnh ALTER USER mà không sử dụng tham số bind
                    string alterUserQuery = "ALTER USER \"" + txt_TenTK.Text.Trim() + "\" IDENTIFIED BY "
                                            + ":password";
                    Console.WriteLine("SQL Query: " + alterUserQuery);

                    // Sử dụng câu lệnh trực tiếp thay vì tham số bind cho PASSWORD EXPIRE
                    string alterPasswordQuery = "ALTER USER \"" + txt_TenTK.Text.Trim() + "\" IDENTIFIED BY " + txt_MatKhau.Text;
                    Database.ExecuteNonQuery(alterPasswordQuery, null);

                    MessageBox.Show("Cập nhật mật khẩu thành công",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiThongTinGV();  // Cập nhật giao diện sau khi thay đổi
                    this.Dispose();        // Đóng form hoặc làm tươi lại form
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được cập nhật",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OracleException ex)
            {
                string message = "Lỗi cập nhật: ";
                switch (ex.Number)
                {
                    case 1:  // Unique constraint violated
                        message += "Tên tài khoản đã tồn tại!";
                        break;
                    case 1920: // Invalid user
                        message += "Người dùng Oracle không tồn tại!";
                        break;
                    case 28001: // Password expired
                        message += "Mật khẩu đã hết hạn!";
                        break;
                    default:
                        message += ex.Message;
                        break;
                }
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}