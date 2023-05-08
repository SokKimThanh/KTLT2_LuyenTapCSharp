using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.KeThua
{
    class NhanVien
    {
        private string hoDem;
        private string ten;
        private double heSoLuong;

        public NhanVien()
        {

        }

        public NhanVien(string hoDem, string ten, double heSoLuong)
        {
            this.hoDem = hoDem;
            this.ten = ten;
            this.heSoLuong = heSoLuong;
        }

        public string HoDem { get => hoDem; set => hoDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public void Nhap()
        {
            Console.Write("Vui long nhap ho dem: ");
            this.HoDem = Console.ReadLine();
            Console.Write("Vui long nhap ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("Vui long nhap He so luong: ");
            this.HeSoLuong = Double.Parse(Console.ReadLine());
        }

        public string Xuat()
        {
            CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"            
            return $"{this.HoDem} {this.Ten}, {TinhLuong().ToString("C", vi)} ";
        }

        public double TinhLuong()
        {
            double luong = this.heSoLuong * 1150000;
            return luong;
        }
    }
}
