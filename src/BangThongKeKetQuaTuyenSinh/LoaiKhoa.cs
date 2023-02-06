using System;
using System.Threading;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh
{
    class LoaiKhoa
    {
        public string maKhoa;
        public string tenKhoa;
        public double diemChuan;

        public LoaiKhoa() { }

        public LoaiKhoa(string maKhoa, string tenKhoa, double diemChuan)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.diemChuan = diemChuan;
        }
        internal static LoaiKhoa NhapLoaiKhoa()
        {
            string maKhoa;
            string tenKhoa;
            double diemChuan;
            Random d = new Random();
            do
            {
                maKhoa = $"{TaoRandom.TaoKiTuChuHoa()}";
            } while (!NhapXuat.KiemTraNhapMa(maKhoa, 1));

            do
            {
                tenKhoa = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}";
            } while (!NhapXuat.KiemTraNhapTen(tenKhoa));

            diemChuan = d.Next(10, 25) + d.NextDouble();

            return new LoaiKhoa(maKhoa, tenKhoa, diemChuan);
        }

        internal static LoaiKhoa[] NhapDanhSachLoaiKhoa(int n)
        {
            LoaiKhoa[] danhSach = new LoaiKhoa[n];

            for (int i = 0; i < danhSach.Length; i++)
            {
                danhSach[i] = NhapLoaiKhoa();
                Thread.Sleep(1);
            }

            return danhSach;
        }

        public string GetMaKhoa()
        {
            return maKhoa;
        }

        public string ToPrint()
        {
            return $"{maKhoa}{tenKhoa}";
        }

        internal static TablePrinter XuatMang1D(LoaiKhoa[] dsLoaiKhoa)
        {
            TablePrinter tableLoaiKhoa = new TablePrinter("Ma Khoa", "Loai Khoa", "Diem Chuan");
            for (int i = 0; i < dsLoaiKhoa.Length; i++)
            {
                tableLoaiKhoa.AddRow(dsLoaiKhoa[i].maKhoa, dsLoaiKhoa[i].tenKhoa, $"{dsLoaiKhoa[i].diemChuan:0.0}");
            }
            return tableLoaiKhoa;
        }
    }
}
