using System;
namespace KTLT2_TAODOITUONG
{
    class SubMenu_Time
    {
        internal void GetSubMenu()
        {
            Time time = new Time();
            time.Nhap();
            // giay hien tai
            string giayHienTai = time.Xuat();
            Console.WriteLine(giayHienTai);
            // giay ke tiep
            Time nextSecond = time.nextSecond();
            giayHienTai = nextSecond.Xuat();
            Console.WriteLine(giayHienTai);
            // giay truoc do
            Time previousSecond = time.previousSecond();
            giayHienTai = previousSecond.Xuat();
            Console.WriteLine(giayHienTai);
            Console.ReadKey();
        }
    }
}
