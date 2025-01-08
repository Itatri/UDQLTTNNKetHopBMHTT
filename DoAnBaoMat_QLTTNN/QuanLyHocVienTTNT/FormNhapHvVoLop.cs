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
    public partial class FormNhapHvVoLop : Form
    {
        string MaHV;
        public FormNhapHvVoLop(string MaHV)
        {
            this.MaHV = MaHV;
            InitializeComponent();
        }

        Database db = new Database();
        DataTable dt;

        void hienThi_DSLop()
        {
            //đỗ dl lên datatable
            string nht = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string chuoitruyvan = "select MaLopHP from DuLieu.LOPHOCPHAN where NGAYKHAIGIANG >= '" + nht + "'";
            dt = db.getDataTable(chuoitruyvan);

            DataRow dr = dt.NewRow();
            dr["MaLopHP"] = "Không có";
            dt.Rows.InsertAt(dr, 0);

            //đưa vào comboboxx
            cboLopHP.DataSource = dt;
            cboLopHP.DisplayMember = "MaLopHP";
            cboLopHP.ValueMember = "MaLopHP";
        }

        //hiển thị ds mã km
        void hienThi_DSMaKM()
        {
            //đỗ dl lên datatable
            string chuoitruyvan = "select MAKM from DuLieu.KHUYENMAI";
            dt = db.getDataTable(chuoitruyvan);

            DataRow dr = dt.NewRow();
            dr["MAKM"] = "Không có";
            dt.Rows.InsertAt(dr, 0);

            //đưa vào comboboxx
            cboMaKM.DataSource = dt;
            cboMaKM.DisplayMember = "MAKM";
            cboMaKM.ValueMember = "MAKM";
        }

        private void FormNhapHvVoLop_Load(object sender, EventArgs e)
        {
            hienThi_DSLop();
            hienThi_DSMaKM();

            //hiển thị thông tin học viên được lấy từ dòng datagridview của form HOCVIEN qua
            string chuoitv = "select * from DuLieu.HOCVIEN where MAHV = '" + MaHV + "'";
            dt = db.getDataTable(chuoitv);
            txtMaHv.Text = MaHV;
            txtTenHv.Text = dt.Rows[0]["HOTENHV"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            txtGT.Text = dt.Rows[0]["GIOITINH"].ToString();

            //hiển thị ngày hiện tại
            txtNgayLap.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);

            //hiển thị mã hoá đơn tự động
            string maHD = "HD" + DateTime.Now.ToString("ddMMyyyy_").Trim(' ') + "_" + "%";
            string sql = "Select TOP 1 MAHD from DuLieu.HOADON WHERE MAHD LIKE '" + maHD + "' ORDER BY MAHD DESC";
            txtMaHD.Text = Function.CreateKey(sql);
            txtNguoiLap.Text = FormChinh.tentk;

        }

        int flag = 0; //lớp đầy
        private void cboLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuoitv = "select count(*) from DuLieu.PHANLOP where MALOPHP= '" + cboLopHP.SelectedValue.ToString() + "'";
            dt = db.getDataTable(chuoitv);

            DataTable dt2;
            string chuoitv2 = "select SISO, FORMAT(HOCPHI,'N0') AS HOCPHI from DuLieu.LOPHOCPHAN where MALOPHP = '" + cboLopHP.SelectedValue.ToString() + "'";
            dt2 = db.getDataTable(chuoitv2);

            if (dt != null && dt.Rows.Count > 0 && dt2 != null && dt2.Rows.Count > 0)
            {
                txtSiSo.Text = dt.Rows[0][0].ToString() + "/" + dt2.Rows[0]["SISO"].ToString();
                txtHocPhi.Text = dt2.Rows[0]["HOCPHI"].ToString();
                //hiển thị thông báo tình trạng
                if (int.Parse(dt.Rows[0][0].ToString()) < int.Parse(dt2.Rows[0]["SISO"].ToString()))
                {
                    lbTinhTrang.Text = "Lớp còn trống, có thể đăng kí!";
                    flag = 1;
                }
                else
                {
                    lbTinhTrang.Text = "Lớp đầy, không thể đăng kí!";
                    flag = 0;
                }

            }

            //hiện thành tiền
            if (cboLopHP.SelectedIndex != 0)
            {
                if (cboMaKM.SelectedIndex != 0)
                {
                    string chuoitv3 = "select FORMAT(SOTIENGIAM,'N0') AS SOTIENGIAM from DuLieu.KHUYENMAI where MAKM = '" + cboMaKM.SelectedValue.ToString() + "'";
                    dt = db.getDataTable(chuoitv3);
                    decimal tt = decimal.Parse(txtHocPhi.Text) - decimal.Parse(dt.Rows[0]["SOTIENGIAM"].ToString());
                    txtThanhTien.Text = string.Format("{0:0,0}", tt);
                }
                else //không có km
                {
                    txtThanhTien.Text = txtHocPhi.Text;
                }
            }
            else
                txtThanhTien.Clear();

        }

        //nếu đã chọn mã lớp và đã chọn mã km thì tính thành tiền
        private void cboMaKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hiện thành tiền
            if (cboLopHP.SelectedIndex != 0)
            {
                if (cboMaKM.SelectedIndex != 0)
                {
                    string chuoitv3 = "select FORMAT(SOTIENGIAM,'N0') AS SOTIENGIAM from DuLieu.KHUYENMAI where MAKM = '" + cboMaKM.SelectedValue.ToString() + "'";
                    dt = db.getDataTable(chuoitv3);
                    decimal tt = decimal.Parse(txtHocPhi.Text) - decimal.Parse(dt.Rows[0]["SOTIENGIAM"].ToString());
                    txtThanhTien.Text = string.Format("{0:0,0}", tt);
                }
                else //không có km
                {
                    txtThanhTien.Text = txtHocPhi.Text;
                }
            }
            else
                txtThanhTien.Clear();

        }

        //xem trước hoá đơn
        private void ckXemHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cboLopHP.SelectedIndex > 0)
            {
                string hd = "\n\t Thông Tin Hoá Đơn";
                hd += "\n______________________________________________________";
                hd = hd + "\nMã hoá đơn: " + txtMaHD.Text;
                hd += "\nMã học viên: " + txtMaHv.Text;
                hd += "\nNgày lập: " + txtNgayLap.Text;
                hd += "\nMã lớp: " + cboLopHP.SelectedValue.ToString();
                hd += "\nMã khuyến mãi: " + cboMaKM.SelectedValue.ToString();
                hd += "\nNhân viên: " + txtNguoiLap.Text;
                hd += "\nThành tiền: " + string.Format("{0:0,0}", txtThanhTien.Text) + " VNĐ";
                if (ckXemHD.Checked)
                {
                    MessageBox.Show(hd, "Thông tin hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    ckXemHD.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                ckXemHD.Checked = false;
            }

        }

        //kiểm tra hv đã tồn tại lớp đó chưa
        bool kTHvTonTaiTrongLop()
        {
            string chuoitv= "select count(*) from DuLieu.PHANLOP where MAHV = '" + txtMaHv.Text+"' and MALOPHP= '"+cboLopHP.SelectedValue.ToString()+"'";
            dt = db.getDataTable(chuoitv);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0) //lớp đó chưa có hv này
                return true;
            return false;
        }
        //thêm học viên vào lớp học và tạo hoá đơn
        //thêm hv mới ko thành công nếu lớp đầy, kiểm tra hv đã tồn tại lớp đó chưa
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboLopHP.SelectedIndex != 0) //TH đã nhập đủ thông tin
            {
                if ( flag == 1 && kTHvTonTaiTrongLop() == true) //flag = 1 --> lớp còn trống
                {
                    //Phân lớp
                    string chuoitruyvan2 = "Insert into DuLieu.PHANLOP values('" + cboLopHP.SelectedValue.ToString() + "',N'" + txtMaHv.Text + "')";
                    int k2 = db.getNonQuery(chuoitruyvan2);
                    if (k2 == 1)
                    {
                        MessageBox.Show("Phân lớp thành công");
                    }
                    else
                    {
                        MessageBox.Show("Phân lớp thất bại");
                    }

                    //Tạo hoá đơn
                    string nl = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                    string chuoitruyvan3 = "INSERT INTO DuLieu.HOADON VALUES('" + txtMaHD.Text + "',N'" + txtMaHv.Text + "','" + nl + "','" + cboLopHP.SelectedValue.ToString() + "', ";

                    if (cboMaKM.SelectedIndex != 0)
                        chuoitruyvan3 += "'" + cboMaKM.SelectedValue.ToString() + "',";
                    else
                        chuoitruyvan3 += "null,";
                    chuoitruyvan3 += "'" + txtNguoiLap.Text + "','" + txtThanhTien.Text + "')";

                    int k3 = db.getNonQuery(chuoitruyvan3);
                    if (k3 == 1)
                    {
                        MessageBox.Show("Tạo hoá đơn thành công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Tạo hoá đơn thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("\t Lỗi!\nCó thể xảy ra do các nguyên nhân sau: \n- Lớp đầy \n- Học viên đã tham gia lớp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void lbTinhTrang_Click(object sender, EventArgs e)
        {

        }
        


       
    }
}
