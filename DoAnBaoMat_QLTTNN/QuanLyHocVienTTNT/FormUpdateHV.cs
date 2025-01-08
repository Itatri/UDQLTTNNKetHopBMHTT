using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public partial class FormUpdateHV : Form
    {
        Database db = new Database();
        DataTable dt;
        string maHV;
        public FormUpdateHV(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }

        private void FormUpdateHV_Load(object sender, EventArgs e)
        {


            // Khởi tạo giá trị cbo giới tính
            cb_gioiTinh.Items.Add("Nam");
            cb_gioiTinh.Items.Add("Nữ");

            // Hiển thị thông tin học viên
            string chuoitv = "select * from sys.HOCVIEN where MAHV= '" + maHV + "'";
            dt = db.getDataTable(chuoitv);

            if (dt.Rows.Count > 0)
            {
                // Hiển thị thông tin học viên trực tiếp không cần giải mã
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                txtTenHv.Text = dt.Rows[0]["HOTENHV"].ToString();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                txtMaHv.Text = maHV;

                if (dt.Rows[0]["GIOITINH"].ToString() == "Nam")
                    cb_gioiTinh.SelectedIndex = 0;
                else
                    cb_gioiTinh.SelectedIndex = 1;

                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin học viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu không tìm thấy dữ liệu
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {




            try
            {
                // Xác định giới tính
                string gt = cb_gioiTinh.SelectedIndex == 0 ? "Nam" : "Nữ";

                // Tạo truy vấn cập nhật - không mã hóa dữ liệu
                string chuoitruyvan = $"UPDATE HOCVIEN SET HOTENHV = N'{txtTenHv.Text}', GIOITINH = N'{gt}', DIACHI = N'{txtDiaChi.Text}', EMAIL = '{txtEmail.Text}', SDT = '{txtSDT.Text}' WHERE MAHV = '{txtMaHv.Text}'";

                // Thực thi truy vấn
                int k = db.getNonQuery(chuoitruyvan);

                if (k > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Dispose(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kiểm tra số điện thoại
        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.errorProvider1.SetError(txtSDT, "Lỗi");
                txtSDT.Focus();
            }
            else
                this.errorProvider1.Clear();
        }






    }
}
