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
    public partial class ResultLab13 : Form
    {
        public ResultLab13()
        {
            InitializeComponent();
        }

        private void ResultLab13_Load(object sender, EventArgs e)
        {
            VehicleCollection collections = new VehicleCollection();
            collections.Add(new Plane(150000, 800, 2020, 10000, 150));
            collections.Add(new Plane(170000, 900, 2021, 12000, 200));
            collections.Add(new Car(30000, 180, 2022));
            collections.Add(new Car(40000, 220, 2023));
            collections.Add(new Ship(500000, 50, 2018, 56, "Atlantic"));
            collections.Add(new Ship(750000, 70, 2015, 45, "Titanic"));
            textBox1.Text = collections.Display();
        }

        
    }
}
