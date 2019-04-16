using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try

                double resistor1 = double.Parse(textBox1.Text);
            double resistor2 = double.Parse(textBox2.Text);
            double resistor3 = 0.0;
            if (textBox3.Text == "0")
                resistor3 = double.PositiveInfinity;
            else
                resistor3 = double.Parse(textBox3.Text);

            double resistor4 = 0.0;
            if (textBox4.Text == "0")
                resistor1 = double.PositiveInfinity;
            else
                resistor3 = double.Parse(textBox4.Text);



            }
}
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
