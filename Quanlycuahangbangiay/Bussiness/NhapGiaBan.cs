using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapGiaBan
    {
        public static ArrayList giabans = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập giá giầy                         |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|               Nhập mã giá bán: ");
            string maGiaBan=Console.ReadLine();
            Console.Write("|                mã giầy: ");
            string maGiay=Console.ReadLine();
            Console.Write("|                giá bán giầy: ");
            double giaBangiay=double.Parse(Console.ReadLine());
            Console.Write("|               Nhập đơn vị tính: ");
            string donvitinh = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            GiaBan gb = new GiaBan(maGiaBan, maGiay, giaBangiay, donvitinh);
            giabans.Add(gb);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}","Ma gia ban","Ma giay","Gia ban giay","Don vi tinh");
            foreach(GiaBan gb in giabans)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}", gb.MaGiaBan,gb.MaGiay,gb.GiaBangiay,gb.DonViTinh);
            }    
        }
        public static void Tim(string ma)
        {
            foreach (GiaBan gb in giabans)
            {
                if(ma.Equals(gb.MaGiay))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", gb.MaGiaBan, gb.MaGiay, gb.GiaBangiay, gb.DonViTinh);
                }    
            }
        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("GiaBan.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                giabans.Add(new GiaBan(line.Split(';')[0], line.Split(';')[1], double.Parse(line.Split(';')[2]), line.Split(';')[3]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("GiaBan.txt");
            foreach (GiaBan gb in giabans)
            {
                streamWriter.WriteLine(gb.ToString());
            }
            streamWriter.Close();
        }
    }
}
