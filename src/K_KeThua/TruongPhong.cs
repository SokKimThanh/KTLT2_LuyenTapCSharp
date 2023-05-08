using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.KeThua
{
    class TruongPhong : NhanVien
    {
        private double thuong;


        public TruongPhong()
        {
        }

        public TruongPhong(string hoDem, string ten, double heSoLuong) : base(hoDem, ten, heSoLuong)
        {

        }

        public TruongPhong(string hoDem, string ten, double heSoLuong, double thuong) : base(hoDem, ten, heSoLuong)
        {
            this.thuong = thuong;
        }

        public double Thuong { get => thuong; set => thuong = value; }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap thuong truong phong: ");
            this.Thuong = double.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Ham ke thua xuat
        /// </summary>
        public new string Xuat()
        {
            CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return $"truong phong = {base.Xuat()}, {TinhLuong().ToString("C", vi)}";
        }

        public new double TinhLuong()
        {
            double luong = base.TinhLuong() + this.Thuong;
            return luong;
        }
    }
}
