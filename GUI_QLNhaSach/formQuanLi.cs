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
    public partial class formQuanLi : Form
    {
        public formQuanLi()
        {
            InitializeComponent();
        }
        BUS_QLKhachHang bus = new BUS_QLKhachHang();
     

      

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataKH.CurrentCell.RowIndex;
            try
            {
                txtMaKH.Text = dataKH.Rows[dong].Cells[0].Value.ToString();
                txtTenKH.Text = dataKH.Rows[dong].Cells[1].Value.ToString();
                txtNgaySinh.Text = dataKH.Rows[dong].Cells[2].Value.ToString();
               cbGT.Text = dataKH.Rows[dong].Cells[3].Value.ToString();
                txtCCCD.Text = dataKH.Rows[dong].Cells[4].Value.ToString();
                txtSDT.Text = dataKH.Rows[dong].Cells[5].Value.ToString();
         

            }
            catch (Exception) { }
        }

      

        private void btThem_Click(object sender, EventArgs e)
        {

            ET_KhachHang et = new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);

            if (bus.ThemKH(et))
            {
                MessageBox.Show("Thêm thành công!");
                LaodDL();
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ET_KhachHang et = new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);

            if (bus.SuaKH(et))
            {
                MessageBox.Show("Sửa thành công!");
                LaodDL();
            }
            else
                MessageBox.Show("Sửa thất bại!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            ET_KhachHang et = new ET_KhachHang(txtMaKH.Text);

            if (bus.XoaKH(et))
            {
                MessageBox.Show("Xóa thành công!");
                LaodDL();
            }
            else
                MessageBox.Show("Xóa thất bại!");
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            formQuanLi from = new formQuanLi();
            this.Hide();
            from.ShowDialog();
        }

        private void btnQLHoaDOn_Click(object sender, EventArgs e)
        {
            form_QLHoaDon from = new form_QLHoaDon();
            this.Hide();
            from.ShowDialog();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            formQLSach from = new formQLSach();
            this.Hide();
            from.ShowDialog();
        }

        private void btnQLNhanvien_Click(object sender, EventArgs e)
        {
            formQLNhanVien from = new formQLNhanVien();
            this.Hide();
            from.ShowDialog();
        }

        private void btnNhaXB_Click(object sender, EventArgs e)
        {
            formQLNhaXuatBan from = new formQLNhaXuatBan();
            this.Hide();
            from.ShowDialog();
        }

        private void formQuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không ? ", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(kq == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không ? ", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                formDangNhap from = new formDangNhap();

                this.Hide();
                from.ShowDialog();
            }    


        }

        private void btnBaoCAo_Click(object sender, EventArgs e)
        {
            formBaoCao from = new formBaoCao();
            this.Hide();
            from.ShowDialog();
        }

        private void formQuanLi_Load(object sender, EventArgs e)
        {
            LaodDL();
        }
        private void LaodDL()
        {
            dataKH.DataSource = bus.LoadKH();
        }
    }
}
