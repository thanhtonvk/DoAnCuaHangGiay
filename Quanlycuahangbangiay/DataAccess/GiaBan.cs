using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class GiaBan
    {
        string maGiaBan;
        string maGiay;
        double giaBangiay;
        string donViTinh;
        public GiaBan(string maGiaBan,string maGiay, double giaBangiay,string donViTinh)
        {
            this.maGiaBan = maGiaBan;
            this.maGiay = maGiay;
            this.giaBangiay = giaBangiay;
            this.donViTinh = donViTinh;
           
        }
        override
            public string ToString()
        {
            return maGiaBan + ";" + maGiay + ";" + giaBangiay + ";" + donViTinh;
        }
        public string MaGiaBan { get => maGiaBan; set => maGiaBan = value; }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public double GiaBangiay { get => giaBangiay; set => giaBangiay = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
