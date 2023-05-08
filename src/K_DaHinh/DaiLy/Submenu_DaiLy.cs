using KTLT2_TAODOITUONG.src.KeThua;
using KTLT2_TAODOITUONG.src.TimKiemSapXep;
using System;
using System.Threading;
using static System.Console;


namespace KTLT2_TAODOITUONG.src.K_DaHinh.DaiLy
{
    class Submenu_DaiLy
    {
        public void GetSubMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Nhap danh sach dai ly");
            Write("nhap n: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int n = int.Parse(Console.ReadLine());
            DaiLy[] arr = new DaiLy[n];

            NhapDanhSachDaiLy(arr);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("-----Danh sach dai ly-----");
            Console.ForegroundColor = ConsoleColor.White;
            XuatDanhSachDaiLy(arr);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("-----Danh sach dai ly co doanh thu hon 50 trieu va hon 3 nam hop tac-----");
            Console.ForegroundColor = ConsoleColor.White;
            XuatDanhSachDailyCoDoanhThuHon50TrieuVaHon3NamHopTac(arr);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        private void XuatDanhSachDailyCoDoanhThuHon50TrieuVaHon3NamHopTac(DaiLy[] arr)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"{"Ma dai ly",-15}{"ten dai ly",-15}{"so nam hop tac",-15}{"doanh so",-15}");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].checkDoanhSo();
                Thread.Sleep(100);
            }
        }

        private void XuatDanhSachDaiLy(DaiLy[] arr)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"{"Ma dai ly",-15}{"ten dai ly",-15}{"so nam hop tac",-15}{"doanh so",-15}");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
                Thread.Sleep(100);
            }
        }

        private void NhapDanhSachDaiLy(DaiLy[] arr)
        {
            string maDaiLy, tenDaiLy;
            int soNamHopTac;
            int doanhSo;
            Random d = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"---------Nhap thong tin Dai ly {i+1}--------");
                maDaiLy = d.Next(100000, 999999).ToString();
                tenDaiLy = "daily "+d.Next(100000, 999999).ToString();
                soNamHopTac = d.Next(1, 10);
                doanhSo = d.Next(1000000, 1000000000);
                arr[i] = new DaiLyBanLe(maDaiLy, tenDaiLy, soNamHopTac, doanhSo);
                Thread.Sleep(100);
            }
        }
    }
}
