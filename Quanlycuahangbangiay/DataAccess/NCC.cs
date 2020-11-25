using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NCC
    {
        string maNCC;
        string tenNCC;
        string diaChi;
        string sdt;
        public NCC(string maNCC,string tenNCC,string diaChi,string sdt)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return maNCC + ";" + tenNCC + ";" + diaChi + ";" + sdt;
        }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
