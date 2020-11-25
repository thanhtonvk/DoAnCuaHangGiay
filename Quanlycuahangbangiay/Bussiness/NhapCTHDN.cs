using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapCTHDN
    {
        public static ArrayList cthdns = new ArrayList(); // Mảng chi tiết hóa đơn nhập
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập chi tiết hóa đươn nhập            |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|            Nhập mã chi tiết hóa đơn nhập: ");
            string maCTHDN=Console.ReadLine();
            Console.Write("|            Nhập mã hóa đơn nhập: ");
            string maHDN=Console.ReadLine();
            Console.Write("|            Nhập mã giầy: ");
            string maGiay=Console.ReadLine();
            Console.Write("|            Nhập số lượng: ");
            int soLuong=int.Parse(Console.ReadLine());
            Console.Write("|            Nhập đơn giá nhập: ");
            double donGiaNhap=double.Parse(Console.ReadLine());
            Console.Write("|            Nhập VAT: ");
            string vAT=Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            ChiTietHoaDonNhap cthd = new ChiTietHoaDonNhap(maCTHDN, maHDN, maGiay, soLuong, donGiaNhap,vAT);
            cthdns.Add(cthd);//Thêm đối tượng vài mảng hóa đơn nhập
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}","Ma CTHD","Ma HDN","Ma giay","So luong", "Don gia","Thanh tien","VAT");
            foreach(ChiTietHoaDonNhap cthd in cthdns)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}", cthd.MaCTHDN, cthd.MaHDN, cthd.MaGiay, cthd.SoLuong, cthd.DonGiaNhap, cthd.ThanhTien(cthd.SoLuong, cthd.DonGiaNhap), cthd.VAT);
            }    
        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("CTHDN.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                cthdns.Add(new ChiTietHoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), double.Parse(line.Split(';')[4]), line.Split(';')[5]));

            }
            streamReader.Close();

        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("CTHDN.txt");
            foreach (ChiTietHoaDonNhap hdn in cthdns)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
