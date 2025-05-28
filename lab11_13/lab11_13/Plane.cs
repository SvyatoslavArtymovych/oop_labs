using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_13
{
    internal class Plane : Vehicle
    {
        int altitude;
        int passengerCount;

        public Plane(decimal price, int speed, int year, int altitude, int passengers) : base(price, speed, year)
        {
            Altitude = altitude;
            PassengerCount = passengers;
        }


        public int Altitude
        {
            get { return altitude; }
            set
            {
                if (value < 0)throw new ArgumentOutOfRangeException("Висота літака не повинна бути від'ємною!");
                altitude = value;
            }
        }

        public int PassengerCount
        {
            get { return passengerCount; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Кількість пасажирів літака не повинна бути від'ємною!");
                passengerCount = value;
            }
        }

        public override string DisplayInfo()
        {
            return $"Літак: Ціна: {Price}, Швидкість: {Speed}, Рік: {Year}, Висота: {Altitude}, Пасажирів: {PassengerCount}";
        }

    }
}
