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
    public partial class FormNhapKhuyenMai : Form
    {
        Database db = new Database();

        public FormNhapKhuyenMai()
        {
            InitializeComponent();
        }

        private void FormNhapKhuyenMai_Load(object sender, EventArgs e)
        {
            
        }
        public bool kiemTraTrung(string mgv)
        {
            string chuoitruyvan = "select count(*) from KHUYENMAI where MaKM='" + mgv + "'";
            int k = (int)db.getScalar(chuoitruyvan);

            if (k != 0)
            {
                return false;
            }

            return true;
        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            if (kiemTraTrung(txt_MaKhuyenMai.Text))
            {
                string chuoitruyvan = "Insert into KHUYENMAI values('" + txt_MaKhuyenMai.Text + "','" + txt_SoLuongHV.Text + "','" + txt_GiamGia.Text + "')";
                int k = db.getNonQuery(chuoitruyvan);
                if (k == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Mã khuyến mãi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1 );
            }
        }
        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            string tiento = "KM";
            string chuoitruyvan = "Select MAKM From KHUYENMAI where MAKM = '" + txt_MaKhuyenMai.Text + "'";
            if (txt_GiamGia.Text.Length >= 7)
            {
                string hauto = txt_GiamGia.Text.Substring(0, 4);
                tiento += hauto;
            }
            else if (txt_GiamGia.Text.Length >= 6)
            {
                string hauto = txt_GiamGia.Text.Substring(0, 3);
                tiento += hauto;
            }
            else if (txt_GiamGia.Text.Length >= 5)
            {
                string hauto = txt_GiamGia.Text.Substring(0, 2);
                tiento += "0" + hauto;
            }
            txt_MaKhuyenMai.Text = tiento;
            Database db = new Database();
            DataTable dt = db.getDataTable(chuoitruyvan);

            if (dt.Rows.Count == 0)
            {
                label_error.Text = "";
            }
            else
            {
                //this.errorProvider1.SetError(TB_MaKhuyenMai,"Mã khuyến mãi đã tồn tại, hãy nhập tiền khác!");
                label_error.Text = "Mã khuyến mãi đã tồn tại, hãy nhập tiền khác!";
            }
        }

    }
}
