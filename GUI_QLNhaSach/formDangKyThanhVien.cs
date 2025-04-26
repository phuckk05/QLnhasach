using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QLNhaSach;
using BUS_QLNhaSach;

namespace GUi_QLNhaSach
{
    public partial class formDangKyThanhVien : Form
    {
        public formDangKyThanhVien()
        {
            InitializeComponent();
        }
        BUS_KhachHang bus= new BUS_KhachHang();

        private void btThoat_Click(object sender, EventArgs e)
        {
            formTrangChu form  = new formTrangChu();
            this.Hide();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formDangKyThanhVien_Load(object sender, EventArgs e)
        {
            LoadMaKH();
        }
        private void LoadMaKH()
        {
            int a = Convert.ToInt32(bus.LoadMAKH()) + 1;

            txtMaKH.Text = "KH0"+ a.ToString();

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
         
            ET_KhachHang et = new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);

            if(bus.ThemKH(et) == true)
            {
                MessageBox.Show("Lưu Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtNgaySinh.Clear();
                txtSDT.Clear();
                txtCCCD.Clear();
                cbGT.SelectedIndex = -1;




                LoadMaKH();
            }
            else
            {
                MessageBox.Show("Thông Tin Sai  ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formTrangChu from = new formTrangChu();
            this.Hide();
            from.ShowDialog();
        }
    }
}
