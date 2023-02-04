using System;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    internal class TaoRandom
    {
        public static char TaoKiTuChuThuong()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        public static char TaoKiTuChuHoa()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }
        public static char TaoKiTuSo()
        {
            string chars = "0123456789";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }
        public static string TaoNgaySinhTuDongString()
        {
            Random l = new Random();
            return $"{l.Next(0, 31)}/{l.Next(0, 12)}/{l.Next(1900, DateTime.Now.Year)}";
        }
        public static DateTime TaoNgaySinhTuDongDateTime()
        {
            Random l = new Random();
            return new DateTime(l.Next(1900, DateTime.Now.Year), l.Next(0, 12), l.Next(0, 31));
        }
        public static string TaoIDTuDong(int length)
        {
            Random r = new Random();
            string id = string.Empty;
            for (int i = 0; i < length / 3; i++)
            {
                id += $"{TaoKiTuChuHoa()}{TaoKiTuChuHoa()}{r.Next(1000, 9999)}";
            }
            return id;
        }
        /// <summary>
        /// Hàm này cho phép tạo random trạng thái true/false
        /// </summary>
        /// <returns></returns>
        public static bool RanDomBoolean()
        {
            Random r = new Random();
            var randomBool = r.Next(2) == 1; // 0 = false, 1 = true;
            return randomBool;
        }

        /// <summary>
        /// Hàm kiểm tra thử trước khi sử dụng
        /// </summary>
        public static void UnitTest()
        {
            // khai bao
            string tenHangHoa;
            string maHangHoa;
            string ngayNhap;
            string soLuong;
            string donGia;
            Random r = new Random();
            Random l = new Random();
            Random m = new Random();
            Random n = new Random();

            // kiem tra nhap

            maHangHoa = $"{TaoKiTuChuHoa()}{TaoKiTuChuHoa()}{r.Next(1000, 9999)}";
            WriteLine($"Nhap Ma hang hoa : {maHangHoa}");

            // kiem tra nhap

            tenHangHoa = $"{TaoKiTuChuHoa()}{TaoKiTuChuThuong()}{TaoKiTuChuThuong()} {TaoKiTuChuHoa()}{TaoKiTuChuThuong()}{TaoKiTuChuThuong()}";
            WriteLine($"Nhap Ten hang hoa: {tenHangHoa}");


            // kiem tra nhap

            ngayNhap = $"{l.Next(0, 31)}/{l.Next(0, 12)}/{l.Next(1900, DateTime.Now.Year)}";
            Write($"Nhap ngay nhap hang hoa: {ngayNhap}");

            // kiem tra nhap

            soLuong = $"{m.Next(0, 9999)}";
            WriteLine($"Nhap so luong hang hoa: {soLuong}");

            // kiem tra nhap

            var aNumberAsString = $"{n.Next(100000, 500000):0.####}";

            donGia = aNumberAsString;
            WriteLine($"Nhap don gia hang hoa: {donGia}");

        }
    }
}
