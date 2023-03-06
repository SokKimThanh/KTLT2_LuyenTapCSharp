///author: Hoang Van Dung.
///ID:22211TT0043.
///date:02/03/2023.
///Class: CD22TT1.
///Subject: OOP.
///class: Time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIME
{
    class Time
    {
        // field
        private int _Gio;
        private int _Phut;
        private int _Giay;

        public int Gio
        {
            get
            {
                return _Gio;
            }

            set
            {
                _Gio = value;
            }
        }

        public int Phut
        {
            get
            {
                return _Phut;
            }

            set
            {
                _Phut = value;
            }
        }

        public int Giay
        {
            get
            {
                return _Giay;
            }

            set
            {
                _Giay = value;
            }
        }
        // method
        // phuong thuc khoi tao
        public Time()
        {
            this._Gio = 0;
            this._Phut = 0;
            this._Giay = 0;
        }
        public Time(int Gio, int Phut, int Giay)
        {

            if (Gio >= 0 && Gio <= 24)
            {
                this.Gio = Gio;
            }
            if (Phut >= 0 && Phut <= 60)
            {
                this.Phut = Phut;
            }
            if (Giay >= 0 && Giay <= 60)
            {
                this.Giay = Giay;
            }

        }
        public string toString()
        {
            return ($"{this._Gio}h: {this._Phut}m: {this._Giay}s");
        }
        // cong them gio
        public Time AddGio(Time t)
        {
            Time kq = new Time();
            int totalSec = (this._Gio + t.Gio) * 3600 + (this.Phut + t.Phut) * 60 + this.Giay + t.Giay; 
            kq._Gio = totalSec / 3600;
            kq.Phut = (totalSec % 3600) / 60;
            kq.Giay = (totalSec % 360) % 60;
            return kq;
        }
        // cong them giay
        public Time AddGiay(int sec)
        {
            Time kq = new Time();
            int totalSec = this._Gio*3600 + this._Phut*60 + this._Giay + sec;
            kq._Gio = totalSec / 3600;

            kq._Phut = (totalSec % 3600) / 60;

            kq._Giay = (totalSec % 3600) % 60;
            return kq;
        }
        // tru theo thoi gian nhap vao
        public Time AbTraTime(Time t)
        {
            Time kq = new Time();
            int totalSec = this._Gio * 3600 + this._Phut * 60 + this._Giay;
            int totalSecT = t.Gio * 3600 + t.Phut * 60 + t.Giay;
            int timeLast = totalSec - totalSecT;
            kq._Gio = timeLast /3600;
            kq._Phut = timeLast % 3600 / 60;
            kq._Giay = timeLast % 3600 % 60;
            return kq;
        }
    }
}
