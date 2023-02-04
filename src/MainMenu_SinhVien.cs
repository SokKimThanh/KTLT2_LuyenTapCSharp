using KTLT2_TAODOITUONG.src.RapChieuPhim;
using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class MainMenu_SinhVien
    {
        public static void ShowMainMenu(string[] arrMenu, out List<SinhVien> arrSinhVien, TablePrinter tableSinhVien, TablePrinter tableMenu, out SinhVien svGioiNhat)
        {
            // khai bao
            //SinhVien[] arrSinhVien = new SinhVien[0];
            arrSinhVien = new List<SinhVien>();
            svGioiNhat = new SinhVien();
            int n;
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("Chuong trinh quan ly thong tin Sinh vien");
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long chon command: ");
                int.TryParse(ReadLine(), out n);
                switch (n)
                {
                    case 1:
                        {
                            WriteLine(arrMenu[0]);
                            WriteLine("Vui long nhap so luong sinh vien muon luu diem");
                            int.TryParse(ReadLine(), out int k);
                            arrSinhVien = NhapXuatSinhVien.NhapDSSinhVienList(k);
                            NhapXuatSinhVien.XuatMang1D(arrSinhVien, ref tableSinhVien);
                            tableSinhVien.Print();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 2:
                        {
                            WriteLine(arrMenu[1]);
                            MaHoa.ThaoTacGhiFile($@"D:\Console.txt", arrSinhVien);
                            MaHoa.ThaoTacDocFile($@"D:\Console.txt");
                            MaHoa.ThaoTacMaHoa($@"D:\Console.txt", arrSinhVien);
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 3:
                        {
                            WriteLine(arrMenu[2]);
                            if (arrSinhVien == null || arrSinhVien.Count == 0)
                            {
                                WriteLine("Vui Long nhap sinh vien!");
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            SinhVien.TimSinhVienGioiNhat(arrSinhVien, out svGioiNhat);
                            string diemTBChiTiet = SinhVien.GetDiemTBCT(svGioiNhat);
                            // remove all 
                            tableSinhVien.RemoveAll(arrSinhVien);
                            // add only result.
                            tableSinhVien.AddRow(svGioiNhat.id, svGioiNhat.hoTen, $"{svGioiNhat.ngaySinh:dd/MM/yyyy}", svGioiNhat.diemTBTN, svGioiNhat.xepLoai, diemTBChiTiet);
                            tableSinhVien.Print();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();

                            break;
                        }
                    case 4:
                        {
                            WriteLine(arrMenu[3]);
                            B_GradeBook gradeBook = new B_GradeBook();
                            gradeBook.Main();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 5:
                        {
                            WriteLine(arrMenu[4]);
                            Main_RapChieuPhim rapChieuPhim = new Main_RapChieuPhim();
                            rapChieuPhim.GetSubMenu();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
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
                "Nhap/xuat Danh sach Sinh Vien",
                "Thao doc/ghi tu file thong tin sinh vien: ",
                "In Thong tin sinh vien co diem trung binh tot nghiep lon nhat",
                "Quan ly diem sach",
                "Rap chieu phim",
                "Connect database",
                "Create table Sinh Vien",
                "Create table Bang Diem",
                "Press any key to continous.",
                "-1.Thoat chuong trinh",
            };
            string[] titles = { "MSSV", "Ho Ten", "Ngay Sinh", "Diem trung binh tot nghiep", "Xep loai", "Diem Trung binh chi tiet" };
            string[] menuTitle = { "STT", "Ten chuc nang" };

            TablePrinter tableSinhVien = new TablePrinter(titles);
            TablePrinter tableMenu = new TablePrinter(menuTitle);

            for (int i = 0; i < arrMenu.Length - 5; i++)
            {
                tableMenu.AddRow(i + 1, arrMenu[i]);
            }
            // tao menu nhap xuat sinh vien
            ShowMainMenu(arrMenu, out _, tableSinhVien, tableMenu, out _);

            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
