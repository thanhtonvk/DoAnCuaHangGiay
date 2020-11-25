using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class NhanVien
    {
        string maNV;
        string tenNV;
        string ngaySinh;
        string gioiTinh;
        string ngayVaoLV;
        string loaiNV;
        public NhanVien(string maNV,string tenNV,string ngaySinh,string gioiTinh,string ngayVaoLV,string loaiNV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.ngayVaoLV = ngayVaoLV;
            this.loaiNV = loaiNV;
        }
        override
            public string ToString()
        {
            return maNV + ";" + tenNV + ";" + ngaySinh + ";" + gioiTinh + ";" + ngayVaoLV + ";" + loaiNV;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgayVaoLV { get => ngayVaoLV; set => ngayVaoLV = value; }
        public string LoaiNV { get => loaiNV; set => loaiNV = value; }
    }
}
