using KTLT2_TAODOITUONG.src;
using System;
using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    public class B_GradeBook
    {
        private B_Book NhapBook()
        {
            string name = string.Empty;
            do
            {
                name = $"{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuHoa()}{TaoRandom.TaoKiTuChuHoa()}";
            } while ((name == null) == true);

            return new B_Book(name);
        }
        private void XuatMang(List<double> arr)
        {
            foreach (var a in arr)
            {
                Write(a + "\t");
            }
            WriteLine("\n");
        }
        /// <summary>
        /// Khong co static thi phai new GradeBook
        /// </summary>
        public void Main()
        {
            Random n = new Random();
            WriteLine($"Vui long nhap K so can so sanh: ");
            int.TryParse(ReadLine(), out int k);
            B_Book book1 = NhapBook();
            for (int i = 0; i < k; i++)
            {
                book1.AddGrade(n.NextDouble());
            }
            // lay danh sach diem cua doi tuong book1(co encapsulation: bao mat)
            XuatMang(book1.GetGrade());
            B_Statics s = book1.ShowStatics();
            Write(s.ToPrint());
        }
    }
}
