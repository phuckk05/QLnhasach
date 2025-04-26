using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLNhaSach
{
    public class ET_HoaDon
    {
        private string ID;
        private string NgayLap;
        private string MaKH;
        private string MaNV;
        private int TongTien;

        //=================================================================================
        public string ID1 { get => ID; set => ID = value; }
        public string NgayLap1 { get => NgayLap; set => NgayLap = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }

        //=================================================================================

        public ET_HoaDon()
        {

        }

        public ET_HoaDon(string ngay, string Manv, string makh, int Tong)
        {
            this.NgayLap = ngay;
            this.MaNV = Manv;
            this.MaKH = makh;
            this.TongTien = Tong;
        }

        public ET_HoaDon(string id, string ngay, string makh, string Manv, int Tong)
        {
            this.ID = id;
            this.NgayLap = ngay;
            this.MaKH = makh;
            this.MaNV = Manv;
            this.TongTien = Tong;
        }
        public ET_HoaDon(string ngay)
        {
            this.NgayLap = ngay;

        }

        public ET_HoaDon(string id, int Tong)
        {
            this.ID = id;

            this.TongTien = Tong;
        }
    }
}
