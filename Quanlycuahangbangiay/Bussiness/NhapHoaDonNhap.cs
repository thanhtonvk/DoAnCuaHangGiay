using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapHoaDonNhap
    {
        public static ArrayList hoadonnhaps = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập hóa đơn nhập                 |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã hóa đơn nhập: ");
            string maHDN=Console.ReadLine();
            Console.Write("|                    mã nhân viên: ");
            string maNCC=Console.ReadLine();
            Console.Write("|                    mã nhân viên giao: ");
            string nvGiao=Console.ReadLine();
            Console.Write("|                   Nhập mã nhân viên nhận: ");
            string maNvNhan=Console.ReadLine();
            Console.Write("|                   Nhập ngày nhận: ");
            string ngayNhan=Console.ReadLine();
            Console.Write("|                   Nhập tổng tiền: ");
            double tongTien=double.Parse(Console.ReadLine());
            Console.Write("|                   Nhập trạng thái: ");
            string trangThai=Console.ReadLine();
            Console.Write("|                   Nhập số tiền đã thanh toán: ");
            double daTT=double.Parse(Console.ReadLine());
            double conNo=tongTien-daTT;
            Console.Write("|                   Nhập ghi chú: ");
            string ghiChu=Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            HoaDonNhap hdn = new HoaDonNhap(maHDN, maNCC, nvGiao, maNvNhan, ngayNhan, tongTien, trangThai, daTT, conNo, ghiChu);
            hoadonnhaps.Add(hdn);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}|{7,15}|{8,15}|{9,15}", "Mã HDN","Ma NCC","Ma NvGiao","Ma NvNhan","Tong tien","Trang thai","Thanh toan","Con no","Ghi chu");
            foreach(HoaDonNhap hdn in hoadonnhaps)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}|{7,15}|{8,15}|{9,15}", hdn.MaHDN,hdn.MaNCC,hdn.NvGiao,hdn.MaNvNhan,hdn.NgayNhan,hdn.TongTien,hdn.TrangThai,hdn.DaTT,hdn.ConNo,hdn.GhiChu);
            }    

        }
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("HoaDonNhap.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                hoadonnhaps.Add(new HoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], double.Parse(line.Split(';')[5]), line.Split(';')[6], double.Parse(line.Split(';')[7]), double.Parse(line.Split(';')[8]), line.Split(';')[9]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("HoaDonNhap.txt");
            foreach (HoaDonNhap hdn in hoadonnhaps)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
