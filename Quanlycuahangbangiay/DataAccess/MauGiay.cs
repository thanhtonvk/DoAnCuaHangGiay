using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class MauGiay
    {
        string maGiay;
        string tenGiay;
        string maLoai;
        int slNhapve;
        int slHienco;
        public MauGiay(string maGiay,string tenGiay,string maLoai,int slNhapve,int slHienco)
        {
            this.maGiay = maGiay;
            this.tenGiay = tenGiay;
            this.maLoai = maLoai;
            this.slNhapve = slNhapve;
            this.slHienco = slHienco;
        }
        override
            public string ToString()
        {
            return maGiay + ";" + tenGiay + ";" + maLoai + ";" + slNhapve + ";" + slHienco;
        }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public string TenGiay { get => tenGiay; set => tenGiay = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public int SlNhapve { get => slNhapve; set => slNhapve = value; }
        public int SlHienco { get => slHienco; set => slHienco = value; }
    }
}
