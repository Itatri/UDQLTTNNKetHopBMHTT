using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormDS_GV : Form
    {
        public FormDS_GV()
        {
            InitializeComponent();
        }

        DataTable dt;
        string selectedMaGV = "";

        void hienThiDanhSachGV()
        {
            try
            {
                string chuoitruyvan = "SELECT * FROM DuLieu.GIAOVIEN";
                dt = Database.GetDataTable(chuoitruyvan); // Sử dụng lớp Database
                DataColumn[] key = new DataColumn[1];
                key[0] = dt.Columns["MaGV"]; // Đảm bảo rằng tên cột là "MaGV"
                dt.PrimaryKey = key;

                dgv_GiaoVien.DataSource = dt;

                // Đăng ký sự kiện CellFormatting để xử lý hiển thị mật khẩu
                dgv_GiaoVien.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dgv_GiaoVien.Columns["MatKhau"].Index)
                    {
                        if (e.Value != DBNull.Value)
                        {
                            // Hiển thị mật khẩu dưới dạng dấu sao (*)
                            e.Value = new string('*', e.Value.ToString().Length);
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách giáo viên: " + ex.Message);
            }
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            new FormNhapGV().ShowDialog();
            hienThiDanhSachGV();
        }

        private void FormDS_GV_Load(object sender, EventArgs e)
        {
            hienThiDanhSachGV();
        }

        private void dgv_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_GiaoVien.Rows[e.RowIndex];

                // Lấy giá trị trong cột MaGV của dòng được chọn
                selectedMaGV = selectedRow.Cells["MaGV"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaGV)) // Kiểm tra đã chọn được giá trị
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên và tài khoản liên quan?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Truy vấn để lấy Tentkgv
                        string queryLayTentkgv = "SELECT Tentkgv FROM DuLieu.GIAOVIEN WHERE MaGV = :magv";
                        OracleParameter[] parameters = {
                    new OracleParameter(":magv", selectedMaGV)
                };

                        DataTable dt = Database.GetDataTable(queryLayTentkgv, parameters);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin tài khoản giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string tentkgv = dt.Rows[0]["Tentkgv"].ToString();

                        // Xóa dòng trong bảng GIAOVIEN
                        string queryXoaGV = "DELETE FROM DuLieu.GIAOVIEN WHERE MaGV = :magv";
                        int resultGV = Database.ExecuteNonQuery(queryXoaGV, parameters);

                        if (resultGV > 0)
                        {
                            // Xóa tài khoản Oracle
                            string queryDropUser = "BEGIN EXECUTE IMMEDIATE 'DROP USER ' || :tentkgv || ' CASCADE'; END;";
                            OracleParameter[] dropParams = {
                        new OracleParameter(":tentkgv", tentkgv)
                    };

                            int resultDrop = Database.ExecuteNonQuery(queryDropUser, dropParams);

                            if (resultDrop > 0)
                            {
                                MessageBox.Show("Xóa giáo viên và tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                hienThiDanhSachGV(); // Cập nhật danh sách sau khi xóa
                            }
                            else
                            {
                                MessageBox.Show("Xóa tài khoản thất bại, nhưng giáo viên đã được xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                hienThiDanhSachGV();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xóa giáo viên không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgv_GiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_GiaoVien.Rows[e.RowIndex];
            selectedMaGV = selectedRow.Cells["MaGV"].Value.ToString();
            new FormUpdateGV(selectedMaGV).ShowDialog();
            hienThiDanhSachGV();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string chuoitruyvan = "SELECT * FROM DuLieu.GIAOVIEN WHERE MaGV LIKE :search OR TenGV LIKE :search";
            OracleParameter[] parameters = {
                new OracleParameter(":search", "%" + txt_TimKiem.Text + "%")
            };
            dt = Database.GetDataTable(chuoitruyvan, parameters); // Sử dụng lớp Database
            dgv_GiaoVien.DataSource = dt;
        }
    }
}