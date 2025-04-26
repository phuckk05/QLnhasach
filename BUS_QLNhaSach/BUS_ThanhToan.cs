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
    public class BUS_ThanhToan
    {

        DAL_ThanhToan tt = new DAL_ThanhToan();
      

        public string LoadMaTheoTen(ET_NhanVien et)
        {
            return tt.LoadMaTheoTen(et);
        }
        public DataTable LoadTenNhanVien()
        {
            return tt.LoadTebNV();
        }
        public DataTable LayDSMaNV()
        {
            return tt.LoadMaNV();
        }
        public string LayMAHD()
        {
            return tt.LoadMaHDNEW();
        }
        public string LayTenKH(ET_KhachHang et)
        {
            return tt.LoadTenKH(et);
        }
        public string LayMaKh(ET_KhachHang et)
        {
            return tt.LoadMAKH(et);
        }

        public string LayTenSach(ET_Sach et)
        {
            return tt.LoadTenSach(et);
        }
        public int LayDonGia(ET_Sach et)
        {
            return tt.LoadDonGia(et);
        }
        public int LaySoLuong(ET_Sach et)
        {
            return tt.LoadSOluong(et);
        }
        public int LayHoaDon()
        {
            return tt.LoadHoaDon();
        }

        public bool LayHoaDonChiteit(ET_HoaDonChiTiet et)
        {
            return tt.LoadHoaDonChiTet1(et);
        }
        public bool LayMaHDTRONG(ET_HoaDon et)
        {
            return tt.LoadlayMHDtrong(et);
        }
        public DataTable LayHoaDonChiTietG(ET_HoaDonChiTiet et)
        {
            return tt.LoadHoaDonChiTiet(et);
        }
        public bool UpdateTongtien(ET_HoaDon et)
        {
           return   tt.LoadUpdateTongTien(et);
        }

       
    }
}
