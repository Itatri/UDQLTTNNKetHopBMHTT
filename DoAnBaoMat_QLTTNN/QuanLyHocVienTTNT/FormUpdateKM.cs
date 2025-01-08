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
    public partial class FormUpdateKM : Form
    {
        string maKM;
        Database db = new Database();
        DataTable dt;
        public FormUpdateKM(string maKM)
        {
            this.maKM = maKM;
            InitializeComponent();
        }
        void hienThiThongTinKM()
        {
            string chuoitruyvan = "SELECT MAKM, SOHVNHOM, FORMAT(SOTIENGIAM,'N0') AS SOTIENGIA FROM KHUYENMAI WHERE MAKM = '" + maKM + "'";
            dt = db.getDataTable(chuoitruyvan);
            txt_MaKM.Text = dt.Rows[0].ItemArray[0].ToString();
            txt_SLHV.Text = dt.Rows[0].ItemArray[1].ToString();
            txt_GiamGia.Text = dt.Rows[0].ItemArray[2].ToString();
        }
        public bool kiemTraTrung(string mgv)
        {
            string chuoitruyvan = "select count(*) from KHUYENMAI where MAKM='" + mgv + "'";
            int k = (int)db.getScalar(chuoitruyvan);

            if (k != 0)
            {
                return false;
            }

            return true;
        }

        private void FormUpdateKM_Load(object sender, EventArgs e)
        {
            hienThiThongTinKM();
        }

        private void BT_CapNhat_Click(object sender, EventArgs e)
        {
            if (!kiemTraTrung(txt_MaKM.Text))
            {
                string chuoitruyvan = "UPDATE KHUYENMAI SET SOHVNHOM = '" + txt_SLHV.Text + "' WHERE MAKM = '" + maKM + "'";
                int k = db.getNonQuery(chuoitruyvan);
                if (k > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    hienThiThongTinKM();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Mã khuyến mãi không tồn tại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
