using ET_QLNhaSach;
using DAL_QLNhaSach;
using System.Data;

namespace BUS_QLNhaSach
{
    public class BUS_QLKhachHang
    {
        DAL_QLKhachHang dal = new DAL_QLKhachHang();

        public bool ThemKH(ET_KhachHang et)
        {
            return dal.ThemKhachHang(et);
        }

        public bool XoaKH(ET_KhachHang et)
        {
            return dal.XoaKhachHang(et);
        }

        public bool SuaKH(ET_KhachHang et)
        {
            return dal.SuaKhachHang(et);
        }
        public DataTable LoadKH()
        {
            return dal.LoadKhachHang();
        }

    }
}
