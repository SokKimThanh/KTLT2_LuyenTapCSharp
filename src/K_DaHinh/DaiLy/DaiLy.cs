using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.K_DaHinh.DaiLy
{
    abstract class DaiLy
    {
        //xây dựng lớp đại lý gồm: mã đại lý, tên , số năm hợp tác, chiến khấu cơ bản là 500.000,
        private string maDaiLy, tenDaiLy;
        private int soNamHopTac;
        private double chietKhauCoBan = 500000;

        protected DaiLy(string maDaiLy, string tenDaiLy, int soNamHopTac)
        {
            this.maDaiLy = maDaiLy;
            this.tenDaiLy = tenDaiLy;
            this.soNamHopTac = soNamHopTac;
        }

        public string MaDaiLy { get => maDaiLy; set => maDaiLy = value; }
        public string TenDaiLy { get => tenDaiLy; set => tenDaiLy = value; }
        public int SoNamHopTac { get => soNamHopTac; set => soNamHopTac = value; }
        public double ChietKhauCoBan { get => chietKhauCoBan;  }

        /// <summary>
        /// hàm tính tổng tiền thưởng cho đại lý bán lẻ(Tiền chiết khấu + tiền thưởng hoa hồng). 
        /// </summary>
        /// <returns></returns>
        public abstract double tinhTienChietKhau();
        /// <summary>
        ///  tiền hưởng hoa hồng cho đại lý bán lẻ dựa vào doanh số bán hàng như sau:
        /// Nếu doanh số >= 50.000.000 đồng thì tiền hoa hồng = 15% doanh số,
        /// nếu doanh số >= 20M và< 50M thì tiền hoa hồng = 10% doanh số,
        /// còn lại tiền hoa hồng = 5% doanh số*/
        /// </summary>
        /// <returns></returns>
        public abstract double tinhTienHuongHoaHong();
        public abstract double tinhTongTienThuong();
        /// <summary>
        /// check đại lý bán lẻ co doanh số > 50M và số năm hợp tác > 3 năm
        /// </summary>
        public abstract void checkDoanhSo();

        public virtual string toString()
        {
            return $"{maDaiLy,-15}{tenDaiLy,-15}{soNamHopTac,-15}";
        }
    }
}
