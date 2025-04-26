using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaSach;

namespace BUS_QLNhaSach
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dal = new DAL_ThongKe();
        public DataTable LoadDL(string a, string b)
        {
            return dal.LoadDL(a, b);
        }
    }
}
