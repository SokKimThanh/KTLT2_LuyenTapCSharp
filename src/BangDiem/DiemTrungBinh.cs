using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.BangDiem
{
    class DiemTrungBinh
    {
        private double dTB;
        public string KetQuaXepLoai(double dTB)
        {
            string ketqua = "";
            if (dTB >= 0 && dTB < 5)
            {
                ketqua = "yeu";
            }
            else if (dTB >= 5 && dTB < 7)
            {
                ketqua = "Trung binh";
            }
            else if (dTB >= 7 && dTB < 8)
            {
                ketqua = "Kha";
            }
            else if (dTB >= 8 && dTB <= 10)
            {
                ketqua = "Gioi";
            }

            return ketqua;
        }
    }
}
