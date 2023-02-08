/*
 * 6:49 5/2/2023 Sok Kim Thanh
 * Submenu bảng thống kê kết quả tuyển sinh
 */
using KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh;
using KTLT2_TAODOITUONG.src.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class SubMenu_BangThongKeKetQuaTuyenSinh
    {

        public void ShowMenu(TablePrinter tableMenu, string[] arrMenu)
        {
            int n;
            DoiTuongTuyenSinh[] dsDTTS = new DoiTuongTuyenSinh[] { }; ;
            LoaiKhoa[] dsLoaiKhoa = new LoaiKhoa[] { };
            ThiSinh[] dsThiSinh = new ThiSinh[] { };
            KetQuaTuyenSinh[] dsKetQuaTS = new KetQuaTuyenSinh[] { };
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
                            //Kiem tra danh
                            if (dsThiSinh == null || dsThiSinh.Length == 0)
                            {
                                WriteLine("Vui long nhap danh sach thi sinh");
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            if (dsLoaiKhoa == null || dsLoaiKhoa.Length == 0)
                            {
                                WriteLine("Vui long nhap danh sach loai khoa");
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            if (dsDTTS == null || dsDTTS.Length == 0)
                            {
                                WriteLine("Vui long nhap danh sach doi tuong tuyen sinh");
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            // format table
                            WriteLine("Xuat danh sach tuyen sinh");
                            dsKetQuaTS = KetQuaTuyenSinh.NhapDanhSachKQTS(dsThiSinh, dsLoaiKhoa, dsDTTS);
                            tableThongKe = KetQuaTuyenSinh.XuatMang1D(dsKetQuaTS);
                            tableThongKe.Print();
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 5:// Sắp xếp bảng tính tăng dần theo cột họ tên
                        {
                            WriteLine(arrMenu[4]);
                            //KetQuaTuyenSinh ketqquaTsmax = dsKetQuaTS[0];

                            // Kiem Tra ket qua
                            if (dsKetQuaTS == null || dsKetQuaTS.Length == 0)
                            {
                                WriteLine("Vui long nhap danh sach ket qua tuyen sinh");
                                WriteLine(arrMenu[arrMenu.Length - 2]);
                                ReadKey();
                                break;
                            }
                            // in ket qua 1
                            WriteLine("Danh sach ket qua tuyen sinh chua duoc sap xep");
                            tableThongKe = KetQuaTuyenSinh.XuatMang1D(dsKetQuaTS);
                            tableThongKe.Print();

                            // khai bao
                            List<KetQuaTuyenSinh> ketQuaTuyenSinhList = new List<KetQuaTuyenSinh>();
                            for (int i = 0; i < dsKetQuaTS.Length - 1; i++)
                            {
                                ketQuaTuyenSinhList.Add(dsKetQuaTS[i]);
                            }

                            // sap xep danh sach thi sinh
                            // sort đối tượng theo cột họ và tên;
                            WriteLine("Sap xep danh sach thi sinh theo họ tên");
                            ketQuaTuyenSinhList.Sort((ketqua1, ketQua2) => ketqua1.GetThiSinh().GetHoVaTen().CompareTo(ketQua2.GetThiSinh().GetHoVaTen()));

                            // in ket qua 2
                            tableThiSinh = KetQuaTuyenSinh.XuatMang1D(ketQuaTuyenSinhList);
                            tableThiSinh.Print();

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
                "Nhap/Xuat Danh Sach Thong Ke Ket qua Tuyen Sinh",
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