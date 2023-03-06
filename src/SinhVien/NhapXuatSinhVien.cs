using System;
using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    internal class NhapXuatSinhVien
    {

        public static SinhVien NhapSinhVien()
        {
            string id;
            string hoTen;
            DateTime ngaySinh;
            double[] diemTBNam;
            double diemTBTN;
            string xepLoai;
            Random r = new Random();
            SinhVien sv = new SinhVien();
            id = $"{TaoRandom.TaoIDTuDong(6)}";
            WriteLine("Vui long nhap id: ", id);
            hoTen = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuThuong()}";
            WriteLine("Vui long nhap ho ten: ", hoTen);
            do
            {

            } while (!DateTime.TryParse(TaoRandom.TaoNgaySinhTuDongString(), out ngaySinh));
            WriteLine($"Vui long nhap ngay sinh: {ngaySinh}");

            // khai bao bang diem
            WriteLine($"LAP BANG DIEM SINH VIEN: ");
            int n, m;
            do
            {
                WriteLine($"Vui long nhap so dong: ");
            } while (!int.TryParse(ReadLine(), out n));
            do
            {
                WriteLine($"Vui long nhap so cot: ");
            } while (!int.TryParse(ReadLine(), out m));
            WriteLine($"Bang diem: {n} dong, {m} cot la: ");
            var bangDiem = NhapXuatBangDiem.NhapDSBangDiemList(n, m);


            // Diem trung binh nam hoc
            diemTBNam = sv.TimDiemTrungBinhTheoNamHoc(bangDiem);
            WriteLine($"Diem trung binh nam là: ");
            NhapXuat a = new NhapXuat();
            a.XuatMang1D(diemTBNam);



            // diem trung binh tot nghiep
            diemTBTN = sv.TinhDiemTBTN(diemTBNam);
            WriteLine($"\nDiem trung binh tot nghiep là: {diemTBTN}\n");
            xepLoai = sv.Ranking(diemTBTN);
            WriteLine($"\nXep loai là: {xepLoai}\n");
            WriteLine($"\nBang diem chi tiet la: \n");
            NhapXuatBangDiem.XuatMang2D(bangDiem);

            sv = new SinhVien(id, hoTen, ngaySinh, diemTBNam, diemTBTN, xepLoai);
            sv.bangDiemListArr = bangDiem;

            return sv;
        }

        public static SinhVien[] NhapDSSinhVien(int n)
        {
            SinhVien[] bangDiem = new SinhVien[n];
            for (int i = 0; i < bangDiem.Length; i++)
            {
                bangDiem[i] = NhapSinhVien();
            }
            return bangDiem;
        }
        public static List<SinhVien> NhapDSSinhVienList(int n)
        {
            List<SinhVien> bangDiem = new List<SinhVien>();
            for (int i = 0; i < n; i++)
            {
                bangDiem.Add(NhapSinhVien());
            }
            return bangDiem;
        }


        /// <summary>
        /// Xuat diem trung binh chi tiet va them bao table sinh vien
        /// </summary>
        /// <param name="arr">danh sach sinh vien</param>
        /// <param name="tableSinhVien">Table sinh vien</param>
        public static void XuatMang1D(SinhVien[] arr, ref TablePrinter tableSinhVien)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string diemTBChiTiet = SinhVien.GetDiemTBCT(arr[i]);
                tableSinhVien.AddRow(arr[i].id, arr[i].hoTen, $"{arr[i].ngaySinh:dd/MM/yyyy}", arr[i].diemTBTN, arr[i].xepLoai, diemTBChiTiet);
                WriteLine(diemTBChiTiet);
            }
        }

        /// <summary>
        /// Hàm xuất điểm sinh viên giỏi nhất
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="tableSinhVien"></param>
        /// <param name="sv"></param>
        public static void XuatMang1D(SinhVien[] arr, ref TablePrinter tableSinhVien, SinhVien sv)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].id == sv.id)
                {
                    int length = arr[i].bangDiem.GetLength(0) * arr[i].bangDiem.GetLength(1);
                    BangDiem[] bangdiem = NhapXuatBangDiem.XuatMang2D(arr[i].bangDiem, length);
                    string diemTBChiTiet = arr[i].ToPrint() + "#" + NhapXuatBangDiem.XuatMang1D(bangdiem);
                    tableSinhVien.RemoveAll(arr);
                    tableSinhVien.AddRow(arr[i].id, arr[i].hoTen, $"{arr[i].ngaySinh:dd/MM/yyyy}", arr[i].diemTBTN, arr[i].xepLoai, diemTBChiTiet);
                    tableSinhVien.Print();
                }
            }
        }

        /// <summary>
        /// Hàm xuất tất cả các điểm kiểu collection
        /// </summary>
        /// <param name="arr">danh sách sinh viên kiểu collection</param>
        /// <param name="tableSinhVien">Format table sinh viên</param>
        public static void XuatMang1D(List<SinhVien> arr, ref TablePrinter tableSinhVien)
        {
            foreach (var s in arr)
            {
                string diemTBChiTiet = SinhVien.GetDiemTBCT(s);
                tableSinhVien.AddRow(s.id, s.hoTen, $"{s.ngaySinh:dd/MM/yyyy}", s.diemTBTN, s.xepLoai, diemTBChiTiet);
            }
        }
    }
}
