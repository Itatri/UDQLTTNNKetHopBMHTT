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
    public partial class FormTaoBT : Form
    {
        /*FORM NÀY CÓ:
         * Tạo mã bài tập tự động khi ta chọn lớp
         * Nhập điểm tối đa: chỉ được nhập số
         * Tạo bài tập: chỉ tạo khi đã nhập đủ các trường
         */
        public FormTaoBT()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable dt;


        void hienThi_DSLop()
        {
            string nht = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string chuoitruyvan = "select MaLopHP from DuLieu.LOPHOCPHAN where '" + nht + "' BETWEEN NGAYKHAIGIANG AND NGAYKT";
            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "select MaLopHP from DuLieu.PHANCONG where PHANCONG.MAGV = '" + FormChinh.magv + "' ";
            }
            dt = db.getDataTable(chuoitruyvan);

            DataRow dr = dt.NewRow();
            dr["MaLopHP"] = "Hãy chọn";
            dt.Rows.InsertAt(dr, 0);

            cboMaLop.DataSource = dt;
            cboMaLop.DisplayMember = "MaLopHP";
            cboMaLop.ValueMember = "MaLopHP";

        }

        private void FormTaoBT_Load(object sender, EventArgs e)
        {
            hienThi_DSLop();
            txtMaBT.Text = null;
        }

        //khi chọn mã lớp thì mã bt tạo lại tương ứng theo lớp đó
        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaBT.Clear();
            if (cboMaLop.SelectedIndex > 0)
            {
                string maBT = "BT" + cboMaLop.SelectedValue.ToString().Trim(' ') + "_" + "%";
                txtMaBT.Text = Function.taoMaBTTuDong(cboMaLop.SelectedValue.ToString(), "Select TOP 1 MaBT from DuLieu.HOCTAP WHERE MaBT LIKE '" + maBT + "' ORDER BY MaBT DESC");
            }
            
        }

              
        //chỉ được nhập số ở textbox điểm tối đa
        private void txtDiemTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                this.errorProvider1.SetError(txtDiemTD, "Không nhập kí tự khác số!");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }

        int k;
        //Click tạo thì thông tin được lưu vào db bảng HOCTAP
        private void btnTaoBT_Click(object sender, EventArgs e)
        {
            //không được để trống trường nào thì mới click tạo được
            if (txtDiemTD.Text.Length > 0)
            {
                string chuoitv1 = "Select MAHV from DuLieu.PHANLOP where MALOPHP = '" + cboMaLop.SelectedValue.ToString()+"'";
                dt = db.getDataTable(chuoitv1); //bảng gồm các học viên lớp tương ứng trong cbo
                string diemTD = txtDiemTD.Text;
                string maBT = txtMaBT.Text;
                string lop = cboMaLop.SelectedValue.ToString();
                //lần lượt thêm các học viên vào bảng HOCTAP
                foreach (DataRow row in dt.Rows)
                {
                    string chuoitv2 = "insert into DuLieu.HOCTAP values ('" + maBT+"','"+row["MAHV"].ToString()+"',null,'"+diemTD+"','"+lop+"')";
                    k = db.getNonQuery(chuoitv2);
               
                }

                if (k == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
                MessageBox.Show("Hãy nhập điểm tối đa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }
    }
}
