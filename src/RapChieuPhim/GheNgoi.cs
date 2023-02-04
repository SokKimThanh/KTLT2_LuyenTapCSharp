using System;
using static System.Console;

namespace KTLT2_TAODOITUONG.src.RapChieuPhim
{
    /// <summary>
    /// Lớp đối tuong mô tả thế nào là một ghế ngồi trong rạp chiếu phim
    /// </summary>
    class GheNgoi
    {
        MaGhe maGhe;
        bool trangThaiGheTrong;

        public GheNgoi() { }
        /// <summary>
        /// Khi tạo mới đối tượng ghê ngồi sẽ cần mã ghế ngồi và trạng thái ghế trống
        /// </summary>
        /// <param name="maGhe">Mã ghế ngồi</param>
        /// <param name="trangThaiGheTrong">Trạng thái ghế trống true là trống, false là đã đặt chỗ</param>
        public GheNgoi(MaGhe maGhe, bool trangThaiGheTrong)
        {
            this.maGhe = maGhe;
            this.trangThaiGheTrong = trangThaiGheTrong;
        }

        public MaGhe getMaGhe() { return maGhe; }
        public bool getTrangThaiGheTrong() { return trangThaiGheTrong; }

        public string ToPrint()
        {
            return $"{maGhe.ToPrint()}-{trangThaiGheTrong}\t";
        }
    }
}
