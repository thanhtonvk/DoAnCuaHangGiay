using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class ChiTietHoaDonBan
    {
        string maCTHDB;
        string maHDB;
        string maGiay;
        int soLuong;
        double donGiaBan;
        string donViTinh;
        public ChiTietHoaDonBan(string maCTHDB,string maHDB,string maGiay,int soLuong,double donGiaBan,string donViTinh)
        {
            this.maCTHDB = maCTHDB;
            this.maHDB = maHDB;
            this.maGiay = maGiay;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donViTinh = donViTinh;
        }
        override
            public string ToString()
        {
            return maCTHDB + ";" + ";" + maHDB+ ";"+ maGiay+ ";" + soLuong+ ";" + donGiaBan+ ";" + donViTinh;
        }
        public string MaCTHDB { get => maCTHDB; set => maCTHDB = value; }
        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double ThanhTien(int soLuong,double donGiaBan)
        {
            return soLuong * donGiaBan;
        }
    }
}
