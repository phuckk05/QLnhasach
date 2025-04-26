using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUi_QLNhaSach
{
    public partial class formTrangChu : Form
    {
        public formTrangChu()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            formThanhToan form = new formThanhToan();
           this.Hide();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            formDangKyThanhVien form = new formDangKyThanhVien();
            this.Hide();
            form.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không ? ", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                formDangNhap from = new formDangNhap();

                this.Hide();
                from.ShowDialog();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            formBaoCaoDanhThu form = new formBaoCaoDanhThu();
            this.Hide();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            formDanhSachSach from = new formDanhSachSach();
            this.Hide();
            from.ShowDialog();
        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            formThongKe from = new formThongKe();
            this.Hide(); from.ShowDialog();
        }
    }
}
