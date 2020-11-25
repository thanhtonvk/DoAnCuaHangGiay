using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapLoaiGiay
    {
        public static ArrayList loaigiays = new ArrayList();
        public static void them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập loại giầy                    |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã giầy: ");
            string magiay = Console.ReadLine();
            Console.Write("|                   Nhập tên giầy: ");
            string tengiay = Console.ReadLine();
            Console.Write("|                   Nhập đặc điểm: ");
            string dacdiem = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            LoaiGiay lg = new LoaiGiay(magiay, tengiay, dacdiem);
            loaigiays.Add(lg);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,20}","Mã giày","Tên giày","Đặc điểm");
            foreach(LoaiGiay lg in loaigiays)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,20}", lg.MaGiay, lg.TenGiay, lg.DacDiem);
            }    
        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("LoaiGiay.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                loaigiays.Add(new LoaiGiay(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("LoaiGiay.txt");
            foreach (LoaiGiay lg in loaigiays)
            {
                streamWriter.WriteLine(lg.ToString());
            }
            streamWriter.Close();
        }

    }
}
