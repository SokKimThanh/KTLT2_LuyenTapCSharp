using System;
using static System.Console;
/**
 * Sok kim thanh
 * date 28/03/2023
 */

namespace KTLT2_TAODOITUONG.src.TimKiemSapXep
{
    class Submenu_SapXep
    {
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
                WriteLine("CHUONG TRINH CAI DAT GIAI THUAT SAP XEP");
                // kiem tra nhap
                tableMenu.Print();
                // nhap lenh
                Write($"Vui long nhap command hoac '-1' de ket thuc chuong trinh: ");
                int.TryParse(ReadLine(), out menuNumber);
                Console.WriteLine("Nhap n:");
                //int k = Ultilities.NhapSoNguyen();
                int k = 50;// so phan tu cua mang arr
                WriteLine(arrMenu[menuNumber]);
                switch (menuNumber)
                {
                    case 0: // Interchange sort giam dan
                        {

                            // khai bao
                            int[] arr;
                            int power = 0;// power: so lan thuc hien cong viec
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            // interchange sort 
                            // duyet mang arr den cuoi mang

                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // hoan vi cap nghich the
                                // tim cap nghich the 
                                for (int j = i + 1; j < arr.Length; j++)
                                {
                                    if (arr[i] < arr[j])
                                    {
                                        Ultilities.Swap(ref arr[i], ref arr[j]);
                                        power++;
                                    }
                                }
                            }
                            Console.WriteLine("ket qua so lan lap interchange sort giam dan:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 1: // Interchange sort tang dan
                        {

                            // khai bao
                            int[] arr;
                            int power = 0;// power: so lan thuc hien cong viec
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            // interchange sort 
                            // duyet mang arr den cuoi mang

                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // hoan vi cap nghich the
                                // tim cap nghich the 
                                for (int j = i + 1; j < arr.Length; j++)
                                {
                                    if (arr[i] > arr[j])
                                    {
                                        Ultilities.Swap(ref arr[i], ref arr[j]);
                                        power++;
                                    }
                                }
                            }
                            Console.WriteLine("ket qua so lan lap interchange sort tang dan:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 2: // Interchange sort tang dan cai tien
                        {

                            // khai bao
                            int[] arr;
                            int power = 0;// power: so lan thuc hien cong viec
                            bool check;// check hoan thanh sap xep
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            // interchange sort 
                            // duyet mang arr den cuoi mang

                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // khai bao
                                check = false;
                                // hoan vi cap nghich the
                                // tim cap nghich the 
                                for (int j = i + 1; j < arr.Length; j++)
                                {
                                    if (arr[i] > arr[j])
                                    {
                                        Ultilities.Swap(ref arr[i], ref arr[j]);
                                        check = true;
                                        power++;
                                    }
                                }
                                if (check == false)
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("ket qua so lan lap interchange sort tang dan cai tien:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 3: // bubble sort
                        {

                            // khai bao
                            int[] arr;
                            int power = 0;
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            //  bubble sort
                            //  dua thang lon nhat ve cuoi day
                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // hoan vi cap nghich the
                                // tim cap nghich the 
                                for (int j = 0; j < arr.Length - 1; j++)
                                {
                                    if (arr[j] < arr[j + 1])
                                    {
                                        Ultilities.Swap(ref arr[j], ref arr[j + 1]);
                                        power++;
                                    }
                                }
                            }
                            Console.WriteLine("ket qua so lan lap bubble sort:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 4: // bubble sort cai tien (day co sap xep)
                        {
                            // khai bao
                            int[] arr;
                            int power = 0;
                            bool check = false;// kiem tra dung luot sap xep
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            //  bubble sort
                            //  dua thang lon nhat ve cuoi day
                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // hoan vi cap nghich the
                                // tim cap nghich the 
                                for (int j = 0; j < arr.Length - 1; j++)
                                {
                                    if (arr[j] < arr[j + 1])
                                    {
                                        Ultilities.Swap(ref arr[j], ref arr[j + 1]);
                                        power++;
                                        check = true;// con luot sap xep
                                    }
                                }
                                // het luot sap xep
                                if (check == false)
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("ket qua so lan lap bubble sort cai tien:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 5: // selection sort ( tim min )
                        {
                            // khai bao
                            int[] arr;
                            int power = 0;
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            //  selection sort
                            //  dua thang lon nhat ve cuoi day
                            for (int i = 0; i < arr.Length - 1; i++)
                            {
                                // hoán vị với pos min
                                int posMin = Ultilities.FindPosMin(arr, i);
                                // check trung vi tri pos min va i la vi tri nho nhat
                                if (posMin != i)
                                {
                                    Ultilities.Swap(ref arr[posMin], ref arr[i]);
                                    power++;
                                }
                            }
                            Console.WriteLine("ket qua so lan lap selection sort:  " + power);
                            Ultilities.XuatLine(arr);

                            ReadKey();
                            break;
                        }
                    case 6: // insertion sort (dat v vao vi tri thich hop)
                        {
                            // khai bao
                            int[] arr;
                            int power = 0;
                            arr = Ultilities.NhapRandomMangSoNguyen(k);
                            Console.WriteLine("new arr: " + arr.Length);
                            Ultilities.XuatLine(arr);
                            //  insertion sort
                            //  bat dau tu 1
                            int i; // vi tri bat dau tim
                            int pos; // vi tri phia truoc i;
                            int v;// chep v vao vi tri thich hop
                            for (i = 1; i < arr.Length; i++)
                            {
                                pos = i - 1;// vi tri phia truoc i;
                                v = arr[i];// save point gia tri arr[i]!
                                // xet dieu kien pos tiep tuc con dich sang trai va gia tri tai vi tri pos nho hon V de chep sang phai tat ca gia tri truoc i
                                while (pos >= 0 && arr[pos] < v)
                                {
                                    arr[pos + 1] = arr[pos];
                                    pos--;// dich sang trai tiep tuc dieu kien
                                    power++;
                                }
                                // het dieu kien
                                arr[pos + 1] = v;// chep v vao vi tri thich hop
                            }
                            Console.WriteLine("ket qua so lan lap insertion sort (dat v vao vi tri thich hop):  " + power);
                            Ultilities.XuatLine(arr);

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
                "interchange sort giam dan",
                "interchange sort tang dan",
                "interchange sort tang dan cai tien",
                "bubble sort",
                "bubble sort cai tien",
                "selection sort (dua gia tri lon nhat ve cuoi day) ",
                "insertion sort (dat v vao vi tri thich hop)",
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
