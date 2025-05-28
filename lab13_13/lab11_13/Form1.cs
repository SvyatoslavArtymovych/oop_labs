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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lab_11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultLab11 form = new ResultLab11();
            form.ShowDialog();
        }

        private void resultLab12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultLab12 form = new ResultLab12();
            form.ShowDialog();
        }

        private void resultLab13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultLab13 form = new ResultLab13();
            form.ShowDialog();
        }
    }
}
