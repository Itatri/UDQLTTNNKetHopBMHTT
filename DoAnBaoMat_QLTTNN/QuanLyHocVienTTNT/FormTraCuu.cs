using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormTraCuu : Form
    {
        public FormTraCuu()
        {
            InitializeComponent();
        }

        DataTable dt;

        void hienThi_DSLop()
        {
            string chuoitruyvan = "SELECT MALOPHP FROM DuLieu.LOPHOCPHAN";
            dt = Database.GetDataTable(chuoitruyvan); // Sử dụng lớp Database

            DataRow dr = dt.NewRow();
            dr["MALOPHP"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);

            cboLop.DataSource = dt;
            cboLop.DisplayMember = "MALOPHP";
            cboLop.ValueMember = "MALOPHP";
        }

        void hienThi_DSHocVien()
        {
            string chuoitruyvan = "SELECT MAHV, HOTENHV, GIOITINH, SDT FROM DuLieu.HOCVIEN";
            dt = Database.GetDataTable(chuoitruyvan); // Sử dụng lớp Database
            dgvTraCuu.DataSource = dt;
        }

        private void FormTraCuu_Load(object sender, EventArgs e)
        {
            hienThi_DSHocVien();
            hienThi_DSLop();

            // Khởi tạo cbo lọc
            cboLuaChon.Items.Add("Tổng ngày vắng");
            cboLuaChon.Items.Add("Tổng số lần làm bài tập");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex > 0)
            {
                if (cboLuaChon.SelectedIndex == 0) // Tổng ngày vắng
                {
                    string chuoitv = @"
                        SELECT HV.MAHV, HOTENHV, GIOITINH, SDT, 
                        COALESCE(COUNT(DD.NGAYVANG), 0) AS N'Số ngày vắng' 
                        FROM DuLieu.PHANLOP PL 
                        LEFT JOIN DIEMDANH DD ON PL.MALOPHP = DD.MALOPHP AND PL.MAHV = DD.MAHV 
                        AND DD.NGAYVANG BETWEEN :ngayBD AND :ngayKT 
                        LEFT JOIN HOCVIEN HV ON PL.MAHV = HV.MAHV 
                        WHERE PL.MALOPHP = :malop 
                        GROUP BY HV.MAHV, HOTENHV, GIOITINH, SDT";

                    OracleParameter[] parameters = {
                        new OracleParameter(":ngayBD", ngayBD.Value.ToString("yyyy-MM-dd")),
                        new OracleParameter(":ngayKT", ngayKT.Value.ToString("yyyy-MM-dd")),
                        new OracleParameter(":malop", cboLop.SelectedValue.ToString())
                    };

                    dt = Database.GetDataTable(chuoitv, parameters); // Sử dụng lớp Database
                    dgvTraCuu.DataSource = dt;
                }
                else if (cboLuaChon.SelectedIndex == 1) // Tổng số lần làm bài tập
                {
                    string chuoitv = @"
                        SELECT HV.MAHV, HOTENHV, GIOITINH, SDT, 
                        COUNT(CASE WHEN HT.DIEM IS NOT NULL THEN 1 ELSE NULL END) AS N'Số lần làm bài' 
                        FROM DuLieu.PHANLOP PL 
                        LEFT JOIN HOCTAP HT ON PL.MAHV = HT.MAHV AND PL.MALOPHP = HT.MALOPHP 
                        LEFT JOIN HOCVIEN HV ON PL.MAHV = HV.MAHV 
                        WHERE PL.MALOPHP = :malop 
                        GROUP BY HV.MAHV, HOTENHV, GIOITINH, SDT";

                    OracleParameter[] parameters = {
                        new OracleParameter(":malop", cboLop.SelectedValue.ToString())
                    };

                    dt = Database.GetDataTable(chuoitv, parameters); // Sử dụng lớp Database
                    dgvTraCuu.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Hãy chọn lựa chọn thích hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lớp thích hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedIndex == 0)
            {
                ngayBD.Enabled = true;
                ngayKT.Enabled = true;
            }
            else
            {
                ngayBD.Enabled = false;
                ngayKT.Enabled = false;
            }
        }
    }
}