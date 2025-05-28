using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_13
{
    abstract class Vehicle
    {
        decimal price;
        int speed;
        int year;

        public Vehicle(decimal price, int speed, int year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0 ) throw new ArgumentException("Ціна не може бути від'ємною!");
                price = value;
            }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0) throw new ArgumentException("Швидкість не може бути від'ємною!");
                speed = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0) throw new ArgumentException("Рік випуску не може бути від'ємною!");
                year = value;
            }
        }

        public abstract string DisplayInfo();
    }
}
