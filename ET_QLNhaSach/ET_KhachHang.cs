using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLNhaSach
{
    public class ET_KhachHang
    {
        private string ID;
        private string TenKH;
        private string NgaySinh;
        private string GT;
        private string CCCD;
        private string SDT;

        // ===========================================================================
        public string ID1 { get => ID; set => ID = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GT1 { get => GT; set => GT = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        //===========================================================================

        public ET_KhachHang() { }
        public ET_KhachHang(string id)
        {
            this.ID = id;
       
        }
        public ET_KhachHang(string id, string Ten, string nsinh, string gt, string cccd, string sdt)
        {
            this.ID = id;
            this.TenKH = Ten;
            this.NgaySinh = nsinh;
            this.GT = gt;
            this.CCCD = cccd;
            this.SDT = sdt;
        }
    }
}
