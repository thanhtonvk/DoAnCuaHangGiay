using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class LoaiGiay
    {
        string maGiay;
        string tenGiay;
        string dacDiem;
        override
            public string ToString()
        {
            return maGiay + ";" + tenGiay + ";" + dacDiem;
        }
        public string MaGiay { get => maGiay; set => maGiay = value; }
        public string TenGiay { get => tenGiay; set => tenGiay = value; }
        public string DacDiem { get => dacDiem; set => dacDiem = value; }
        public LoaiGiay(string maGiay, string tenGiay, string dacDiem)
        {
            this.maGiay = maGiay;
            this.tenGiay = tenGiay;
            this.dacDiem = dacDiem;
        }
    }
}
