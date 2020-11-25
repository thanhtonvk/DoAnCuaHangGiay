using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonNhap
    {
        string maHDN;
        string maNCC;
        string nvGiao;
        string maNvNhan;
        string ngayNhan;
        double tongTien;
        string trangThai;
        double daTT;
        double conNo;
        string ghiChu;
        public HoaDonNhap(string maHDN, string maNCC, string nvGiao, string maNvNhan,string ngayNhan,double tongTien, string trangThai, double daTT, double conNo,string ghiChu)
        {
            this.maHDN = maHDN;
            this.maNCC = maNCC;
            this.nvGiao = nvGiao;
            this.maNvNhan = maNvNhan;
            this.ngayNhan = ngayNhan;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
            this.daTT = daTT;
            this.conNo = conNo;
            this.ghiChu = ghiChu;
        }
        override
            public string ToString()
        {
            return maHDN + ";" + maNCC + ";" + nvGiao + ";" + maNvNhan + ";" + ngayNhan + ";" + tongTien + ";" + trangThai + ";" + daTT + ";" + conNo + ";" + ghiChu;
        }
        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string NvGiao { get => nvGiao; set => nvGiao = value; }
        public string MaNvNhan { get => maNvNhan; set => maNvNhan = value; }
        public string NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public double DaTT { get => daTT; set => daTT = value; }
        public double ConNo { get => conNo; set => conNo = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
