using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class NhapXuat
    {
        public void XuatMang1D(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + "\t");
            }
            WriteLine();
        }
        public void XuatMang1D(IEnumerable<double> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                Write(arr + "\t");
            }
            WriteLine();
        }
        public string XuatMang1D(int[] arr)
        {
            string sum = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] + "\t";
            }
            WriteLine();
            return sum;
        }
        public void XuatMang1D(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                WriteLine(arr[i]);
            }
        }
        /// <summary>
        /// Không được rỗng, viet hoa đầu từ, chỉ có kí tự chữ và số, không bao gồm khoảng trắng thừa
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool KiemTraNhapTen(string name)
        {
            // khong duoc rong
            if (name == null)
            {
                WriteLine("khong duoc rong"); ReadKey();
                return false;
            }
            // viet hoa dau tu
            string[] arr = name.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] < 'A' || arr[i][0] > 'Z')
                {

                    WriteLine("viet hoa dau tu"); ReadKey();
                    return false;
                }
            }
            // chi co ki tu chu va so
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i][j] < 'A' && arr[i][j] > 'Z' ||
                        arr[i][j] < 'a' && arr[i][j] > 'z' ||
                        arr[i][j] < '0' && arr[i][j] > '9')
                    {
                        WriteLine("chi co ki tu chu va so");

                        ReadKey();
                        return false;
                    }
                }

            }
            // khong bao gom khoang trang thua 

            for (int i = 0; i < name.Length - 1; i++)
            {
                if (name[i] == ' ' && name[i + 1] == ' ')
                {
                    WriteLine("khong bao gom khoang trang thua ");
                    ReadKey();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Không được rỗng, kiểu chuỗi, không quá n kí tự, không chứa khoảng trắng trong chuỗi
        /// </summary>
        /// <param name="code">ma cần kiểm tra</param>
        /// <param name="kiTuLength">So Luong ki tu cho phep nhap</param>
        /// <returns></returns>
        public static bool KiemTraNhapMa(string code, int kiTuLength)
        {
            // khong duoc rong
            if (code == null)
            {
                WriteLine("khong duoc rong");
                ReadKey();
                return false;
            }
            // kieu chuoi 
            string[] arr = code.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i][j] < 'A' && arr[i][j] > 'Z' ||
                        arr[i][j] < 'a' && arr[i][j] > 'z' ||
                        arr[i][j] < '0' && arr[i][j] > '9')
                    {
                        WriteLine("chi co ki tu chu va so");
                        ReadKey();
                        return false;
                    }
                }

            }
            // khong qua 1 ki tu 
            if (code.Length != kiTuLength)
            {
                WriteLine($"khong qua {kiTuLength} ki tu ");
                ReadKey();
                return false;
            }
            // khong chua khoang trang trong chuoi
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "")
                {
                    WriteLine("khong chua khoang trang trong chuoi");
                    ReadKey();
                    return false;
                }
            }
            return true;
        }
        public static DateTime ChuyenDoiNgayThang(string ngayNhap)
        {
            // ["29"]["12"]["2022"]
            // 0 1 2
            string[] arrS = ngayNhap.Split('/');// "29/12/2022".Split('/') => // ["29"]["12"]["2022"]

            DateTime s = new DateTime();
            try
            {
                s = new DateTime(int.Parse(arrS[2]), int.Parse(arrS[1]), int.Parse(arrS[0]));
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            return s;
        }
        /// <summary>
        /// Hàm kiểm tra nhập ngày tháng năm
        /// Lớn hơn 1900, đúng định dạng dd/MM/yyyy, nhỏ hơn ngày hiện tại
        /// </summary>
        /// <param name="ngayThang">Ngày tháng cần kiểm tra</param>
        /// <returns>True nếu đúng định dạng</returns>
        public static bool KiemTraNhapNgayThang(string ngayThang)
        {
            if (ngayThang == null || ngayThang == "")
            {
                return false;
            }
            string[] arrS = ngayThang.Split('/');
            // lon hon 1900 
            if (int.Parse(arrS[2]) < 1900)
            {
                return false;
            }
            // dung dinh dang
            if (!DateTime.TryParse(ngayThang, out _))
            {
                WriteLine($"\tKhong dung dinh dang ngay thang nam");
                return false;
            }
            DateTime okDate = ChuyenDoiNgayThang(ngayThang);
            // nho hon ngay hien tai  
            if (DateTime.Compare(DateTime.Now, okDate) <= 0)
            {
                WriteLine($"\tnho hon ngay hien tai");
                return false;
            }
            WriteLine($"\tHop le: {okDate:dd/MM/yyyy}");
            return true;
        }
    }
}
