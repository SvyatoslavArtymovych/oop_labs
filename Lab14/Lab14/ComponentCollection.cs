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
    internal class ComponentCollection : ISerializable
    {
        private List<ComputerComponents> components;

        public ComponentCollection() 
        {
            components = new List<ComputerComponents>();
        }

        // Конструктор для десеріалізації
        protected ComponentCollection(SerializationInfo info, StreamingContext context)
        {
            components = (List<ComputerComponents>)info.GetValue("Components", typeof(List<ComputerComponents>));
        }

        // Метод серіалізації
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Components", components);
        }

        public void AddComponent(ComputerComponents component)
        {
            components.Add(component);
        }

        public string DisplayComponents()
        {
            string result = "";
            foreach (var component in components)
            {
                result += component.ToString() + Environment.NewLine;
            }
            return result;
        }

        public List<ComputerComponents> GetComponentsByName(string name)
        {
            return components.Where(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<ComputerComponents> GetComponentsByCountry(string country)
        {
            return components.Where(c => c.Country.Equals(country, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void SortComponentsBySerialNumber()
        {
            components.Sort();  
        }

        // Використання методів серіалізації з ComputerComponent
        public void SaveToFile(string filePath)
        {
                foreach (var component in components)
                {
                    component.SerializeToFile(filePath); // Використання серіалізації з першого класу
                }
        }

        public void Clear()
        {
            components.Clear();
            ComputerComponents.serialNumbers.Clear();
        }

        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                components.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        components.Add(ComputerComponents.DeserializeFromFile(line)); // Використання десеріалізації з першого класу
                    }
                }
            }
        }

    }
}
