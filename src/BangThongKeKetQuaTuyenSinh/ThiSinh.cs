using System;
using System.Threading;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh
{
    class ThiSinh
    {
        // id:int dung cho csdl tu dong tang; Không hiển thị với người dùng
        readonly int id;

        public string soBaoDanh;
        public string hoVaTen;
        public DateTime ngaySinh;
        public double tongDiem;

        public ThiSinh(string soBaoDanh, string hoVaTen, DateTime ngaySinh, double tongDiem)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
            this.tongDiem = tongDiem;
        }
        internal static ThiSinh NhapThiSinh()
        {
            string soBaoDanh;
            string hoVaTen;
            DateTime ngaySinh;
            double tongDiem;
            Random d = new Random();
            // nhap so bao danh
            do
            {
                soBaoDanh = $"{TaoRandom.TaoKiTuSo()}{TaoRandom.TaoKiTuSo()}{TaoRandom.TaoKiTuSo()}{TaoRandom.TaoKiTuSo()}";
            } while (!NhapXuat.KiemTraNhapMa(soBaoDanh, 4));
            // nhap ho va ten
            do
            {
                hoVaTen = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}{TaoRandom.TaoKiTuSo()}{TaoRandom.TaoKiTuSo()}";
            } while (!NhapXuat.KiemTraNhapTen(hoVaTen));

            // nhap ngay sinh
            while (!DateTime.TryParse(TaoRandom.TaoNgaySinhTuDongString(), out ngaySinh)) ;

            // nhap tong diem
            tongDiem = d.Next(0, 25) + d.NextDouble();

            return new ThiSinh(soBaoDanh, hoVaTen, ngaySinh, tongDiem);
        }
        /// <summary>
        /// Hàm nhập danh sách thí sinh
        /// </summary>
        /// <param name="n">Số lượng thí sinh cần nhập</param>
        /// <returns>Danh sách thí sinh</returns>
        internal static ThiSinh[] NhapDanhSachThiSinh(int n)
        {
            ThiSinh[] danhSach = new ThiSinh[n];

            for (int i = 0; i < danhSach.Length; i++)
            {
                danhSach[i] = NhapThiSinh();
                Thread.Sleep(1);
            }

            return danhSach;
        }

        internal static TablePrinter XuatMang1D(ThiSinh[] dsThiSinh)
        {
            TablePrinter tableLoaiKhoa = new TablePrinter("So Bao danh", "Ho va ten", "Ngay Sinh", "Tong Diem");
            for (int i = 0; i < dsThiSinh.Length; i++)
            {
                tableLoaiKhoa.AddRow(dsThiSinh[i].soBaoDanh, dsThiSinh[i].hoVaTen, $"{dsThiSinh[i].ngaySinh:dd/MM/yyyy}", $"{dsThiSinh[i].tongDiem:0.0}");
            }
            return tableLoaiKhoa;
        }

        public string ToPrint()
        {
            return $"{soBaoDanh}{hoVaTen}{ngaySinh}";
        }
    }
}
