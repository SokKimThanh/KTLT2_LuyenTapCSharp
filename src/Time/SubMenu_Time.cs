using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TIME
{
    class SubMenu_Time
    {
        internal void GetSubMenu()
        {

            Time t1 = new Time(2, 10, 15);
            Time t2 = new Time(3, 55, 50);
            Time tong = t1.AddGio(t2);
            Console.WriteLine($"{t1.toString()} + {t2.toString()} = {tong.toString()}");
            int addSec = 0;
            string giaTriNhapTuBanPhim = "";
            bool giaTriNhapSoSai = false;
            while (giaTriNhapTuBanPhim != "exit")
            {

                do
                { 
                    Write("nhap vao so giay cong vao (nhap 'exit' de thoat): ");
                    giaTriNhapTuBanPhim = ReadLine();
                    giaTriNhapSoSai =  !int.TryParse(giaTriNhapTuBanPhim, out addSec); // check nhap chuoi sai cho nhap lai
                    if (giaTriNhapSoSai && giaTriNhapTuBanPhim == "exit")
                    {
                        //break;
                        WriteLine("break");
                        break;
                    }

                    Time sumAddSec = t1.AddGiay(addSec);
                    Console.WriteLine($"{t1.toString()} + ({addSec}s) ={sumAddSec.toString()}");
                    Console.WriteLine($"{t2.toString()} - {t1.toString()} = {t2.AbTraTime(t1).toString()}");
                  

                } while (addSec != -1);

                WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
