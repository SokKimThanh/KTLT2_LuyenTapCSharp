using KTLT2_TAODOITUONG.src.TimKiemSapXep;
using System;
using static System.Console;
/*
 * Sok Kim Thanh
 * 9/4/2023 3:12PM;
 */
namespace KTLT2_TAODOITUONG.src.KeThua
{
    class Submenu_nhanvien
    {
        static void ShowMainMenu(DanhSachMenu arrMenu)
        {
            // khai bao
            int menuNumber;
            DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien();
            TruongPhong truongPhong = new TruongPhong();
            do
            {
                Clear();
                Console.ForegroundColor = ConsoleColor.White;
                // tao menu chuong trinh 
                WriteLine("BAI TAP KIEM TRA QUA TRINH: ");
                WriteLine("\n---------------------------------------------------------------------\n");
                WriteLine("Chuong trinh thu nghiem ke thua nhan vien - truong phong");
                // kiem tra nhap
                arrMenu.ShowAllMenu();
                // nhap lenh
                Write($"Vui long nhap command hoac '-1' de ket thuc chuong trinh: ");
                int.TryParse(ReadLine(), out menuNumber);

                try
                {
                    arrMenu.ShowMenuBySTT(menuNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (menuNumber)
                {
                    case 1:  //"Nhap Thong tin mang gom n nhan vien"
                        {
                            Console.WriteLine("Vui long nhap so nhan vien can tao");

                            int soLuongNhanVien = Ultilities.NhapSoNguyen();
                            danhSachNhanVien = new DanhSachNhanVien();
                            // them vao danh sach nhan vien
                            for (int i = 0; i < soLuongNhanVien; i++)
                            {
                                NhanVien nv = new NhanVien();
                                nv.Nhap();
                                danhSachNhanVien.ThemVaoDanhSach(nv);
                            }
                            Console.WriteLine("Them thanh cong!");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Press any key to back for menu.");
                            ReadKey();
                            break;
                        }
                    case 2:  //Nhap Thong tin 1  truong phong
                        {
                            Console.WriteLine("Vui long nhap thong tin truong phong");

                            truongPhong.Nhap();
                            danhSachNhanVien.ThemVaoDanhSach(truongPhong);
                            Console.WriteLine("Them thanh cong!");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Press any key to back for menu.");
                            ReadKey();
                            break;
                        }
                    case 3:  //Xuat ra thong tin nhan vien
                        {
                            Console.WriteLine("Xuat thong tin cac nhan vien");

                            danhSachNhanVien.HienThiDanhSach();

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Press any key to back for menu.");
                            ReadKey();
                            break;
                        }
                    case 4:  //Xuat ra thong tin truong phong
                        {
                            Console.WriteLine("Xuat thong tin truong phong");
                            Console.WriteLine(truongPhong.Xuat());

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Press any key to back for menu.");
                            ReadKey();
                            break;
                        }
                    default:
                        {
                            if (menuNumber == -1)
                            {
                                Console.WriteLine(arrMenu.ShowMenuBySTT(-1));
                                ReadKey();
                                break;
                            }
                            break;
                        }
                }

            } while (menuNumber != -1);
        }

        public void GetSubMenu()
        {
            string[] arrMenu = new string[] {
                "Nhap Thong tin mang gom n nhan vien",
                "Nhap Thong tin 1  truong phong ",
                "Xuat ra thong tin nhan vien",
                "Xuat ra thong tin truong phong",
                "Press any key to continue.",
                "-1.Thoat chuong trinh",
            };
            DanhSachMenu arrMenuS = new DanhSachMenu();
            for (int i = 0; i < arrMenu.Length; i++)
            {
                arrMenuS.AddMenu(new Menu(arrMenu[i]));
            }
            arrMenuS.ShowAllMenu();

            ShowMainMenu(arrMenuS);
            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
