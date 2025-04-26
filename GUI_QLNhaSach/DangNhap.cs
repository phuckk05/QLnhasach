using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaSach;

namespace GUi_QLNhaSach
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }
        BUS_TaiKhoan yk = new BUS_TaiKhoan();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            //formTrangChu form = new formTrangChu();
            //form.MdiParent = this;
            //form.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Nhập Thiếu Thông Tin ", "Thông Báo Đén Người Dùng ", MessageBoxButtons.OK);
            }
            else
            {
                if(txtMatKhau.Text == "admin" && txtTenDangNhap.Text == "admin")
                {
                  formQuanLi from = new formQuanLi();
                    this.Hide();
                    from.ShowDialog();
                }
                else if(txtMatKhau.Text == "12345" && txtTenDangNhap.Text == "admin")
                {

                    //string a = txtTenDangNhap.Text;
                    //string b = txtMatKhau.Text;


                    //if (yk.KiemTraTK(a, b) == true)
                    //{
                    formTrangChu form = new formTrangChu();
                    this.Hide();
                    form.ShowDialog();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("thông Tin Không Hớp Lệ ", "Thông Báo Lỗi Đén Người Dùng ", MessageBoxButtons.OK);
                    //}
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {

        }

        private void labelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formDangKi form = new formDangKi();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
