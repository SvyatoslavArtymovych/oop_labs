using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11_13
{
    public partial class ResultLab12 : Form
    {
        public ResultLab12()
        {
            InitializeComponent();
        }
        void printArray(Vehicle[] myArray)
        {
            for(int i = 0;i< myArray.Length;i++)
            {
                if (myArray[i] != null)
                {
                    textBox1.Text += myArray[i].DisplayInfo() + Environment.NewLine;
                }
                else
                {
                    break;
                }
            }
        }

        private void workWithPlane(Vehicle[] myArray)
        {
            arrayPlane(myArray);
            textBox1.Text = "Масив літаків заповнений на половину:" + Environment.NewLine;
            printArray(myArray);

            clonePlane(myArray);
            textBox1.Text += "Масив літаків заповнений повістю:" + Environment.NewLine;
            printArray(myArray);

            Array.Sort(myArray);
            textBox1.Text += "Масив літаків відсортований:" + Environment.NewLine;
            printArray(myArray);
        }

        private void workWithCar(Vehicle[] myArray)
        {
            Array.Clear(myArray, 0, myArray.Length);
            arrayCar(myArray);
            textBox1.Text += "Масив авто заповнений на половину:" + Environment.NewLine;
            printArray(myArray);

            cloneCar(myArray);
            textBox1.Text += "Масив авто заповнений повістю:" + Environment.NewLine;
            printArray(myArray);

            Array.Sort(myArray);
            textBox1.Text += "Масив авто відсортований:" + Environment.NewLine;
            printArray(myArray);
        }

        private void workWithShip(Vehicle[] myArray)
        {
            Array.Clear(myArray, 0, myArray.Length);
            arrayShip(myArray);
            textBox1.Text += "Масив човнів заповнений на половину:" + Environment.NewLine;
            printArray(myArray);

            cloneShip(myArray);
            textBox1.Text += "Масив кораблів заповнений повістю:" + Environment.NewLine;
            printArray(myArray);

            Array.Sort(myArray);
            textBox1.Text += "Масив кораблів відсортований:" + Environment.NewLine;
            printArray(myArray);
        }

        private void ResultLab12_Load(object sender, EventArgs e)
        {
            Vehicle[] myArray = new Vehicle[10];
            workWithPlane(myArray);
            workWithCar(myArray);
            workWithShip(myArray);
        }

        private void arrayPlane(Vehicle[] myArray)
        {
            Random random = new Random();
            for(int i = 0;i  < myArray.Length / 2;i++)
            {
                myArray[i] = new Plane(random.Next(100000, 220000), random.Next(300, 450), random.Next(2010, 2026), random.Next(1000, 4000),
                                       random.Next(50, 130));
            }
        }

        private void clonePlane(Vehicle[] myArray)
        {
            for (int i = myArray.Length / 2; i < myArray.Length; i++)
            {
                myArray[i] = (Plane)myArray[i - myArray.Length / 2].Clone(); 
            }
        }

        private void arrayCar(Vehicle[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length / 2; i++)
            {
                myArray[i] = new Car(random.Next(100000, 220000), random.Next(300, 450), random.Next(2010, 2026));
            }
        }

        private void cloneCar(Vehicle[] myArray)
        {
            for (int i = myArray.Length / 2; i < myArray.Length; i++)
            {
                myArray[i] = (Car)myArray[i - myArray.Length / 2].Clone();
            }
        }

        private void arrayShip(Vehicle[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length / 2; i++)
            {
                myArray[i] = new Ship(random.Next(100000, 220000), random.Next(300, 450), random.Next(2010, 2026), random.Next(1000, 4000),
                                "Одеський");
            }
        }

        private void cloneShip(Vehicle[] myArray)
        {
            for (int i = myArray.Length / 2; i < myArray.Length; i++)
            {
                myArray[i] = (Ship)myArray[i - myArray.Length / 2].Clone();
            }
        }
    }
}
