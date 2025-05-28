using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_13
{
    internal class Ship: Vehicle
    {
        int passengerCount;
        string Port {  get; set; }

        public int PassengerCount
        {
            get { return passengerCount; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Кількість пасажирів корабля не повинна бути від'ємною!");
                passengerCount = value;
            }
        }

        public Ship(decimal price, int speed, int year, int passengers, string port)
        : base(price, speed, year)
        {
            PassengerCount = passengers;
            Port = port;
        }

        public override string DisplayInfo()
        {
            return $"Корабель: Ціна: {Price}, Швидкість: {Speed}, Рік: {Year}, Пасажирів: {PassengerCount}, Порт: {Port}";
        }

        public override int CompareTo(Vehicle other)
        {
            return Year.CompareTo(((Ship)other).Year);
        }

        public override string TypeMove()
        {
            return "Корабель рухається по воді";
        }

        public override object Clone()
        {
            return new Ship(Price, Speed, Year, PassengerCount, Port);
        }

    }
}
