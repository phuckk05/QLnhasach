using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLNhaSach;
using DAL_QLNhaSach;
using System.Data;
namespace BUS_QLNhaSach
{
    public class BUS_QLHoaDon
    {

        DAL_QLhoaDon dal = new DAL_QLhoaDon();

        // Hàm lấy danh sách hóa đơn


        public DataTable LoadKhachHang()
        {
            return dal.LayMaKH();
        }
        public DataTable LoaNhanVien()
        {
            return dal.LayMaNV();
        }
        public DataTable LoadDSHoaDon()
        {
            return dal.LoadDSHoaDon();
        }

        // Hàm tìm kiếm hóa đơn theo ngày
        public DataTable TimHoaDonTheoNgay(DateTime ngayLap)
        {
            return dal.TimHoaDonTheoNgay(ngayLap);
        }

        // Hàm thêm hóa đơn
        public void ThemHoaDon(string maHD, DateTime ngayLap, string maKH, string maNV, decimal tongTien)
        {
            dal.ThemHoaDon(maHD, ngayLap, maKH, maNV, tongTien);
        }

        // Hàm sửa hóa đơn
        public void SuaHoaDon(string maHD, DateTime ngayLap, string maKH, string maNV, decimal tongTien)
        {
            dal.SuaHoaDon(maHD, ngayLap, maKH, maNV, tongTien);
        }

        // Hàm xóa hóa đơn
        public void XoaHoaDon(string maHD)
        {
            dal.XoaHoaDon(maHD);
        }
    }
}
