using KTLT2_TAODOITUONG.src.Author;
using KTLT2_TAODOITUONG.src.BTTH2._1;
using KTLT2_TAODOITUONG.src.RapChieuPhim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class SubMenu_TimKiemSapXep
    {
        public static void UnorderBinarySearch(int[] arr)
        {
            int key = Ultilities.NhapSoNguyen();
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("CAI TIEN THUAT TOAN KIEM KIEM BANG THUAT TOAN BINARY SEARCH( Chua sap xep)".ToUpper());

            // Binary search
            // sort list        
            int ketquaBS = Ultilities.BinarySearch(arr, key);

            //in ket qua  
            WriteLine("{0, -10} {1,-10}", "Vi tri binary search ", ketquaBS);
        }
        public static void DeleteAllWithKey(ref int[] arr)
        {
            WriteLine("\n\n---------------------------------------------------------------------");
            WriteLine("XOA TAT CA VI TRI KEY");
            int key = Ultilities.NhapSoNguyen();
            Ultilities.DeleteAllWithKey(ref arr, key);
            if (arr.Length != 0)
            {
                WriteLine("\nDanh sach sau khi xoa: ");
                Ultilities.XuatLine(arr);
            }
        }
        public static void SearchAllWithOrderLinearSearch(int[] arr)
        {
            int key;
            WriteLine("\n\n---------------------------------------------------------------------");
            WriteLine("CAI TIEN CHUONG TRINH LINEAR SEARCH BANG PHUONG PHAP SAP XEP TRUOC KHI TIM KIEM");

            //sort list
            WriteLine("\n  CHUONG TRINH DANG SAP XEP DANH SACH....\n");
            Array.Sort(arr);
            WriteLine("\n Danh SACH SAU KHI SAP XEP LA: \n");
            Ultilities.XuatLine(arr);

            //VA BAT DAU TIM KIEM CAI TIEN LINEAR SEARCH...
            WriteLine("\nVui long nhap key ban muon tim? ");
            key = int.Parse(ReadLine());

            // order linear search
            int ketquaOrderLNS = Ultilities.IncreaseLinearSearch(arr, key);
            //in ket qua 
            WriteLine("{0, -10} {1,-10}", "Vi tri order linear search", ketquaOrderLNS);
        }
        public static void SearchAllWithLinearSearchKey(int[] arr)
        {
            WriteLine("\n\n---------------------------------------------------------------------");
            WriteLine("CAI TIEN CHUONG TRINH \nLINEAR SEARCH TIM KEY TAI TAT CA VI TRI");
            int key = Ultilities.NhapSoNguyen();
            int[] arrIndex = Ultilities.SearchAllWithKey(arr, key);
            if (arrIndex.Length != 0)
            {
                WriteLine("\nDanh sach index xuat hien la: " + Ultilities.XuatString(arrIndex.ToArray()));
            }
            WriteLine("\n");
            WriteLine("\n\n---------------------------------------------------------------------");
        }
        public static void SearchOneWithUnOderLinearSearch(int[] arr)
        {
            // nhap key thuat toan chua sap xep unoder linear search
            WriteLine("---------------------------------------------------------------------");
            WriteLine("Thuat toan linear search(chua sap xep)".ToUpper());
            Write("Vui long nhap key: ");
            int key = Ultilities.NhapSoNguyen();

            // unorder linear search
            int vitriDauTien = Ultilities.UnorderLinearSearch(arr, key);
            // in ket qua
            if (vitriDauTien != -1)
            {
                WriteLine("Tim thay key = " + key + " tai vi tri: " + vitriDauTien);
            }
            else
            {
                WriteLine("Khong Tim thay key = " + key + " tai bat ky vi tri nao.");
            }

            WriteLine("Press any key to exit.");
            ReadKey();
        }
        /// <summary>
        /// Hàm nhập xuất
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="d"></param>
        public static void NhapXuat(out int[] arr)
        {
            // nhap 
            int n = Ultilities.NhapSoNguyen();
            Random d = new Random();
            arr = Ultilities.NhapRandomMangSoNguyen(n);
            //int[] arr = { 0, -1, 8, 8, 8, 8, -1, 8 };
            // xuat
            Ultilities.XuatLine(arr);
            WriteLine();
        }
        private static void SearchAllWithReverserLinearSearch(int[] arr)
        {
            // dao nguoc sap xep giam dan
            Array.Reverse(arr);
            Ultilities.XuatLine(arr);
            int key = Ultilities.NhapSoNguyen();
            int ketquaDecreaseBS = Ultilities.DecreaseLinearSearch(arr, key);
            //in ket qua  
            WriteLine("{0, -10} {1,-10}", "Vi tri ReverserLinearSearch", ketquaDecreaseBS);
        }

        private static void DeleteAllWithSearchAllLinearSearch(int[] arr)
        {
            // nhap key thuat toan chua sap xep unoder linear search
            WriteLine("---------------------------------------------------------------------");
            WriteLine("Thuat toan delete with linear search all (da sap xep)".ToUpper());

            Array.Sort(arr);
            Ultilities.XuatLine(arr);

            Write("Vui long nhap key: ");
            int key = Ultilities.NhapSoNguyen();
            // in ket qua
            Ultilities.DeleteAllWithSearchAllLinearSearch(ref arr, key);
            if (arr.Length == 0)
            {
                WriteLine($"Không còn gì để xóa.");
            }
            WriteLine($"Xoa thanh cong [key = {key}].");
            Ultilities.XuatLine(arr);

            WriteLine("Press any key to exit.");
            ReadKey();
        }

        private static void DeleteAllWithSearchOneLinearSearch(int[] arr)
        {
            // nhap key thuat toan chua sap xep unoder linear search
            WriteLine("---------------------------------------------------------------------");
            WriteLine("Thuat toan delete with linear search one (chua sap xep)".ToUpper());
            Write("Vui long nhap key: ");
            int key = Ultilities.NhapSoNguyen();
            // in ket qua
            if (Ultilities.DeleteAllWithSearchOneLinearSearch(ref arr, key) == true)
            {
                WriteLine($"Xoa Thanh cong key {key}");
            }
            else
            {
                WriteLine($"Khong the xoa key {key}");
            }
            Ultilities.XuatLine(arr);

            WriteLine("Press any key to exit.");
            ReadKey();
        }

        private static void OrderBinarySearch(int[] arr)
        {
            // nhap key thuat toan chua sap xep unoder linear search
            WriteLine("---------------------------------------------------------------------");
            WriteLine("Thuat toan Binary Search all with order( da sap xep )".ToUpper());
            Array.Sort(arr);
            Ultilities.XuatLine(arr);
            Write("Vui long nhap key: ");
            int key = Ultilities.NhapSoNguyen();
            int[] newBinaryIndex = Ultilities.BinarySearchAllWithKey(ref arr, key);
            Array.Sort(newBinaryIndex);
            // in ket qua
            if (newBinaryIndex.Length != 0)
            {
                WriteLine($"Tim thay key {key} tai cac vi tri: [{Ultilities.XuatString(newBinaryIndex)}]");
            }
            else
            {
                WriteLine($"Khong tim thay key {key} tai bat ky vi tri nao.");
            }

            WriteLine("Press any key to exit.");
            ReadKey();
        }
        static void ShowMainMenu(string[] arrMenu, TablePrinter tableMenu)
        {
            // khai bao
            int menuNumber;
            do
            {
                Clear();
                // tao menu chuong trinh 
                WriteLine("BAI TAP O LOP: ");
                WriteLine("\n---------------------------------------------------------------------\n");
                WriteLine("CHUONG TRINH CAI DAT GIAI THUAT TIM KIEM");
                // kiem tra nhap
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long nhap command hoac '-1' de ket thuc chuong trinh: ");
                int.TryParse(ReadLine(), out menuNumber);
                switch (menuNumber)
                {
                    case 0: // Search one with unorder Linear Search
                        {
                            WriteLine(arrMenu[0]);
                            int[] arr;
                            NhapXuat(out arr);
                            SearchOneWithUnOderLinearSearch(arr);

                            ReadKey();
                            break;
                        }
                    case 1: // Search one with Order Linear Search
                        {
                            WriteLine(arrMenu[1]);
                            int[] arr;
                            NhapXuat(out arr);
                            SearchAllWithOrderLinearSearch(arr);

                            ReadKey();
                            break;
                        }
                    case 2: // Search one with Reserve Linear Search
                        {
                            WriteLine(arrMenu[2]);
                            int[] arr;
                            NhapXuat(out arr);
                            SearchAllWithReverserLinearSearch(arr);

                            ReadKey();
                            break;
                        }
                    case 3: // Search all with linear Search key
                        {
                            WriteLine(arrMenu[3]);
                            int[] arr;
                            NhapXuat(out arr);
                            SearchAllWithLinearSearchKey(arr);

                            ReadKey();
                            break;
                        }
                    case 4: // Delete all with key
                        {
                            WriteLine(arrMenu[4]);
                            int[] arr;
                            NhapXuat(out arr);
                            DeleteAllWithKey(ref arr);

                            ReadKey();
                            break;
                        }
                    case 5: // Delete all with Search all linear search
                        {
                            WriteLine(arrMenu[5]);
                            int[] arr;
                            NhapXuat(out arr);
                            DeleteAllWithSearchAllLinearSearch(arr);

                            ReadKey();
                            break;
                        }
                    case 6: // Delete all with Search one linear search
                        {
                            WriteLine(arrMenu[6]);
                            int[] arr;
                            NhapXuat(out arr);
                            DeleteAllWithSearchOneLinearSearch(arr);

                            ReadKey();
                            break;
                        }
                    case 7: // Binary Search unorder
                        {
                            WriteLine(arrMenu[7]);
                            int[] arr;
                            NhapXuat(out arr);
                            UnorderBinarySearch(arr);

                            ReadKey();
                            break;
                        }
                    case 8: // Binary Search all with order
                        {
                            WriteLine(arrMenu[8]);
                            int[] arr;
                            NhapXuat(out arr);
                            OrderBinarySearch(arr);

                            ReadKey();
                            break;
                        }
                    default:
                        {
                            if (menuNumber == -1)
                            {
                                WriteLine(arrMenu[arrMenu.Length - 2]);
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
                "Search one with unorder Linear Search",
                "Search one with Order Linear Search",
                "Search one with Reserve Linear Search",

                "Search all with linear Search key",

                "Delete all with key",
                "Delete all with Search all linear search",
                "Delete all with Search one linear search",

                "Binary Search all with unorder",
                "Binary Search all with order",

                "Press any key to continue.",
                "-1.Thoat chuong trinh",
            };
            string[] menuTitle = { "STT", "Ten chuc nang" };

            TablePrinter tableMenu = new TablePrinter(menuTitle);
            tableMenu.NhapMenu(arrMenu, 0);
            ShowMainMenu(arrMenu, tableMenu);

            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
