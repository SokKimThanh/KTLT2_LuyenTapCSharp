using System;
using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class NhapXuatBangDiem
    {
        public static void XuatMang2D(List<BangDiem[]> arr)
        {
            foreach (var a in arr)
            {
                foreach (var s in a)
                {
                    Write($"{s.diemSo}\t");
                }
                WriteLine("\n");
            }
        }
        public static BangDiem[] XuatMang2D(BangDiem[,] arr, int n)
        {
            if (n < 0)
            {
                WriteLine("Bang diem chua nhap duoc");
            }
            BangDiem[] bangDiem1D = new BangDiem[n];
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bangDiem1D[count] = arr[i, j];
                    count++;
                }
            }
            return bangDiem1D;
        }

        public static BangDiem NhapBangDiem(int namH, int hocK)
        {
            string namHoc;
            string hocKy;
            double diemSo;
            namHoc = $"Nam hoc {namH}";
            hocKy = $"Hoc ky {hocK}";
            diemSo = new Random().NextDouble();
            return new BangDiem(namHoc, hocKy, diemSo);
        }

        /// <summary>
        /// Hàm nhập bảng điểm
        /// </summary>
        /// <param name="n">Số dòng</param>
        /// <param name="m">Số cột</param>
        /// <returns>Danh sách bảng điểm</returns>
        public static BangDiem[,] NhapDSBangDiem(int n, int m)
        {
            BangDiem[,] bangDiem = new BangDiem[n, m];
            for (int i = 0; i < bangDiem.GetLength(0); i++)
            {
                for (int j = 0; j < bangDiem.GetLength(1); j++)
                {
                    bangDiem[i, j] = NhapBangDiem(i, j);
                }
            }
            return bangDiem;
        }
        /// <summary>
        /// Hàm nhập bảng điểm list
        /// </summary>
        /// <param name="n">n dòng</param>
        /// <param name="m">m cột</param>
        /// <returns></returns>
        public static List<BangDiem[]> NhapDSBangDiemList(int n, int m)
        {
            List<BangDiem[]> bangDiem = new List<BangDiem[]>();
            for (int i = 0; i < n; i++)
            {
                BangDiem[] arr = new BangDiem[m];
                for (int j = 0; j < m; j++)
                {
                    arr[j] = NhapBangDiem(i, j);
                }
                bangDiem.Add(arr);
            }
            return bangDiem;
        }
        /// <summary>
        /// Xuat bảng diểm chi tiết 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string XuatMang1D(BangDiem[] arr)
        {
            string sum = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].ToPrint();
            }
            return sum;
        }
        /// <summary>
        /// Hàm xuất mảng 2 chiều bảng điểm
        /// </summary>
        /// <param name="arr"></param>
        static void XuatMang2D(BangDiem[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"{arr[i, j].ToPrint()}\t");
                }
                WriteLine("\n");
            }
        }
        /// <summary>
        /// Xuất bảng điểm chi tiết theo loại
        /// </summary>
        /// <param name="bangdiem"></param>
        /// <returns></returns>
        public static string XuatMang1D(object bangdiem)
        {
            string sum = string.Empty;
            List<BangDiem[]> w = new List<BangDiem[]>();
            if (w.GetType().ToString() == bangdiem.GetType().ToString())
            {
                List<BangDiem[]> arr = (List<BangDiem[]>)bangdiem;
                foreach (var k in arr)
                {
                    foreach (var s in k)
                    {
                        sum += s.ToPrint();
                    }
                }
            }
            return sum;
        }
    }
}
