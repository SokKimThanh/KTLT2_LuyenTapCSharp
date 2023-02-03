using System;
using System.Collections.Generic;
namespace KTLT2_TAODOITUONG
{
    public class SinhVien
    {
        /// <summary>
        /// Mã số sinh viên
        /// </summary>
        public string id;
        public string hoTen;
        public DateTime ngaySinh;
        public double[] diemTBNam;
        public double diemTBTN;
        /// <summary>
        /// Bảng điểm kiểu collection 2 chiều
        /// </summary>
        public List<BangDiem[]> bangDiemListArr;
        /// <summary>
        /// Bảng điểm kiểu collection 1 chiều
        /// </summary>
        public List<BangDiem> bangDiemList;
        /// <summary>
        /// Đối tượng danh sách Bảng điểm 2 chiều
        /// </summary>
        public BangDiem[,] bangDiem;
        public string xepLoai;
        /// <summary>
        /// Khởi tạo một sinh viên không có dữ liệu
        /// </summary>
        public SinhVien() { }
        /// <summary>
        /// Hàm khởi tạo đối tượng sinh viên
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <param name="hoTen">Họ và tên</param>
        /// <param name="ngaySinh">Ngày sinh</param>
        /// <param name="diemTB">Điểm trung binh năm</param>
        /// <param name="diemTBTN">Điểm trung binh tốt nghiệp</param>
        /// <param name="bangDiem">Bảng điểm chi tiết</param>
        public SinhVien(string id, string hoTen, DateTime ngaySinh, double[] diemTB, double diemTBTN, BangDiem[,] bangDiem, string xepLoai)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diemTBNam = diemTB;
            this.diemTBTN = diemTBTN;
            this.bangDiem = bangDiem;
            this.xepLoai = xepLoai;
        }

        /// <summary>
        /// Hàm khởi tạo đối tượng sinh viên
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <param name="hoTen">Họ và tên</param>
        /// <param name="ngaySinh">Ngày sinh</param>
        /// <param name="diemTB">Điểm trung binh năm</param>
        /// <param name="diemTBTN">Điểm trung binh tốt nghiệp</param>
        /// <param name="bangDiem">Bảng điểm chi tiết</param>
        public SinhVien(string id, string hoTen, DateTime ngaySinh, double[] diemTB, double diemTBTN, string xepLoai)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diemTBNam = diemTB;
            this.diemTBTN = diemTBTN;
            this.xepLoai = xepLoai;
            this.bangDiemListArr = new List<BangDiem[]>();
            this.bangDiemList = new List<BangDiem>();
        }

        public void AddBangDiem(BangDiem a)
        {
            bangDiemList.Add(a);
        }
        public void AddBangDiem(BangDiem[] a)
        {
            bangDiemListArr.Add(a);
        }
        public string Ranking(double finalScore)
        {
            string ranking = string.Empty;
            if (finalScore >= 8 && finalScore <= 10)
            {
                ranking = "Excellent";
            }
            if (finalScore >= 7 && finalScore <= 8)
            {
                ranking = "Good";
            }
            if (finalScore >= 5 && finalScore <= 7)
            {
                ranking = "Normal";
            }
            if (finalScore >= 0 && finalScore <= 5)
            {
                ranking = "Bad";
            }
            return ranking;
        }
        public double TinhDiemTBTN(double[] arr)
        {
            double sum = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum /= 3;
        }

        public double[] TimDiemTrungBinhTheoNamHoc(BangDiem[,] bangdiem)
        {
            // diem trung binh 3 nam hoc
            double[] diemTBNam = new double[bangdiem.GetLength(0)];

            for (int i = 0; i < bangdiem.GetLength(0); i++)
            {
                double sum = bangdiem[i, 0].diemSo;
                for (int j = 0; j < bangdiem.GetLength(1); j++)
                {
                    sum += bangdiem[i, j].diemSo;
                }
                // diem trung binh 2 hoc ky 1 nam
                diemTBNam[i] = sum /= 2;
            }
            return diemTBNam;
        }

        public double[] TimDiemTrungBinhTheoNamHoc(List<BangDiem[]> bangdiem)
        {
            // diem trung binh 3 nam hoc
            double[] diemTBNam = new double[bangdiem.Count];
            int count = 0;
            foreach (var arr in bangdiem)
            {
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i].diemSo;
                }
                diemTBNam[count] = sum /= 2;
                count++;
            }
            return diemTBNam;
        }
        public SinhVien TimSinhVienGioiNhat(SinhVien[] arr, out SinhVien svGioiNhat)
        {
            double max = arr[0].diemTBTN;
            svGioiNhat = new SinhVien();
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].diemTBTN)
                {
                    max = arr[i].diemTBTN;
                    svGioiNhat = arr[i];
                }
            }
            return svGioiNhat;
        }
        /// <summary>
        /// Hàm tìm sinh viên giỏi nhất trong danh sách sinh viên
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="svGioiNhat"></param>
        /// <returns></returns>
        public static SinhVien TimSinhVienGioiNhat(List<SinhVien> arr, out SinhVien svGioiNhat)
        {
            double max = arr[0].diemTBTN;
            svGioiNhat = new SinhVien();
            foreach (var sv in arr)
            {
                if (sv.diemTBTN > max)
                {
                    max = sv.diemTBTN;
                    svGioiNhat = sv;
                }
            }
            return svGioiNhat;
        }
        public static string GetDiemTBCT(SinhVien sv)
        {
            string diemTBChiTiet;

            if (sv.bangDiem != null && sv.bangDiem.Length != 0)
            {
                diemTBChiTiet = NhapXuatBangDiem.XuatMang1D(sv.bangDiem);
            }
            else if (sv.bangDiemList != null && sv.bangDiemList.Count != 0)
            {
                diemTBChiTiet = NhapXuatBangDiem.XuatMang1D(sv.bangDiemList);
            }
            else if (sv.bangDiemListArr != null && sv.bangDiemListArr.Count != 0)
            {
                diemTBChiTiet = NhapXuatBangDiem.XuatMang1D(sv.bangDiemListArr);
            }
            else
            {
                diemTBChiTiet = "khong co bang diem";
            }

            return diemTBChiTiet;
        }
        public string ToPrint()
        {
            return $"{id}#{hoTen}#{ngaySinh:dd/MM/yyyy}#{diemTBTN:0.00}#{xepLoai}";
        }
    }
}
