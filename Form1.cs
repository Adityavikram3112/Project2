using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project2
{
    public partial class Form1 : Form
    {

        static List<double> weatherdata = new List<double>();
        public Form1()
        {
            InitializeComponent();
            
        }
        int a = 0;
        List<double> sd = new List<double>();
        

        private void Startbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
             
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }



        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            WeatherProcessor wp = new WeatherProcessor();
            weatherdata = wp.WheatherInfo(CityTextBox.Text);
            int a = weatherdata.Count;
            for (int i = 0; i < a; i++)
            {
                if (i % 3 == 0)
                {
                    chart1.Series["TempMax"].Points.AddXY(x, weatherdata[i]);
                    x += 2;
                    TempMaxText.Text =Convert.ToString( weatherdata[i]); 
                }

                else if (i % 3 == 1)
                {
                    chart1.Series["TempMin"].Points.AddXY(x, weatherdata[i]);
                    x += 2;
                    TempMinText.Text = Convert.ToString(weatherdata[i]);
                }

                else if (i % 3 == 2)
                {
                    chart1.Series["WindSpeed"].Points.AddXY(x, weatherdata[i]);
                    x += 2;
                    WindSpeedText.Text = Convert.ToString(weatherdata[i]);
                }
            }

            StockProcessor sp = new StockProcessor();
            sp.GetData();
            int b = sd.Count;
            for (int j =0; j<b;j++)
            {
                chart1.Series["curencyChange"].Points.AddXY(a, sd[j]);
                a += 2;
            }

            StockProcessor sp1 = new StockProcessor();
            sp1.GetData();


        }
    }
}
