using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.Author
{
    internal class Submenu_Author
    {
        public void GetSubMenu()
        {
            // Chuong trinh nhap tu ban phim
            Console.WriteLine("Sok Kim Thanh 22211tt0063");
            Console.WriteLine("Bai tap 2: Chuong trinh cai dat class Author");
            // khai bao
            Console.WriteLine("Nhap Thong tin tac gia");
            // nhap
            int n = NhapSoNguyen();
            Author[] authors = NhapDanhSach(n);
            // xuat
            Console.WriteLine("Xuat thong tin tac gia");
            XuatDanhSach(authors);
            Random d = new Random();
            // thu nghiem get set random
            Console.WriteLine("thu nghiem get set random");
            string sum = string.Empty;
            authors[d.Next(0, authors.Length - 1)].setEmail("22211tt0063@mail.tdc.edu.vn");
            sum += authors[d.Next(0, authors.Length - 1)].getName() + " ";
            sum += authors[d.Next(0, authors.Length - 1)].getEmail() + " ";
            sum += authors[d.Next(0, authors.Length - 1)].getGender() + " ";
            Console.WriteLine(sum);
            // tim kiem 
            Console.WriteLine("Tim kiem");
            string ten = NhapChuoi();
            Console.WriteLine("Ket qua: ");
            Array.Sort(authors);
            int index = Search.TimKiemNhiPhan(authors, ten);
            if (index != -1)
            {
                authors[index].Print();
            }
            else
            {
                Console.WriteLine("Khong tim thay key {0,5}--------------", ten);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.Write("Nhap n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 10);
            return n;
        }
        public string NhapChuoi()
        {
            string s;
            do
            {
                Console.Write("Nhap ten: ");
                s = Console.ReadLine();
            } while (s == null);
            return s;
        }
        public Author[] NhapDanhSach(int n)
        {
            Author[] authors = new Author[n];
            for (int i = 0; i < n; i++)
            {
                Author author = new Author();
                author.Nhap();
                authors[i] = author;
            }
            return authors;
        }
        public void XuatDanhSach(Author[] authors)
        {
            foreach (var a in authors)
            {
                a.Print();
            }
        }
    }
}
