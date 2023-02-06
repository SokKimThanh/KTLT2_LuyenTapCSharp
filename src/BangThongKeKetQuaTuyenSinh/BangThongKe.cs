/*
 * 6/2/2023 2:44PM Sok Kim Thanh
 * Lưu giữ kết quả thống kê của tất cả thí sinh được tuyển
 */
using System;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh
{
    class BangThongKe
    {

        public string phongHoc;

        public string ketQua;

        public BangThongKe() { }

        public BangThongKe(string phongHoc, string ketQua)
        {
            this.phongHoc = phongHoc;
            this.ketQua = ketQua;
        }


        /// <summary>
        /// Hàm kiểm tra ma khoa của thí sinh
        /// </summary>
        /// <param name="khoa">Đối tượng khoa</param>
        /// <returns>Tra về Khu H nếu học khoa hóa, Khu T nếu học khoa hóa, còn lại là khu A</returns>
        public string getPhongHoc(LoaiKhoa khoa)
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
        public string GetKetQua(LoaiKhoa khoa, ThiSinh thiSinh)
        {
            if (khoa.diemChuan <= thiSinh.tongDiem)
                return "Đậu";
            else
                return "Rớt";
        }
    }
}
