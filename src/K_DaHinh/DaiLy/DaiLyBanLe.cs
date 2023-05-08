using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.K_DaHinh.DaiLy
{
    class DaiLyBanLe : DaiLy
    {
        private int doanhSo;

        public DaiLyBanLe(string maDaiLy, string tenDaiLy, int soNamHopTac, int doanhSo) : base(maDaiLy, tenDaiLy, soNamHopTac)
        {
            this.doanhSo = doanhSo;
        }

      
        public override double tinhTienChietKhau()
        {
            return this.ChietKhauCoBan * this.SoNamHopTac * 0.1;
        }

        public override double tinhTienHuongHoaHong()
        {
            double huongHoaHong = 0.0;
            if (this.doanhSo > 50000000)
            {
                huongHoaHong = this.tinhTienChietKhau() + this.doanhSo * 15 / 100;
            }
            else if (20000000 <= this.doanhSo && this.doanhSo < 50000000)
            {
                huongHoaHong = this.tinhTienChietKhau() + this.doanhSo * 10 / 100;
            }
            else
            {
                huongHoaHong = this.tinhTienChietKhau() + this.doanhSo * 5 / 100;
            }
            return huongHoaHong;
        }

        public override double tinhTongTienThuong()
        {
            throw new NotImplementedException();
        }

        public override void checkDoanhSo()
        {
            if (doanhSo >= 50000000 && this.SoNamHopTac > 3)
            {
                Console.WriteLine(this.toString());
            }
        }

        public override string toString()
        {
            return $"{base.toString()}{doanhSo.ToString("C"),-15}";
        }
    }
}
