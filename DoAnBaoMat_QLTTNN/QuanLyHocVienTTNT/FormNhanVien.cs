using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLyHocVienTTNT
{
    public partial class FormNhanVien : Form
    {
        Database db = new Database();
        DataTable dt;
        private static OracleConnection conn;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void hienThiDanhSachNV()
        {
            string chuoitruyvan = "SELECT TENTKNV, EMAIL, SDT FROM DuLieu.NHANVIEN";
            dt = db.getDataTable(chuoitruyvan);
            dgv.DataSource = dt;
        }
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            FormThemNV formThemNV = new FormThemNV();
            formThemNV.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            hienThiDanhSachNV();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            hienThiDanhSachNV();
        }
    }
}
