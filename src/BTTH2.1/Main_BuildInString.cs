using KTLT2_TAODOITUONG.src.Helpers;
using System;
using static System.Console;

namespace KTLT2_TAODOITUONG.src.BTTH2._1
{
    internal class Main_BuildInString
    {
        /// <summary>
        /// Ham Kiem tra Kieu nhap vao
        /// </summary>
        /// <param name="ID"></param>
        internal static void Checking(int ID)
        {
            WriteLine("Moi nhap doan van: ");
            string inputLine = ReadLine();
            WriteLine("Moi nhap ky tu: ");
            char inputChar;
            char.TryParse(ReadLine(), out inputChar);
            bool isHasChar = BuildInString.CheckingCharaterNoCase(inputChar, inputLine);
            if (isHasChar)
            {
                WriteLine("Doan van nay co ki tu nguoi dung da nhap");
            }
        }

        /// <summary>
        /// Counting Type of character
        /// </summary>
        /// <param name="ID">Loai character muốn đếm</param>
        internal static void Counting(int ID)
        {
            int numberCharacter;
            string input = string.Empty;
            while (input != "exit")
            {
                try
                {
                    Write("Vui long nhap: 1 chuoi ky tu hoac nhap: 'exit' de tro ve: ");
                    input = ReadLine();


                    if (input != "exit")
                    {
                        if (ID == (int)TaoType.CharType.CHARACTER)
                        {
                            numberCharacter = BuildInString.CountingCharacter(input);//ArgumentNullException
                            WriteLine($"So ky tu co trong chuoi la: {numberCharacter}");
                        }
                        else if (ID == (int)TaoType.CharType.UPPERCASE)
                        {
                            numberCharacter = BuildInString.CountingCharacterUpperCase(input);//ArgumentNullException
                            WriteLine($"So ky tu co trong chuoi la: {numberCharacter}");
                        }
                        else if (ID == (int)TaoType.CharType.NUMBER)
                        {
                            numberCharacter = BuildInString.CountingCharacterNumber(input);//ArgumentNullException
                            WriteLine($"So ky tu co trong chuoi la: {numberCharacter}");
                        }
                        else
                        {
                            WriteLine($"Khong the thuc hien lenh");
                        }
                    }
                }
                catch (ArgumentNullException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }
    }
}
