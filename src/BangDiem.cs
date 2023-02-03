namespace KTLT2_TAODOITUONG
{
    public class BangDiem
    {
        public string namHoc;
        public string hocKy;
        public double diemSo;
        /// <summary>
        /// Khởi tạo bảng điểm chi tiết
        /// </summary>
        /// <param name="namHoc"></param>
        /// <param name="hocKy"></param>
        /// <param name="diemSo"></param>
        public BangDiem(string namHoc, string hocKy, double diemSo)
        {
            this.namHoc = namHoc;
            this.hocKy = hocKy;
            this.diemSo = diemSo;
        }

        public string ToPrint()
        {
            return $"{diemSo:0.00}";
        }
    }
}
