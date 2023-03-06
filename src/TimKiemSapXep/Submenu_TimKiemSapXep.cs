using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ThuatToan
{
    class SubMenu_TimKiemSapXep
    {
        internal void GetSubMenu()
        {
            Random d = new Random();
            WriteLine("Vui long nhap co bao nhieu phan tu ma ban muon nhap?");
            int n;
            int.TryParse(ReadLine(), out n);

            // nhap 
            int[] arr = Utililies.NhapRandomMangSoNguyen(n, d);
            // xuat
            Utililies.Xuat(arr.ToArray());

            WriteLine("Vui long nhap key ban muon tim? ");
            int key = int.Parse(ReadLine());

            // unorder linear search
            int ketquaUnorderLNS = Utililies.UnorderLinearSearch(arr, key);
            WriteLine("{0, -10} {1,-10}", "Vi tri unorder linear search", ketquaUnorderLNS);

            WriteLine("\nVui long nhap key ban muon tim? ");
            key = int.Parse(ReadLine());

            //sort list
            WriteLine("\n Sap xep mang\n");
            Array.Sort(arr);
            //Array.Reverse(arr); dao nguoc sap xep giam dan
            Utililies.Xuat(arr);

            // order linear search
            int ketquaOrderLNS = Utililies.OrderLinearSearch(arr, key);

            // Binary search
            // sort list        
            int ketquaBS = Utililies.BinarySearch(arr, key);

            //in ket qua 
            WriteLine("{0, -10} {1,-10}", "Vi tri order linear search", ketquaOrderLNS);
            WriteLine("{0, -10} {1,-10}", "Vi tri binary search", ketquaBS);


            //int ketquaInscreseBS = Utililies.IncreaseOrderBinarySearch(arr, key);


            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
