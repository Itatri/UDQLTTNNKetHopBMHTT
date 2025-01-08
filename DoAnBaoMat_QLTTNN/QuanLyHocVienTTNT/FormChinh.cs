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
    public partial class FormChinh : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Database db = new Database();
        DataTable dt;
        public FormChinh()
        {
            InitializeComponent();
            Custom();
            random = new Random();
        }

        public static string loaitk;
        public static string tentk;
        public static string magv;
        #region Setup Màu
        private Color chonMau()
        {
            int index = random.Next(Function.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Function.ColorList.Count);
            }
            tempIndex = index;
            string color = Function.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = chonMau();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelHeader.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls) // duyệt qua tất cả các control trong panelMenu
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(48, 49, 73);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }

            foreach (Control previousBtn in panelLopHocSubMenu.Controls) // duyệt qua tất cả các control trong panelMenu
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(48, 49, 73);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }

            foreach (Control previousBtn in panelHocVienSubMenu.Controls) // duyệt qua tất cả các control trong panelMenu
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(48, 49, 73);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }


            foreach (Control previousBtn in panelHocTapSubMenu.Controls) // duyệt qua tất cả các control trong panelMenu
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(48, 49, 73);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        #endregion


        #region Ẩn hiện Menu
        private void Custom()
        {
            panelLopHocSubMenu.Visible = false;
            panelHocVienSubMenu.Visible = false;
            panelHocTapSubMenu.Visible = false;
        }

        private void anSubMenu()
        {
            if (panelLopHocSubMenu.Visible == true)
            {
                panelLopHocSubMenu.Visible = false;
            }

            if (panelHocVienSubMenu.Visible == true)
            {
                panelHocVienSubMenu.Visible = false;
            }
            if (panelHocTapSubMenu.Visible == true)
            {
                panelHocTapSubMenu.Visible = false;
            }
        }

        private void hienSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                anSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pannelFormCon.Controls.Add(childForm);
            this.pannelFormCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        //Các nút menu
        private void btn_LopHoc_Click(object sender, EventArgs e)
        {
            hienSubMenu(panelLopHocSubMenu);
            ActivateButton(sender);
        }

        private void btn_TaoLop_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            //OpenChildForm(new FormDSLopHP(), sender);
        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDS_GV(), sender);
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormKhuyenMai(), sender);
        }



        private void btn_HocTap_Click(object sender, EventArgs e)
        {
            hienSubMenu(panelHocTapSubMenu);
            ActivateButton(sender);
        }

        private void btn_HocVien_Click(object sender, EventArgs e)
        {
            if (loaitk == "Giáo viên")
            {
                OpenChildForm(new FormHocVien(), sender);
            }
            else
            {
                OpenChildForm(new FormHocVien(), sender);
                hienSubMenu(panelHocVienSubMenu);
                ActivateButton(sender);
            }
        }

        private void btn_DiemSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHocTap(), sender);
        }


        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(), sender);
        }


        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            anSubMenu();
            ActivateButton(sender);
            OpenChildForm(new FormTraCuu(), sender);
        }


        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSDiemDanh(), sender);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            anSubMenu();
            ActivateButton(sender);
            FormMaHoaHeThong f = new FormMaHoaHeThong();
            f.Show();
            f.Hide();
            OpenChildForm(f, sender);
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            anSubMenu();
            ActivateButton(sender);
            FormNhanVien frm = new FormNhanVien();
            frm.ShowDialog();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            //Logout(this, new EventArgs());
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap frm = new FormDangNhap();
                frm.ShowDialog();
                this.FormClosing -= FormChinh_FormClosing;
                this.Close();
            }
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            if (loaitk == "Giáo viên")
            {
                btn_LopHoc.Visible = false;
                btn_ThongKe.Visible = false;
                btn_TraCuu.Visible = false;
                btn_ThongKe.Visible = false;
                btn_HoaDon.Visible = false;
                string chuoitruyvan = "select TENGV from DuLieu.GIAOVIEN where MAGV = '" + magv + "'";
                dt = db.getDataTable(chuoitruyvan);
                //lb_NameGV.Text = "Xin chào GV \n" + dt.Rows[0][0].ToString();
                lb_NameNV.Visible = false;
            }
            else
            {
                lb_NameNV.Visible = true;
                string chuoitruyvan = "select TENTKNV from DuLieu.NHANVIEN where TENTKNV = '" + tentk + "'";
                dt = db.getDataTable(chuoitruyvan);
                //lb_NameNV.Text = "Xin chào: " + dt.Rows[0][0].ToString();
                lb_NameGV.Visible = false;
            }
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_TaoLop_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAudit(), sender);
        }
    }
}
