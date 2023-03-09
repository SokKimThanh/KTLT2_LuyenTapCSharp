using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (hour > 23 || hour < 0)
                {
                    hour = 0;
                }
                hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (minute > 59 || minute < 0)
                {
                    minute = 0;
                }
                minute = value;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (second > 59 || second < 0)
                {
                    second = 0;
                }
                second = value;
            }
        }

        /// <summary>
        /// Ham huy
        /// </summary>
        ~Time() { }

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        /// <summary>
        /// Ham Khoi tao
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public string Xuat()
        {
            return $"{Hour:00}:{Minute:00}:{Second:00}";
        }

        public Time nextSecond()
        {
            // xu ly node tang len 1 giay
            int hour = Hour;
            int minute = Minute;
            int second = Second;
            second++;
            if (second >= 59)
            {
                second = 0;
                minute++;
            }
            if (minute >= 59)
            {
                minute = 0;
                hour++;
            }
            if (hour >= 23)
            {
                hour = 0;
            }

            return new Time(hour, minute, second);
        }

        public Time previousSecond()
        {
            // xu ly node giam xuong 1 giay
            int hour = Hour;
            int minute = Minute;
            int second = Second;
            second--;
            if (second < 0)
            {
                second = 59;
                minute--;
            }
            if (minute < 0)
            {
                minute = 59;
                hour--;
            }
            if (hour < 0)
            {
                hour = 0;
            }

            return new Time(hour, minute, second);
        }
        public void setHour(int hour)
        {
            this.Hour = hour;
        }
        public void setTime(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public void Nhap()
        {
            int hour;
            int minute;
            int second;
            // nhap gio 
            do
            {
                Console.Write("Vui long nhap gio: ");
            } while (!int.TryParse(Console.ReadLine(), out hour) || hour > 23 || hour < 0);

            do
            {
                Console.Write("Vui long nhap phut: ");
            } while (!int.TryParse(Console.ReadLine(), out minute) || minute > 59 || minute < 0);

            do
            {
                Console.Write("Vui long nhap giay: ");
            } while (!int.TryParse(Console.ReadLine(), out second) || second > 59 || second < 0);

            this.setTime(hour, minute, second);
        }
    }
}
