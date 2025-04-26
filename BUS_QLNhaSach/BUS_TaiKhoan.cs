using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaSach;
namespace BUS_QLNhaSach
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal = new  DAL_TaiKhoan();
        public bool ThemtaiKhoan(string a, string b)
        {
            return dal.ThemTK(a, b);
        }
        public bool KiemTraTK(string a, string b)
        {
             return dal.KiểmTraTK(a, b);
        }
    }
}
