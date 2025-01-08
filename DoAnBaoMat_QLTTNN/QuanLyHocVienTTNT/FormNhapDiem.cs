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
    public partial class FormNhapDiem : Form
    {
        /*FORM NÀY CÓ:
         * Nhập điểm: chỉ khi không để trống trường nào và điểm <= điểm tối đa
         */
        string maBT, maHV;
        Database db = new Database();
        DataTable dt;
        public FormNhapDiem(string maBT, string maHV)
        {
            this.maBT = maBT;
            this.maHV = maHV;
            InitializeComponent();
        }

        void hienThiThongTin()
        {
            string chuoitruyvan = "SELECT MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, HOCTAP.MALOPHP FROM DuLieu.HOCTAP, DuLieu.HOCVIEN WHERE MABT = '" + maBT + "' and HOCTAP.MAHV = '" + maHV + "' and HOCTAP.MAHV = HOCVIEN.MAHV";
            dt = db.getDataTable(chuoitruyvan);
            txtMaBT.Text = dt.Rows[0].ItemArray[0].ToString();
            txtMaHV.Text = dt.Rows[0].ItemArray[1].ToString();
            txtTenHV.Text = dt.Rows[0].ItemArray[2].ToString();
            txtDiem.Text = dt.Rows[0].ItemArray[3].ToString();
            txtDiemTD.Text = dt.Rows[0].ItemArray[4].ToString();
            txtMaLop.Text = dt.Rows[0].ItemArray[5].ToString();

        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            hienThiThongTin();

        }

        //click nhập thì sẽ cập nhật điểm vào bảng HOCTAP trong db
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if( txtDiem.Text.Length != 0 && int.Parse(txtDiem.Text) <= int.Parse(txtDiemTD.Text))
            {
                string chuoitruyvan = "UPDATE DuLieu.HOCTAP SET DIEM = '" + txtDiem.Text + "' WHERE MABT = '"+txtMaBT.Text+"' and MAHV= '"+txtMaHV.Text+"'";
                int k = db.getNonQuery(chuoitruyvan);
                if (k > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    hienThiThongTin();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }else
            {
                MessageBox.Show("Điểm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
           
        }

       
    }
}
