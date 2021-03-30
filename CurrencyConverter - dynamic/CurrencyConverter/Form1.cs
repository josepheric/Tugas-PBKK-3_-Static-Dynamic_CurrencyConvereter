using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Globalization;



namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double callRateAPI(string from, string to)
        {
            var json = "";
            double curRate;
            try
            {
                string beforeCUR = from.ToUpper();
                string afterCUR = to.ToUpper();
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=e3a161b5717a874cb850", beforeCUR, afterCUR);
                string index = string.Format("{0}_{1}", beforeCUR,afterCUR);

                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                curRate = stuff[index];
            }
            catch
            {
                curRate = 0;
            }
            return curRate;
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
            
            string fromSelected = comboBox1.SelectedItem.ToString();
            string toSelected = comboBox2.SelectedItem.ToString();
            double rate = callRateAPI(fromSelected , toSelected);

            label5.Text = "Result: " + (double.Parse(textBox1.Text) * rate).ToString() + " " + toSelected;

            DateTime now = DateTime.Now;

            label6.Text = label6.Text + " " + now.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Result: ";
            label6.Text = "Rates are taken at: ";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
