/*
 * 6:49 5/2/2023 Sok Kim Thanh
 * Submenu bảng thống kê kết quả tuyển sinh
 */
using KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh;
using System;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class SubMenu_BangThongKeKetQuaTuyenSinh
    {

        public void ShowMenu(TablePrinter tableMenu, string[] arrMenu)
        {
            int n;
            KetQuaTuyenSinh bangThongKe;
            DoiTuongTuyenSinh[] dsDTTS;
            LoaiKhoa[] dsLoaiKhoa;
            ThiSinh[] dsThiSinh;
            KetQuaTuyenSinh[] dsKetQuaTS;
            TablePrinter tableLoaiKhoa;
            TablePrinter tableThongKe;
            TablePrinter tableThiSinh;
            TablePrinter tableDoiTuongTuyenSinh;
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("Chuong trinh Thong ke ket qua tuyen sinh");
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long chon command: ");
                int.TryParse(ReadLine(), out n);
                switch (n)
                {
                    case 1://Nhap/xuat nhap danh sach doi tuong tuyen sinh
                        {
                            WriteLine(arrMenu[0]);
                            // khai bao
                            WriteLine("Vui Long nhap danh doi tuong tuyen sinh: ");
                            int.TryParse(ReadLine(), out int k);
                            // format table
                            dsDTTS = DoiTuongTuyenSinh.NhapDanhSanhDoiTuongTuyenSinh(k);
                            WriteLine("Xuat danh sach doi tuong tuyen sinh");
                            tableDoiTuongTuyenSinh = DoiTuongTuyenSinh.XuatMang1D(dsDTTS);
                            tableDoiTuongTuyenSinh.Print();

                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 2:// Nhap/Xuat loai khoa
                        {
                            WriteLine(arrMenu[1]);
                            // khai bao
                            WriteLine("Vui Long nhap danh sach khoa: ");
                            int.TryParse(ReadLine(), out int k);
                            // format table
                            WriteLine("Xuat danh sach loai khoa");
                            dsLoaiKhoa = LoaiKhoa.NhapDanhSachLoaiKhoa(k);
                            tableLoaiKhoa = LoaiKhoa.XuatMang1D(dsLoaiKhoa);
                            tableLoaiKhoa.Print();

                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 3:// Nhap/Xuat Thi Sinh;
                        {
                            WriteLine(arrMenu[2]);
                            // khai bao
                            WriteLine("Vui Long nhap danh thi sinh: ");
                            int.TryParse(ReadLine(), out int k);
                            // format table
                            WriteLine("Xuat danh sach thi sinh");
                            dsThiSinh = ThiSinh.NhapDanhSachThiSinh(k);
                            tableThiSinh = ThiSinh.XuatMang1D(dsThiSinh);
                            tableThiSinh.Print();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 4://Nhập danh sách kết quả tuyển sinh
                        {
                            WriteLine(arrMenu[3]);
                            WriteLine("Vui Long nhap danh ket qua tuyen sinh: ");
                            int.TryParse(ReadLine(), out int k);
                            // format table
                            WriteLine("Xuat danh sach tuyen sinh");
                            dsKetQuaTS = KetQuaTuyenSinh.NhapDanhSachKQTS(k);
                            tableThiSinh = KetQuaTuyenSinh.XuatMang1D(dsKetQuaTS);
                            tableThiSinh.Print();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 5:
                        {
                            WriteLine(arrMenu[4]);

                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 6:
                        {
                            WriteLine(arrMenu[5]);

                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 7:
                        {
                            WriteLine(arrMenu[6]);

                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 8:
                        {
                            WriteLine(arrMenu[7]);
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 9:
                        {
                            WriteLine(arrMenu[8]);
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    default:
                        {
                            if (n == -1)
                            {
                                WriteLine(arrMenu[arrMenu.Length - 1]);
                                ReadKey();
                                break;
                            }
                            ReadKey();
                            break;
                        }
                }
            } while (n != -1);
        }
        public void GetSubmenu()
        {
            var submenu = new string[] {
                "Nhap/Xuat danh sach doi tuong tuyen sinh",
                "Nhap/Xuat danh sach loai khoa",
                "Nhap/xuat danh sach thi sinh",
                "Nhap Danh Sach Thong Ke Ket qua Tuyen Sinh",
                "Xuat ten khoa",
                "Xuat ten doi tuong tuyen sinh",
                "Xuat ten phong hoc",
                "Xuat ket qua tong diem",
                "Xuat Danh Sach Thong Ke Ket qua Tuyen Sinh",
                "Sap xep bang tinh tang dan theo cot ho ten",
                "Sap xep ma khoa, tong diem, ma khoa tang dan, tong diem giam dan",
                "Press any key to continue.",
                "-1. Tro ve."
            };
            var titles = new string[] { "stt", "Chuc nang" };
            TablePrinter tableMenu = new TablePrinter(titles);
            tableMenu.NhapMenu(submenu);
            ShowMenu(tableMenu, submenu);
        }
    }
}