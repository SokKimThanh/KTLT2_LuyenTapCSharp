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
        internal void GetSubMenu()
        {
            // khai bao
            Random d = new Random();
            int n = 0;
            int key;
            WriteLine("BAI TAP O LOP: ");
            WriteLine("\n---------------------------------------------------------------------\n");
            WriteLine("CHUONG TRINH LINEAR SEARCH CHUA DUOC SAP XEP");
            // kiem tra nhap
            do
            {
                Write("Nhap n: ");
            } while (int.TryParse(ReadLine(), out n) == false);


            WriteLine("Ban nhap " + n + " so tu dong");

            // nhap 
            // int[] arr = Utililies.NhapRandomMangSoNguyen(n, d);
            int[] arr = { 0, -1, 8, 8, 8, 8, -1, 8 };
            // xuat
            Utililies.Xuat(arr);
            WriteLine();
            // nhap key thuat toan chua sap xep unoder linear search
            WriteLine("---------------------------------------------------------------------");
            WriteLine("Thuat toan linear search(chua sap xep)".ToUpper());
            Write("Vui long nhap key: ");
            int.TryParse(ReadLine(), out key);

            // unorder linear search
            int vitriDauTien = Utililies.UnorderLinearSearch(arr, key);
            // in ket qua
            if (vitriDauTien != -1)
            {
                WriteLine("Tim thay key = " + key + " tai vi tri: " + vitriDauTien);
            }
            else
            {
                WriteLine("Khong Tim thay key = " + key + " tai bat ky vi tri nao.");
            }


            WriteLine("\n\n---------------------------------------------------------------------");
            WriteLine("CAI TIEN CHUONG TRINH \nLINEAR SEARCH TIM KEY TAI TAT CA VI TRI");
            int[] arrIndex = Utililies.TimTatCaViTriX(arr, key);
            if (arrIndex.Length != 0)
            {
                WriteLine("\nDanh sach index xuat hien la: ");
                Utililies.Xuat(arrIndex.ToArray());
            }
            WriteLine("\n");
            WriteLine("\n\n---------------------------------------------------------------------");


            WriteLine("\n\n---------------------------------------------------------------------");
            WriteLine("XOAT TAT CA VI TRI KEY");
            int[] arrRemovedIndex = arr;
            Utililies.XoaTatCa(ref arrRemovedIndex, key);
            if (arrIndex.Length != 0)
            {
                WriteLine("\nDanh sach sau khi xoa: ");
                Utililies.Xuat(arrRemovedIndex);
            }
            WriteLine("\n");
            WriteLine("\n\n---------------------------------------------------------------------");
            //WriteLine("\n\n---------------------------------------------------------------------");
            //WriteLine("CAI TIEN CHUONG TRINH LINEAR SEARCH BANG PHUONG PHAP SAP XEP TRUOC KHI TIM KIEM");

            ////sort list
            //WriteLine("\n  CHUONG TRINH DANG SAP XEP DANH SACH....\n");
            //Array.Sort(arr);
            //WriteLine("\n Danh SACH SAU KHI SAP XEP LA: \n");
            //Utililies.Xuat(arr);

            ////VA BAT DAU TIM KIEM CAI TIEN LINEAR SEARCH...
            //WriteLine("\nVui long nhap key ban muon tim? ");
            //key = int.Parse(ReadLine());

            //// order linear search
            //int ketquaOrderLNS = Utililies.OrderLinearSearch(arr, key);

            //WriteLine("--------------------------------------------------------------------------------");
            //WriteLine("CAI TIEN THUAT TOAN KIEM KIEM BANG THUAT TOAN BINARY SEARCH( DANH SACH CHUA DUOC ");

            //// Binary search
            //// sort list        
            //int ketquaBS = Utililies.BinarySearch(arr, key);

            ////in ket qua 
            //WriteLine("{0, -10} {1,-10}", "Vi tri order linear search", ketquaOrderLNS);
            //WriteLine("{0, -10} {1,-10}", "Vi tri binary search", ketquaBS);

            //int ketquaInscreseBS = Utililies.IncreaseOrderBinarySearch(arr, key);

            //// dao nguoc sap xep giam dan
            //Array.Reverse(arr);
            //int ketquaDecreaseBS = Utililies.DecreaseOrderBinarySearch(arr, key);

            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
