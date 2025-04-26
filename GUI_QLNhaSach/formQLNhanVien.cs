using ET_QLNhaSach;
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
    public partial class formQLNhanVien : Form
    {
        public formQLNhanVien()
        {
            InitializeComponent();
        }
        BUS_QLNhanVien busnhanvien = new BUS_QLNhanVien();

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

        private void formQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadDLNV();
        }
        private void LoadDLNV()
        {
            dataNV.DataSource = busnhanvien.LoadNV();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
       
            ET_NhanVien et = new ET_NhanVien(txtMaNV.Text);

            if (busnhanvien.XoaNV(et) == true)
            {
                MessageBox.Show("Xoa Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtMaNV.Clear();
                txtTen.Clear();
                txtNgaySinh.Clear();
                txtSDT.Clear();
                txtCCCD.Clear();
                txtDiaChi.Clear();
                cbGT.SelectedIndex = -1;




                LoadDLNV();
            }
            else
            {
                MessageBox.Show("Xoa Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTen.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text);

            if (busnhanvien.SuaNV(et) == true)
            {
                MessageBox.Show("Sua Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtMaNV.Clear();
                txtTen.Clear();
                txtNgaySinh.Clear();
                txtSDT.Clear();
                txtCCCD.Clear();
                txtDiaChi.Clear();
                cbGT.SelectedIndex = -1;




                LoadDLNV();
            }
            else
            {
                MessageBox.Show("Sua  Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void dataNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataNV.CurrentCell.RowIndex;
            try
            {
                txtMaNV.Text = dataNV.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dataNV.Rows[dong].Cells[1].Value.ToString();
                txtNgaySinh.Text = dataNV.Rows[dong].Cells[2].Value.ToString();
                cbGT.Text = dataNV.Rows[dong].Cells[3].Value.ToString();
                txtCCCD.Text = dataNV.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dataNV.Rows[dong].Cells[5].Value.ToString();
                txtSDT.Text = dataNV.Rows[dong].Cells[6].Value.ToString();


            }
            catch (Exception) { }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
         
    
          
            ET_NhanVien et = new ET_NhanVien(txtMaNV.Text, txtTen.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text);

            if (busnhanvien.ThemNV(et) == true)
            {
                MessageBox.Show("Them Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtMaNV.Clear();
                txtTen.Clear();
                txtNgaySinh.Clear();
                txtSDT.Clear();
                txtCCCD.Clear();
                txtDiaChi.Clear();
                cbGT.SelectedIndex = -1;




                LoadDLNV();
            }
            else
            {
                MessageBox.Show("Them  Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }
    }
}
