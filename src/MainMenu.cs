using KTLT2_TAODOITUONG.src.BTTH2._1;
using KTLT2_TAODOITUONG.src.RapChieuPhim; 
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class MainMenu
    {
        public static void ShowMainMenu(string[] arrMenu, TablePrinter tableMenu)
        {
            int n;
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("Chuong trinh quan ly thong tin tong hop");
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long nhap command hoac '-1' de ket thuc chuong trinh: ");
                int.TryParse(ReadLine(), out n);
                switch (n)
                {
                    case 1: // Chuong trinh quan ly sinh vien
                        {
                            WriteLine(arrMenu[0]);
                            SubMenu_SinhVien submenu = new SubMenu_SinhVien();
                            submenu.GetSubMenu();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 2:// chuong trinh nhap diem 
                        {
                            WriteLine(arrMenu[1]);
                            SubMenu_Sach gradeBook = new SubMenu_Sach();
                            gradeBook.GetSubMenu();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 3: // rap chieu phim 
                        {
                            WriteLine(arrMenu[2]);
                            SubMenu_RapChieuPhim rapChieuPhim = new SubMenu_RapChieuPhim();
                            rapChieuPhim.GetSubMenu();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 4:// Bảng thống kê kết quả tuyển sinh
                        {
                            WriteLine(arrMenu[3]);
                            SubMenu_BangThongKeKetQuaTuyenSinh bangTuyenSinh = new SubMenu_BangThongKeKetQuaTuyenSinh();
                            bangTuyenSinh.GetSubmenu();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 5:// bai tap thuc hanh so 2.1
                        {
                            WriteLine(arrMenu[4]);
                            SubMenu_btth21_BuildInTypeString subMenu = new SubMenu_btth21_BuildInTypeString();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 6:// Quan ly thoi gian
                        {
                            WriteLine(arrMenu[5]);
                            SubMenu_Time subMenu = new SubMenu_Time();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 7:// Quan ly Tim Kiem Va sap xep
                        {
                            WriteLine(arrMenu[6]);
                            SubMenu_TimKiemSapXep subMenu = new SubMenu_TimKiemSapXep();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    default:
                        {
                            if (n == -1)
                            {
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            break;
                        }
                }

            } while (n != -1);
        }

        static void Main(string[] args)
        {
            string[] arrMenu = new string[] {
                "Quan ly sinh vien",
                "Quan ly diem sach",
                "Rap chieu phim",
                "Bang thong ke ket qua tuyen sinh",
                "Chuong 2: Mot so kieu du lieu xay dung san trong c#(string)",
                "Quan ly thoi gian",
                "Quan ly Tim Kiem Va sap xep",
                "Press any key to continue.",
                "-1.Thoat chuong trinh",
            };
            string[] menuTitle = { "STT", "Ten chuc nang" };

            TablePrinter tableMenu = new TablePrinter(menuTitle);
            tableMenu.NhapMenu(arrMenu);
            ShowMainMenu(arrMenu, tableMenu);
            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
