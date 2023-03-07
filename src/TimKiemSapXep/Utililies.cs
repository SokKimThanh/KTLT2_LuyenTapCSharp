using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    public class Utililies
    {
        public static int BinarySearch(int[] arrInt, int key)
        {
            // xuat ket qua
            int left = 0;
            int right = arrInt.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arrInt[mid] == key)
                    return mid;
                else if (arrInt[mid] < key)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        public static int UnorderLinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] TimTatCaViTriX(int[] arr, int key)
        {
            // khai bao mang rong chua co phan tu nao
            List<int> arrIndex = new List<int>();
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    arrIndex.Add(i);
                    check = true;
                }
            }
            if (check == false)
            {
                Write($"Khong tim thay {key}");
            }
            return arrIndex.ToArray();
        }

        public static void XoaTatCa(ref int[] arr, int key)
        {
            for (int i = 0; i < arr.Length;)
            {
                // tim key
                if (arr[i] == key)
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

        public static int OrderLinearSearch(int[] arr, int key)
        {
            int kqCuoiCung = 0;
            // xuat ket qua
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    kqCuoiCung = i;
                else if (arr[i] > key)
                    // khong tim thay 7 > 4
                    break;
                else
                {
                    kqCuoiCung = -1;
                }
            }
            return -1;
        }
        public static int[] NhapRandomMangSoNguyen(int n, Random d)
        {
            int[] arr = new int[n];
            // nhap ran dom thong tin
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = d.Next(0, 20);
            }
            return arr;
        }

        internal static int IncreaseOrderBinarySearch(int[] arrInt, int key)
        {
            // xuat ket qua
            int left = 0;
            int right = arrInt.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arrInt[mid] == key)
                    return mid;
                else if (arrInt[mid] < key)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        internal static int DecreaseOrderBinarySearch(int[] arrInt, int key)
        {
            // xuat ket qua
            int left = 0;
            int right = arrInt.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arrInt[mid] == key)
                    return mid;
                else if (arrInt[mid] < key)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        public static void Xuat(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{arr[i]}\t");
            }
        }
    }
}
