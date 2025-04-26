using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLNhaSach;
using DAL_QLNhaSach;
namespace BUS_QLNhaSach
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal = new DAL_KhachHang();

        public string LoadMAKH()
        {
            return dal.LoadMaHD();
        }
        public bool ThemKH(ET_KhachHang et)
        {
            return dal.ThemKH(et);
        }

    }
}
