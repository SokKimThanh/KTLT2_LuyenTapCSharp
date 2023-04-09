using System;
using System.Collections.Generic;

namespace KTLT2_TAODOITUONG.src.KeThua
{
    class DanhSachNhanVien
    {
        private List<NhanVien> data;

        public DanhSachNhanVien()
        {
            data = new List<NhanVien>();
        }

        public DanhSachNhanVien(List<NhanVien> data)
        {
            this.data = data;
        }

        internal List<NhanVien> Data { get => data; set => data = value; }

        public void ThemVaoDanhSach(NhanVien nv)
        {
            this.Data.Add(nv);
        }
        public void HienThiDanhSach()
        {
            foreach (NhanVien nv in data)
            {
                if (nv is TruongPhong)
                {
                    Console.WriteLine($"Truong phong = {nv.Xuat()}");
                }
                else
                {
                    Console.WriteLine(nv.Xuat());
                }
            }
        }
    }
}
