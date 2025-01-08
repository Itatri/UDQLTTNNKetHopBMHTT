using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocVienTTNT
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable dt;

        void HienThiHoaDon()
        {
            string chuoitruyvan = @"
                SELECT 
                    HoaDon.MaHD, 
                    LOPHOCPHAN.MaLopHP, 
                    TO_CHAR(NgayLap, 'DD/MM/YYYY') AS NgayLap,
                    HOCVIEN.MaHV, 
                    NHANVIEN.TENTKNV, 
                    HoTenHV, 
                    KHUYENMAI.MaKM, 
                    TO_CHAR(SoTienGiam, 'FM999,999,999') AS SoTienGiam, 
                    TO_CHAR((LOPHOCPHAN.HocPhi - SoTienGiam), 'FM999,999,999') AS ThanhTien 
                FROM 
                    DuLieu.HOADON 
                    INNER JOIN DuLieu.HOCVIEN ON HOADON.MAHV = HOCVIEN.MAHV
                    INNER JOIN DuLieu.LOPHOCPHAN ON LOPHOCPHAN.MaLopHP = HOADON.MaLopHP
                    INNER JOIN DuLieu.KHUYENMAI ON HOADON.MAKM = KHUYENMAI.MAKM
                    INNER JOIN DuLieu.NHANVIEN ON HOADON.TENTKNV = NHANVIEN.TENTKNV";
            dt = db.getDataTable(chuoitruyvan);
            dgv_HoaDon.DataSource = dt;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            //txt_MaHD.Text = Function.CreateKey("HD", "Select * From HOADON");
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string chuoitruyvan = $@"
                SELECT 
                    MaHD, 
                    HOADON.TenTKNV, 
                    LOPHOCPHAN.MaLopHP, 
                    TO_CHAR(NgayLap, 'DD/MM/YYYY') AS NgayLap,
                    HOCVIEN.MaHV, 
                    HoTenHV, 
                    KHUYENMAI.MaKM, 
                    TO_CHAR(SoTienGiam, 'FM999,999,999') AS SoTienGiam, 
                    TO_CHAR((LOPHOCPHAN.HocPhi - SoTienGiam), 'FM999,999,999') AS ThanhTien 
                FROM 
                    DuLieu.HOADON 
                    INNER JOIN DuLieu.HOCVIEN ON HOCVIEN.MAHV = HOADON.MAHV
                    INNER JOIN DuLieu.LOPHOCPHAN ON LOPHOCPHAN.MALOPHP = HOADON.MALOPHP
                    INNER JOIN DuLieu.KHUYENMAI ON HOADON.MAKM = KHUYENMAI.MAKM
                WHERE 
                    MAHD = '{txt_TimKiem.Text}'";
            DataTable dt = db.getDataTable(chuoitruyvan);

            if (dt.Rows.Count == 1)
            {
                dgv_HoaDon.DataSource = dt;
                txt_MaHD.Text = dt.Rows[0]["MAHD"].ToString();
                txt_MaHV.Text = dt.Rows[0]["MAHV"].ToString();
                txt_NgayLap.Text = dt.Rows[0]["NgayLap"].ToString();
                txt_MaLop.Text = dt.Rows[0]["MALOPHP"].ToString();
                txt_TenHV.Text = dt.Rows[0]["HOTENHV"].ToString();
                txt_MaKM.Text = dt.Rows[0]["MAKM"].ToString();
                txt_TenTK.Text = dt.Rows[0]["TENTKNV"].ToString();
                txt_ThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString();
            }
        }
    }

}

