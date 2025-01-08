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
    public partial class FormXoaHvRaLop : Form
    {
        Database db = new Database();
        DataTable dt;
        string maHV;
        public FormXoaHvRaLop(string maHV)
        {
            this.maHV = maHV;
            InitializeComponent();
        }

        //hiển thị những ds lớp học phần của hv đó
        void hienThi_DsLop()
        {
            string chuoitv= "select MALOPHP from HOCVIEN, PHANLOP where HOCVIEN.MAHV = PHANLOP.MAHV and PHANLOP.MAHV= '"+maHV+"'";
            dt = db.getDataTable(chuoitv);

            DataRow dr = dt.NewRow();
            dr["MALOPHP"] = "Hãy chọn";
            //dr["TenLopHP"] = "Tat ca lop";
            dt.Rows.InsertAt(dr, 0);

            //đưa vào comboboxx
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "MALOPHP";
            cboLop.ValueMember = "MALOPHP";
        }

        private void FormXoaHvRaLop_Load(object sender, EventArgs e)
        {
            hienThi_DsLop();
            
            //hiển thị thông tin học viên
            string chuoitv = "select * from HOCVIEN where MAHV= '" + maHV + "'";
            dt = db.getDataTable(chuoitv);
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            txtTenHv.Text = dt.Rows[0]["HOTENHV"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            txtMaHv.Text = maHV;
            txtGT.Text = dt.Rows[0]["GIOITINH"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
        }

        //Xoá học viên ra khỏi lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex > 0)//Đã chọn lớp cần xoá
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string chuoitruyvan = "DELETE FROM PHANLOP WHERE MALOPHP = '" + cboLop.SelectedValue.ToString() + "' and MAHV = '"+ txtMaHv.Text+"'";
                    int kq = db.getNonQuery(chuoitruyvan);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lớp cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        
    }
}
