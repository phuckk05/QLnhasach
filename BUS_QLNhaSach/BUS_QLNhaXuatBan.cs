using DAL_QLNhaSach;
using ET_QLNhaSach;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNhaSach
{
    public class BUS_QLNhaXuatBan
    {
        DAL_QLNhaXuatBan dalnhaxuatban = new DAL_QLNhaXuatBan();


        public DataTable LayTen()
        {
            return dalnhaxuatban.LayTenSB();
        }
        public bool ThemNXB(ET_NhaXuatBan et)
        {
            return dalnhaxuatban.ThemNhaXuatBan(et);
        }
        public bool XoaNXB(ET_NhaXuatBan et)
        {
            return dalnhaxuatban.XoaNhaXuatBan(et);
        }
        public bool SuaNXB(ET_NhaXuatBan et)
        {
            return dalnhaxuatban.SuaNhaXuatBan(et);
        }
        public DataTable LoadNXB()
        {
            return dalnhaxuatban.LoadDSNXB();
        }

        public DataTable TimNXB(ET_NhaXuatBan et)
        {
            return dalnhaxuatban.TimNhaXuatBan(et);
        }
    }
}
