using KTLT2_TAODOITUONG.src.Helpers;
using System;
using System.Linq;
using static System.Console;
namespace KTLT2_TAODOITUONG.src.BTTH2._1
{
    internal class BuildInString
    {
        internal static int CountingCharacter(string v)
        {
            int count = v.Count();
            return count;
        }
        internal static int CountingCharacterUpperCase(string v)
        {
            string alphabetUpperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < alphabetUpperCase.Length; j++)
                {
                    if (v[i] == alphabetUpperCase[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        internal static int CountingCharacterNumber(string v)
        {
            string numbers = "123456789";
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (v[i] == numbers[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        internal static bool CheckingCharaterNoCase(char s, string v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (s == v[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
