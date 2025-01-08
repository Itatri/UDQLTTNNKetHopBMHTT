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
    public partial class FormNhapDiemDanh : Form
    {
        string maLopHP;
        string maHV;
        Database db = new Database();
        public FormNhapDiemDanh(string maLopHP, string maHV)
        {
            this.maLopHP = maLopHP;
            this.maHV = maHV;
            InitializeComponent();
        }

        void hienThiThongTin()
        {
            string chuoitruyvan = "SELECT PHANLOP.MALOPHP, HOCVIEN.MAHV, HOCVIEN.HOTENHV, DIEMDANH.NGAYVANG FROM DuLieu.PHANLOP LEFT JOIN DuLieu.DIEMDANH ON DIEMDANH.MAHV = PHANLOP.MAHV AND DIEMDANH.MALOPHP = PHANLOP.MALOPHP LEFT JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = PHANLOP.MAHV WHERE PHANLOP.MALOPHP = '" + maLopHP + "' AND PHANLOP.MAHV = '" + maHV + "'";
            Database db = new Database();
            DataTable dt = db.getDataTable(chuoitruyvan);

            //Chọn ngày vắng
            dt_NgayVang.Value = DateTime.Now;
            txt_MaHV.Text = dt.Rows[0]["MaHV"].ToString();
            txt_TenHV.Text = dt.Rows[0]["HoTenHV"].ToString();
            txt_MaLopHP.Text = dt.Rows[0]["MaLopHP"].ToString();

        }

        private void FormNhapDiemDanh_Load(object sender, EventArgs e)
        {
            hienThiThongTin();
        }

        //Kiểm tra ngày vắng có trùng với ngày vắng đã điểm danh hay không
        bool kiemTraNgayVang(string ngayVang)
        {
            string chuoitruyvan = "select count(*) from DuLieu.DIEMDANH where NGAYVANG='" + ngayVang + "' AND MAHV = '" + maHV + "' AND MALOPHP = '" + maLopHP + "'";
            int k = (int)db.getScalar(chuoitruyvan);

            if (k != 0)
            {
                return false;
            }
            return true;
        }

        //Xác nhận điểm danh thêm vào table DIEMDANH
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            //kiểm tra ngày vắn có hợp lệ hay không
            if (dt_NgayVang.Value > DateTime.Now )
            {
                MessageBox.Show("Ngày vắng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                if (kiemTraNgayVang(dt_NgayVang.Value.ToString("yyyy-MM-dd")))
                {
                    string chuoitruyvan = "INSERT INTO DuLieu.DIEMDANH VALUES('" + dt_NgayVang.Value.ToString("yyyy-MM-dd") + "', '" + maHV + "', '" + maLopHP + "')";
                    db.getNonQuery(chuoitruyvan);
                    MessageBox.Show("Điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ngày vắng đã được điểm danh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
