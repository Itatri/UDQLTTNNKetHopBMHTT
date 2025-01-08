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
    public partial class FormMaHoaHeThong : Form
    {
        public FormMaHoaHeThong()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            FormMaHoaThongTinHV formMaHoa = new FormMaHoaThongTinHV();
            formMaHoa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaHoaThongTinGV formMaHoa = new FormMaHoaThongTinGV();
            formMaHoa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMaHoaThongTinNV formMaHoa = new FormMaHoaThongTinNV();
            formMaHoa.ShowDialog();
        }
    }
}
