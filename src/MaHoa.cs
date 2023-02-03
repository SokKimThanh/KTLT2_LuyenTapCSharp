using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace KTLT2_TAODOITUONG
{
    /// <summary>
    /// Mã hóa dữ liệu, giải mã dữ liệu, thao tác đọc file, ghi file
    /// </summary>
    class MaHoa
    {
        /// <summary>
        /// Thao tác mã hóa file
        /// </summary>
        /// <param name="pathName">đường dẫn tập tin</param>
        /// <param name="arrInt">Dữ liệu vùng nhớ số nguyên</param>
        public static void ThaoTacMaHoa(string pathName, int[] arrInt)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 2: Kiem tra file ton tai
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");

                // cong viec tiep theo la
                // 1 / Tao doi tuong de doc file
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                // 2 / Tao doi tuong de ma hoa file
                BinaryWriter binW = new BinaryWriter(fs);
                // 3/ Mo file
                using (fs)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 4/ ghi tung gia tri vao trong file
                    foreach (var item in arrInt)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        binW.Write(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacMaHoa(string pathName, SinhVien[] arr)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 2: Kiem tra file ton tai
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");

                // cong viec tiep theo la
                // 1 / Tao doi tuong de doc file
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                // 2 / Tao doi tuong de ma hoa file
                BinaryWriter binW = new BinaryWriter(fs);
                // 3/ Mo file
                using (fs)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 4/ ghi tung gia tri vao trong file
                    foreach (var item in arr)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        binW.Write(item.ToPrint());
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacMaHoa(string pathName, List<SinhVien> arr)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 2: Kiem tra file ton tai
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");

                // cong viec tiep theo la
                // 1 / Tao doi tuong de doc file
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                // 2 / Tao doi tuong de ma hoa file
                BinaryWriter binW = new BinaryWriter(fs);
                // 3/ Mo file
                using (fs)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 4/ ghi tung gia tri vao trong file
                    foreach (var item in arr)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        binW.Write(item.ToPrint());
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacDocFile(string pathName)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");
                // Thao tac doc file la
                // 1/ Tao duong doc file
                StreamReader fs = new StreamReader(path);
                // 2/ mo file
                using (fs)
                {
                    // 3/ Doc file
                    while (!fs.EndOfStream)
                    {
                        // 4/ in tung dong trong file ra man hinh console
                        WriteLine(fs.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacGhiFile(string pathName, int[] arrInt)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");
                // Thao tac ghi file la
                // 1/ Tao duong ghi file
                StreamWriter sw = new StreamWriter(path);
                // 2/ mo file
                using (sw)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 3/ ghi file
                    foreach (var item in arrInt)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        sw.Write(item + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacGhiFile(string pathName, SinhVien[] arr)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");
                // Thao tac ghi file la
                // 1/ Tao duong ghi file
                StreamWriter sw = new StreamWriter(path);
                // 2/ mo file
                using (sw)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 3/ ghi file
                    foreach (var item in arr)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        sw.Write(item.ToPrint());
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        public static void ThaoTacGhiFile(string pathName, List<SinhVien> arr)
        {
            // buoc 1 : tao duong dan
            string path = pathName;
            // buoc 3: try catch bat loi
            try
            {
                // Cong viec TRY
                // kiem tra thao tac tren file
                WriteLine($"\nPhan viec try: \nHien thi o dia la: {path}\n");
                // Thao tac ghi file la
                // 1/ Tao duong ghi file
                StreamWriter sw = new StreamWriter(path);
                // 2/ mo file
                using (sw)
                {
                    // khai bao mang so nguyen
                    //int[] arrInt = new int[] { 100, 200, 500, 1000, 2000, 5000, 10000 };
                    // 3/ ghi file
                    foreach (var item in arr)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        sw.Write(item.ToPrint());
                    }
                }
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// hàm kiêm tra trước khi sử dụng
        /// </summary>
        /// <param name="args"></param>
        public void UnitTest(string[] args)
        {
            // doc file trong o dia D:\
            Write("Moi ban nhap ten do dia: ");
            string tenODia = ReadLine();
            Write("Moi ban nhap ten file: ");
            string tenFile = ReadLine();
            string path = $@"{tenODia}:\{tenFile}.txt";
            WriteLine("-------------------------------------------------");
            WriteLine("\nThao tac ghi file\n");
            //ThaoTacGhiFile(path);

            WriteLine("-------------------------------------------------");
            WriteLine("\nThao tac doc file\n");
            ThaoTacDocFile(path);

            //WriteLine("-------------------------------------------------");
            //WriteLine("\nThao tac ma hoa file\n");
            //ThaoTacMaHoa(path);

            //WriteLine("-------------------------------------------------");
            //WriteLine("\nThao tac doc file\n");
            //ThaoTacDocFile(path);

            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}
