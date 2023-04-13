using System;
using System.Threading;

/*
 * Sok Kim Thanh
 * 13/04/2023
 */
namespace KTLT2_TAODOITUONG.src.DSArrayList_LinkedList
{
    class Submenu_ArrayList
    {
        public void GetSubMenu()
        {
            // khai bao
            Random d = new Random();
            int n;
            Console.WriteLine("Cap phat mang so nguyen n phan tu: ");
            n = Ultilities.NhapSoNguyen();
            MyArrayList arr = new MyArrayList(n);
            arr.Add(1);
            arr.PrintList();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("count: " + arr.Count + "");
                arr.Add(d.Next(1, 20));
                Thread.Sleep(10);
            }
            arr.PrintList();
            Console.WriteLine("count: " + arr.Count + "");
            Console.WriteLine("press any key to back");
            Console.ReadKey();
        }
    }
}
