using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.Author
{
    internal class Search
    {
        public static int TimKiemNhiPhan(Author[] arr, string name)
        {
            int left = 0;
            int mid;
            int right = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid].Name.ToLower().CompareTo(name.ToLower()) == 0)
                {
                    return mid;
                }
                else if (arr[mid].Name.ToLower().CompareTo(name.ToLower()) < 0)
                {
                    left = mid + 1;
                }
                else { right = mid - 1; }
            }
            return -1;
        }
    }
}
