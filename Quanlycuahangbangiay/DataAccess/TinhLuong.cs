using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class TinhLuong
    {
        string maTL;
        string maNV;
        double soNgayLV;
        double thuong;
        double luongCoBan;
        public TinhLuong(string maTL, string maNV, double soNgayLV, double thuong, double luongCoBan)
        {
            this.maTL = maTL;
            this.MaNV = maNV;
            this.soNgayLV = soNgayLV;
            this.thuong = thuong;
            this.luongCoBan = luongCoBan;
        }
        override
            public string ToString()
        {
            return maTL + ";" + maNV + ";" + soNgayLV + ";" + thuong + ";" + luongCoBan;
        }
        public string MaTL { get => maTL; set => maTL = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public double SoNgayLV { get => soNgayLV; set => soNgayLV = value; }
        public double Thuong { get => thuong; set => thuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public double TinhTien(double soNgayLV,double luongCoBan,double thuong)
        {
            return soNgayLV * luongCoBan + thuong;
        }
    }
}
