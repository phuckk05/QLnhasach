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
    public partial class form_QLHoaDon : Form
    {
        public form_QLHoaDon()
        {
            InitializeComponent();
        }

        // Khởi tạo BUS_QLHoaDon để xử lý logic
        BUS_QLHoaDon bus = new BUS_QLHoaDon();

        // Sự kiện khi form load
        private void form_QLHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSHoaDon(); // Tải danh sách hóa đơn lên DataGridView
            LayNV();
            LayKH();
        
            }

        // Hàm tải danh sách hóa đơn từ cơ sở dữ liệu
        private void LoadDSHoaDon()
        {
            dataTong.DataSource = bus.LoadDSHoaDon();  // Hiển thị danh sách hóa đơn
            
        }

        // Các sự kiện chuyển đổi giữa các form quản lý
        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            formQuanLi from = new formQuanLi();
            this.Hide();
            from.ShowDialog();
            this.Show();
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
            this.Show();
        }

        private void btnNhaXB_Click(object sender, EventArgs e)
        {
            formQLNhaXuatBan from = new formQLNhaXuatBan();
            this.Hide();
            from.ShowDialog();
            this.Show();
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

        private void txtNgay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

       

        private void dataDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Sự kiện tìm kiếm hóa đơn theo ngày
        private void txtNgay_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtNgay.Text, out DateTime ngayLap))
            {
                dataDT.DataSource = bus.TimHoaDonTheoNgay(ngayLap);
            }
        }

       

        private void dataTong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataTong.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtNgayLap.Text = row.Cells["NgayLap"].Value.ToString();
                CBKhachHang.Text = row.Cells["MaKH"].Value.ToString();
                CBNhanVien.Text = row.Cells["MaNV"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string maHD = txtMaHD.Text;
            DateTime ngayLap = DateTime.Parse(txtNgay.Text);
            string maKH = CBKhachHang.Text;
            string maNV = CBNhanVien.Text;
            decimal tongTien = decimal.Parse(txtTongTien.Text);

            bus.ThemHoaDon(maHD, ngayLap, maKH, maNV, tongTien);
            LoadDSHoaDon();
        }

        // Sự kiện sửa hóa đơn
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            bus.XoaHoaDon(maHD);
            LoadDSHoaDon();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            DateTime ngayLap = DateTime.Parse(txtNgay.Text);
            string maKH = CBKhachHang.Text;
            string maNV = CBNhanVien.Text;
            decimal tongTien = decimal.Parse(txtTongTien.Text);

            bus.SuaHoaDon(maHD, ngayLap, maKH, maNV, tongTien);
            LoadDSHoaDon();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
        //
        private void LayNV()
        {
            CBNhanVien.DataSource = bus.LoaNhanVien();
            CBNhanVien.DisplayMember = "MaNV";
        }
        private void LayKH()
        {
            CBKhachHang.DataSource = bus.LoadKhachHang();
            CBKhachHang.DisplayMember = "MaKH";
        }

        private void CBNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
