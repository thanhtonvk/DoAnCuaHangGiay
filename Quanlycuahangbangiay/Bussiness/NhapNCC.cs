using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapNCC
    {
        public static ArrayList nccs = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập nhà cung cấp                 |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã nhà cung cấp: ");
            string mancc = Console.ReadLine();
            Console.Write("|                   Nhập tên nhà cung cấp: ");
            string tenncc = Console.ReadLine();
            Console.Write("|                   Nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.Write("|                   Nhập số điện thoại: ");
            string sdt = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            NCC nc = new NCC(mancc, tenncc, diachi, sdt);
            nccs.Add(nc);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,25}|{2,30}|{3,15}", "Ma NCC","TenNCC","Dia chi", "So dien thoai");
            foreach(NCC nc in nccs)
            {
                Console.WriteLine("{0,10}|{1,25}|{2,30}|{3,15}", nc.MaNCC, nc.TenNCC, nc.DiaChi, nc.Sdt);
            }    
        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("NhaCungCap.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                nccs.Add(new NCC(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("NhaCungCap.txt");
            foreach (NCC nc in nccs)
            {
                streamWriter.WriteLine(nc.ToString());
            }
            streamWriter.Close();
        }
    }
}
