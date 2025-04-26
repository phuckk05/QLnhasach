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
using System.Runtime.InteropServices;

namespace GUi_QLNhaSach
{
    public partial class formQLSach : Form
    {
        public formQLSach()
        {
            InitializeComponent();
        }
       
        BUS_QLSach bus = new BUS_QLSach();
        BUS_QLNhaXuatBan busn = new BUS_QLNhaXuatBan();
        private void label7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// xóa Sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            ET_Sach et = new ET_Sach(txtId.Text);
            if(bus.XoaSach(et) == true)
            {
                MessageBox.Show("Xóa Thành Công");
                txtId.Clear();
                txtDonGia.Clear();
                txtSL.Clear();
                cbTheLoai.SelectedIndex =- 1;
                cbNXB.SelectedIndex =- 1;
                txtTacGia.Clear();
                txtTenSach.Clear();
                txtId.Focus();
                LoadDSSach();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
        }
        /// <summary>
        /// Sủa Dl sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSua_Click(object sender, EventArgs e)
        {
            int dongia = Convert.ToInt32(txtDonGia.Text);
            int sl = Convert.ToInt32(txtSL.Text);
            int cb = Convert.ToInt32(cbTheLoai.Text);
            int nxb = Convert.ToInt32(cbNXB.Text);
            ET_Sach et = new ET_Sach(txtId.Text, txtTenSach.Text, txtTacGia.Text, dongia, sl, cb, nxb);
            if (bus.SuaSach(et) == true)
            {
                MessageBox.Show("Sửa Thành Công ", "Thông Báo Đến Người Dùng", MessageBoxButtons.OK);
                txtId.Clear();
                txtDonGia.Clear();
                txtSL.Clear();
                cbTheLoai.SelectedIndex = -1;
                cbNXB.SelectedIndex = -1;
                txtTacGia.Clear();
                txtTenSach.Clear();
                txtId.Focus();
                LoadDSSach();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công ", "Thông Báo Đến Người Dùng", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Thêm Dữ Liệu Sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThem_Click(object sender, EventArgs e)
        {
            int dongia =  Convert.ToInt32(txtDonGia.Text);
            int sl = Convert.ToInt32(txtSL.Text);
            int cb = Convert.ToInt32(cbTheLoai.Text);
            int nxb = Convert.ToInt32(cbNXB.Text);
               ET_Sach et = new ET_Sach(txtId.Text, txtTenSach.Text, txtTacGia.Text,dongia , sl,cb, nxb);
           if(bus.ThemDS(et) == true)
            {
                MessageBox.Show("Thêm Thành Công ", "Thông Báo Đến Người Dùng", MessageBoxButtons.OK);
                txtId.Clear();
                txtDonGia.Clear();
                txtSL.Clear();
                cbTheLoai.SelectedIndex = -1;
                cbNXB.SelectedIndex = -1;
                txtTacGia.Clear();
                txtTenSach.Clear();
                txtId.Focus();
                LoadDSSach();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công ", "Thông Báo Đến Người Dùng", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Data Sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataSach.CurrentCell.RowIndex;
            try
            {
                txtId.Text = dataSach.Rows[dong].Cells[0].Value.ToString();
                txtTenSach.Text = dataSach.Rows[dong].Cells[1].Value.ToString();
                txtTacGia.Text = dataSach.Rows[dong].Cells[2].Value.ToString();
                txtDonGia.Text = dataSach.Rows[dong].Cells[3].Value.ToString();
                txtSL.Text = dataSach.Rows[dong].Cells[4].Value.ToString();
                cbTheLoai.Text = dataSach.Rows[dong].Cells[5].Value.ToString();
                cbNXB.Text = dataSach.Rows[dong].Cells[6].Value.ToString();

            }
            catch(Exception) { }
        }

        private void cbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// load sau khi xoa ở text box tìm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                LoadDSSach();
            }
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// load Tìm Kiếm
        /// </summary>
        private void LoadTim()
        {
            ET_Sach et = new ET_Sach(txtTimKiem.Text);
            dataSach.DataSource = bus.TimDS(et);
            if (dataSach.Rows.Count == 1)
            {
                MessageBox.Show("Không Tồn Tại ");
                LoadDSSach();
            }
            else
            {
                dataSach.DataSource = bus.TimDS(et);
            }
           
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadTim();
        }

        private void formQLSach_Load(object sender, EventArgs e)
        {
            
            LoadTheloai();
            LoadTen();
            LoadDSSach();
        }
        private void LoadTen()
        {
            cbNXB.DataSource = busn.LayTen();
            cbNXB.DisplayMember = "TenNXB";
        }

        private void LoadDSSach()
        {
            dataSach.DataSource = bus.LayDSsach();
        }
        private void LoadTheloai()
        {
            cbTheLoai.DataSource = bus.LayTheLoai();
            cbTheLoai.DisplayMember = "TheLoaiID";
            
        }
        private void NhaXuatban()
        {
            cbNXB.DataSource = bus.LayNXB();
            cbNXB.DisplayMember = "NXBID";
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

        private void btnAdenZ_Click(object sender, EventArgs e)
        {
            dataSach.DataSource = bus.LoadAdenZ();
        }

        private void btnZdenA_Click(object sender, EventArgs e)
        {
            dataSach.DataSource = bus.LoadZdenA();
        }
    }
}
