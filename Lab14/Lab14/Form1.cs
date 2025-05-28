using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void inputCollection(ComponentCollection myCllection)
        {
            ComputerComponents component1 = new ComputerComponents("Процесор Intel i7", "SN12345", "Intel", "США", 320.99m);
            ComputerComponents component2 = new ComputerComponents("Відеокарта RTX 3080", "SN67890", "NVIDIA", "Тайвань", 899.99m);
            ComputerComponents component3 = new ComputerComponents("Оперативна пам'ять 16GB DDR4", "SN11111", "Corsair", "Китай", 129.99m);
            ComputerComponents component4 = new ComputerComponents("SSD NVMe 1TB", "SN22222", "Samsung", "Корея", 179.99m);
            ComputerComponents component5 = new ComputerComponents("Блок живлення 750W", "SN33333", "Seasonic", "Японія", 139.99m);
            myCllection.AddComponent(component1);
            myCllection.AddComponent(component2); 
            myCllection.AddComponent(component3);
            myCllection.AddComponent(component4);
            myCllection.AddComponent(component5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComponentCollection myCollection = new ComponentCollection();
            inputCollection(myCollection);

            myCollection.SaveToFile("MyFile1.txt");
            myCollection.Clear();

            myCollection.LoadFromFile("MyFile1.txt");
            textBox1.Text = myCollection.DisplayComponents();
            using (FileStream fs = new FileStream("MyFile1.txt", FileMode.Truncate)) { }
            
            myCollection.SortComponentsBySerialNumber();
            textBox1.Text += "Відсотрований список: " + Environment.NewLine + myCollection.DisplayComponents();
            GetComponentsFromUSA(myCollection);
        }

        private void GetComponentsFromUSA(ComponentCollection myCollection)
        {
            textBox1.Text += "Компоненти зі США: " + Environment.NewLine;
            foreach (ComputerComponents component in myCollection.GetComponentsByCountry("США"))
            {
                textBox1.Text += component.ToString() + Environment.NewLine;
            }

        }
    }
}
