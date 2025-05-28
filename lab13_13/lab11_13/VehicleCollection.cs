using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_13
{
    internal class VehicleCollection
    {
        SortedList mySortedListCollections;
        SortedList<decimal, Vehicle> mySortedListGeneric;

        public VehicleCollection()
        {
            mySortedListCollections = new SortedList();
            mySortedListGeneric = new SortedList<decimal, Vehicle>();
        }

        public void Add(Vehicle vehicle)
        {
            mySortedListCollections.Add(vehicle.Price, vehicle);
            mySortedListGeneric.Add(vehicle.Price, vehicle);
        }

        public void Remove(decimal key)
        {
            if (mySortedListCollections.ContainsKey(key))
            {
                mySortedListCollections.Remove(key);
            }
            else if (mySortedListGeneric.ContainsKey(key))
            {
                mySortedListGeneric.Remove(key);
            }
        }

        public void RemoveAllVehicles()
        {
            mySortedListCollections.Clear();
            mySortedListGeneric.Clear();
        }

        public string Display()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Колекція SortedList:");

            foreach (DictionaryEntry entry in mySortedListCollections)
            {
                decimal key = (decimal)entry.Key; 
                Vehicle vehicle = (Vehicle)entry.Value;
                result.AppendLine(vehicle.DisplayInfo());
            }

            result.AppendLine("Колекція SortedList<decimal, Vehicle>:");

            foreach (KeyValuePair<decimal, Vehicle> vehicle in mySortedListGeneric)
            {
                result.AppendLine(vehicle.Value.DisplayInfo());
            }

            return result.ToString();
        }
    }
}
