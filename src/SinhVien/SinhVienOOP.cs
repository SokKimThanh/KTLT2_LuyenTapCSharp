using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    public class SinhVien2
    {
        /// <summary>
        /// họ tên sinh vien
        /// </summary>
        private string hoTen;
        /// <summary>
        /// tính năm sinh
        /// </summary>
        private int tuoi;
        /// <summary>
        /// điểm toán
        /// </summary>
        private double diemToan;
        /// <summary>
        /// điểm văn
        /// </summary>
        private double diemVan;
        /// <summary>
        /// điểm trung bình môn học
        /// </summary>
        private double diemTB;
        /// <summary>
        /// random
        /// </summary>
        static Random d = new Random();

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public static Random D { get => d; set => d = value; }




        /// <summary>
        /// Nhập thông tin sinh viên
        /// </summary>
        public void Nhap()
        {

            // nhap ho ten
            for (int i = 0; i < 10; i++)
            {
                HoTen = Random1KiTu();
            }
            // nhap tuoi
            Tuoi = RandomTuoi();
            // diem toan

            while (DiemToan >= 0 && DiemToan <= 10)
            {
                DiemToan = D.Next(0, 9) + D.NextDouble();
            }
            // diem van
            while (DiemVan >= 0 && DiemVan <= 10)
            {
                DiemVan = D.Next(0, 9) + D.NextDouble();
            }

        }

        /// <summary>
        /// Xuất thông tin sinh viên
        /// </summary>
        public void Xuat()
        {

        }

        /// <summary>
        /// Random 1 ki tu
        /// </summary>
        public static string Random1KiTu()
        {
            string arrString = "qwertyuiuopasdfghjklZxcvbnm";
            return arrString[D.Next(0, arrString.Length - 1)].ToString();
        }

        /// <summary>
        /// Random năm sinh
        /// </summary>
        public int RandomTuoi()
        {
            DateTime now = DateTime.Now;
            int ngay = D.Next(1900, now.Year);
            return now.Year - ngay;
        }
    }
}
