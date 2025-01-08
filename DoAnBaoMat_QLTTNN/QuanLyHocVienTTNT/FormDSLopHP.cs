using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//=========================NỘI DUNG====
//// Thêm lớp học phần mới + phân công giáo viên cho lớp đó => Button Thêm
///  Xóa lớp học phần, click chọn dòng cần xóa => Button xóa
///  Update thông tin lớp học phần => Double click vào dòng
///  Tìm kiếm giáo viên bằng Mã lớp HP or tên lơp HP or tên GV

namespace QuanLyHocVienTTNT
{
    public partial class FormDSLopHP : Form
    {
        Database db = new Database();
        DataTable dt;
        string selectedMaLopHP = "";

        public FormDSLopHP()
        {
            InitializeComponent();
        }

        void hienThiDanhSachLop()
        {
            string chuoitruyvan = "SELECT L.MaLopHP, L.TenLopHP, L.TenKhoa, L.NgayKhaiGiang, L.NgayKT, L.LichHoc, L.SiSo,  G.TenGV, FORMAT(L.HocPhi,'N0') AS HocPhi FROM DuLieu.LOPHOCPHAN L, DuLieu.PHANCONG P, DuLieu.GIAOVIEN G WHERE L.MaLopHP = P.MaLopHP AND P.MaGV = G.MaGV;";
            dt = db.getDataTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dgv_DsLop.DataSource = dt;
        }


        private void FormDSLopHP_Load(object sender, EventArgs e)
        {
            hienThiDanhSachLop();
        }

        private void dgv_DsLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_DsLop.Rows[e.RowIndex];
        
                // Lấy giá trị trong cột MaLopHP (hoặc ID của dòng) của dòng được chọn
                selectedMaLopHP = selectedRow.Cells["MaLop"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaLopHP))//Kiểm tra đã chọn được giá trị trên dòng
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string chuoitruyvan_PC= "DELETE FROM DuLieu.PHANCONG WHERE MaLopHP = '" + selectedMaLopHP+"'";
                    int kq_PC = db.getNonQuery(chuoitruyvan_PC);

                    string chuoitruyvan_LHP = "DELETE FROM DuLieu.LOPHOCPHAN WHERE MaLopHP = '" + selectedMaLopHP + "'";
                    int kq_LHP = db.getNonQuery(chuoitruyvan_LHP);

                    if (kq_LHP > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        hienThiDanhSachLop(); // Cập nhật DataGridView sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgv_DsLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormUpdateLHP(selectedMaLopHP).ShowDialog();
            hienThiDanhSachLop();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            new FormNhapLHP().ShowDialog();
            hienThiDanhSachLop();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string chuoitruyvan = "SELECT L.MaLopHP, L.TenLopHP, L.TenKhoa, L.NgayKhaiGiang, L.NgayKT, L.LichHoc, L.SiSo,  G.TenGV, FORMAT(L.HocPhi,'N0') AS HocPhi FROM DuLieu.LOPHOCPHAN L, DuLieu.PHANCONG P, DuLieu.GIAOVIEN G WHERE L.MaLopHP Like '%" + txt_TimKiem.Text + "%' AND L.MaLopHP = P.MaLopHP AND P.MaGV = G.MaGV OR L.TenLopHP Like N'%" + txt_TimKiem.Text + "%' AND L.MaLopHP = P.MaLopHP AND P.MaGV = G.MaGV OR G.TenGV Like N'%" + txt_TimKiem.Text + "%' AND L.MaLopHP = P.MaLopHP AND P.MaGV = G.MaGV";
            dt = db.getDataTable(chuoitruyvan);
            if (dt.Rows.Count > 0)
            {
                dgv_DsLop.DataSource = dt;
            }
            else
            {
                hienThiDanhSachLop();
            }
        }

    }
}
