using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLNhaSach
{
    public class ET_NhaXuatBan
    {
        private int ID;
        private string TenNXB;
        private string Email;
        private string DiaChi;
        private string SDT;

        //-----------------------------------------------------------------------------------
        public int ID1 { get => ID; set => ID = value; }
        public string TenNXB1 { get => TenNXB; set => TenNXB = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        //-----------------------------------------------------------------------------------
        public ET_NhaXuatBan( string dc, string email, string sdt)
        {
            this.DiaChi = dc;
            this.Email = email;
            this.SDT = sdt;
        }
        public ET_NhaXuatBan(int id)
        {
            this.ID = id;

        }

        public ET_NhaXuatBan(int id, string Ten,  string dc, string email, string sdt)
        {
            this.ID = id;
            this.TenNXB = Ten;
            this.DiaChi = dc;
            this.Email = email;
            this.SDT = sdt;
        }
    }
}
