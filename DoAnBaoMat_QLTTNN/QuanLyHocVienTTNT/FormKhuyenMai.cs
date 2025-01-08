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
    public partial class FormKhuyenMai : Form
    {
        /*
         *FORM NÀY DÙNG ĐỂ : 
         *Khởi Tạo tự động Mã khuyến mãi khi nhấp vào thêm sẽ hiện thị ra màn hình
         *Button Thêm để thêm vào mã khuyến mãi, số lượng học viên, tiền giảm vào csdl 
         *Xóa là chọn dòng đó để xóa 
         *Thoát khỏi form khuyến mãi
         *Update lại số lượng học viên , số tiền giảm
         *Tìm kiếm theo mã học viên
         */
        Database db = new Database();
        DataTable dt;
        string selectedMaKM = "";
        public FormKhuyenMai()
        {
            InitializeComponent();
        }
        void Load_DgvGiamGia()
        {
            string chuoitruyvan = "Select MAKM, SOHVNHOM, FORMAT(SOTIENGIAM,'N0') AS SOTIENGIAM from DuLieu.KHUYENMAI";
            dt = db.getDataTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];//so phan tu toi da
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            Dvg_GiamGia.DataSource = dt;
        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            new FormNhapKhuyenMai().ShowDialog();
            Load_DgvGiamGia();
        }
        
        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            Load_DgvGiamGia();
        }
        private void Dvg_GiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = Dvg_GiamGia.Rows[e.RowIndex];

                // Lấy giá trị trong cột MaKM (hoặc ID của dòng) của dòng được chọn
                selectedMaKM = selectedRow.Cells["MaKM"].Value.ToString();
            }
        }
        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaKM))//Kiểm tra đã chọn được giá trị trên dòng
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string chuoitruyvan_PC = "DELETE FROM DuLieu.KHUYENMAI WHERE MaKM = '" + selectedMaKM + "'";
                    int kq = db.getNonQuery(chuoitruyvan_PC);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Load_DgvGiamGia(); // Cập nhật DataGridView sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void Dvg_GiamGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormUpdateKM(selectedMaKM).ShowDialog();
            Load_DgvGiamGia();
        }

        private void BT_TimKiem_Click(object sender, EventArgs e)
        {
            string maKM = TB_MKM.Text;
            string chuoitruyvan = "select * from DuLieu.KHUYENMAI where MAKM = '" + maKM+"'";
            dt = db.getDataTable(chuoitruyvan);

            Dvg_GiamGia.DataSource = dt;
        }

        private void LB_MaKM_Click(object sender, EventArgs e)
        {

        }
    }
}
