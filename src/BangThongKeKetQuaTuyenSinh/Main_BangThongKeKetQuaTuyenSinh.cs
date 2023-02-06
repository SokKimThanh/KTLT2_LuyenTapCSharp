/*
 * 6:49 5/2/2023 Sok Kim Thanh
 * Submenu bảng thống kê kết quả tuyển sinh
 */
using System;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class Main_BangThongKeKetQuaTuyenSinh
    {
        public void GetSubmenu()
        {
            var submenu = new string[] {
                "Nhap/xuat thi sinh",
                "Nhap/Xuat loai khoa",
                "Nhap/Xuat doi tuong tuyen sinh",
                "In/luu ten khoa trong bang thong ke kq.t.sinh",
                "In/Luu ten doi tuong tuyen sinh",
                "In/Luu ten phong hoc cua tung thi sinh du tuyen",
                "In/Luu ket qua cua tung thi sinh",
                "Sap xep bang tinh tang dan theo cot ho ten",
                "Sap xep ma khoa, tong diem, ma khoa tang dan, tong diem giam dan"
            };
            var titles = new string[] { "stt", "Chuc nang" };
            TablePrinter table = new TablePrinter(titles);
            table.NhapMenu(submenu);
            table.Print();
        }
    }
}