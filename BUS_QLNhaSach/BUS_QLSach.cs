using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaSach;
using ET_QLNhaSach;
namespace BUS_QLNhaSach
{
    public class BUS_QLSach
    {
        DAL_QLSach ttsach = new DAL_QLSach();

        public DataTable LayTheLoai()
        {
            return ttsach.LoadTheLoai();
        }

        public DataTable LayNXB()
        {
            return ttsach.LoadNhaxuatBan();
        }
        public DataTable LayDSsach()
        {
            return ttsach.LoadDSsach();
        }
        public bool ThemDS(ET_Sach et)
        {
            return ttsach.LoadThem(et);
        }
        public DataTable TimDS(ET_Sach et)
        {
            return ttsach.TimSach(et);
        }
        public bool XoaSach(ET_Sach et)
        {
            return ttsach.XoaSach(et);
        }
        public bool SuaSach(ET_Sach et)
        {
            return ttsach.LoadUpdate(et);
        }
        public DataTable LoadAdenZ()
        {
            return ttsach.LoadAdenZ();
        }
        public DataTable LoadZdenA()
        {
            return ttsach.LoadZdenA();
        }
        public  bool  UpdateSlSach(ET_Sach et)
        {
            return ttsach.UpdateSach(et);
        }
    }
}
