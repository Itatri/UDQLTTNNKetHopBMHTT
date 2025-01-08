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
    public partial class FormHocTap : Form
    {
        /*FORM NÀY CÓ:
         * Tạo bài tập: click chọn button
         * Nhập điểm: nháy đúp chuột vào dòng cần nhập
         * Lọc: lọc đã nhập/ chưa nhập
         * Lọc mã lớp: xem ds theo lớp
         */
        public FormHocTap()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable dt;

        void hienThi_DSLop()
        {
            string chuoitruyvan = "select MaLopHP from DuLieu.LOPHOCPHAN";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "select MaLopHP from DuLieu.PHANCONG where PHANCONG.MAGV = '" + FormChinh.magv + "' ";
            }
            dt = db.getDataTable(chuoitruyvan);

            
            cboMaLop.DataSource = dt;
            cboMaLop.DisplayMember = "MaLopHP";
            cboMaLop.ValueMember = "MaLopHP";
        }


        void hienThi_DSHocTap()
        {
            string chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP where HOCVIEN.MAHV = HOCTAP.MAHV";

            if (FormChinh.loaitk == "Giáo viên")
            {
                chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, LOPHOCPHAN.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP, DuLieu.LOPHOCPHAN, DuLieu.PHANCONG where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MALOPHP = LOPHOCPHAN.MALOPHP AND LOPHOCPHAN.MALOPHP = PHANCONG.MALOPHP AND MAGV = '" + FormChinh.magv+"'";
            }
            dt = db.getDataTable(chuoitruyvan);

            dgvHocTap.DataSource = dt;

        }

        private void FormHocTap_Load(object sender, EventArgs e)
        {
            hienThi_DSHocTap();
            hienThi_DSLop();

            //tạo dữ liệu cho comboboxx lọc
            cboLoc.Items.Add("Chưa nhập điểm");
            cboLoc.Items.Add("Tất cả");

        }

       

        //tạo 1 bài tập mới--> hiển thị lên datagridview bài tập mới
        private void btnTao_Click(object sender, EventArgs e)
        {
            //new FormTaoBT().ShowDialog();
            //hienThi_DSHocTap();

        }

        string MaBT ="";
        string MaHV = "";
        //click 2 lần vào dòng tương ứng thì nó sẽ lấy dữ liệu dòng đó đưa vào form mới
        private void dgvHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHocTap.Rows[e.RowIndex];

                MaBT = selectedRow.Cells["MABT"].Value.ToString();
                MaHV = selectedRow.Cells["MAHV"].Value.ToString();
            }
        }

        //nhập điểm
        private void dgvHocTap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormNhapDiem(MaBT, MaHV).ShowDialog();
            
            //hiển thị lại dữ liệu lên datagrid view theo lựa chọn đã chọn từ trước             
            if (cboLoc.SelectedIndex == 0) //hiển thị bài tập điểm null của lớp tương ứng
            {
                string chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, HOCTAP.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP where DuLieu.DIEM is null and DuLieu.HOCVIEN.MAHV = DuLieu.HOCTAP.MAHV and DuLieu.HOCTAP.MaLopHP = '" + cboMaLop.SelectedValue.ToString() + "'";
                dt = db.getDataTable(chuoitruyvan);

                if (FormChinh.loaitk == "Giáo viên")
                {
                    chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, LOPHOCPHAN.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP, DuLieu.LOPHOCPHAN, DuLieu.PHANCONG where DuLieu.HOCVIEN.MAHV = DuLieu.HOCTAP.MAHV and DuLieu.HOCTAP.MALOPHP = DuLieu.LOPHOCPHAN.MALOPHP AND DuLieu.LOPHOCPHAN.MALOPHP = DuLieu.PHANCONG.MALOPHP AND MAGV = '" + FormChinh.magv + "' AND DIEM is null";
                }

                dgvHocTap.DataSource = dt;
            }
            else  //hiển thị tắt cả bài tập theo lớp tương ứng
            {
                string chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, HOCTAP.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MaLopHP = '" + cboMaLop.SelectedValue.ToString() + "'";
                dt = db.getDataTable(chuoitruyvan);

                if (FormChinh.loaitk == "Giáo viên")
                {
                    chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, LOPHOCPHAN.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP, DuLieu.LOPHOCPHAN, DuLieu.PHANCONG where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MALOPHP = LOPHOCPHAN.MALOPHP AND LOPHOCPHAN.MALOPHP = PHANCONG.MALOPHP AND MAGV = '" + FormChinh.magv + "'";
                }

                dgvHocTap.DataSource = dt;
            }

        }

        

        //Khi chọn 1 lớp bất kì thì sẽ hiện ds bài tập kèm điểm số từng hv của lớp học đó
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if( cboMaLop.SelectedIndex >= 0 && cboLoc.SelectedIndex >= 0)
            {
                if (cboLoc.SelectedIndex == 0) //hiển thị bài tập điểm null của lớp tương ứng
                {
                    string chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, HOCTAP.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP where DIEM is null and HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MaLopHP = '" + cboMaLop.SelectedValue.ToString() + "'";
                    dt = db.getDataTable(chuoitruyvan);

                    if (FormChinh.loaitk == "Giáo viên")
                    {
                        chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, LOPHOCPHAN.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP, DuLieu.LOPHOCPHAN, DuLieu.PHANCONG where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MALOPHP = LOPHOCPHAN.MALOPHP AND LOPHOCPHAN.MALOPHP = PHANCONG.MALOPHP AND MAGV = '" + FormChinh.magv + "' AND DIEM is null";
                    }

                    dgvHocTap.DataSource = dt;
                }
                else  //hiển thị tắt cả bài tập theo lớp tương ứng
                {
                    string chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, HOCTAP.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MaLopHP = '" + cboMaLop.SelectedValue.ToString() + "'";
                    dt = db.getDataTable(chuoitruyvan);

                    if (FormChinh.loaitk == "Giáo viên")
                    {
                        chuoitruyvan = "select MABT, HOCTAP.MAHV, HOTENHV, DIEM, DIEMTOIDA, LOPHOCPHAN.MALOPHP from DuLieu.HOCVIEN, DuLieu.HOCTAP, DuLieu.LOPHOCPHAN, DuLieu.PHANCONG where HOCVIEN.MAHV = HOCTAP.MAHV and HOCTAP.MALOPHP = LOPHOCPHAN.MALOPHP AND LOPHOCPHAN.MALOPHP = PHANCONG.MALOPHP AND MAGV = '" + FormChinh.magv + "'";
                    }

                    dgvHocTap.DataSource = dt;
                }

            }else
            {
                MessageBox.Show("Vui lòng lựa chọn phù hợp");
            }

            
        }
        
    }
}
