using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KTLT2_TAODOITUONG.src.TimKiemSapXep
{
    class DanhSachMenu
    {
        private List<Menu> data;


        public DanhSachMenu()
        {
            this.data = new List<Menu>();
        }

        // destructor
        ~DanhSachMenu() { }

        public DanhSachMenu(List<Menu> data)
        {
            this.data = data;
        }

        public List<Menu> Data { get => data; set => data = value; }

        public void AddMenu(Menu menu)
        {
            this.data.Add(menu);
        }

        public void RemoveMenu(Menu menu)
        {
            this.data.Remove(menu);
        }

        public void Clear()
        {
            this.data.Clear();
        }

        public void FindMenuByTitle(Menu menu)
        {
            foreach (Menu s in data)
            {
                if (s.Title == menu.Title)
                {
                    s.toString();
                    break;
                }
            }
        }
        public void FindMenuById(int id)
        {
            foreach (Menu s in data)
            {
                if (s.Id == id)
                {
                    s.toString();
                    break;
                }
            }
        }
        /// <summary>
        /// Ham show menu tu vi tri 0;
        /// </summary>
        /// <param name="i"></param>
        public Menu ShowMenuBySTT(int i)
        {
            //khai bao;
            Menu menu = new Menu();
            if (i < -1 && i > data.ToArray().Length)
            {
                throw new Exception("Khong duoc nhap i < 0 va > arr.length");
            }
            if (i <= -1)
            {
                menu.Title = data.ToArray()[data.ToArray().Length - 1].Title;
                menu.Description = data.ToArray()[data.ToArray().Length - 1].Description;
                return menu;
            }

            menu.Title = data.ToArray()[i].Title;
            menu.Description = data.ToArray()[i].Description;
            return menu;
        }

        public void ShowAllMenu()
        {
            int count = 0;
            Console.WriteLine($"{"STT",-15}{"Chuc nang",-15}");
            foreach (Menu s in data)
            {
                count++;
                Console.WriteLine($"{count,-15}{s.toString()}");
            }
        }

        public void EditMenu(Menu menu)
        {
            foreach (Menu s in data)
            {
                if (s == menu)
                {
                    s.Title = menu.Title;
                    s.Description = menu.Description;
                    break;
                }
            }
        }
    }
}
