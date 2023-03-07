using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG
{
    internal class Sach
    {
        private string maSach, tenSach;
        private int gia, namSX;
        static Random d = new Random();

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int Gia { get => gia; set => gia = value; }
        public int NamSX { get => namSX; set => namSX = value; }

        // ham huy destructor
        ~Sach() { }

        public void Nhap()
        {
            // nhap ma sach
            do
            {
                //Console.Write("Vui long nhap ma sach: ");
                //maSach = Console.ReadLine();
                maSach = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}{TaoRandom.TaoKiTuSo()}";
                if (maSach.Length > 6)
                {
                    Console.WriteLine("Ma sach chi duoc nhap toi da 6 ky tu");
                }
            } while (maSach.Length > 6 || maSach.Length <= 0);

            // nhap ten sach
            do
            {
                //Console.Write("Vui long nhap ten sach: ");
                //tenSach = Console.ReadLine();
                tenSach = $"{maSach} - {TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}";
                if (tenSach.Length > 30)
                {
                    Console.WriteLine("Ten sach chi duoc nhap toi da 30 ky tu");
                }
            } while (tenSach.Length > 30 || tenSach.Length <= 0);

            // nhap gia

            gia = d.Next();
            //do
            //{
            //    Console.Write("Vui long nhap gia: ");
            //} while (!int.TryParse(Console.ReadLine(), out gia));


            // nhap nam
            namSX = d.Next(1900, DateTime.Now.Year);
            //do
            //{
            //    Console.Write("vui long nhap nam san xuat: ");
            //    if (namSX < 1900)
            //    {
            //        Console.WriteLine("Nam san xuat phai lon 1900");
            //    }
            //} while (!int.TryParse(Console.ReadLine(), out namSX) || namSX < 1900);

        }
        public void Xuat()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, 15}{3, 15}", maSach, tenSach, namSX, gia);
        }
    }
}
