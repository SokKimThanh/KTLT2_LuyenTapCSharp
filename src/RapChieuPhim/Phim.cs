/*
 * Bai tap o lop
 * Sok Kim thanh 1/3/2023 4:47
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.RapChieuPhim
{
    internal class Phim
    {
        /// <summary>
        /// Tên phim
        /// </summary>
        private string tenPhim;
        /// <summary>
        /// Ngày phát hành
        /// </summary>
        private DateTime ngayPhatHanh;
        /// <summary>
        /// Giá sản xuất
        /// </summary>
        private double giaSanXuat;
        /// <summary>
        /// Giá vé gốc
        /// </summary>
        private int giaVeGoc;

        public string TenPhim
        {
            get
            {
                return tenPhim;
            }

            set
            {
                tenPhim = value;
            }
        }

        public DateTime NgayPhatHanh
        {
            get
            {
                return ngayPhatHanh;
            }

            set
            {
                ngayPhatHanh = value;
            }
        }

        public double GiaSanXuat
        {
            get
            {
                return giaSanXuat;
            }

            set
            {
                giaSanXuat = value;
            }
        }

        public int GiaVeGoc
        {
            get
            {
                return giaVeGoc;
            }

            set
            {
                giaVeGoc = value;
            }
        }

        /// <summary>
        /// Hàm khởi tạo đối tượng phim
        /// </summary>
        /// <param name="tenPhim">Tên phim</param>
        /// <param name="ngayPhatHanh">ngày phát hành</param>
        /// <param name="giaSanXuat">Giá sản xuất</param>
        /// <param name="giaVeGoc">Giá vé gốc</param>
        public Phim(string tenPhim, DateTime ngayPhatHanh, double giaSanXuat, int giaVeGoc)
        {
            this.TenPhim = tenPhim;
            this.NgayPhatHanh = ngayPhatHanh;
            this.GiaSanXuat = giaSanXuat;
            this.GiaVeGoc = giaVeGoc;
        }
        /// <summary>
        /// In tất cả thông tin của phim
        /// </summary>
        public string Print()
        {
            return $"{tenPhim}-{ngayPhatHanh}-{giaSanXuat}-{GiaVeGoc:#}";
        }

        /// <summary>
        /// hàm random Nhảy 1 kí tự chữ cái viết hoa
        /// </summary>
        /// <param name="d">đối tượng random</param>
        public static string RDUpLetter(Random d)
        {
            string upperAlphabet = "QWERTYUIOPASDFGHJKLZXCVBNM";
            return upperAlphabet[(d.Next(0, upperAlphabet.Length))].ToString();
        }

        /// <summary>
        /// Nhập thông tin 1 phim
        /// </summary>
        public static Phim NhapPhim()
        {
            string tenPhim;
            DateTime ngayPhatHanh;
            double giaSanXuat;
            int giaVeGoc;

            tenPhim = "";
            Random d = new Random();
            string ngayPhatHanhString;
            // ten phim 
            tenPhim = RDUpLetter(d) + RDUpLetter(d).ToLower();
            // ngay phat hanh
            do
            {
                ngayPhatHanhString = $"{d.Next(0, 30)}/{d.Next(0, 12)}/{d.Next(1900, 2024)}";
            } while (!DateTime.TryParse(ngayPhatHanhString, out ngayPhatHanh));
            //  gia San Xuat
            giaSanXuat = d.NextDouble() + d.Next(100000, 999999);
            // gia ve goc
            giaVeGoc = d.Next(10000, 99999);

            return new Phim(tenPhim, ngayPhatHanh, giaSanXuat, giaVeGoc);
        }
        /// <summary>
        /// Nhập danh sách phim
        /// </summary>
        /// <param name="n">nhập số lượng phim cần lưu</param>
        public static Phim[] NhapDanhSachPhim(int n)
        {
            Phim[] danhSachPhim = new Phim[n];
            for (int i = 0; i < danhSachPhim.Length; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(20));
                danhSachPhim[i] = NhapPhim();
            }
            return danhSachPhim;
        }
        /// <summary>
        /// Hàm xuất danh sách phim
        /// </summary>
        /// <param name="arr">danh sách phim cần hiển thị</param>
        public static void XuatDanhSachPhim(Phim[] arr)
        {
            foreach (var a in arr)
            {
                Console.WriteLine(a.Print());
            }
        }
    }
}
