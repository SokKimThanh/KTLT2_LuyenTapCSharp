using KTLT2_TAODOITUONG.src.Author;
using KTLT2_TAODOITUONG.src.BTTH2._1;
using KTLT2_TAODOITUONG.src.DSArrayList_LinkedList;
using KTLT2_TAODOITUONG.src.KeThua;
using KTLT2_TAODOITUONG.src.RapChieuPhim;
using KTLT2_TAODOITUONG.src.TimKiemSapXep;
using System;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class MainMenu
    {
        public static void ShowMainMenu(DanhSachMenu arrMenu)
        {
            int n;
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("Chuong trinh quan ly thong tin tong hop");
                arrMenu.ShowAllMenu();
                // nhap lenh
                Write($"Vui long nhap command hoac '-1' de ket thuc chuong trinh: ");
                int.TryParse(ReadLine(), out n);
                try
                {
                    WriteLine(arrMenu.ShowMenuBySTT(n-1).toString());
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
                switch (n)
                {
                    case 1: // Chuong trinh quan ly sinh vien
                        {

                            SubMenu_SinhVien submenu = new SubMenu_SinhVien();
                            submenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 2:// chuong trinh nhap diem 
                        {

                            SubMenu_Sach gradeBook = new SubMenu_Sach();
                            gradeBook.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 3: // rap chieu phim 
                        {

                            SubMenu_RapChieuPhim rapChieuPhim = new SubMenu_RapChieuPhim();
                            rapChieuPhim.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 4:// Bảng thống kê kết quả tuyển sinh
                        {

                            SubMenu_BangThongKeKetQuaTuyenSinh bangTuyenSinh = new SubMenu_BangThongKeKetQuaTuyenSinh();
                            bangTuyenSinh.GetSubmenu();
                            ReadKey();
                            break;
                        }
                    case 5:// bai tap thuc hanh so 2.1
                        {

                            SubMenu_btth21_BuildInTypeString subMenu = new SubMenu_btth21_BuildInTypeString();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 6:// Quan ly thoi gian
                        {

                            SubMenu_Time subMenu = new SubMenu_Time();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 7:// Quan ly author
                        {

                            Submenu_Author subMenu = new Submenu_Author();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 8:// Quan ly Tim Kiem 
                        {

                            SubMenu_TimKiemSapXep subMenu = new SubMenu_TimKiemSapXep();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }

                    case 9:// Quan ly sap xep
                        {

                            Submenu_SapXep subMenu = new Submenu_SapXep();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 10:// Ke thua nhan vien - truong phong
                        {

                            Submenu_nhanvien subMenu = new Submenu_nhanvien();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 11:// thu nghiem Danh sach lien ket linkedlist
                        {

                            Submenu_LinkedList subMenu = new Submenu_LinkedList();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    case 12:// thu nghiem Danh sach array list
                        {

                            Submenu_ArrayList subMenu = new Submenu_ArrayList();
                            subMenu.GetSubMenu();
                            ReadKey();
                            break;
                        }
                    default:
                        {
                            ReadKey();
                            break;
                        }
                }

            } while (n != -1);
        }

        static void Main(string[] args)
        {
            string[] arrMenu = new string[] {
                "Quan ly sinh vien",
                "Quan ly sach",
                "Rap chieu phim",
                "Bang thong ke ket qua tuyen sinh",
                "Chuong 2: Mot so kieu du lieu xay dung san trong c#(string)",
                "Quan ly thoi gian",
                "Quan ly Tac gia",
                "Quan ly Tim Kiem",
                "Quan ly Sap xep",
                "Ke thua nhan vien - truong phong",
                "Thu nghiem Danh sach lien ket linkedlist",
                "Thu nghiem Danh sach arrayList",
                "-1.Thoat chuong trinh",
            };
            DanhSachMenu arrMenuS = new DanhSachMenu();

            for (int i = 0; i < arrMenu.Length; i++)
            {
                arrMenuS.AddMenu(new Menu(arrMenu[i]));
            }

            ShowMainMenu(arrMenuS);
            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
