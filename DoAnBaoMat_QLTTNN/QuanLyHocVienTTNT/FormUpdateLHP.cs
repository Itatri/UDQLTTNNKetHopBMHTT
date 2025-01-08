using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public partial class FormUpdateLHP : Form
    {
        string maLopHP;
        Database db = new Database();
        DataTable dt;
        public FormUpdateLHP(string maLopHP)
        {
            this.maLopHP = maLopHP;
            InitializeComponent();
        }

        void hienthiThongTinLopHP()
        {
            string chuoitruyvan = "SELECT L.MaLopHP, L.TenLopHP, L.TenKhoa, L.NgayKhaiGiang, L.NgayKT, L.LichHoc, L.SiSo, FORMAT(L.HocPhi,'N0') AS HocPhi , G.TenGV FROM LOPHOCPHAN L, PHANCONG P, GIAOVIEN G WHERE L.MaLopHP = P.MaLopHP AND P.MaGV = G.MaGV AND L.MaLopHP = '" + maLopHP + "'";
            //string chuoitruyvan = "SELECT * FROM LOPHOCPHAN";
            dt = db.getDataTable(chuoitruyvan);
            txt_MaLopHP.Text = dt.Rows[0].ItemArray[0].ToString();
            txt_TenLop.Text = dt.Rows[0].ItemArray[1].ToString();

            //Datetimepicker NgayKhaiGiang
            DateTime dt1 = Convert.ToDateTime(dt.Rows[0].ItemArray[3].ToString());
            dTime_KhaiIGiang.Value = dt1;
            //Datetimepicker NgayKetThuc
            DateTime dt2 = Convert.ToDateTime(dt.Rows[0].ItemArray[4].ToString());
            dt_NgayKetThuc.Value = dt2;

            txt_LichHoc.Text = dt.Rows[0].ItemArray[5].ToString();
            txt_Siso.Text = dt.Rows[0].ItemArray[6].ToString();
            txt_HocPhi.Text = dt.Rows[0].ItemArray[7].ToString();

            //Combobox Giao vien
            string maGV = "";
            string chuoitruyvanGV = "Select GIAOVIEN.MaGV From GIAOVIEN , LOPHOCPHAN, PHANCONG Where GIAOVIEN.MaGV = PHANCONG.MaGV AND LOPHOCPHAN.MaLopHP = PHANCONG.MaLopHP AND LOPHOCPHAN.MaLopHP = '" + maLopHP + "'";
            //Lay giao vien tu ma lop
            DataTable dt2GV = db.getDataTable(chuoitruyvanGV);
            maGV = dt2GV.Rows[0].ItemArray[0].ToString();

            string chuoitruyvan2 = "Select MaGV,TenGV From GIAOVIEN";
            DataTable dt3 = db.getDataTable(chuoitruyvan2);
            cb_GiaoVien.DataSource = dt3;
            cb_GiaoVien.DisplayMember = "TenGV";
            cb_GiaoVien.ValueMember = "MaGV";
            cb_GiaoVien.SelectedValue = maGV;//Lấy giáo viên mặc định đầu tiên là giáo viên đã được phân công

            //Combobox Khoa
            string[] tenKhoaHoc = { "TOEIC", "HSK", "IELST" };
            foreach (string s in tenKhoaHoc)
            {
                cb_TenKhoa.Items.Add(s);
            }

            string tenKhoa = "";
            string chuoitruyvanKhoa = "Select TenKhoa From LOPHOCPHAN Where MaLopHP = '" + maLopHP + "'";
            DataTable dt4 = db.getDataTable(chuoitruyvanKhoa);
            tenKhoa = dt4.Rows[0].ItemArray[0].ToString();

            // string chuoitruyvan3 = "Select TenKhoa From LOPHOCPHAN";
            // DataTable dt5 = db.getDataTable(chuoitruyvan3);
            // cb_TenKhoa.DataSource = dt5;
            // cb_TenKhoa.DisplayMember = "TenKhoa";
            // cb_TenKhoa.ValueMember = "TenKhoa";
            cb_TenKhoa.SelectedItem = tenKhoa;
        }

        private void FormUpdateLHP_Load(object sender, EventArgs e)
        {
            hienthiThongTinLopHP();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string NgayKhaiGiang = string.Format("{0:MM-dd-yyyy}", dTime_KhaiIGiang.Value);
            string NgayKetThuc = string.Format("{0:MM-dd-yyyy}", dt_NgayKetThuc.Value);
            string tenKhoa = cb_TenKhoa.SelectedItem.ToString();
            string chuoitruyvan_CNLOP = "UPDATE LOPHOCPHAN SET TenLopHP = N'" + txt_TenLop.Text + "', TenKhoa = N'" + tenKhoa + "', NgayKhaiGiang = '" + NgayKhaiGiang + "', NgayKT = '" + NgayKetThuc + "', LichHoc = N'" + txt_LichHoc.Text + "', SiSo = '" + txt_Siso.Text + "', HocPhi = '" + txt_HocPhi.Text + "' WHERE MaLopHP = '" + maLopHP + "'";
            string chuoitruyvan_CNPHANCONG = "UPDATE PHANCONG SET MaGV = '" + cb_GiaoVien.SelectedValue + "' WHERE MaLopHP = '" + maLopHP + "'";
            int k = db.getNonQuery(chuoitruyvan_CNLOP);
            int j = db.getNonQuery(chuoitruyvan_CNPHANCONG);
            if (k > 0 || j > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                hienthiThongTinLopHP();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void cb_GiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGV = cb_GiaoVien.SelectedValue.ToString();
            Database db = new Database();
            string chuoitruyvan = "Select MaGV From GIAOVIEN";
            DataTable dt = db.getDataTable(chuoitruyvan);
        }
    }
}
