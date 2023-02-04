using System;
using System.Collections.Generic;
using static System.Console;
using System.Threading;
using System.Linq;

namespace KTLT2_TAODOITUONG.src.RapChieuPhim
{
    class RapChieuPhim
    {
        private List<GheNgoi[]> listGheNgoi;
        private GheNgoi[] hangGheArr;

        public RapChieuPhim() { }

        public RapChieuPhim(List<GheNgoi[]> listGheNgoi)
        {
            this.listGheNgoi = listGheNgoi;
        }

        GheNgoi NhapGheNgoi()
        {
            bool trangThaiGheNgoi = TaoRandom.RanDomBoolean();
            MaGhe maGhe = new MaGhe();
            maGhe.AddSoGhe();
            maGhe.AddHangGhe();

            return new GheNgoi(maGhe, trangThaiGheNgoi);
        }
        /// <summary>
        /// Phương thức này tạo ra một danh sách ghê ngồi trong rạp một cách tự động
        /// </summary>
        /// <param name="soHangGhe">Số hàng ghế</param>
        /// <param name="soLuongGhe">Số Lượng ghế</param>
        /// <returns></returns>
        public List<GheNgoi[]> NhapDanhSachGheNgoi(int soHangGhe, int soLuongGhe)
        {
            listGheNgoi = new List<GheNgoi[]>();
            // so hang ghe
            for (int i = 0; i < soHangGhe; i++)
            {
                // so ghe ngoi trong moi hang ghe
                hangGheArr = new GheNgoi[soLuongGhe];
                for (int j = 0; j < hangGheArr.Length; j++)
                {
                    // thong tin moi ghe ngoi
                    hangGheArr[j] = NhapGheNgoi();
                    // random qua nhanh nen so luc nao cung giong nhau can phai lam cham lai
                    Thread.Sleep(1);
                }
                listGheNgoi.Add(hangGheArr);
            }

            return listGheNgoi;
        }


        /// <summary>
        /// Hàm xuất mảng 2d collection danh sách ghế ngồi trong rạp
        /// </summary>
        /// <param name="listGheNgoi"></param>
        public static void XuatMang2D(List<GheNgoi[]> listGheNgoi)
        {
            foreach (var gheNgoi in listGheNgoi)
            {
                foreach (var ghe in gheNgoi)
                {
                    if (ghe != null)
                    {
                        Write(ghe.ToPrint());
                    }
                }
                WriteLine("\n");
            }
        }
        /// <summary>
        /// Hàm xuất mảng 2d collection Hang ghế ngồi trong rạp
        /// </summary>
        /// <param name="hangGheArr"></param>
        public static string XuatMang2D(GheNgoi[] hangGheArr)
        {
            string sumS = string.Empty;
            foreach (var gheNgoi in hangGheArr)
            {
                sumS += gheNgoi.ToPrint();
            }
            return sumS;
        }
        /// <summary>
        /// Hàm tính số ghê trống mỗi hàng
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] TongSoLuongGheTrongMoiHang(List<GheNgoi[]> arr)
        {
            // loc ra so hang ghe dai nhat
            int[] soGheNgoiMoiHangGheArr = new int[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                int count = 0;
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j].getTrangThaiGheTrong() == true)
                    {
                        count++;
                    }
                }
                soGheNgoiMoiHangGheArr[i] = count;
            }
            return soGheNgoiMoiHangGheArr;
        }
        /// <summary>
        /// Hàm tính số ghê trống mỗi dãy trong rạp
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] TongSoLuongGheTrongMoiDay(List<GheNgoi[]> arr)
        {
            // loc ra so hang ghe dai nhat
            int[] soGheTheoDay = new int[arr[0].Length];

            for (int i = 0; i < arr.Count; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j].getTrangThaiGheTrong() == true)
                    {
                        soGheTheoDay[j] += 1;
                    }
                }
            }
            return soGheTheoDay;
        }
        /// <summary>
        /// Hàm tính tổng số ghê trống trong rạp
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int TongSoLuongGheTrongRap(List<GheNgoi[]> arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j].getTrangThaiGheTrong() == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        /// <summary>
        /// Hàm tính số cặp ghê trống theo hàng trong rạp
        /// </summary>
        /// <param name="arr">Danh sách ghế có trong rạp</param>
        /// <returns>Số lượng cặp ghế trống</returns>
        public int[] TongSoLuongCapGheTrongTrongRap(List<GheNgoi[]> arr)
        {

            // loc ra so hang ghe dai nhat
            int[] soCapGheTrongTheoDay = new int[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                int count = 0;
                for (var j = 0; j < arr[i].Length - 1; j++)
                {
                    if (arr[i][j].getTrangThaiGheTrong() == true && arr[i][j + 1].getTrangThaiGheTrong() == true)
                    {
                        count++;
                    }
                }
                soCapGheTrongTheoDay[i] = count;
            }
            return soCapGheTrongTheoDay;
        }
        /// <summary>
        /// Hàm tim hang co nhieu ghế trống nhất
        /// </summary>
        /// <param name="arr">Danh sách ghế có trong rạp</param>
        /// <returns>Số lượng cặp ghế trống</returns>
        public GheNgoi[] TimHangGheCoNhieuChoTrongNhat(List<GheNgoi[]> arr)
        {
            // loc ra so hang ghe dai nhat
            int[] arrInt = TongSoLuongGheTrongMoiHang(arr);
            int max = arrInt[0];
            for (int i = 0; i < arrInt.Length - 1; i++)
            {
                if (max < arrInt[i + 1])
                {
                    max = arrInt[i + 1];
                    hangGheArr = arr[i + 1];
                }
            }
            return hangGheArr;
        }
        /// <summary>
        /// Hàm kiem tra hang ghe het cho trong
        /// </summary>
        /// <param name="hangGheArr">Danh sách ghế có trong rạp</param>
        /// <returns>True tra ve ket qua hang ghe da het cho trong; False tra về hàng ghế vẫn còn chỗ trống</returns>
        private bool KiemTraHangGheHetChoTrong(GheNgoi[] hangGheArr)
        {
            foreach (var gheNgoi in hangGheArr)
            {
                // tim thay hang ghe nay van con cho trong
                if (gheNgoi.getTrangThaiGheTrong() == true)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Hàm tìm hàng ghế đã hết chỗ trống
        /// </summary>
        /// <param name="danhSachGheNgoi"></param>
        /// <returns></returns>
        public GheNgoi[] TimHangGheHetChoTrong(List<GheNgoi[]> danhSachGheNgoi)
        {
            hangGheArr = new GheNgoi[0];
            foreach (var hangGheArr in danhSachGheNgoi)
            {
                if (KiemTraHangGheHetChoTrong(hangGheArr))
                {
                    this.hangGheArr = hangGheArr;
                }
            }
            return hangGheArr;
        }
        public bool KiemTraGheTrong(GheNgoi a)
        {
            if (a.getTrangThaiGheTrong() == false)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Hàm kiêm tra ghê ngồi ngoài biên đã hết chỗ trống hay chưa?
        /// </summary>
        /// <param name="arr">Danh sách ghế ngồi trong rạp</param>
        /// <returns>False : TÌm thấy ghế trống/ True: không còn ghế trống</returns>
        public List<GheNgoi[]> KiemTraGheTrongNgoaiBien(List<GheNgoi[]> arr)
        {
            GheNgoi[] hangGheTrongdauBien = new GheNgoi[arr[0].Length];
            GheNgoi[] hangGheTrongCuoiBien = new GheNgoi[arr[0].Length];
            List<GheNgoi[]> danhSachGheNgoi = new List<GheNgoi[]>();

            for (int i = 0; i < arr.Count; i++)
            {
                //false : đã đặt chỗ/ true: còn trống chỗ
                if (KiemTraGheTrong(arr[i][0]))
                {
                    // tìm thấy một chỗ còn trống biên đầu
                    hangGheTrongdauBien[i] = arr[i][0];
                }
                if (KiemTraGheTrong(arr[i][arr[i].Length - 1]))
                {
                    // tìm thấy một chỗ còn trống biên cuối 
                    hangGheTrongCuoiBien[i] = arr[i][arr[i].Length - 1];
                }
            }
            danhSachGheNgoi.Add(hangGheTrongdauBien);
            danhSachGheNgoi.Add(hangGheTrongCuoiBien);
            return danhSachGheNgoi;
        }
    }
}
