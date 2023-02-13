using KTLT2_TAODOITUONG.src.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    internal class SubMenu_SinhVien
    {

        /// <summary>
        /// Chuong trinh gọi chức năng của sub menu
        /// </summary>
        /// <param name="tableSubMenu"></param>
        void ShowSubmenu(TablePrinter tableSubMenu, string[] arrMenu)
        {
            int n = 0;
            // khai bao
            //SinhVien[] arrSinhVien = new SinhVien[0];
            List<SinhVien> arrSinhVien = new List<SinhVien>();
            SinhVien svGioiNhat = new SinhVien();
            string[] titles = { "MSSV", "Ho Ten", "Ngay Sinh", "Diem trung binh tot nghiep", "Xep loai", "Diem Trung binh chi tiet" };
            TablePrinter tableSinhVien = new TablePrinter(titles);
            do
            {
                try
                {
                    Clear();
                    tableSubMenu.Print();
                    WriteLine(TaoMenuMessage.pressKeyToEnterCommandOrExit);
                    int.TryParse(ReadLine(), out n); //FormatException
                }
                catch (FormatException ex)
                {
                    WriteLine(ex.Message);
                    WriteLine("Vui long khong duoc de trong!");
                }
                switch (n)
                {
                    case 1:
                        {
                            WriteLine(arrMenu[0]);
                            WriteLine("Vui long nhap so luong sinh vien muon luu diem");
                            int.TryParse(ReadLine(), out int k);
                            arrSinhVien = NhapXuatSinhVien.NhapSinhVienList(k);
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

                    default:
                        {
                            if (n == -1)
                            {
                                WriteLine(TaoMenuMessage.pressKeyToBye);
                                ReadKey();
                                break;
                            }
                            break;
                        }
                }

            } while (n != -1);
        }
        /// <summary>
        /// Chức năng cài đặt submenu để sử dụng ở chương trình chính
        /// Tách lớp submenu build in type string
        /// </summary>
        internal void GetSubMenu()
        {
            var submenu = new string[] {
            "Nhap/xuat Danh sach Sinh Vien",
            "Thao doc/ghi tu file thong tin sinh vien: ",
            "In Thong tin sinh vien co diem trung binh tot nghiep lon nhat",
            "Connect database",
            "Create table Sinh Vien",
            "Create table Bang Diem",
            };
            var titles = new string[] { "Stt", "Chuc nang" };
            TablePrinter tableSubMenu = new TablePrinter(titles);
            tableSubMenu.NhapMenu(submenu);
            ShowSubmenu(tableSubMenu, submenu);
        }
    }
}
