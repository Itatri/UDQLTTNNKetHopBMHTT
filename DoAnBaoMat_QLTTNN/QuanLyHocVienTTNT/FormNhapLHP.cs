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
//// Kiểm tra học phí, sỉ sổ phải là số
//// Kiểm phải nhập đủ thông tin mới xác nhận lưu thành công

namespace QuanLyHocVienTTNT
{
    public partial class FormNhapLHP : Form
    {
        public FormNhapLHP()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable dt;

        void hienThiDanhSachGV()
        {
            string chuoitruyvan = "Select * From DuLieu.GIAOVIEN";
            dt = db.getDataTable(chuoitruyvan);

            cbo_GiaoVien.DataSource = dt;
            cbo_GiaoVien.DisplayMember = "TenGV";
            cbo_GiaoVien.ValueMember = "MaGV";
        }

        void hienThiDanhSachKhoa()
        {
            string[] tenKhoaHoc = { "TOEIC", "HSK", "IELST" };

            foreach (string s in tenKhoaHoc)
            {
                cbo_TenKhoa.Items.Add(s);
            }
            cbo_TenKhoa.SelectedIndex = 0;
        }

        private void FormNhapLHP_Load(object sender, EventArgs e)
        {
            hienThiDanhSachGV();
            hienThiDanhSachKhoa();
            txt_MaLopHPhan.Text = Function.TaoMa("HP", "Select TOP 1 MALOPHP from DuLieu.LOPHOCPHAN WHERE MALOPHP LIKE 'HP%' ORDER BY MALOPHP DESC");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //kiểm tra đã nhập đủ thông tin chưa
            if (txt_TenLopHP.Text == "" || txt_LichHocLHP.Text == "" || txt_SiSoLop.Text == "" || txt_HocPhiLHP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            string ngayKG = string.Format("{0:yyyy-MM-dd}", dtp_NgayKG.Value);
            string ngayKT = string.Format("{0:yyyy-MM-dd}", dtp_NgayKT.Value);
            string tenKhoa = cbo_TenKhoa.SelectedItem.ToString();
            string chuoitruyvan = "Insert into DuLieu.LOPHOCPHAN values('" + txt_MaLopHPhan.Text + "','" + txt_TenLopHP.Text + "','" + tenKhoa + "','" + ngayKG + "','" + ngayKT + "','" + txt_LichHocLHP.Text + "','" + txt_SiSoLop.Text + "','" + txt_HocPhiLHP.Text + "')";

            int k = db.getNonQuery(chuoitruyvan);

            if (k == 1)
            {
                string chuoitruyvanPhanCong = "Insert into DuLieu.PHANCONG (MAGV,MALOPHP) values('" + cbo_GiaoVien.SelectedValue + "','" + txt_MaLopHPhan.Text + "')";
                int kq = db.getNonQuery(chuoitruyvanPhanCong);
                if (kq == 1)
                {
                    MessageBox.Show("Tạo lớp học và phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Tạo lớp học và phân công thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Tạo lớp học thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }


        private void cbo_GiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGV = cbo_GiaoVien.SelectedValue.ToString();
            Database db = new Database();
            string chuoitruyvan = "Select MaGV From DuLieu.GIAOVIEN";
            DataTable dt = db.getDataTable(chuoitruyvan);
        }

        private void txt_SiSoLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                this.errorProvider1.SetError(txt_SiSoLop, "Không nhập kí tự khác số!");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_HocPhiLHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                this.errorProvider1.SetError(txt_HocPhiLHP, "Không nhập kí tự khác số!");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }
    }
}
