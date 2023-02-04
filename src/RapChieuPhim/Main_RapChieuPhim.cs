using System;
using System.Collections.Generic;
using static System.Console;

namespace KTLT2_TAODOITUONG.src.RapChieuPhim
{
    /// <summary>
    /// Lớp đối tượng này là menu điều khiển lựa chọn cho chương trình rạp chiếu phim
    /// </summary>
    class Main_RapChieuPhim
    {
        private void ShowMainMenu(string[] arrMenu, TablePrinter tableMenu)
        {
            // khai bao
            int n;
            RapChieuPhim rapChieuPhim = new RapChieuPhim();
            List<GheNgoi[]> danhSachGheNgoiTrongRap = new List<GheNgoi[]>();
            NhapXuat nx = new NhapXuat();
            // thuc hien menu
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("Chuong trinh quan ly thong tin Rap chieu phim");
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long chon command: ");
                int.TryParse(ReadLine(), out n);
                switch (n)
                {
                    case 1:
                        {
                            WriteLine(arrMenu[0]);
                            int soHangGhe;
                            int soLuongGhe;
                            do
                            {
                                Write("Vui long nhap so luong hang ghe: ");
                            } while (int.TryParse(ReadLine(), out soHangGhe) == false);

                            do
                            {
                                Write("Vui long nhap so luong ghe 1 hang: ");
                            } while (int.TryParse(ReadLine(), out soLuongGhe) == false);

                            danhSachGheNgoiTrongRap = rapChieuPhim.NhapDanhSachGheNgoi(soHangGhe, soLuongGhe);
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            //end
                            WriteLine(arrMenu[arrMenu.Length - 2]);
                            ReadKey();
                            break;
                        }
                    case 2:
                        {
                            WriteLine(arrMenu[1]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            int[] soLuongGheTrong = rapChieuPhim.TongSoLuongGheTrongMoiHang(danhSachGheNgoiTrongRap);
                            WriteLine($"Tong so luong ghe trong rap la: {rapChieuPhim.TongSoLuongGheTrongRap(danhSachGheNgoiTrongRap)}");
                            ReadKey();
                            break;
                        }
                    case 3:
                        {
                            WriteLine(arrMenu[2]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            int[] soLuongGheTrong = rapChieuPhim.TongSoLuongGheTrongMoiHang(danhSachGheNgoiTrongRap);
                            WriteLine($"Tong so luong ghe trong moi hang la: {nx.XuatMang1D(soLuongGheTrong)}");
                            ReadKey();
                            break;
                        }
                    case 4:
                        {
                            WriteLine(arrMenu[3]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            int[] soLuongGheTrong = rapChieuPhim.TongSoLuongGheTrongMoiDay(danhSachGheNgoiTrongRap);
                            WriteLine($"Tong so luong ghe trong moi day la: {nx.XuatMang1D(soLuongGheTrong)}");
                            ReadKey();
                            break;
                        }
                    case 5://so cap ghe trong theo hang
                        {
                            WriteLine(arrMenu[4]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            int[] soLuongGheTrong = rapChieuPhim.TongSoLuongCapGheTrongTrongRap(danhSachGheNgoiTrongRap);
                            WriteLine($"Tong so cap ghe trong theo hang la: {nx.XuatMang1D(soLuongGheTrong)}");
                            ReadKey();
                            break;
                        }
                    case 6://Tim hang co nhieu ghe trong nhat
                        {
                            WriteLine(arrMenu[5]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            GheNgoi[] hangGheArr = rapChieuPhim.TimHangGheCoNhieuChoTrongNhat(danhSachGheNgoiTrongRap);
                            WriteLine($"Hang co nhieu ghe trong nhat la: {RapChieuPhim.XuatMang2D(hangGheArr)}");
                            ReadKey();
                            break;
                        }
                    case 7://Tim hang ghe het cho trong
                        {
                            WriteLine(arrMenu[6]);
                            if (danhSachGheNgoiTrongRap.Count == 0 || danhSachGheNgoiTrongRap == null)
                            {
                                WriteLine("chua co danh sach vui long nhap lai!");
                                ReadKey();
                                break;
                            }
                            RapChieuPhim.XuatMang2D(danhSachGheNgoiTrongRap);
                            GheNgoi[] hangGheArr = rapChieuPhim.TimHangGheHetChoTrong(danhSachGheNgoiTrongRap);

                            if (hangGheArr.Length == 0 || hangGheArr == null)
                            {
                                WriteLine($"Chua tim thay hang ghe nao het cho trong!");
                                ReadKey();
                                break;
                            }
                            WriteLine($"Hang khong co ghe trong nao la: {RapChieuPhim.XuatMang2D(hangGheArr)}");
                            ReadKey();
                            break;
                        }
                    default:
                        break;
                }
            }
            while (n != -1);
        }
        public void Main()
        {
            // tao menu rap chieu phim
            string[] arrMenu = new string[]
            {
                "Nhap/Xuat random thong tin ghe ngoi trong rap.",
                "Tong so ghe ngoi con trong trong rap",
                "So luong ghe trong tung hang",
                "So luong ghe trong tung day",
                "So cap ghe trong theo hang",
                "Tim Hang co nhieu ghe trong nhat",
                "Tim hang da het cho trong",
                "Kiem tra tat ca cac ghe o ngoai bien duoc dat het hay chua",
                "Press any key to continous.",
                "-1.Tro ve",
            };

            string[] titles = { "stt", "Chuc nang" };

            TablePrinter tableMenu = new TablePrinter(titles);
            // menu nay la menu cua rap chieu phim
            tableMenu.NhapMenu(arrMenu);

            // tao menu nhap xuat ghe ngoi trong rap chieu phim
            ShowMainMenu(arrMenu, tableMenu);
        }
    }
}
