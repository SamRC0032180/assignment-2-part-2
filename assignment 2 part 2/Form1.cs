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
            double resistor1 = double.Parse(textBox1.Text);
            // read values from textbox 1 and inputs to resistor 1 and inputs toresistor 1
            double resistor2 = double.Parse(textBox2.Text);
            double resistor3 = double.Parse(textBox3);
            // reads values from textBox2 and inputs to resistor 2
            double resistor4 = double.Parse(textBox4);

            double totalresistance = resistor1 + resistor2 + resistor3 + resistor4;
            // calculate the total resistance of the series circuit 
            MessageBox.Show("total resistance =" + totalresistance.ToString("0.00") + "ohms");
            // display the total resistance of the series circuit with unit ohms 

        }
           
            
   
 


      
            
