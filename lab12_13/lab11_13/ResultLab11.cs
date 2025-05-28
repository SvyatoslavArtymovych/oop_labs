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
    public partial class ResultLab11 : Form
    {
        public ResultLab11()
        {
            InitializeComponent();
        }

        private void ResultLab11_Load(object sender, EventArgs e)
        {
            Vehicle myObjecj = new Plane(12000000, 360, 2023, 220, 127);
            textBox1.Text = myObjecj.DisplayInfo() + Environment.NewLine;

            myObjecj = new Car(128000, 240, 2015);
            textBox1.Text += myObjecj.DisplayInfo() + Environment.NewLine;

            myObjecj = new Ship(245000, 144, 2000, 35, "Одеський");
            textBox1.Text += myObjecj.DisplayInfo() + Environment.NewLine;
        }
    }
}
