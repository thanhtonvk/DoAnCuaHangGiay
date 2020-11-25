using Quanlycuahangbangiay.Bussiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.View
{
    class Run
    {
        public static int Menu()
        {
            Console.WriteLine("                      _________________________________________");
            Console.WriteLine("                     |        1. Quản lý loại giày             |");
            Console.WriteLine("                     |        2. Quản lý mẫu giày              |");
            Console.WriteLine("                     |        3. Quản lý nhà cung cấp          |");
            Console.WriteLine("                     |        4. Quản lý nhân viên             |");
            Console.WriteLine("                     |        5. Quản lý tính lương            |");
            Console.WriteLine("                     |        6. Quản lý giá bán               |");
            Console.WriteLine("                     |        7. Quản lý hóa đơn nhập          |");
            Console.WriteLine("                     |        8. Chi tiết hóa đơn nhập         |");
            Console.WriteLine("                     |        9. Quản lý hóa đơn bán           |");
            Console.WriteLine("                     |       10. Chi tiết hóa đơn bán          |");
            Console.WriteLine("                     |       11. Thoát                         |");
            Console.WriteLine("                      _________________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 11));
            return n;
        }
        public static int MenuLG()
        {
            Console.WriteLine("                      ___________________________");
            Console.WriteLine("                     |   1. Thêm loại giày       |");
            Console.WriteLine("                     |   2. Hiện các loại giày   |");
            Console.WriteLine("                     |   3. Quay lại             |");
            Console.WriteLine("                      ___________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuMG()
        {
            Console.WriteLine("                      _______________________________");
            Console.WriteLine("                     |      1. Thêm mẫu giày         |");
            Console.WriteLine("                     |      2. Hiện các mẫu giày     |");
            Console.WriteLine("                     |      3. Quay lại              |");
            Console.WriteLine("                      _______________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuNCC()
        {
            Console.WriteLine("                      ___________________________________");
            Console.WriteLine("                     |      1. Thêm nhà cung cấp         |");
            Console.WriteLine("                     |      2. Hiện tất cả nhà cung cấp  |");
            Console.WriteLine("                     |      3. Quay lại                  |");
            Console.WriteLine("                      ___________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuNhanVien()
        {
            Console.WriteLine("                      ___________________________________");
            Console.WriteLine("                     |       1. Thêm nhân viên           |");
            Console.WriteLine("                     |       2. Hiện nhân viên           |");
            Console.WriteLine("                     |       3. Xóa nhân viên            |");
            Console.WriteLine("                     |       4. Tìm nhân viên            |");
            Console.WriteLine("                     |       5. Quay lại                 |");
            Console.WriteLine("                      ___________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 4));
            return n;
        }
        public static int MenuTinhLuong()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |     1. Thêm hóa đơn tính lương       |");
            Console.WriteLine("                     |     2. Hiện hóa đơn tính lương       |");
            Console.WriteLine("                     |     3. Tìm hóa đơn                   |");
            Console.WriteLine("                     |     4. Quay lại                      |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 3));
            return n;
        }
        public static int MenuGiaBan()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |           1. Thêm giá giầy           |");
            Console.WriteLine("                     |           2. Hiện giá giầy           |");
            Console.WriteLine("                     |           3. Tìm giá giầy            |");
            Console.WriteLine("                     |           4. Quay lại                |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 3));
            return n;
        }
        public static int MenuHDN()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |        1. Thêm hóa đơn nhập          |");
            Console.WriteLine("                     |        2. Hiện hóa đơn nhập          |");
            Console.WriteLine("                     |        3. Quay lại                   |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuCTHDN()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |    1. Thêm chi tiết hóa đơn nhập     |");
            Console.WriteLine("                     |    2. Hiện chi tiết hóa đơn nhập     |");
            Console.WriteLine("                     |    3. Quay lại                       |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuHDB()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |         1. Thêm hóa đơn bán          |");
            Console.WriteLine("                     |         2. Hiện hóa đơn bán          |");
            Console.WriteLine("                     |         3. Quay lại                  |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static int MenuCTHDB()
        {
            Console.WriteLine("                      ______________________________________");
            Console.WriteLine("                     |    1. Thêm chi tiết hóa đơn ban      |");
            Console.WriteLine("                     |    2. Hiện chi tiết hóa đơn ban      |");
            Console.WriteLine("                     |    3. Quay lại                       |");
            Console.WriteLine("                      ______________________________________");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 || n <= 2));
            return n;
        }
        public static void View()
        {
            do
            {
                switch(Menu())
                {                   
                    case 1:
                        Console.Clear();
                        int chon;
                        do
                        {
                            chon = MenuLG();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapLoaiGiay.them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapLoaiGiay.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon == 1 || chon == 2);
                        break;
                    case 2:
                        Console.Clear();
                        do
                        {
                            chon = MenuMG();
                            switch(chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapMauGiay.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapMauGiay.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            chon = MenuNCC();
                            switch(chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapNCC.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapNCC.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 4:
                        Console.Clear();
                        do
                        {
                            chon = MenuNhanVien();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapNhanVien.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapNhanVien.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã nhân viên cần tìm: ");
                                    string name = Console.ReadLine();
                                    NhapNhanVien.Tim(name);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.Write("Nhập mã nhân viên cần xóa: ");
                                    string ma = Console.ReadLine();
                                    NhapNhanVien.Xoa(ma);
                                    
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 4);
                        break;
                    case 5:
                        Console.Clear();
                        do
                        {
                            chon = MenuTinhLuong();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapTinhLuong.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapTinhLuong.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã tính lương cần tìm: ");
                                    string ma = Console.ReadLine();
                                    NhapTinhLuong.Tim(ma);
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 3);
                        break;
                    case 6:
                        Console.Clear();
                        do
                        {
                            chon = MenuGiaBan();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapGiaBan.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapGiaBan.Hien();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Nhập mã giầy cần tìm giá: ");
                                    string ma = Console.ReadLine();
                                    NhapGiaBan.Tim(ma);
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 3);
                        break;
                    case 7:
                        Console.Clear();
                        do
                        {
                            chon = MenuHDN();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapHoaDonNhap.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapHoaDonNhap.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 8:
                        Console.Clear();
                        do
                        {
                            chon = MenuCTHDN();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapCTHDN.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapCTHDN.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 9:
                        Console.Clear();
                        do
                        {
                            chon = MenuHDB();
                            switch(chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapHoaDonBan.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapHoaDonBan.Hien();
                                    Console.ReadKey();
                                    break;
                                
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 10:
                        Console.Clear();
                        do
                        {
                            chon = MenuCTHDB();
                            switch (chon)
                            {
                                case 1:
                                    Console.Clear();
                                    NhapCTHDB.Them();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    NhapCTHDB.Hien();
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        } while (chon >= 1 && chon <= 2);
                        break;
                    case 11:
                        GhiAllFile();
                        System.Environment.Exit(0);
                        break;
                }
                Console.Clear();
            } while (true);
        }
        public static void DocAllFile()
        {
            NhapCTHDB.Docfile();
            NhapCTHDN.Docfile();
            NhapGiaBan.Docfile();
            NhapHoaDonBan.Docfile();
            NhapHoaDonNhap.Docfile();
            NhapLoaiGiay.Docfile();
            NhapMauGiay.Docfile();
            NhapNCC.Docfile();
            NhapNhanVien.Docfile();
            NhapTinhLuong.Docfile();
        }
        public static void GhiAllFile()
        {
            NhapCTHDB.Ghifile();
            NhapCTHDN.Ghifile();
            NhapGiaBan.Ghifile();
            NhapHoaDonBan.Ghifile();
            NhapHoaDonNhap.Ghifile();
            NhapLoaiGiay.Ghifile();
            NhapMauGiay.Ghifile();
            NhapNCC.Ghifile();
            NhapNhanVien.Ghifile();
            NhapTinhLuong.Ghifile();
        }
        public static void Main()
        {          
            DocAllFile();
            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;
            View();
            Console.ReadKey();
        }

    }
}
