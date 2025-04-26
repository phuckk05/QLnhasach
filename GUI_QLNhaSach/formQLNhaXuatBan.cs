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
    public partial class formQLNhaXuatBan : Form
    {
        public formQLNhaXuatBan()
        {
            InitializeComponent();
        }
        BUS_QLNhaXuatBan busnhaxuatban = new BUS_QLNhaXuatBan();
        private void label4_Click(object sender, EventArgs e)
        {

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void formQLNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadDLNXB();
        }

        private void dataNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataNXB.CurrentCell.RowIndex;
            try
            {
                txtmanhaxuatban.Text = dataNXB.Rows[dong].Cells[0].Value.ToString();
                txtTenNXB.Text = dataNXB.Rows[dong].Cells[1].Value.ToString();
                txtEmail.Text = dataNXB.Rows[dong].Cells[2].Value.ToString();
                txtDiaChi.Text = dataNXB.Rows[dong].Cells[3].Value.ToString();
                txtSDT.Text = dataNXB.Rows[dong].Cells[4].Value.ToString();



            }
            catch (Exception) { }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void LoadDLNXB()
        {
            dataNXB.DataSource = busnhaxuatban.LoadNXB();
        }
        private void LoadTimNXB()
        {
            int n = Convert.ToInt32(txtmanhaxuatban.Text);
            ET_NhaXuatBan et = new ET_NhaXuatBan(n, txtTenNXB.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);
            dataNXB.DataSource = busnhaxuatban.TimNXB(et);
            if (dataNXB.Rows.Count == 1)
            {
                MessageBox.Show("Không Tồn Tại ");
                LoadDLNXB();
            }
            else
            {
                dataNXB.DataSource = busnhaxuatban.TimNXB(et);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtmanhaxuatban.Text);
            ET_NhaXuatBan et = new ET_NhaXuatBan(n, txtTenNXB.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);

            if (busnhaxuatban.XoaNXB(et) == true)
            {
                MessageBox.Show("Xoa Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtmanhaxuatban.Clear();
                txtTenNXB.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();




                LoadDLNXB();
            }
            else
            {
                MessageBox.Show("Xoa Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(txtmanhaxuatban.Text);
            ET_NhaXuatBan et = new ET_NhaXuatBan(n, txtTenNXB.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);

            if (busnhaxuatban.ThemNXB(et) == true)
            {
                MessageBox.Show("Them Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtmanhaxuatban.Clear();
                txtTenNXB.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();




                LoadDLNXB();
            }
            else
            {
                MessageBox.Show("Them Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtmanhaxuatban.Text);
            ET_NhaXuatBan et = new ET_NhaXuatBan(n, txtTenNXB.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);

            if (busnhaxuatban.SuaNXB(et) == true)
            {
                MessageBox.Show("Sua Thành Công ", "Thông Báo Đến Người Dùng ! ", MessageBoxButtons.OK);
                txtmanhaxuatban.Clear();
                txtTenNXB.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();




                LoadDLNXB();
            }
            else
            {
                MessageBox.Show("Sua Khong Thành Công ", "Thông Báo Lỗi Đến Người Dùng ! ", MessageBoxButtons.OK);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadTimNXBB();
        }
        private void LoadTimNXBB()
        {
            int n = Convert.ToInt32(txtTimKiem.Text);
            ET_NhaXuatBan et = new ET_NhaXuatBan(n);
            dataNXB.DataSource = busnhaxuatban.TimNXB(et);
            if (dataNXB.Rows.Count == 1)
            {
                MessageBox.Show("Không Tồn Tại ");
                LoadDLNXB();
            }
            else
            {
                dataNXB.DataSource = busnhaxuatban.TimNXB(et);
            }

        }
    }
}
