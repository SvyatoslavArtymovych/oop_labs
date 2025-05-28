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

        public override int CompareTo(Vehicle other)
        {
            return Speed.CompareTo(((Car)other).Speed);
        }

        public override string TypeMove()
        {
            return "Австо рухається по суші";
        }

        public override object Clone()
        {
            return new Car(Price, Speed, Year);
        }
    }
}
