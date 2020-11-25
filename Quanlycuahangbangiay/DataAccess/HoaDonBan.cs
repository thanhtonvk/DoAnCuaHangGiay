using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonBan
    {
        string maHDB;
        string maNVBan;
        string ngayBan;
        double tongTien;
        public HoaDonBan(string maHDB, string maNVBan, string ngayBan, double tongTien)
        {
            this.maHDB = maHDB;
            this.maNVBan = maNVBan;
            this.ngayBan = ngayBan;
            this.tongTien = tongTien;
        }
        override
            public string ToString()
        {
            return maHDB + ";" + maNVBan + ";" + ngayBan + ";" + tongTien;
        }
        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaNVBan { get => maNVBan; set => maNVBan = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
