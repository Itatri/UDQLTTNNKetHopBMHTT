using System;
using System.Data;
using System.Windows.Forms;

//=========================NỘI DUNG====
//// Chọn dòng học viên cần điêm danh => Button Điểm danh
///  Chọn dòng học viên cần xóa ngày vắng => Button xóa
///  Lọc theo lớp HP => cbo Lớp học
///  Lọc theo tình trạng có mặt / vắng mặt => cbo Tình trạng
///  Tìm kiếm theo tên học viên
///  Tìm kiếm ngày của lớp học phần đó => Chọn cbo lớp Hp + nhập ngày => Button tìm kiếm

namespace QuanLyHocVienTTNT
{
    public partial class FormDSDiemDanh : Form
    {
        Database db = new Database();
        DataTable dt;
        string selectedMaLopHP = "";
        string selectedMaHV = "";
        string selectedNgayVang = "";
        public FormDSDiemDanh()
        {
            InitializeComponent();
        }

        void hienThiMaLopHP()
        {
            string chuoitruyvan = "SELECT * FROM DuLieu.LOPHOCPHAN";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "SELECT MALOPHP FROM DuLieu.PHANCONG WHERE PHANCONG.MAGV = '" + FormChinh.magv + "' ";
            }
            dt = db.getDataTable(chuoitruyvan);
            DataRow dr = dt.NewRow();
            dr["MALOPHP"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cb_MaLopHP.DataSource = dt;
            cb_MaLopHP.DisplayMember = "MALOPHP";
            cb_MaLopHP.ValueMember = "MALOPHP";
            cb_MaLopHP.SelectedIndex = 0;
        }

        void locThongTin()
        {
            string[] trangThai = { "Tất cả", "Vắng", "Có mặt" };
            foreach (string s in trangThai)
            {
                cb_TrangThaiDiemDanh.Items.Add(s);
            }
        }

        void hienThiThongTin()
        {
            string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = SYSDATE LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANCONG INNER JOIN DuLieu.LOPHOCPHAN ON PHANCONG.MAGV = '" + FormChinh.magv + "' AND PHANCONG.MALOPHP = LOPHOCPHAN.MALOPHP LEFT JOIN DuLieu.PHANLOP ON LOPHOCPHAN.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = TO_DATE('" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MAHV IS NOT NULL";
            }
            dt = db.getDataTable(chuoitruyvan);
            dgv_DSDiemDanh.DataSource = dt;
        }

        void hienThiThongTinUpdate()
        {
            string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = TO_DATE('" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANCONG INNER JOIN DuLieu.LOPHOCPHAN ON PHANCONG.MAGV = '" + FormChinh.magv + "' AND PHANCONG.MALOPHP = LOPHOCPHAN.MALOPHP LEFT JOIN PHANLOP ON LOPHOCPHAN.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MAHV IS NOT NULL";
            }
            dt = db.getDataTable(chuoitruyvan);
            dgv_DSDiemDanh.DataSource = dt;
        }


        private void FormDSDiemDanh_Load(object sender, EventArgs e)
        {
            hienThiMaLopHP();
            hienThiThongTin();
            locThongTin();
            cb_TrangThaiDiemDanh.SelectedIndex = 0;

            if (FormChinh.loaitk == "Giáo viên")
            {
                btn_DiemDanh.Enabled = false;
                btn_Xoa.Enabled = false;
                // Ngăn không cho phép click vào DataGridView
                dgv_DSDiemDanh.Enabled = false;

            }
        }

        private void cb_MaLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_MaLopHP.SelectedIndex == 0)
            {
                hienThiThongTin();
            }
            else
            {
                string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = TO_DATE('" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MALOPHP = '" + cb_MaLopHP.SelectedValue.ToString() + "'";
                dt = db.getDataTable(chuoitruyvan);
                dgv_DSDiemDanh.DataSource = dt;
            }
        }

        private void dgv_DSDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv_DSDiemDanh.Rows[e.RowIndex];

                // Lấy giá trị trong cột MaLopHP (hoặc ID của dòng) của dòng được chọn
                selectedMaLopHP = selectedRow.Cells["MaLopHP"].Value.ToString();
                selectedMaHV = selectedRow.Cells["MaHV"].Value.ToString();
                selectedNgayVang = selectedRow.Cells["NgayVang"].Value.ToString();
            }
        }

        private void dgv_DSDiemDanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormNhapDiemDanh(selectedMaLopHP, selectedMaHV).ShowDialog();
            hienThiThongTinUpdate();


        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaLopHP) && !string.IsNullOrEmpty(selectedMaHV))
            {
                new FormNhapDiemDanh(selectedMaLopHP, selectedMaHV).ShowDialog();
                hienThiThongTinUpdate();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học viên để điểm danh.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaLopHP) && !string.IsNullOrEmpty(selectedMaHV) && !string.IsNullOrEmpty(selectedNgayVang))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ngày vắng của học viên này ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string chuoitruyvan = "DELETE FROM DuLieu.DIEMDANH WHERE NgayVang = TO_DATE('" + selectedNgayVang + "', 'YYYY-MM-DD')";
                    int kq = db.getNonQuery(chuoitruyvan);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        hienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }

        }

        private void cb_TrangThaiDiemDanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TrangThaiDiemDanh.SelectedIndex == 0)
            {
                hienThiThongTin();
            }
            else if (cb_TrangThaiDiemDanh.SelectedIndex == 1) //Vắng
            {
                string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DuLieu.DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = '" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "' LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE DIEMDANH.NGAYVANG IS NOT NULL AND DIEMDANH.MALOPHP = '" + cb_MaLopHP.SelectedValue.ToString() + "'";

                if (FormChinh.loaitk == "Giáo viên")
                {
                    chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANCONG INNER JOIN DuLieu.LOPHOCPHAN ON DuLieu.PHANCONG.MAGV = '" + FormChinh.magv + "' AND PHANCONG.MALOPHP = LOPHOCPHAN.MALOPHP LEFT JOIN DuLieu.PHANLOP ON LOPHOCPHAN.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = '" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "' LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE DIEMDANH.NGAYVANG IS NOT NULL";
                }
                dt = db.getDataTable(chuoitruyvan);
                dgv_DSDiemDanh.DataSource = dt;
            }
            else if (cb_TrangThaiDiemDanh.SelectedIndex == 2) //Có mặt
            {
                string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = '" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "' LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MALOPHP = '" + cb_MaLopHP.SelectedValue.ToString() + "' AND DIEMDANH.NGAYVANG IS NULL";

                if (FormChinh.loaitk == "Giáo viên")
                {
                    chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANCONG INNER JOIN DuLieu.LOPHOCPHAN ON DuLieu.PHANCONG.MAGV = '" + FormChinh.magv + "' AND PHANCONG.MALOPHP = LOPHOCPHAN.MALOPHP LEFT JOIN DuLieu.PHANLOP ON LOPHOCPHAN.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP AND DIEMDANH.NGAYVANG = '" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "' LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE DIEMDANH.NGAYVANG IS NULL AND PHANLOP.MAHV IS NOT NULL";
                }
                dt = db.getDataTable(chuoitruyvan);
                dgv_DSDiemDanh.DataSource = dt;

            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MALOPHP = '" + cb_MaLopHP.SelectedValue.ToString() + "'  AND DIEMDANH.NGAYVANG = '" + dt_TimKIem.Value.ToString("yyyy-MM-dd") + "'";
            db.getNonQuery(chuoitruyvan);
            dt = db.getDataTable(chuoitruyvan);
            dgv_DSDiemDanh.DataSource = dt;

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE HOCVIEN.HOTENHV LIKE N'%" + txt_TimKiem.Text + "%'";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "SELECT PHANLOP.MALOPHP, PHANLOP.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANCONG INNER JOIN DuLieu.LOPHOCPHAN ON PHANCONG.MAGV = '" + FormChinh.magv + "' AND PHANCONG.MALOPHP = LOPHOCPHAN.MALOPHP LEFT JOIN DuLieu.PHANLOP ON LOPHOCPHAN.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE HOCVIEN.HOTENHV LIKE N'%" + txt_TimKiem.Text + "%'";
            }

            dt = db.getDataTable(chuoitruyvan);
            if (dt.Rows.Count > 0)
            {
                dgv_DSDiemDanh.DataSource = dt;
            }
            else
            {
                hienThiThongTin();
            }
        }


    }
}
