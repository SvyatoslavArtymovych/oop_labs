using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_13
{
    internal class Car: Vehicle
    {
        public Car(decimal price, int speed, int year) : base(price, speed, year) { }

        public override string DisplayInfo()
        {
           return $"Авто: Ціна: {Price}, Швидкість: {Speed}, Рік: {Year}";
        }

    }
}
