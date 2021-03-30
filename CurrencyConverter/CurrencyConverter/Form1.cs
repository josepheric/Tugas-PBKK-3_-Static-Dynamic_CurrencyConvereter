using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                if (comboBox2.SelectedItem.ToString() == "USD")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 1).ToString() + " USD";
                else if (comboBox2.SelectedItem.ToString() == "IDR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 14400).ToString() +" IDR";
                else if (comboBox2.SelectedItem.ToString() == "EUR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 0.85).ToString() + " EUR";
                else
                    label5.Text = "Select Currency to Convert to";
            }
            if (comboBox1.SelectedItem.ToString() == "IDR")
            {
                if (comboBox2.SelectedItem.ToString() == "IDR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 1).ToString() + " IDR";
                else if (comboBox2.SelectedItem.ToString() == "USD")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 0.000069).ToString() + " USD";
                else if (comboBox2.SelectedItem.ToString() == "EUR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 0.000058).ToString() + " EUR";
                else
                    label5.Text = "Select Currency to Convert to";
            }
            if (comboBox1.SelectedItem.ToString() == "EUR")
            {
                if (comboBox2.SelectedItem.ToString() == "EUR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 1).ToString() + " EUR";
                else if (comboBox2.SelectedItem.ToString() == "USD")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 1.18).ToString() + " USD";
                else if (comboBox2.SelectedItem.ToString() == "IDR")
                    label5.Text = "Result: " + (double.Parse(textBox1.Text) * 17103).ToString() + " IDR";
                else
                    label5.Text = "Select Currency to Convert to";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Result: ";
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
