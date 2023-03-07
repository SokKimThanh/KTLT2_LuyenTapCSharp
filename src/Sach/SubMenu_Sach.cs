using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG
{
    internal class SubMenu_Sach
    {
        public void GetSubMenu()
        {
            Sach[] arr = new Sach[10];

            NhapDSSach(arr);
            XuatDSSach(arr);
            // cau 2 tim sach
            Sach sachCanTim;
            string key;
            do
            {
                Console.Write("Vui long nhap tua sach (linear search): ");
                key = Console.ReadLine();
            } while (key == "" || key.Length <= 0);

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

            string keyDelete;
            do
            {
                Console.Write("Vui long nhap ma sach (linear search delete): ");
                keyDelete = Console.ReadLine();
            } while (keyDelete == "" || keyDelete.Length <= 0);
            SupportClass.LinearSeachDeleteAll(ref danhSachxoa, keyDelete);
            XuatDSSach(danhSachxoa);

            // cau 4 tim sach theo binary search
            string maSach = string.Empty;
            int position;

            XuatDSSach(danhSachxoa);

            Array.Reverse(danhSachxoa);
            XuatDSSach(danhSachxoa);

            while (maSach != "exit")
            {
                do
                {
                    Console.Write("Vui long nhap ma sach (binary search): ");
                    maSach = Console.ReadLine();
                } while (maSach == "" || maSach.Length <= 0);
                // sap xep danh sach


                position = SupportClass.BinarySearch(danhSachxoa, maSach);

                if (position != -1)
                {
                    Sach newSach = danhSachxoa[position];
                    newSach.Xuat();
                }
                else
                {
                    Console.WriteLine("Khong tim thay sach {0}", position);
                }
            }

            Console.ReadKey();
        }

        public static void NhapDSSach(Sach[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("Vui long nhap thong tin sach thu {0}", i);
                Sach sach = new Sach();
                sach.Nhap();
                Thread.Sleep(10);
                arr[i] = sach;
            }
        }
        public static void XuatDSSach(Sach[] arr)
        {
            Console.WriteLine($"\n{"Ma Sach",-15}{"Ten Sach",-15}{"Nam San Xuat",15}{"Gia tien",15}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
        }
    }
}
