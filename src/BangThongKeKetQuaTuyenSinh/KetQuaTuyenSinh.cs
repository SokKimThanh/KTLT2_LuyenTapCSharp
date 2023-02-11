/*
 * 6/2/2023 2:44PM Sok Kim Thanh
 * Lưu giữ kết quả thống kê của tất cả thí sinh được tuyển
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh
{
    class KetQuaTuyenSinh
    {
        private ThiSinh thiSinh;
        private LoaiKhoa khoa;
        private DoiTuongTuyenSinh doiTuong;

        public string phongHoc;

        public string ketQua;

        public KetQuaTuyenSinh() { }

        /// <summary>
        /// Tạo mới đối tượng kết quả tuyển sinh
        /// </summary>
        /// <param name="thiSinh">Danh sách Thí sinh dự thi</param>
        /// <param name="khoa">Danh sách Loai khoa thí sinh dự thi</param>
        /// <param name="doiTuong">Danh sách Đôi tượng thí sinh dự thi</param>
        /// <param name="phongHoc">Phòng học từ mã khoa</param>
        /// <param name="ketQua">Kết quả từ tổng điểm so với điểm chuẩn của khoa</param>
        public KetQuaTuyenSinh(ThiSinh thiSinh, LoaiKhoa khoa, DoiTuongTuyenSinh doiTuong, string phongHoc, string ketQua)
        {
            this.thiSinh = thiSinh;
            this.khoa = khoa;
            this.doiTuong = doiTuong;
            this.phongHoc = phongHoc;
            this.ketQua = ketQua;
        }

        /// <summary>
        /// Hàm kiểm tra ma khoa của thí sinh
        /// </summary>
        /// <param name="khoa">Đối tượng khoa</param>
        /// <returns>Tra về Khu H nếu học khoa hóa, Khu T nếu học khoa hóa, còn lại là khu A</returns>
        internal static string getPhongHoc(LoaiKhoa khoa)
        {
            if (khoa.GetMaKhoa() == "H")
            {
                return "Khu H";
            }
            else if (khoa.GetMaKhoa() == "T")
            {
                return "Khu T";
            }
            else
            {
                return "Khu A";
            }

        }
        /// <summary>
        /// Hàm Kiểm tra thí sinh có đạt điểm chuẩn hay không
        /// </summary>
        /// <param name="khoa"></param>
        /// <returns> True neu thi sinh co tong diem >= diem chuan thi dau; False nguoc lai thi rot</returns>
        internal static string GetKetQua(LoaiKhoa khoa, ThiSinh thiSinh)
        {
            if (khoa.GetDiemChuan() <= thiSinh.GetTongDiem())
                return "Đậu";
            else
                return "Rớt";
        }

        internal static KetQuaTuyenSinh[] NhapDanhSachKQTS(ThiSinh[] thiSinhs, LoaiKhoa[] khoas, DoiTuongTuyenSinh[] doituongs)
        {
            KetQuaTuyenSinh[] dsKQTS = new KetQuaTuyenSinh[thiSinhs.Length];

            for (int i = 0; i < thiSinhs.Length; i++)
            {
                dsKQTS[i] = NhapKetQuaTuyenSinh(thiSinhs[i], khoas, doituongs);
            }
            return dsKQTS;
        }

        private static KetQuaTuyenSinh NhapKetQuaTuyenSinh(ThiSinh thiSinh, LoaiKhoa[] loaiKhoas, DoiTuongTuyenSinh[] doiTuongs)
        {
            Random r = new Random();
            LoaiKhoa khoa = loaiKhoas[r.Next(0, loaiKhoas.Length)];
            Thread.Sleep(1);
            DoiTuongTuyenSinh doiTuong = doiTuongs[r.Next(0, doiTuongs.Length)];
            return new KetQuaTuyenSinh(thiSinh, khoa, doiTuong, getPhongHoc(khoa), GetKetQua(khoa, thiSinh));
        }
        /// <summary>
        /// table format 2d array
        /// </summary>
        /// <param name="dsKetQuaTS"></param>
        /// <returns></returns>
        internal static TablePrinter XuatMang1D(KetQuaTuyenSinh[] dsKetQuaTS)
        {
            string[] titles = { "So Bao danh", "Ho va ten", "Ngay sinh", "Ma Khoa", "Phong hoc", "Ten khoa", "Tong diem", "Ma doi tuong", "Ten doi tuong", "Diem chuan", "Ket qua" };
            TablePrinter tableThongKe = new TablePrinter(titles);
            for (int i = 0; i < dsKetQuaTS.Length; i++)
            {
                KetQuaTuyenSinh ketqua = dsKetQuaTS[i];
                ThiSinh thiSinh = ketqua.thiSinh;
                LoaiKhoa khoa = ketqua.khoa;
                DoiTuongTuyenSinh doiTuong = ketqua.doiTuong;
                tableThongKe.AddRow(thiSinh.GetSoBaoDanh(), thiSinh.GetHoVaTen(), thiSinh.GetNgaySinh(), khoa.GetMaKhoa(), ketqua.phongHoc, khoa.GetTenKhoa(), thiSinh.GetTongDiem(), doiTuong.GetMaDoiTuong(), doiTuong.GetTenDoiTuong(), khoa.GetDiemChuan(), ketqua.ketQua);
            }
            return tableThongKe;
        }
        /// <summary>
        /// Table format collection type
        /// </summary>
        /// <param name="dsKetQuaTS"></param>
        /// <returns></returns>
        internal static TablePrinter XuatMang1D(List<KetQuaTuyenSinh> dsKetQuaTS)
        {
            string[] titles = { "So Bao danh", "Ho va ten", "Ngay sinh", "Ma Khoa", "Phong hoc", "Ten khoa", "Tong diem", "Ma doi tuong", "Ten doi tuong", "Diem chuan", "Ket qua" };
            TablePrinter tableThongKe = new TablePrinter(titles);
            for (int i = 0; i < dsKetQuaTS.Count; i++)
            {
                KetQuaTuyenSinh ketqua = dsKetQuaTS[i];
                ThiSinh thiSinh = ketqua.thiSinh;
                LoaiKhoa khoa = ketqua.khoa;
                DoiTuongTuyenSinh doiTuong = ketqua.doiTuong;
                tableThongKe.AddRow(thiSinh.GetSoBaoDanh(), thiSinh.GetHoVaTen(), thiSinh.GetNgaySinh(), khoa.GetMaKhoa(), ketqua.phongHoc, khoa.GetTenKhoa(), thiSinh.GetTongDiem(), doiTuong.GetMaDoiTuong(), doiTuong.GetTenDoiTuong(), khoa.GetDiemChuan(), ketqua.ketQua);
            }
            return tableThongKe;
        }
        /// <summary>
        /// Table format linq 
        /// </summary>
        /// <param name="dsKetQuaTS"></param>
        /// <returns></returns>
        internal static TablePrinter XuatMang1D(IEnumerable<KetQuaTuyenSinh> dsKetQuaTS)
        {
            return XuatMang1D(dsKetQuaTS.ToList());
        }

        internal ThiSinh GetThiSinh()
        {
            return thiSinh;
        }
        internal LoaiKhoa GetKhoa()
        {
            return khoa;
        }
        internal DoiTuongTuyenSinh GetDoiTuongTuyenSinh()
        {
            return doiTuong;
        }
        public static void Swap(ref KetQuaTuyenSinh kqMax, ref KetQuaTuyenSinh kqNext)
        {
            KetQuaTuyenSinh temp = kqMax;
            kqMax = kqNext;
            kqNext = temp;
        }
    }
}
