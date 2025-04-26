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
   public class BUS_DanhSachSach
    {
        DAL_DanhSachSach dal = new DAL_DanhSachSach();
        public DataTable LoadDS()
        {
            return dal.LoadDSsach();
        }

        public DataTable LoadTimMaa(ET_Sach et)
        {
            return dal.LoadTimMa(et);

        }
        public DataTable LoadTimTen(ET_Sach et)
        {
            return dal.LoadTimTen(et);
        }
    }
}
