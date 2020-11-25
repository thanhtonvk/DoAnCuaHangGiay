using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapMauGiay
    {
        public static ArrayList maugiays = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập mẫu giầy                     |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã giầy: ");
            string magiay = Console.ReadLine();
            Console.Write("|                   Nhập tên giầy: ");
            string tengiay = Console.ReadLine();
            Console.Write("|                   Nhập mã loại giầy: ");
            string maloai = Console.ReadLine();
            Console.Write("|                    số lượng nhập: ");
            int slNhap = int.Parse(Console.ReadLine());
            Console.Write("|                   Nhập số lượng hiện có: ");
            int slHienco = int.Parse(Console.ReadLine());
            Console.WriteLine(" _____________________________________________________");
            MauGiay mg = new MauGiay(magiay, tengiay, maloai, slNhap, slHienco);
            maugiays.Add(mg);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,20}|{4,20}","Ma giay","Ten Giay","Ma Loai","So luong nhap","So luong hien co");
            foreach(MauGiay mg in maugiays)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,20}|{4,20}", mg.MaGiay, mg.TenGiay, mg.MaLoai, mg.SlNhapve, mg.SlHienco);
            }    
        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("MauGiay.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                maugiays.Add(new MauGiay(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), int.Parse(line.Split(';')[4])));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("MauGiay.txt");
            foreach (MauGiay mg in maugiays )
            {
                streamWriter.WriteLine(mg.ToString());
            }
            streamWriter.Close();
        }
    }
}
