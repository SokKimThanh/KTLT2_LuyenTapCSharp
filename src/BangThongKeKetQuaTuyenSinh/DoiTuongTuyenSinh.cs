using System;

namespace KTLT2_TAODOITUONG.src.BangThongKeKetQuaTuyenSinh
{
    class DoiTuongTuyenSinh
    {
        public int maDoiTuong;
        public string tenDoiTuong;

        public DoiTuongTuyenSinh() { }

        public DoiTuongTuyenSinh(int maDoiTuong, string tenDoiTuong)
        {
            this.maDoiTuong = maDoiTuong;
            this.tenDoiTuong = tenDoiTuong;
        }

        static DoiTuongTuyenSinh NhapDoiTuongTuyenSinh(int i)
        {
            return new DoiTuongTuyenSinh(i + 1, GetTenDoiTuong(i + 1));
        }

        internal static DoiTuongTuyenSinh[] NhapDanhSanhDoiTuongTuyenSinh(int soLuongLoaiDoiTuong)
        {
            DoiTuongTuyenSinh[] danhSach = new DoiTuongTuyenSinh[soLuongLoaiDoiTuong];

            for (int i = 0; i < danhSach.Length; i++)
            {
                DoiTuongTuyenSinh doiTuong = NhapDoiTuongTuyenSinh(i);
                danhSach[i] = doiTuong;
            }

            return danhSach;
        }

        internal static string GetTenDoiTuong(int maDoiTuong)
        {
            if (maDoiTuong == 1)
            {
                return "Thuong Binh - Liet si";
            }
            else if (maDoiTuong == 2)
            {
                return "Mien cao";
            }
            else if (maDoiTuong == 3)
            {
                return "Tinh";
            }
            else if (maDoiTuong == 4)
            {
                return "Thanh Pho";
            }
            else
            {
                return "";
            }
        }
        public string ToPrint()
        {
            return $"{maDoiTuong}{tenDoiTuong}";
        }

        internal static TablePrinter XuatMang1D(DoiTuongTuyenSinh[] dsDTTS)
        {
            TablePrinter table = new TablePrinter("Ma doi tuong", "Ten doi tuong");
            for (int i = 0; i < dsDTTS.Length; i++)
            {
                table.AddRow(dsDTTS[i].maDoiTuong, dsDTTS[i].tenDoiTuong);
            }
            return table;
        }
    }
}
