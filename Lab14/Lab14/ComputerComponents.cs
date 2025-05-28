using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    [Serializable]
    internal class ComputerComponents : ISerializable, IComparable<ComputerComponents>
    {
        public string Name { get; set; }
        public string SerialNumber { get; private set; }
        public string Manufacturer { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }

        public static HashSet<string> serialNumbers = new HashSet<string>();

        public ComputerComponents(string name, string serialNumber, string manufacturer, string country, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(serialNumber) ||
                string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException("Поля не можуть бути порожніми.");
            }

            if (serialNumbers.Contains(serialNumber))
            {
                throw new ArgumentException("Серійний номер повинен бути унікальним.");
            }

            Name = name;
            SerialNumber = serialNumber;
            Manufacturer = manufacturer;
            Country = country;
            Price = price;

            serialNumbers.Add(serialNumber);
        }

        public override string ToString()
        {
            return $"{Name};{SerialNumber};{Manufacturer};{Country};{Price}";
        }

        // Конструктор для десеріалізації
        protected ComputerComponents(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            SerialNumber = info.GetString("SerialNumber");
            Manufacturer = info.GetString("Manufacturer");
            Country = info.GetString("Country");
            Price = info.GetDecimal("Price");

            if (serialNumbers.Contains(SerialNumber))
            {
                throw new ArgumentException("Серійний номер вже існує.");
            }

            serialNumbers.Add(SerialNumber);
        }

        // Метод серіалізації
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("SerialNumber", SerialNumber);
            info.AddValue("Manufacturer", Manufacturer);
            info.AddValue("Country", Country);
            info.AddValue("Price", Price);
        }

        // Реалізація IComparable для сортування
        public int CompareTo(ComputerComponents other)
        {
            return SerialNumber.CompareTo(other.SerialNumber);
        }

        // Метод серіалізації у файл
        public void SerializeToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(this.ToString());
            }
        }

        // Метод десеріалізації з файлу
        public static ComputerComponents DeserializeFromFile(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length == 5)
            {
                return new ComputerComponents(parts[0], parts[1], parts[2], parts[3], decimal.Parse(parts[4]));
            }
            throw new FormatException("Некоректний формат даних.");
        }

    }
}
