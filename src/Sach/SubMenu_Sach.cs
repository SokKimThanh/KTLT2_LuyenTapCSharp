using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG
{
    internal class SubMenu_Sach
    {
        public void GetSubMenu()
        {
            Sach[] arr = new Sach[3];
            NhapDSSach(arr);
            XuatDSSach(arr);
            // cau 2 tim sach
            Sach sachCanTim;
            string key = Console.ReadLine();
            if (SupportClass.LinearSeach(arr, key) != -1)
            {
                sachCanTim = arr[SupportClass.LinearSeach(arr, key)];
                sachCanTim.Xuat();
            }
            else
            {
                Console.WriteLine("Khong tim thay sach {0}", key);
            }

            // cau 3 xoa sach theo ma sach
            Sach[] danhSachxoa = arr;
            string keyDelete = Console.ReadLine();
            SupportClass.LinearSeachDeleteAll(ref danhSachxoa, keyDelete);

            Console.ReadKey();
        }

        public static void NhapDSSach(Sach[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Vui long nhap thong tin sach thu {0}", i);
                Sach sach = new Sach();
                sach.Nhap();
                arr[i] = sach;
            }
        }
        public static void XuatDSSach(Sach[] arr)
        {
            Console.WriteLine($"{"Ma Sach",-15}{"Ten Sach",-15}{"Nam San Xuat",15}{"Gia tien",15}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
        }
    }
}
