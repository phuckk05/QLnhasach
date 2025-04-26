using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaSach;

namespace GUi_QLNhaSach
{
    public partial class formDangKi : Form
    {
        public formDangKi()
        {
            InitializeComponent();
        }
        BUS_TaiKhoan bus= new BUS_TaiKhoan();

        private void btnBack_Click(object sender, EventArgs e)
        {
           formDangNhap fom = new formDangNhap();
            this.Hide();
            fom.ShowDialog();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "" || txtmatkhau2.Text == "" || txtMatKhau.Text == "" && txtMatKhau.Text != txtmatkhau2.Text)
            {
                MessageBox.Show("Thông Tin Không Hợp lệ", "Thông Báo Đến Người Dùng");

            }
            else
            {
                string a = txtTenDangNhap.Text;
                string b = txtmatkhau2.Text;
                if(bus.ThemtaiKhoan(a,b) == true)
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo Đến Người Dùng ", MessageBoxButtons.OK);
                    formDangNhap form = new formDangNhap();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo Lỗi Đến Người Dùng ", MessageBoxButtons.OK);


                    
                }


            }
        }

        private void btnQuaDangNhap_Click(object sender, EventArgs e)
        {
            formDangNhap form = new formDangNhap();
            this.Hide();
            form.ShowDialog();
        }

        private void formDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
