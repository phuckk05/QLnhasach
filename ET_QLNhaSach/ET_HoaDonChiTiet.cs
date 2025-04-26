using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLNhaSach
{
    public class ET_HoaDonChiTiet
    {
        private int ID;
        private string MaSach;
        private int SL;
        private int ThanhTien;
        private string MaHD;
        //============================================================================

        public int ID1 { get => ID; set => ID = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public int SL1 { get => SL; set => SL = value; }
        public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string MaHD1 { get => MaHD; set => MaHD = value; }

        //============================================================================

        public ET_HoaDonChiTiet()
        {

        }
        public ET_HoaDonChiTiet(int id, string masach, int sl, int thanhtien, string mahd)
        {
            this.ID = id;
            this.MaSach = masach;
            this.SL = sl;
            this.ThanhTien = thanhtien;
            this.MaHD = mahd;
        }
    }
}
