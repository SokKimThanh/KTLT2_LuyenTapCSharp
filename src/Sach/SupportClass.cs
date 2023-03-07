using System;
using System.Text.RegularExpressions;

namespace KTLT2_TAODOITUONG
{
    internal class SupportClass
    {
        // Giai thuat tim kiem 1 vi tri
        public static int LinearSeach(Sach[] arr, string key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].TenSach.ToLower().Contains(key.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }
        // Giai thuat tim kiem tat ca vi tri
        public static Sach[] LinearSeachAll(Sach[] arr, Sach key)
        {
            // cap du mang
            Sach[] arrNew = new Sach[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    arr[j++] = arr[i];
                }
            }
            return arrNew;
        }
        // Giai thuat xoa tat ca vi tri
        public static void LinearSeachDeleteAll(ref Sach[] arr, string maSach)
        {
            // cap du mang  
            for (int i = 0; i < arr.Length;)
            {
                if (arr[i].MaSach.ToLower() == maSach.ToLower())
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
                else
                {
                    i++;
                }
            }
        }
        /// <summary>
        /// Tìm sách theo thuật toán binary seach
        /// </summary>
        /// <param name="arr">Danh sach doi tuong</param>
        /// <param name="maSach">Ma sach</param>
        /// <returns></returns>
        public static int BinarySearch(Sach[] arr, string maSach)
        {
            // xuat ket qua
            int location = -1;
            int left = 0;
            int mid = -1;
            int right = arr.Length - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid].MaSach.ToLower().Contains(maSach.ToLower()))
                    location = mid;
                else if (arr[mid].MaSach.ToLower().CompareTo(maSach.ToLower()) > 0)
                    left = mid + 1;
                else right = mid - 1;
            }
            return location;
        }
    }
}
