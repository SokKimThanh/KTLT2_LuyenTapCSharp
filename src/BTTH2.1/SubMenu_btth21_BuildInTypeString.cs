/*
 * 13/2/2023 Sok Kim Thanh 10:31 AM 
 * Chương trình luyện tập với các kiểu dữ liệu xây dựng sẵn: STRING
 */
using KTLT2_TAODOITUONG.src.Helpers;
using System;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BTTH2._1
{
    internal class SubMenu_btth21_BuildInTypeString
    {
        int n = 0;

        /// <summary>
        /// Chuong trinh gọi chức năng của sub menu
        /// </summary>
        /// <param name="tableSubMenu"></param>
        void ShowSubmenu(TablePrinter tableSubMenu, string[] arrMenu)
        {
            do
            {
                try
                {
                    tableSubMenu.Print();
                    WriteLine(TaoMenuMessage.pressKeyToEnterCommandOrExit);
                    int.TryParse(ReadLine(), out n); //FormatException
                }
                catch (FormatException ex)
                {
                    WriteLine(ex.Message);
                    WriteLine("Vui long khong duoc de trong!");
                }
                switch (n)
                {
                    case 1://Viet ham dem so ky tu co trong chuoi
                        {
                            TaoMenuMessage.PrintRequestMenu(arrMenu, 0);
                            Main_BuildInString.Counting((int)TaoType.CharType.CHARACTER);
                            WriteLine(TaoMenuMessage.pressKeyToContinue);
                            ReadKey();
                            break;
                        }
                    case 2://Viet ham dem so ky tu chu Hoa co trong chuoi
                        {
                            TaoMenuMessage.PrintRequestMenu(arrMenu, 1);
                            Main_BuildInString.Counting((int)TaoType.CharType.UPPERCASE);
                            WriteLine(TaoMenuMessage.pressKeyToContinue);
                            ReadKey();
                            break;
                        }
                    case 3://Viet ham dem so ky tu chu So co trong chuoi
                        {
                            TaoMenuMessage.PrintRequestMenu(arrMenu, 2);
                            Main_BuildInString.Counting((int)TaoType.CharType.NUMBER);
                            WriteLine(TaoMenuMessage.pressKeyToContinue);
                            ReadKey();
                            break;
                        }
                    case 4:// viet ham cho phep kiem tra chuoi co ton tai ky tu char hay khong, biet cha do nguoi dung nhap vao tu ban phim
                        {
                            TaoMenuMessage.PrintRequestMenu(arrMenu, 3);
                            Main_BuildInString.Checking((int)TaoType.CharType.CHARACTER);
                            WriteLine(TaoMenuMessage.pressKeyToContinue);
                            ReadKey();
                            break;
                        }

                    default:
                        {
                            if (n == -1)
                            {
                                WriteLine(TaoMenuMessage.pressKeyToBye);
                                ReadKey();
                                break;
                            }
                            break;
                        }
                }

            } while (n != -1);
        }
        /// <summary>
        /// Chức năng cài đặt submenu để sử dụng ở chương trình chính
        /// Tách lớp submenu build in type string
        /// </summary>
        internal void GetSubMenu()
        {
            var submenu = new string[] {
            "Viet ham dem so ky tu co trong chuoi",
            "viet ham dem so ky tu la chu hoa co trong chuoi",
            "viet ham dem so ky tu la chu so co trong chuoi",
            "viet ham cho phep kiem tra chuoi co ton tai ky tu char hay khong, biet cha do nguoi dung nhap vao tu ban phim",
            "Viet ham dao nguoc chuoi",
            "Viet ham dem so tu trong mot chuoi. biet tu do nguoi dung nhap vao tu ban phim",
            "Viet ham so sanh hai chuoi khong phan biet chu hoa, chu thuong.  Ham tra ve true neu hai chuoi giong nhau, nguoc lai tra ve false.",
            "viet ham tao email tu chuoi ho ten cua nguoi dung. Biet email duoc tao bang cach xoa cac khoang trang trong chuoi va them @tdc.edu.vn",
            "Viet ham kiem tra chuoi email do nguoi dung nhap vao co hop le hay khong,  biet chuoi email hop le la chuoi khong chua cac ky tu dac biet nhu #,%,$,&,^, khong co khaong trang nao trong hcuoi va bat buoc phai co ky tu @ trong chuoi.",
            "Viet ham kie mtra chuoi co hop le hay khong . Biet chuoi hop le la chuoi khong co khoang trang dau va cuoi chuoi, bat dau bang ky tu chu hoa va khong chua hai khoang trang lien tiep trong chuoi.",
            "Viet chuong trinh cho phep nguoi dung nhap vao mot chuoi ho ten. Chuong trinh tao username vaf password tu dong cho nguoi dung bang cach ghep phan tu vaf phan ho, password mac dinh duoc tao ra bang cach ghep cac ky tu dau tien cua chuoi ho ten va viet thuong ghep voi mot so co 6 chu so ngau nhien",
            "Viet chuong trinh cho phep nguoi dung nhap vao mot danh sach. Chuong trinh thuc hien sap xep danh sach vua nhap theo thu tu aphabet roi in ra man hinh. Biet ho ten hop le la chuoi chi bao gom cac ky tu chu, khong co khoang trang dau va cuoi chuoi, bat dau bang ky tu chu Hoa va khong chua hai khoang trang lien tiep trong chuoi."
            };
            var titles = new string[] { "Stt", "Chuc nang" };
            TablePrinter tableSubMenu = new TablePrinter(titles);
            tableSubMenu.NhapMenu(submenu);
            ShowSubmenu(tableSubMenu, submenu);
        }
    }
}
