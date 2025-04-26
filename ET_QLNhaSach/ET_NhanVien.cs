using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLNhaSach
{
    public class ET_NhanVien
    {
        private string ID;
        private string TenNV;
        private string NgaySinh;
        private string GT;
        private string CCCD;
        private string DiaChi;
        private string SDT;

        // ===========================================================================
        public string ID1 { get => ID; set => ID = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GT1 { get => GT; set => GT = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        //===========================================================================
        public ET_NhanVien() { }

        

        public ET_NhanVien(string id)
        {
            this.ID = id;

        }

        public ET_NhanVien(string id, string Ten, string nsinh, string gt, string cccd, string dc, string sdt)
        {
            this.ID = id;
            this.TenNV = Ten;
            this.NgaySinh = nsinh;
            this.GT = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
        }
    }
}
