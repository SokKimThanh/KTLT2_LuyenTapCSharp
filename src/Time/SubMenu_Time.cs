using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class SubMenu_Time
    {
        internal void GetSubMenu()
        {
            Time time = new Time();
            time.Nhap();
            // ket qua nhap
            string ketQua = time.Xuat();
            Console.WriteLine(ketQua);
            // giay ke tiep
            Time nextSecond = time.nextSecond();
            ketQua = nextSecond.Xuat();
            Console.WriteLine(ketQua);
            // giay truoc do
            Time previousSecond = time.previousSecond();
            ketQua = previousSecond.Xuat();
            Console.WriteLine(ketQua);
            Console.ReadKey();
        }
    }
}
