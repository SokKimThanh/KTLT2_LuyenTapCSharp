using System.Collections.Generic;
using System.Linq;

namespace KTLT2_TAODOITUONG
{

    /// <summary>
    /// Thiết kế bảng dữ liệu định dạng format table trên console
    /// </summary>
    class TablePrinter
    {
        private readonly string[] titles;
        private readonly List<int> lengths;
        private readonly List<string[]> rows = new List<string[]>();

        /// <summary>
        /// Danh sách cột cần tạo mới
        /// </summary>
        /// <param name="titles">Tên danh sách cột</param>
        public TablePrinter(params string[] titles)
        {
            this.titles = titles;
            lengths = titles.Select(t => t.Length).ToList();
        }

        public void AddRow(params object[] row)
        {
            if (row.Length != titles.Length)
            {
                throw new System.Exception($"Added row length [{row.Length}] is not equal to title row length [{titles.Length}]");
            }
            rows.Add(row.Select(o => o.ToString()).ToArray());
            for (int i = 0; i < titles.Length; i++)
            {
                if (rows.Last()[i].Length > lengths[i])
                {
                    lengths[i] = rows.Last()[i].Length;
                }
            }
        }
        /// <summary>
        /// Xóa dữ liệu trong bảng
        /// </summary>
        /// <param name="row">Dữ liệu trong bảng</param>
        public void RemoveAll(params object[] row)
        {
            rows.Clear();
        }
        public void Print()
        {
            lengths.ForEach(l => System.Console.Write("+-" + new string('-', l) + '-'));
            System.Console.WriteLine("+");

            string line = "";
            for (int i = 0; i < titles.Length; i++)
            {
                line += "| " + titles[i].PadRight(lengths[i]) + ' ';
            }
            System.Console.WriteLine(line + "|");

            lengths.ForEach(l => System.Console.Write("+-" + new string('-', l) + '-'));
            System.Console.WriteLine("+");

            foreach (var row in rows)
            {
                line = "";
                for (int i = 0; i < row.Length; i++)
                {
                    if (int.TryParse(row[i], out int n))
                    {
                        line += "| " + row[i].PadLeft(lengths[i]) + ' ';  // numbers are padded to the left
                    }
                    else
                    {
                        line += "| " + row[i].PadRight(lengths[i]) + ' ';
                    }
                }
                System.Console.WriteLine(line + "|");
            }

            lengths.ForEach(l => System.Console.Write("+-" + new string('-', l) + '-'));
            System.Console.WriteLine("+");
        }


        public void NhapMenu(string[] arr, int hideRow)
        {
            for (int i = 0; i < arr.Length - hideRow; i++)
            {
                AddRow(i, arr[i]);
            }
        }
        public void NhapMenu(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                AddRow(i + 1, arr[i]);
            }
        }
    }
}
