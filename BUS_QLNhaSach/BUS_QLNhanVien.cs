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
    public class BUS_QLNhanVien
    {
        DAL_QLNhanVien dalnhanvien = new DAL_QLNhanVien();

        public bool ThemNV(ET_NhanVien et)
        {
            return dalnhanvien.ThemNhanVien(et);
        }
        public bool XoaNV(ET_NhanVien et)
        {
            return dalnhanvien.XoaNhanVien(et);
        }
        public bool SuaNV(ET_NhanVien et)
        {
            return dalnhanvien.SuaNhanVien(et);
        }
        public DataTable LoadNV()
        {
            return dalnhanvien.LoadDSNV();
        }
    }
}
