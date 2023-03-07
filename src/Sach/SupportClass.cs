using System;

namespace KTLT2_TAODOITUONG
{
    internal class SupportClass
    {
        // Giai thuat tim kiem 1 vi tri
        public static int LinearSeach(Sach[] arr, string key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].TenSach == key)
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
        public static void LinearSeachDeleteAll(ref Sach[] arr, string key)
        {
            // cap du mang  
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].MaSach == key)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j++] = arr[i];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
                else
                {
                    i++;
                }
            }
        }

    }
}
