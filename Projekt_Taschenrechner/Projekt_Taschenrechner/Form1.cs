using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int zahl2 = 2;
            textBox1.AppendText(zahl2.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int zahl0 = 0;
            textBox1.AppendText(zahl0.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zahl1 = 1;
            textBox1.AppendText(zahl1.ToString());
        }

        private void button_3_Click(object sender, EventArgs e)
        {    
                int zahl3 = 3;
                textBox1.AppendText(zahl3.ToString());          
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            int zahl4 = 4;
            textBox1.AppendText(zahl4.ToString());
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            int zahl5 = 5;
            textBox1.AppendText(zahl5.ToString());
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            int zahl6 = 6;
            textBox1.AppendText(zahl6.ToString());
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            int zahl7 = 7;
            textBox1.AppendText(zahl7.ToString());
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            int zahl8 = 8;
            textBox1.AppendText(zahl8.ToString());
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            int zahl9 = 9;
            textBox1.AppendText(zahl9.ToString());
        }

        private void button_Punkt_Click(object sender, EventArgs e)
        {
            string punkt = ".";
            int bool1 = 0;
            if (bool1 == 0)
            {
                punkt 
            }
        }
    }
}
